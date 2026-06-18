using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Application;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormChiTietMon : Form
    {
        private readonly MonNuoc _mon;
        private readonly TaiKhoan _currentUser;
        private readonly ChiTietMonUseCase _useCase;

        public FormChiTietMon(MonNuoc mon, AppDbContext context, TaiKhoan currentUser)
        {
            InitializeComponent();
            _mon = mon;
            _currentUser = currentUser;
            _useCase = new ChiTietMonUseCase(
                new BanRepository(context),
                new MonNuocRepository(context),
                new DonHangRepository(context)
            );
        }

        private void FormChiTietMon_Load(object sender, EventArgs e)
        {
            // Thiết lập Guna2ShadowForm để đổ bóng cho dialog
            guna2ShadowForm1.SetShadowForm(this);

            // Tải danh sách bàn
            LoadBans();

            // Đổ dữ liệu món nước
            BindData();
        }

        private void LoadBans()
        {
            var bans = _useCase.LayDanhSachBan().ToList();
            cbBan.DataSource = bans;
            cbBan.DisplayMember = "TenBan";
            cbBan.ValueMember = "Id";
        }

        private void BindData()
        {
            lblTenMon.Text = _mon.TenMon;
            lblGia.Text = $"{_mon.GiaBan:N0} đ";
            lblLoai.Text = GetLoaiMonString(_mon.LoaiMon);
            lblMoTa.Text = string.IsNullOrWhiteSpace(_mon.MoTa) 
                ? "Không có mô tả cho món nước này." 
                : _mon.MoTa;

            if (_mon.ConBan)
            {
                lblTrangThai.Text = "Còn bán";
                lblTrangThai.ForeColor = Color.Green;
                btnDatMon.Enabled = true;
            }
            else
            {
                lblTrangThai.Text = "Hết món";
                lblTrangThai.ForeColor = Color.Red;
                btnDatMon.Enabled = false;
            }

            // Xử lý hình ảnh
            if (!string.IsNullOrEmpty(_mon.HinhAnh) && System.IO.File.Exists(_mon.HinhAnh))
            {
                try
                {
                    picMon.Image = Image.FromFile(_mon.HinhAnh);
                    picMon.Visible = true;
                    lblImagePlaceholder.Visible = false;
                }
                catch
                {
                    ShowPlaceholderIcon();
                }
            }
            else
            {
                ShowPlaceholderIcon();
            }
        }

        private void ShowPlaceholderIcon()
        {
            lblImagePlaceholder.Text = _mon.LoaiMon switch
            {
                LoaiMon.CaPhe => "☕",
                LoaiMon.Tra => "🍵",
                LoaiMon.Banh => "🍰",
                _ => "🍹"
            };
            lblImagePlaceholder.Visible = true;
            picMon.Visible = false;
        }

        private string GetLoaiMonString(LoaiMon loai)
        {
            return loai switch
            {
                LoaiMon.CaPhe => "Cà phê",
                LoaiMon.Tra => "Trà",
                LoaiMon.Banh => "Bánh",
                _ => "Khác"
            };
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            if (cbBan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần đặt món!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int banId = (int)cbBan.SelectedValue;
            int soLuong = (int)numSoLuong.Value;

            bool success = _useCase.DatMonChoBan(banId, _currentUser.NguoiDungId, _mon.Id, soLuong, out string error);

            if (success)
            {
                MessageBox.Show($"Đặt thành công {soLuong} phần '{_mon.TenMon}' cho bàn!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(error, "Lỗi đặt món", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Tĩnh để hiển thị Dialog kèm lớp phủ mờ nền (Overlay) phía sau bao phủ toàn bộ màn hình
        public static DialogResult ShowWithOverlay(Form parent, FormDialogCreator creator)
        {
            using (Form overlay = new Form())
            {
                overlay.StartPosition = FormStartPosition.Manual;
                overlay.FormBorderStyle = FormBorderStyle.None;
                overlay.BackColor = Color.Black;
                overlay.Opacity = 0.40D;
                overlay.ShowInTaskbar = false;

                // Lấy toàn bộ kích thước của màn hình chứa parent thay vì chỉ bounds của parent
                var screen = Screen.FromControl(parent);
                overlay.Bounds = screen.Bounds;

                overlay.Show(parent);

                using (Form dialog = creator())
                {
                    dialog.Owner = overlay;
                    dialog.StartPosition = FormStartPosition.CenterParent;
                    var result = dialog.ShowDialog(overlay);
                    overlay.Close();
                    return result;
                }
            }
        }

        public delegate Form FormDialogCreator();
    }
}

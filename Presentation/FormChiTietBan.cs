using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Application;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormChiTietBan : Form
    {
        private readonly QuanLyBanUseCase _useCase;
        private readonly int _banId;
        private readonly FormMain _mainForm;
        private readonly TaiKhoan _currentUser;
        private readonly AppDbContext _context;
        private DonHang? _donHang;

        public FormChiTietBan(QuanLyBanUseCase useCase, int banId, FormMain mainForm, TaiKhoan currentUser, AppDbContext context)
        {
            InitializeComponent();
            _useCase = useCase;
            _banId = banId;
            _mainForm = mainForm;
            _currentUser = currentUser;
            _context = context;
        }

        private void FormChiTietBan_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            LoadTableDetails();
        }

        private void LoadTableDetails()
        {
            var ban = _useCase.LayBanTheoId(_banId);
            if (ban == null)
            {
                MessageBox.Show("Không tìm thấy thông tin bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblTitle.Text = $"CHI TIẾT: {ban.TenBan.ToUpper()}";

            string statusText = ban.TrangThai switch
            {
                TrangThaiBan.Trong => "Trống",
                TrangThaiBan.DangPhucVu => "Đang phục vụ",
                TrangThaiBan.ChoThanhToan => "Chờ thanh toán",
                _ => "Không xác định"
            };

            lblBanInfo.Text = $"Bàn: {ban.TenBan} | Số chỗ ngồi: {ban.SoChoNgoi} | Trạng thái: {statusText}";

            if (ban.TrangThai == TrangThaiBan.Trong)
            {
                // Bàn trống
                _donHang = null;
                gridDetails.Rows.Clear();
                lblTongTien.Text = "BÀN TRỐNG (Chưa có đơn hàng)";
                lblTongTien.ForeColor = Color.FromArgb(140, 140, 140);

                // Show Empty table actions
                btnDatMon.Visible = true;
                
                // Phân quyền sửa/xóa bàn
                bool coQuyenAdminOrNhanVien = _currentUser.NguoiDung.VaiTro == VaiTro.Admin || _currentUser.NguoiDung.VaiTro == VaiTro.NhanVien;
                btnSuaBan.Visible = coQuyenAdminOrNhanVien;
                btnXoaBan.Visible = coQuyenAdminOrNhanVien;

                // Hide order actions
                btnThemMon.Visible = false;
                btnTangQty.Visible = false;
                btnGiamQty.Visible = false;
                btnXoaMon.Visible = false;
                btnDoiBan.Visible = false;
                btnThanhToan.Visible = false;
            }
            else
            {
                // Bàn có người / chờ thanh toán
                btnDatMon.Visible = false;
                btnSuaBan.Visible = false;
                btnXoaBan.Visible = false;

                btnThemMon.Visible = true;
                btnTangQty.Visible = true;
                btnGiamQty.Visible = true;
                btnXoaMon.Visible = true;
                btnDoiBan.Visible = true;
                btnThanhToan.Visible = true;

                // Tải đơn hàng dang dở
                _donHang = _useCase.LayDonHangDangMoCuaBan(_banId);
                if (_donHang != null)
                {
                    gridDetails.Rows.Clear();
                    foreach (var ct in _donHang.ChiTietDonHangs)
                    {
                        gridDetails.Rows.Add(
                            ct.MonNuoc.TenMon,
                            $"{ct.DonGia:N0} đ",
                            ct.SoLuong,
                            $"{ct.ThanhTien:N0} đ",
                            ct.MonNuocId
                        );
                    }

                    lblTongTien.Text = $"TỔNG THANH TOÁN: {_donHang.TongTien:N0} đ";
                    lblTongTien.ForeColor = Color.FromArgb(225, 29, 72);
                }
                else
                {
                    // Lỗi đồng bộ trạng thái bàn
                    gridDetails.Rows.Clear();
                    lblTongTien.Text = "Lỗi: Không tìm thấy đơn hàng tương ứng của bàn này!";
                    lblTongTien.ForeColor = Color.Red;

                    btnThemMon.Visible = false;
                    btnTangQty.Visible = false;
                    btnGiamQty.Visible = false;
                    btnXoaMon.Visible = false;
                    btnDoiBan.Visible = false;
                    btnThanhToan.Visible = false;
                }
            }
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            _mainForm.SwitchToTab("DatMon", _banId);
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            var result = FormChiTietMon.ShowWithOverlay(this, () => new FormThemBan(_useCase, _banId));
            if (result == DialogResult.OK)
            {
                LoadTableDetails();
                this.DialogResult = DialogResult.OK; // Kích hoạt refresh màn hình Sơ Đồ Bàn chính
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bàn này khỏi hệ thống?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = _useCase.XoaBan(_banId, out string error);
                if (success)
                {
                    MessageBox.Show("Xóa bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Kích hoạt refresh màn hình Sơ Đồ Bàn chính
                    this.Close();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi xóa bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (_donHang == null) return;

            var result = FormChiTietMon.ShowWithOverlay(this, () => new FormChonMon(_useCase, _donHang.Id));
            if (result == DialogResult.OK)
            {
                LoadTableDetails();
                this.DialogResult = DialogResult.OK; // Refresh sơ đồ bàn chính
            }
        }

        private void btnTangQty_Click(object sender, EventArgs e)
        {
            if (_donHang == null || gridDetails.CurrentRow == null) return;
            int monId = Convert.ToInt32(gridDetails.CurrentRow.Cells["colMonId"].Value);

            bool success = _useCase.CapNhatSoLuongMon(_donHang.Id, monId, 1, out string error);
            if (success)
            {
                LoadTableDetails();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(error, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGiamQty_Click(object sender, EventArgs e)
        {
            if (_donHang == null || gridDetails.CurrentRow == null) return;
            int monId = Convert.ToInt32(gridDetails.CurrentRow.Cells["colMonId"].Value);

            bool success = _useCase.CapNhatSoLuongMon(_donHang.Id, monId, -1, out string error);
            if (success)
            {
                LoadTableDetails();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(error, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (_donHang == null || gridDetails.CurrentRow == null) return;
            int monId = Convert.ToInt32(gridDetails.CurrentRow.Cells["colMonId"].Value);
            string monName = gridDetails.CurrentRow.Cells["colMonName"].Value?.ToString() ?? string.Empty;

            if (MessageBox.Show($"Bạn có muốn xóa món '{monName}' ra khỏi đơn hàng?", "Xác nhận xóa món", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = _useCase.XoaMonKhoiDon(_donHang.Id, monId, out string error);
                if (success)
                {
                    LoadTableDetails();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(error, "Lỗi xóa món", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDoiBan_Click(object sender, EventArgs e)
        {
            if (_donHang == null) return;

            var result = FormChiTietMon.ShowWithOverlay(this, () => new FormDoiBan(_useCase, _donHang.Id, _banId));
            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK; // Để refresh sơ đồ bàn chính
                this.Close();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            _mainForm.SwitchToTab("ThanhToan", _banId);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

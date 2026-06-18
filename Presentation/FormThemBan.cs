using System;
using System.Windows.Forms;
using QuanLyQuanCafe.Application;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormThemBan : Form
    {
        private readonly QuanLyBanUseCase _useCase;
        private readonly int? _banId;

        public FormThemBan(QuanLyBanUseCase useCase, int? banId = null)
        {
            InitializeComponent();
            _useCase = useCase;
            _banId = banId;
        }

        private void FormThemBan_Load(object sender, EventArgs e)
        {
            // Đổ bóng cho form
            guna2ShadowForm1.SetShadowForm(this);

            if (_banId.HasValue)
            {
                lblHeaderTitle.Text = "SỬA THÔNG TIN BÀN";
                var ban = _useCase.LayBanTheoId(_banId.Value);
                if (ban != null)
                {
                    txtTenBan.Text = ban.TenBan;
                    numSoCho.Value = ban.SoChoNgoi;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                lblHeaderTitle.Text = "THÊM BÀN PHỤC VỤ";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenBan = txtTenBan.Text.Trim();
            int soCho = (int)numSoCho.Value;

            if (string.IsNullOrEmpty(tenBan))
            {
                MessageBox.Show("Vui lòng nhập tên bàn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success;
            string error;

            if (_banId.HasValue)
            {
                success = _useCase.SuaThongTinBan(_banId.Value, tenBan, soCho, out error);
            }
            else
            {
                success = _useCase.ThemBanMoi(tenBan, soCho, out error);
            }

            if (success)
            {
                MessageBox.Show("Lưu thông tin bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(error, "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

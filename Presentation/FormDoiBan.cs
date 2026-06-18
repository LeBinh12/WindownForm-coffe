using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Application;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormDoiBan : Form
    {
        private readonly QuanLyBanUseCase _useCase;
        private readonly int _donHangId;
        private readonly int _currentBanId;

        public FormDoiBan(QuanLyBanUseCase useCase, int donHangId, int currentBanId)
        {
            InitializeComponent();
            _useCase = useCase;
            _donHangId = donHangId;
            _currentBanId = currentBanId;
        }

        private void FormDoiBan_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            LoadBanTrong();
        }

        private void LoadBanTrong()
        {
            var bans = _useCase.LayDanhSachBanTrong(_currentBanId).ToList();

            if (!bans.Any())
            {
                MessageBox.Show("Hiện tại không có bàn trống nào để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            cbBanTrong.DataSource = bans;
            cbBanTrong.DisplayMember = "TenBan";
            cbBanTrong.ValueMember = "Id";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbBanTrong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trống đích!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int targetBanId = (int)cbBanTrong.SelectedValue;
            string targetBanName = cbBanTrong.Text;

            if (MessageBox.Show($"Bạn có thực sự muốn chuyển đơn hàng sang {targetBanName}?", "Xác nhận chuyển bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = _useCase.DoiBan(_donHangId, targetBanId, out string error);
                if (success)
                {
                    MessageBox.Show("Chuyển bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi chuyển bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

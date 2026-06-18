using System;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Application;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormChonMon : Form
    {
        private readonly QuanLyBanUseCase _useCase;
        private readonly int _donHangId;

        public FormChonMon(QuanLyBanUseCase useCase, int donHangId)
        {
            InitializeComponent();
            _useCase = useCase;
            _donHangId = donHangId;
        }

        private void FormChonMon_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            LoadMonNuocs();
        }

        private void LoadMonNuocs()
        {
            var mons = _useCase.LayMonNuocCoTheBan().ToList();

            if (!mons.Any())
            {
                MessageBox.Show("Hiện không có món nước nào đang mở bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            cbMonNuoc.DataSource = mons;
            cbMonNuoc.DisplayMember = "TenMon";
            cbMonNuoc.ValueMember = "Id";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbMonNuoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn món nước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int monId = (int)cbMonNuoc.SelectedValue;
            int soLuong = (int)numSoLuong.Value;

            bool success = _useCase.ThemMonVaoDon(_donHangId, monId, soLuong, out string error);
            if (success)
            {
                MessageBox.Show("Thêm món vào đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(error, "Lỗi thêm món", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

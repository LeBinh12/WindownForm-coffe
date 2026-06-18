using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Application;
using QuanLyQuanCafe.Domain;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormQuanLyThucDon : Form
    {
        private readonly QuanLyThucDonUseCase _useCase;
        private List<MonNuoc> _thucDonList = new List<MonNuoc>();
        private int? _selectedMonId = null;

        public FormQuanLyThucDon(QuanLyThucDonUseCase useCase)
        {
            InitializeComponent();
            _useCase = useCase;
        }

        private void FormQuanLyThucDon_Load(object sender, EventArgs e)
        {
            // Nạp ComboBox loại món
            cbLoaiMon.Items.Clear();
            cbLoaiMon.Items.Add("Cà phê");
            cbLoaiMon.Items.Add("Trà");
            cbLoaiMon.Items.Add("Bánh");
            cbLoaiMon.Items.Add("Khác");
            cbLoaiMon.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            _thucDonList = _useCase.LayDanhSachThucDon(null, null).ToList();

            gridThucDon.Rows.Clear();
            foreach (var mon in _thucDonList)
            {
                gridThucDon.Rows.Add(
                    mon.Id,
                    mon.TenMon,
                    GetLoaiString(mon.LoaiMon),
                    mon.GiaBan,
                    mon.ConBan
                );
            }

            CleanForm();
        }

        private string GetLoaiString(LoaiMon loai)
        {
            return loai switch
            {
                LoaiMon.CaPhe => "Cà phê",
                LoaiMon.Tra => "Trà",
                LoaiMon.Banh => "Bánh",
                _ => "Khác"
            };
        }

        private void gridThucDon_SelectionChanged(object sender, EventArgs e)
        {
            if (gridThucDon.CurrentRow == null) return;

            int id = Convert.ToInt32(gridThucDon.CurrentRow.Cells["colID"].Value);
            var mon = _thucDonList.FirstOrDefault(m => m.Id == id);

            if (mon != null)
            {
                _selectedMonId = mon.Id;
                txtTenMon.Text = mon.TenMon;
                numGia.Value = mon.GiaBan;
                cbLoaiMon.SelectedIndex = (int)mon.LoaiMon;
                txtMoTa.Text = mon.MoTa;
                chkConBan.Checked = mon.ConBan;

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenMon = txtTenMon.Text.Trim();
            decimal gia = numGia.Value;
            LoaiMon loai = (LoaiMon)cbLoaiMon.SelectedIndex;
            string moTa = txtMoTa.Text.Trim();
            bool conBan = chkConBan.Checked;

            if (string.IsNullOrEmpty(tenMon))
            {
                MessageBox.Show("Vui lòng nhập tên món nước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var monNuoc = new MonNuoc
            {
                TenMon = tenMon,
                GiaBan = gia,
                LoaiMon = loai,
                MoTa = moTa,
                ConBan = conBan
            };
            bool success = _useCase.ThemMonNuoc(monNuoc, out string error);

            if (success)
            {
                MessageBox.Show("Thêm món nước mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show(error, "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!_selectedMonId.HasValue) return;

            string tenMon = txtTenMon.Text.Trim();
            decimal gia = numGia.Value;
            LoaiMon loai = (LoaiMon)cbLoaiMon.SelectedIndex;
            string moTa = txtMoTa.Text.Trim();
            bool conBan = chkConBan.Checked;

            if (string.IsNullOrEmpty(tenMon))
            {
                MessageBox.Show("Vui lòng nhập tên món nước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var monNuoc = new MonNuoc
            {
                Id = _selectedMonId.Value,
                TenMon = tenMon,
                GiaBan = gia,
                LoaiMon = loai,
                MoTa = moTa,
                ConBan = conBan
            };
            bool success = _useCase.CapNhatMonNuoc(monNuoc, out string error);

            if (success)
            {
                MessageBox.Show("Cập nhật thông tin món nước thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show(error, "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_selectedMonId.HasValue) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa món nước này khỏi thực đơn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool success = _useCase.XoaMonNuoc(_selectedMonId.Value, out string error);
                if (success)
                {
                    MessageBox.Show("Xóa món nước thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show(error, "Xóa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            _selectedMonId = null;
            txtTenMon.Clear();
            numGia.Value = 0;
            cbLoaiMon.SelectedIndex = 0;
            txtMoTa.Clear();
            chkConBan.Checked = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Application;
using QuanLyQuanCafe.Domain;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormDatMon : Form
    {
        private readonly DatMonUseCase _useCase;
        private readonly TaiKhoan _currentUser;
        private List<MonNuoc> _allMonNuoc = new List<MonNuoc>();
        private List<GioHangItem> _gioHang = new List<GioHangItem>();

        private class GioHangItem
        {
            public int MonNuocId { get; set; }
            public string TenMon { get; set; }
            public int SoLuong { get; set; }
            public decimal DonGia { get; set; }
            public decimal ThanhTien => SoLuong * DonGia;
        }

        public FormDatMon(DatMonUseCase useCase, TaiKhoan currentUser)
        {
            InitializeComponent();
            _useCase = useCase;
            _currentUser = currentUser;
        }

        private void FormDatMon_Load(object sender, EventArgs e)
        {
            LoadBans();
            LoadMonNuocs();
        }

        private void LoadBans()
        {
            var bans = _useCase.LayDanhSachBan().ToList();
            cbBan.DataSource = bans;
            cbBan.DisplayMember = "TenBan";
            cbBan.ValueMember = "Id";
        }

        public void SelectBan(int banId)
        {
            cbBan.SelectedValue = banId;
        }

        private void LoadMonNuocs()
        {
            _allMonNuoc = _useCase.LayMonNuocCoTheBan().ToList();
            FilterMonNuocs();
        }

        private void FilterMonNuocs()
        {
            gridMonNuoc.Rows.Clear();
            string search = txtSearch.Text.Trim();

            var filtered = _allMonNuoc;
            if (!string.IsNullOrEmpty(search))
            {
                filtered = filtered.Where(m => m.TenMon.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            foreach (var mon in filtered)
            {
                gridMonNuoc.Rows.Add(mon.Id, mon.TenMon, GetLoaiString(mon.LoaiMon), mon.GiaBan);
            }
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterMonNuocs();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (gridMonNuoc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một món nước từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int monId = Convert.ToInt32(gridMonNuoc.CurrentRow.Cells["colMonId"].Value);
            string tenMon = gridMonNuoc.CurrentRow.Cells["colTenMon"].Value.ToString();
            decimal giaBan = Convert.ToDecimal(gridMonNuoc.CurrentRow.Cells["colGiaMon"].Value);
            int qty = (int)numSoLuong.Value;

            var existing = _gioHang.FirstOrDefault(g => g.MonNuocId == monId);
            if (existing != null)
            {
                existing.SoLuong += qty;
            }
            else
            {
                _gioHang.Add(new GioHangItem
                {
                    MonNuocId = monId,
                    TenMon = tenMon,
                    SoLuong = qty,
                    DonGia = giaBan
                });
            }

            UpdateGioHangGrid();
            numSoLuong.Value = 1;
        }

        private void UpdateGioHangGrid()
        {
            gridGioHang.Rows.Clear();
            decimal total = 0;

            foreach (var item in _gioHang)
            {
                gridGioHang.Rows.Add(item.MonNuocId, item.TenMon, item.SoLuong, item.DonGia, item.ThanhTien);
                total += item.ThanhTien;
            }

            lblTongTien.Text = $"Tổng cộng: {total:N0} đ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridGioHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn món nước muốn xóa trong giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int monId = Convert.ToInt32(gridGioHang.CurrentRow.Cells["colGioMonId"].Value);
            var item = _gioHang.FirstOrDefault(g => g.MonNuocId == monId);
            if (item != null)
            {
                _gioHang.Remove(item);
                UpdateGioHangGrid();
            }
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            if (cbBan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int banId = (int)cbBan.SelectedValue;

            if (!_gioHang.Any())
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng thêm món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var items = _gioHang.Select(g => (g.MonNuocId, g.SoLuong)).ToList();

            bool success = _useCase.DatMon(banId, _currentUser.NguoiDungId, items, out string error);

            if (success)
            {
                MessageBox.Show("Đặt món thành công! Bàn đã được chuyển sang trạng thái đang phục vụ.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _gioHang.Clear();
                UpdateGioHangGrid();
                LoadBans(); // Tải lại để cập nhật trạng thái
            }
            else
            {
                MessageBox.Show(error, "Đặt món thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

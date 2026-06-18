using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCafe.Application;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormDanhSachHoaDon : Form
    {
        private readonly AppDbContext _context;
        private readonly TaiKhoan _currentUser;
        private List<HoaDon> _hoaDons = new List<HoaDon>();

        public FormDanhSachHoaDon(AppDbContext context, TaiKhoan currentUser)
        {
            InitializeComponent();
            _context = context;
            _currentUser = currentUser;
        }

        private void FormDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            cbPhuongThuc.Items.Clear();
            cbPhuongThuc.Items.Add("Tất cả");
            cbPhuongThuc.Items.Add("Tiền mặt");
            cbPhuongThuc.Items.Add("Chuyển khoản");
            cbPhuongThuc.Items.Add("Ví điện tử");
            cbPhuongThuc.SelectedIndex = 0;

            // Set default date range to past 30 days
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;

            LoadHoaDons();
        }

        private void LoadHoaDons()
        {
            var query = _context.HoaDons
                .Include(h => h.DonHang)
                    .ThenInclude(d => d.Ban)
                .AsQueryable();

            // Date filter
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
            query = query.Where(h => h.NgayThanhToan >= fromDate && h.NgayThanhToan <= toDate);

            // Method filter
            int ptIndex = cbPhuongThuc.SelectedIndex;
            if (ptIndex > 0)
            {
                PhuongThucThanhToan pt = (PhuongThucThanhToan)(ptIndex - 1);
                query = query.Where(h => h.PhuongThuc == pt);
            }

            // Search filter
            string search = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(h => 
                    h.Id.ToString().Contains(search) ||
                    h.DonHangId.ToString().Contains(search) ||
                    (h.MaGiaoDich != null && h.MaGiaoDich.ToLower().Contains(search)) ||
                    (h.DonHang.Ban != null && h.DonHang.Ban.TenBan.ToLower().Contains(search))
                );
            }

            _hoaDons = query.OrderByDescending(h => h.NgayThanhToan).ToList();

            gridHoaDon.Rows.Clear();
            decimal totalRevenue = 0;

            foreach (var h in _hoaDons)
            {
                gridHoaDon.Rows.Add(
                    h.Id,
                    h.DonHangId,
                    h.DonHang?.Ban?.TenBan ?? "Không rõ",
                    h.NgayThanhToan.ToString("dd/MM/yyyy HH:mm:ss"),
                    $"{h.TongTien:N0} đ",
                    GetPhuongThucString(h.PhuongThuc),
                    GetTrangThaiString(h.TrangThai),
                    h.MaGiaoDich ?? ""
                );
                totalRevenue += h.TongTien;
            }

            lblTongSoHD.Text = $"Tổng số hóa đơn: {_hoaDons.Count}";
            lblTongDoanhThu.Text = $"Tổng doanh thu: {totalRevenue:N0} đ";
        }

        private string GetPhuongThucString(PhuongThucThanhToan pt)
        {
            return pt switch
            {
                PhuongThucThanhToan.TienMat => "Tiền mặt",
                PhuongThucThanhToan.ChuyenKhoan => "Chuyển khoản",
                PhuongThucThanhToan.ViDienTu => "Ví điện tử",
                _ => "Khác"
            };
        }

        private string GetTrangThaiString(TrangThaiThanhToan tt)
        {
            return tt switch
            {
                TrangThaiThanhToan.DaThanhToan => "Đã thanh toán",
                _ => "Chưa thanh toán"
            };
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            LoadHoaDons();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadHoaDons();
        }

        private void gridHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int donHangId = Convert.ToInt32(gridHoaDon.Rows[e.RowIndex].Cells["colMaDon"].Value);

            var mainForm = this.FindForm();
            if (mainForm != null)
            {
                FormChiTietMon.ShowWithOverlay(mainForm, () => 
                    new FormHoaDonThanhToan(
                        new ThanhToanUseCase(new DonHangRepository(_context), new HoaDonRepository(_context), new BanRepository(_context)),
                        donHangId,
                        _context,
                        _currentUser,
                        readOnly: true
                    )
                );
            }
            else
            {
                using (var frm = new FormHoaDonThanhToan(
                    new ThanhToanUseCase(new DonHangRepository(_context), new HoaDonRepository(_context), new BanRepository(_context)),
                    donHangId,
                    _context,
                    _currentUser,
                    readOnly: true
                ))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}

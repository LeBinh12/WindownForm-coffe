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
    public partial class FormDonHang : Form
    {
        private readonly XuLyDonHangUseCase _useCase;
        private readonly TaiKhoan _currentUser;
        private readonly AppDbContext _context;
        private List<DonHang> _donHangs = new List<DonHang>();

        public FormDonHang(XuLyDonHangUseCase useCase, TaiKhoan currentUser, AppDbContext context)
        {
            InitializeComponent();
            _useCase = useCase;
            _currentUser = currentUser;
            _context = context;
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            cbFilterTrangThai.Items.Clear();
            cbFilterTrangThai.Items.Add("Tất cả");
            cbFilterTrangThai.Items.Add("Chờ xử lý");
            cbFilterTrangThai.Items.Add("Đang phục vụ");
            cbFilterTrangThai.Items.Add("Hoàn thành");
            cbFilterTrangThai.Items.Add("Đã thanh toán");
            cbFilterTrangThai.Items.Add("Đã hủy");
            cbFilterTrangThai.SelectedIndex = 0;

            // Đăng ký sự kiện format ô trạng thái
            this.gridDonHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridDonHang_CellFormatting);

            LoadDonHangs();
            ApplyRoleRestrictions();
        }

        private void ApplyRoleRestrictions()
        {
            if (_currentUser.NguoiDung.VaiTro == VaiTro.KhachHang)
            {
                // Khách hàng không thể tiếp nhận / hoàn thành / thanh toán đơn của người khác
                btnTiepNhan.Visible = false;
                btnHoanThanh.Visible = false;
                btnThanhToanDon.Visible = false;
            }
        }

        private void LoadDonHangs()
        {
            // Eager load tất cả quan hệ
            var query = _context.DonHangs
                .Include(d => d.Ban)
                .Include(d => d.NhanVien)
                .Include(d => d.ChiTietDonHangs)
                    .ThenInclude(ct => ct.MonNuoc)
                .AsQueryable();

            // Nếu là KhachHang -> Chỉ xem đơn của chính họ
            if (_currentUser.NguoiDung.VaiTro == VaiTro.KhachHang)
            {
                query = query.Where(d => d.NhanVienId == _currentUser.NguoiDungId);
            }

            int filterIndex = cbFilterTrangThai.SelectedIndex;
            if (filterIndex > 0)
            {
                TrangThaiDonHang state = (TrangThaiDonHang)(filterIndex - 1);
                query = query.Where(d => d.TrangThai == state);
            }

            _donHangs = query.OrderByDescending(d => d.NgayTao).ToList();

            gridDonHang.Rows.Clear();
            foreach (var dh in _donHangs)
            {
                gridDonHang.Rows.Add(
                    dh.Id,
                    dh.Ban?.TenBan ?? "Không rõ",
                    dh.NhanVien?.HoTen ?? "Khách hàng tự gọi",
                    dh.NgayTao.ToString("dd/MM/yyyy HH:mm"),
                    $"{dh.TongTien:N0} đ",
                    GetTrangThaiString(dh.TrangThai)
                );
            }

            if (gridDonHang.Rows.Count == 0)
            {
                gridChiTiet.Rows.Clear();
            }
        }

        private string GetTrangThaiString(TrangThaiDonHang tt)
        {
            return tt switch
            {
                TrangThaiDonHang.ChoXuLy => "Chờ xử lý",
                TrangThaiDonHang.DangPhucVu => "Đang phục vụ",
                TrangThaiDonHang.HoanThanh => "Hoàn thành",
                TrangThaiDonHang.DaThanhToan => "Đã thanh toán",
                TrangThaiDonHang.DaHuy => "Đã hủy",
                _ => "Không rõ"
            };
        }

        private void cbFilterTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDonHangs();
        }

        private void gridDonHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridDonHang.Columns[e.ColumnIndex].Name == "colDHTrangThai" && e.Value != null)
            {
                string statusText = e.Value.ToString();
                if (statusText == "Chờ xử lý")
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.Gray;
                    e.CellStyle.Font = new System.Drawing.Font(gridDonHang.Font, System.Drawing.FontStyle.Bold);
                }
                else if (statusText == "Đang phục vụ")
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246); // Xanh dương
                    e.CellStyle.Font = new System.Drawing.Font(gridDonHang.Font, System.Drawing.FontStyle.Bold);
                }
                else if (statusText == "Hoàn thành")
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129); // Xanh lá
                    e.CellStyle.Font = new System.Drawing.Font(gridDonHang.Font, System.Drawing.FontStyle.Bold);
                }
                else if (statusText == "Đã thanh toán")
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(78, 54, 41); // Nâu
                    e.CellStyle.Font = new System.Drawing.Font(gridDonHang.Font, System.Drawing.FontStyle.Bold);
                }
                else if (statusText == "Đã hủy")
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68); // Đỏ
                    e.CellStyle.Font = new System.Drawing.Font(gridDonHang.Font, System.Drawing.FontStyle.Bold);
                }
            }
        }

        private void gridDonHang_SelectionChanged(object sender, EventArgs e)
        {
            if (gridDonHang.CurrentRow == null) return;

            int dhId = Convert.ToInt32(gridDonHang.CurrentRow.Cells["colDHId"].Value);
            var dh = _donHangs.FirstOrDefault(d => d.Id == dhId);

            if (dh != null)
            {
                gridChiTiet.Rows.Clear();
                foreach (var ct in dh.ChiTietDonHangs)
                {
                    gridChiTiet.Rows.Add(
                        ct.MonNuoc.TenMon,
                        ct.SoLuong,
                        $"{ct.DonGia:N0} đ",
                        $"{ct.ThanhTien:N0} đ"
                    );
                }

                // Cập nhật trạng thái các nút
                btnTiepNhan.Enabled = (dh.TrangThai == TrangThaiDonHang.ChoXuLy);
                btnHoanThanh.Enabled = (dh.TrangThai == TrangThaiDonHang.DangPhucVu);
                btnHuyDon.Enabled = (dh.TrangThai == TrangThaiDonHang.ChoXuLy);
                btnThanhToanDon.Enabled = (dh.TrangThai == TrangThaiDonHang.HoanThanh); // Đã làm xong nước uống thì cho thanh toán
            }
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            if (gridDonHang.CurrentRow == null) return;
            int dhId = Convert.ToInt32(gridDonHang.CurrentRow.Cells["colDHId"].Value);

            bool success = _useCase.TiepNhanDonHang(dhId, _currentUser.NguoiDungId, out string error);
            if (success)
            {
                MessageBox.Show("Tiếp nhận đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDonHangs();
            }
            else
            {
                MessageBox.Show(error, "Lỗi tiếp nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (gridDonHang.CurrentRow == null) return;
            int dhId = Convert.ToInt32(gridDonHang.CurrentRow.Cells["colDHId"].Value);

            bool success = _useCase.HoanThanhDonHang(dhId, out string error);
            if (success)
            {
                MessageBox.Show("Đã hoàn thành chuẩn bị các món nước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDonHangs();
            }
            else
            {
                MessageBox.Show(error, "Lỗi hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            if (gridDonHang.CurrentRow == null) return;
            int dhId = Convert.ToInt32(gridDonHang.CurrentRow.Cells["colDHId"].Value);

            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đơn hàng này?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = _useCase.HuyDonHang(dhId, out string error);
                if (success)
                {
                    MessageBox.Show("Đã hủy đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDonHangs();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi hủy đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThanhToanDon_Click(object sender, EventArgs e)
        {
            if (gridDonHang.CurrentRow == null) return;
            int dhId = Convert.ToInt32(gridDonHang.CurrentRow.Cells["colDHId"].Value);
            var dh = _donHangs.FirstOrDefault(d => d.Id == dhId);

            if (dh != null && dh.TrangThai == TrangThaiDonHang.HoanThanh)
            {
                var mainForm = this.FindForm();
                if (mainForm != null)
                {
                    var result = FormChiTietMon.ShowWithOverlay(mainForm, () => 
                        new FormHoaDonThanhToan(
                            new ThanhToanUseCase(new DonHangRepository(_context), new HoaDonRepository(_context), new BanRepository(_context)),
                            dh.Id,
                            _context,
                            _currentUser,
                            readOnly: false
                        )
                    );
                    
                    if (result == DialogResult.OK)
                    {
                        LoadDonHangs();
                    }
                }
                else
                {
                    using (var frm = new FormHoaDonThanhToan(
                        new ThanhToanUseCase(new DonHangRepository(_context), new HoaDonRepository(_context), new BanRepository(_context)),
                        dh.Id,
                        _context,
                        _currentUser,
                        readOnly: false
                    ))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            LoadDonHangs();
                        }
                    }
                }
            }
        }
    }
}

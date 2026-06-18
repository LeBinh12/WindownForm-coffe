using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCafe.Application;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormHoaDonThanhToan : Form
    {
        private readonly ThanhToanUseCase _useCase;
        private readonly int _donHangId;
        private readonly AppDbContext _context;
        private readonly TaiKhoan _currentUser;
        private readonly bool _readOnly;
        private DonHang? _donHang;
        private HoaDon? _hoaDon;

        public FormHoaDonThanhToan(ThanhToanUseCase useCase, int donHangId, AppDbContext context, TaiKhoan currentUser, bool readOnly = false)
        {
            InitializeComponent();
            _useCase = useCase;
            _donHangId = donHangId;
            _context = context;
            _currentUser = currentUser;
            _readOnly = readOnly;
        }

        private void FormHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            // Set Shadow
            guna2ShadowForm1.SetShadowForm(this);

            // Populate Payment methods
            cbPhuongThuc.Items.Clear();
            cbPhuongThuc.Items.Add("Tiền mặt");
            cbPhuongThuc.Items.Add("Chuyển khoản");
            cbPhuongThuc.Items.Add("Ví điện tử");
            cbPhuongThuc.SelectedIndex = 0;

            LoadData();

            if (_readOnly)
            {
                lblTitle.Text = "CHI TIẾT HÓA ĐƠN";
                cbPhuongThuc.Enabled = false;
                txtKhachDua.Visible = false;
                lblKhachDua.Visible = false;
                lblTienThua.Visible = false;
                lblTienThuaValue.Visible = false;
                btnXacNhan.Visible = false;
                btnHuy.Text = "Đóng";
                // Center the close button
                btnHuy.Location = new Point((this.ClientSize.Width - btnHuy.Width) / 2, btnHuy.Location.Y);

                // Fetch existing invoice to display details
                _hoaDon = _context.HoaDons.FirstOrDefault(h => h.DonHangId == _donHangId);
                if (_hoaDon != null)
                {
                    cbPhuongThuc.SelectedIndex = (int)_hoaDon.PhuongThuc;
                    lblTitle.Text = $"CHI TIẾT HÓA ĐƠN ({_hoaDon.MaGiaoDich})";
                }
            }
        }

        private void LoadData()
        {
            _donHang = _context.DonHangs
                .Include(d => d.Ban)
                .Include(d => d.NhanVien)
                .Include(d => d.ChiTietDonHangs)
                    .ThenInclude(ct => ct.MonNuoc)
                .FirstOrDefault(d => d.Id == _donHangId);

            if (_donHang == null)
            {
                MessageBox.Show("Không tìm thấy thông tin đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblMaDon.Text = $"Mã đơn hàng: #{_donHang.Id}";
            lblBan.Text = $"Bàn phục vụ: {_donHang.Ban?.TenBan ?? "Không xác định"}";
            lblNhanVien.Text = $"Nhân viên lập: {_donHang.NhanVien?.HoTen ?? "Khách hàng tự gọi"}";
            lblNgayTao.Text = $"Giờ vào: {_donHang.NgayTao:dd/MM/yyyy HH:mm:ss}";

            gridDetails.Rows.Clear();
            foreach (var ct in _donHang.ChiTietDonHangs)
            {
                gridDetails.Rows.Add(
                    ct.MonNuoc.TenMon,
                    $"{ct.DonGia:N0} đ",
                    ct.SoLuong,
                    $"{ct.ThanhTien:N0} đ"
                );
            }

            lblTongTien.Text = $"TỔNG THANH TOÁN: {_donHang.TongTien:N0} đ";
            UpdateChangeCalculation();
        }

        private void cbPhuongThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isTienMat = cbPhuongThuc.SelectedIndex == 0;
            lblKhachDua.Visible = isTienMat && !_readOnly;
            txtKhachDua.Visible = isTienMat && !_readOnly;
            lblTienThua.Visible = isTienMat && !_readOnly;
            lblTienThuaValue.Visible = isTienMat && !_readOnly;
            UpdateChangeCalculation();
        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            UpdateChangeCalculation();
        }

        private void UpdateChangeCalculation()
        {
            if (_donHang == null || _readOnly || cbPhuongThuc.SelectedIndex != 0) return;

            if (decimal.TryParse(txtKhachDua.Text, out decimal khachDua))
            {
                decimal tongTien = _donHang.TongTien;
                decimal tienThua = khachDua - tongTien;
                if (tienThua >= 0)
                {
                    lblTienThuaValue.Text = $"{tienThua:N0} đ";
                    lblTienThuaValue.ForeColor = Color.Green;
                }
                else
                {
                    lblTienThuaValue.Text = $"Thiếu {(tongTien - khachDua):N0} đ";
                    lblTienThuaValue.ForeColor = Color.Red;
                }
            }
            else
            {
                lblTienThuaValue.Text = "0 đ";
                lblTienThuaValue.ForeColor = Color.Green;
            }
        }

        private void txtKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (_readOnly) return;

            PhuongThucThanhToan pt = (PhuongThucThanhToan)cbPhuongThuc.SelectedIndex;

            if (pt == PhuongThucThanhToan.TienMat)
            {
                if (!decimal.TryParse(txtKhachDua.Text, out decimal khachDua) || khachDua < _donHang.TongTien)
                {
                    MessageBox.Show("Số tiền khách đưa không hợp lệ hoặc không đủ để thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            bool success = _useCase.ThanhToan(_donHangId, pt, out HoaDon hd, out string error);
            if (success && hd != null)
            {
                MessageBox.Show($"Lập hóa đơn & thanh toán thành công!\nMã giao dịch: {hd.MaGiaoDich}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(error, "Lỗi thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

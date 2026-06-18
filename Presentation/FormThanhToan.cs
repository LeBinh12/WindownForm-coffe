using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Application;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormThanhToan : Form
    {
        private readonly ThanhToanUseCase _useCase;
        private readonly int _banId;
        private readonly AppDbContext _context;
        private DonHang _currentDonHang;

        public FormThanhToan(ThanhToanUseCase useCase, int banId, AppDbContext context)
        {
            InitializeComponent();
            _useCase = useCase;
            _banId = banId;
            _context = context;
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            // Nạp phương thức thanh toán
            cbPhuongThuc.Items.Clear();
            cbPhuongThuc.Items.Add("Tiền mặt");
            cbPhuongThuc.Items.Add("Chuyển khoản");
            cbPhuongThuc.Items.Add("Ví điện tử");
            cbPhuongThuc.SelectedIndex = 0;

            LoadDonHang();
        }

        private void LoadDonHang()
        {
            _currentDonHang = _useCase.LayDonHangChuaThanhToanCuaBan(_banId);

            if (_currentDonHang == null)
            {
                MessageBox.Show("Bàn này hiện không có đơn hàng nào chưa thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QuayLaiSoDoBan();
                return;
            }

            lblDonHangId.Text = $"Mã đơn hàng: #{_currentDonHang.Id}";
            lblTenBan.Text = $"BÀN: {_currentDonHang.Ban.TenBan}";
            lblNhanVien.Text = $"Nhân viên: {_currentDonHang.NhanVien?.HoTen ?? "Khách hàng tự gọi"}";
            lblNgayTao.Text = $"Giờ vào: {_currentDonHang.NgayTao:dd/MM/yyyy HH:mm}";

            // Hiển thị chi tiết đơn hàng
            gridDetails.Rows.Clear();
            foreach (var detail in _currentDonHang.ChiTietDonHangs)
            {
                gridDetails.Rows.Add(
                    detail.MonNuoc.TenMon,
                    detail.SoLuong,
                    $"{detail.DonGia:N0} đ",
                    $"{detail.ThanhTien:N0} đ"
                );
            }

            lblTongTien.Text = $"TỔNG THANH TOÁN: {_currentDonHang.TongTien:N0} đ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (_currentDonHang == null) return;

            PhuongThucThanhToan pt = (PhuongThucThanhToan)cbPhuongThuc.SelectedIndex;

            bool success = _useCase.ThanhToan(_currentDonHang.Id, pt, out HoaDon hoaDon, out string error);

            if (success && hoaDon != null)
            {
                string message = $"=== HÓA ĐƠN THANH TOÁN ===\n" +
                                 $"Mã Giao Dịch: {hoaDon.MaGiaoDich}\n" +
                                 $"Bàn: {_currentDonHang.Ban.TenBan}\n" +
                                 $"Thời gian: {hoaDon.NgayThanhToan:dd/MM/yyyy HH:mm:ss}\n" +
                                 $"Phương thức: {GetPhuongThucString(hoaDon.PhuongThuc)}\n" +
                                 $"Tổng tiền: {hoaDon.TongTien:N0} đ\n" +
                                 $"==========================\n" +
                                 $"Thanh toán thành công! Trả trạng thái bàn về trống.";
                
                MessageBox.Show(message, "Hóa đơn thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QuayLaiSoDoBan();
            }
            else
            {
                MessageBox.Show(error, "Thanh toán thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            QuayLaiSoDoBan();
        }

        private void QuayLaiSoDoBan()
        {
            // Gọi Main Form chuyển lại tab Sơ đồ bàn
            if (this.ParentForm is FormMain fm)
            {
                fm.SwitchToTab("Ban");
            }
        }
    }
}

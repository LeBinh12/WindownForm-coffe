using System;
using System.Linq;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Application
{
    public class ThanhToanUseCase
    {
        private readonly IDonHangRepository _donHangRepository;
        private readonly IHoaDonRepository _hoaDonRepository;
        private readonly IBanRepository _banRepository;

        public ThanhToanUseCase(
            IDonHangRepository donHangRepository,
            IHoaDonRepository hoaDonRepository,
            IBanRepository banRepository)
        {
            _donHangRepository = donHangRepository;
            _hoaDonRepository = hoaDonRepository;
            _banRepository = banRepository;
        }

        public DonHang LayDonHangChuaThanhToanCuaBan(int banId)
        {
            return _donHangRepository.GetAll()
                .FirstOrDefault(d => d.BanId == banId && 
                                     d.TrangThai != TrangThaiDonHang.DaThanhToan && 
                                     d.TrangThai != TrangThaiDonHang.DaHuy);
        }

        public bool ThanhToan(int donHangId, PhuongThucThanhToan phuongThuc, out HoaDon hoaDon, out string error)
        {
            error = string.Empty;
            hoaDon = null;

            var donHang = _donHangRepository.GetById(donHangId);
            if (donHang == null)
            {
                error = "Đơn hàng không tồn tại!";
                return false;
            }

            if (donHang.TrangThai == TrangThaiDonHang.DaThanhToan)
            {
                error = "Đơn hàng này đã được thanh toán trước đó!";
                return false;
            }

            // Đảm bảo quan hệ 1-1: Mỗi đơn chỉ được thanh toán 1 lần và có 1 hóa đơn duy nhất
            var existingHoaDon = _hoaDonRepository.GetAll().FirstOrDefault(h => h.DonHangId == donHangId);
            if (existingHoaDon != null)
            {
                error = "Đơn hàng này đã được lập hóa đơn thanh toán rồi!";
                return false;
            }

            // Sinh mã giao dịch duy nhất
            string maGiaoDich = "GD" + DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(100, 999);

            // BR-03: Thanh toán thành công -> đơn & hóa đơn DaThanhToan
            donHang.TrangThai = TrangThaiDonHang.DaThanhToan;
            _donHangRepository.Update(donHang);

            // Tạo hóa đơn mới
            hoaDon = new HoaDon
            {
                DonHangId = donHang.Id,
                NgayThanhToan = DateTime.Now,
                TongTien = donHang.TongTien,
                PhuongThuc = phuongThuc,
                TrangThai = TrangThaiThanhToan.DaThanhToan,
                MaGiaoDich = maGiaoDich
            };
            _hoaDonRepository.Add(hoaDon);

            // Trả trạng thái bàn về Trong
            var ban = _banRepository.GetById(donHang.BanId);
            if (ban != null)
            {
                // Kiểm tra xem bàn có đơn hàng chưa thanh toán nào khác không (dự phòng)
                var datMonKhac = _donHangRepository.GetAll()
                    .Any(d => d.BanId == ban.Id && 
                              d.Id != donHang.Id && 
                              d.TrangThai != TrangThaiDonHang.DaThanhToan && 
                              d.TrangThai != TrangThaiDonHang.DaHuy);

                if (!datMonKhac)
                {
                    ban.TrangThai = TrangThaiBan.Trong;
                    _banRepository.Update(ban);
                }
            }

            return true;
        }
    }
}

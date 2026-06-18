using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Application
{
    public class DatMonUseCase
    {
        private readonly IBanRepository _banRepository;
        private readonly IMonNuocRepository _monNuocRepository;
        private readonly IDonHangRepository _donHangRepository;

        public DatMonUseCase(
            IBanRepository banRepository,
            IMonNuocRepository monNuocRepository,
            IDonHangRepository donHangRepository)
        {
            _banRepository = banRepository;
            _monNuocRepository = monNuocRepository;
            _donHangRepository = donHangRepository;
        }

        public IEnumerable<Ban> LayDanhSachBan()
        {
            return _banRepository.GetAll();
        }

        public IEnumerable<MonNuoc> LayMonNuocCoTheBan()
        {
            // BR-01: Chỉ món ConBan = true mới được đặt
            return _monNuocRepository.GetAll().Where(m => m.ConBan);
        }

        public bool DatMon(int banId, int? nhanVienId, List<(int monNuocId, int soLuong)> items, out string error)
        {
            error = string.Empty;

            if (items == null || !items.Any())
            {
                error = "Vui lòng chọn ít nhất một món nước!";
                return false;
            }

            var ban = _banRepository.GetById(banId);
            if (ban == null)
            {
                error = "Bàn không tồn tại!";
                return false;
            }

            // Kiểm tra xem bàn có đơn hàng chưa thanh toán nào không
            var donHangsTrenBan = _donHangRepository.GetAll()
                .Where(d => d.BanId == banId && 
                            d.TrangThai != TrangThaiDonHang.DaThanhToan && 
                            d.TrangThai != TrangThaiDonHang.DaHuy);

            if (donHangsTrenBan.Any())
            {
                error = "Bàn này đang có đơn hàng chưa thanh toán! Không thể tạo đơn hàng mới.";
                return false;
            }

            // Tạo đơn hàng mới
            var donHang = new DonHang
            {
                BanId = banId,
                NhanVienId = nhanVienId,
                NgayTao = DateTime.Now,
                // BR-02: Đặt món xong -> đơn ChoXuLy
                TrangThai = TrangThaiDonHang.ChoXuLy,
                TongTien = 0
            };

            decimal tongTien = 0;
            foreach (var item in items)
            {
                var mon = _monNuocRepository.GetById(item.monNuocId);
                if (mon == null || !mon.ConBan)
                {
                    error = $"Món nước '{mon?.TenMon ?? "Không xác định"}' đã ngừng bán!";
                    return false;
                }

                if (item.soLuong <= 0)
                {
                    error = "Số lượng đặt phải lớn hơn 0!";
                    return false;
                }

                var detail = new ChiTietDonHang
                {
                    MonNuocId = mon.Id,
                    SoLuong = item.soLuong,
                    DonGia = mon.GiaBan,
                    ThanhTien = item.soLuong * mon.GiaBan
                };

                donHang.ChiTietDonHangs.Add(detail);
                tongTien += detail.ThanhTien;
            }

            donHang.TongTien = tongTien;
            _donHangRepository.Add(donHang);

            // Cập nhật trạng thái bàn sang DangPhucVu
            ban.TrangThai = TrangThaiBan.DangPhucVu;
            _banRepository.Update(ban);

            return true;
        }
    }
}

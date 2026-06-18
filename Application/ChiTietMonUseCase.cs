using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Application
{
    public class ChiTietMonUseCase
    {
        private readonly IBanRepository _banRepository;
        private readonly IMonNuocRepository _monNuocRepository;
        private readonly IDonHangRepository _donHangRepository;

        public ChiTietMonUseCase(
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

        public MonNuoc LayMonNuocTheoId(int id)
        {
            return _monNuocRepository.GetById(id);
        }

        public bool DatMonChoBan(int banId, int? nhanVienId, int monNuocId, int soLuong, out string error)
        {
            error = string.Empty;

            var mon = _monNuocRepository.GetById(monNuocId);
            if (mon == null)
            {
                error = "Món nước không tồn tại!";
                return false;
            }

            if (!mon.ConBan)
            {
                error = $"Món nước '{mon.TenMon}' đã ngừng bán! (BR-01)";
                return false;
            }

            if (soLuong <= 0)
            {
                error = "Số lượng đặt phải lớn hơn 0!";
                return false;
            }

            var ban = _banRepository.GetById(banId);
            if (ban == null)
            {
                error = "Bàn không tồn tại!";
                return false;
            }

            // Tìm đơn hàng chưa thanh toán trên bàn này
            var activeOrder = _donHangRepository.GetAll()
                .FirstOrDefault(d => d.BanId == banId && 
                                    d.TrangThai != TrangThaiDonHang.DaThanhToan && 
                                    d.TrangThai != TrangThaiDonHang.DaHuy);

            if (activeOrder != null)
            {
                // Thêm/cập nhật vào đơn hàng hiện tại
                var detail = activeOrder.ChiTietDonHangs.FirstOrDefault(dt => dt.MonNuocId == monNuocId);
                if (detail != null)
                {
                    detail.SoLuong += soLuong;
                    detail.ThanhTien = detail.SoLuong * detail.DonGia;
                }
                else
                {
                    activeOrder.ChiTietDonHangs.Add(new ChiTietDonHang
                    {
                        MonNuocId = monNuocId,
                        SoLuong = soLuong,
                        DonGia = mon.GiaBan,
                        ThanhTien = soLuong * mon.GiaBan
                    });
                }
                activeOrder.TongTien = activeOrder.ChiTietDonHangs.Sum(dt => dt.ThanhTien);
                _donHangRepository.Update(activeOrder);
            }
            else
            {
                // Tạo mới đơn hàng
                var donHang = new DonHang
                {
                    BanId = banId,
                    NhanVienId = nhanVienId,
                    NgayTao = DateTime.Now,
                    TrangThai = TrangThaiDonHang.ChoXuLy,
                    TongTien = soLuong * mon.GiaBan
                };

                donHang.ChiTietDonHangs.Add(new ChiTietDonHang
                {
                    MonNuocId = mon.Id,
                    SoLuong = soLuong,
                    DonGia = mon.GiaBan,
                    ThanhTien = soLuong * mon.GiaBan
                });

                _donHangRepository.Add(donHang);

                // Cập nhật trạng thái bàn sang DangPhucVu
                ban.TrangThai = TrangThaiBan.DangPhucVu;
                _banRepository.Update(ban);
            }

            return true;
        }
    }
}

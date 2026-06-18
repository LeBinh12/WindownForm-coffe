using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Application
{
    public class XuLyDonHangUseCase
    {
        private readonly IDonHangRepository _donHangRepository;
        private readonly IBanRepository _banRepository;

        public XuLyDonHangUseCase(IDonHangRepository donHangRepository, IBanRepository banRepository)
        {
            _donHangRepository = donHangRepository;
            _banRepository = banRepository;
        }

        public IEnumerable<DonHang> LayDanhSachDonHang(TrangThaiDonHang? trangThai = null)
        {
            var list = _donHangRepository.GetAll();
            if (trangThai.HasValue)
            {
                list = list.Where(d => d.TrangThai == trangThai.Value);
            }
            return list.OrderByDescending(d => d.NgayTao);
        }

        public DonHang LayDonHangTheoId(int id)
        {
            return _donHangRepository.GetById(id);
        }

        // UC06: Hủy đơn hàng (Chỉ đơn ChoXuLy -> DaHuy)
        public bool HuyDonHang(int donHangId, out string error)
        {
            error = string.Empty;
            var donHang = _donHangRepository.GetById(donHangId);
            if (donHang == null)
            {
                error = "Đơn hàng không tồn tại!";
                return false;
            }

            // BR-05: Chỉ hủy đơn ChoXuLy
            if (donHang.TrangThai != TrangThaiDonHang.ChoXuLy)
            {
                error = "Chỉ có thể hủy đơn hàng ở trạng thái 'Chờ xử lý'!";
                return false;
            }

            donHang.TrangThai = TrangThaiDonHang.DaHuy;
            _donHangRepository.Update(donHang);

            // Cập nhật bàn tương ứng về trống
            var ban = _banRepository.GetById(donHang.BanId);
            if (ban != null)
            {
                // Kiểm tra xem bàn có đơn hàng chưa thanh toán khác không (dự phòng)
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

        // UC07: Tiếp nhận và xử lý đơn hàng (nhân viên)
        public bool TiepNhanDonHang(int donHangId, int nhanVienId, out string error)
        {
            error = string.Empty;
            var donHang = _donHangRepository.GetById(donHangId);
            if (donHang == null)
            {
                error = "Đơn hàng không tồn tại!";
                return false;
            }

            if (donHang.TrangThai != TrangThaiDonHang.ChoXuLy)
            {
                error = "Đơn hàng phải ở trạng thái 'Chờ xử lý' mới có thể tiếp nhận!";
                return false;
            }

            donHang.TrangThai = TrangThaiDonHang.DangPhucVu;
            donHang.NhanVienId = nhanVienId;
            _donHangRepository.Update(donHang);

            return true;
        }

        public bool HoanThanhDonHang(int donHangId, out string error)
        {
            error = string.Empty;
            var donHang = _donHangRepository.GetById(donHangId);
            if (donHang == null)
            {
                error = "Đơn hàng không tồn tại!";
                return false;
            }

            if (donHang.TrangThai != TrangThaiDonHang.DangPhucVu)
            {
                error = "Đơn hàng phải ở trạng thái 'Đang phục vụ' mới có thể chuyển sang hoàn thành!";
                return false;
            }

            donHang.TrangThai = TrangThaiDonHang.HoanThanh;
            _donHangRepository.Update(donHang);

            // Bàn tương ứng chuyển sang Chờ thanh toán
            var ban = _banRepository.GetById(donHang.BanId);
            if (ban != null)
            {
                ban.TrangThai = TrangThaiBan.ChoThanhToan;
                _banRepository.Update(ban);
            }

            return true;
        }
    }
}

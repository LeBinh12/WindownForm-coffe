using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Application
{
    public class QuanLyBanUseCase
    {
        private readonly AppDbContext _context;
        private readonly IBanRepository _banRepository;
        private readonly IDonHangRepository _donHangRepository;
        private readonly IMonNuocRepository _monNuocRepository;

        public QuanLyBanUseCase(AppDbContext context)
        {
            _context = context;
            _banRepository = new BanRepository(context);
            _donHangRepository = new DonHangRepository(context);
            _monNuocRepository = new MonNuocRepository(context);
        }

        public IEnumerable<Ban> LayDanhSachBan()
        {
            return _banRepository.GetAll();
        }

        public Ban LayBanTheoId(int id)
        {
            return _banRepository.GetById(id);
        }

        public DonHang LayDonHangDangMoCuaBan(int banId)
        {
            // Eager-loading detail relationships
            return _context.DonHangs
                .Include(d => d.Ban)
                .Include(d => d.NhanVien)
                .Include(d => d.ChiTietDonHangs)
                    .ThenInclude(ct => ct.MonNuoc)
                .FirstOrDefault(d => d.BanId == banId &&
                                     d.TrangThai != TrangThaiDonHang.DaThanhToan &&
                                     d.TrangThai != TrangThaiDonHang.DaHuy);
        }

        public IEnumerable<MonNuoc> LayMonNuocCoTheBan()
        {
            return _monNuocRepository.GetAll().Where(m => m.ConBan);
        }

        public IEnumerable<Ban> LayDanhSachBanTrong(int excludeBanId)
        {
            return _banRepository.GetAll().Where(b => b.TrangThai == TrangThaiBan.Trong && b.Id != excludeBanId);
        }

        public bool CapNhatSoLuongMon(int donHangId, int monNuocId, int deltaQuantity, out string error)
        {
            error = string.Empty;

            var donHang = _donHangRepository.GetById(donHangId);
            if (donHang == null)
            {
                error = "Đơn hàng không tồn tại!";
                return false;
            }

            if (donHang.TrangThai == TrangThaiDonHang.DaThanhToan || donHang.TrangThai == TrangThaiDonHang.DaHuy)
            {
                error = "Đơn hàng đã được thanh toán hoặc hủy, không thể chỉnh sửa!";
                return false;
            }

            var chiTiet = donHang.ChiTietDonHangs.FirstOrDefault(ct => ct.MonNuocId == monNuocId);
            if (chiTiet == null)
            {
                error = "Món nước không có trong đơn hàng!";
                return false;
            }

            int newQty = chiTiet.SoLuong + deltaQuantity;
            if (newQty <= 0)
            {
                // Yêu cầu xóa món nước
                return XoaMonKhoiDon(donHangId, monNuocId, out error);
            }

            chiTiet.SoLuong = newQty;
            chiTiet.ThanhTien = chiTiet.SoLuong * chiTiet.DonGia;
            donHang.TongTien = donHang.ChiTietDonHangs.Sum(ct => ct.ThanhTien);

            _donHangRepository.Update(donHang);
            return true;
        }

        public bool XoaMonKhoiDon(int donHangId, int monNuocId, out string error)
        {
            error = string.Empty;

            var donHang = _donHangRepository.GetById(donHangId);
            if (donHang == null)
            {
                error = "Đơn hàng không tồn tại!";
                return false;
            }

            if (donHang.TrangThai == TrangThaiDonHang.DaThanhToan || donHang.TrangThai == TrangThaiDonHang.DaHuy)
            {
                error = "Đơn hàng đã được thanh toán hoặc hủy, không thể chỉnh sửa!";
                return false;
            }

            // Ràng buộc: Đơn hàng phải còn ít nhất 1 món nước
            if (donHang.ChiTietDonHangs.Count <= 1 && donHang.ChiTietDonHangs.Any(ct => ct.MonNuocId == monNuocId))
            {
                error = "Đơn hàng phải còn ít nhất 1 món! Không thể xóa món nước cuối cùng.";
                return false;
            }

            var chiTiet = donHang.ChiTietDonHangs.FirstOrDefault(ct => ct.MonNuocId == monNuocId);
            if (chiTiet != null)
            {
                // Remove the row from DB context
                _context.ChiTietDonHangs.Remove(chiTiet);
                _context.SaveChanges();

                // Recalculate total
                // Need to reload/refresh from local tracking or context
                donHang.TongTien = donHang.ChiTietDonHangs.Where(ct => ct.Id != chiTiet.Id).Sum(ct => ct.ThanhTien);
                _donHangRepository.Update(donHang);
            }

            return true;
        }

        public bool ThemMonVaoDon(int donHangId, int monNuocId, int soLuong, out string error)
        {
            error = string.Empty;

            if (soLuong <= 0)
            {
                error = "Số lượng đặt phải lớn hơn 0!";
                return false;
            }

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

            var donHang = _donHangRepository.GetById(donHangId);
            if (donHang == null)
            {
                error = "Đơn hàng không tồn tại!";
                return false;
            }

            if (donHang.TrangThai == TrangThaiDonHang.DaThanhToan || donHang.TrangThai == TrangThaiDonHang.DaHuy)
            {
                error = "Đơn hàng đã được thanh toán hoặc hủy, không thể chỉnh sửa!";
                return false;
            }

            var chiTiet = donHang.ChiTietDonHangs.FirstOrDefault(ct => ct.MonNuocId == monNuocId);
            if (chiTiet != null)
            {
                chiTiet.SoLuong += soLuong;
                chiTiet.ThanhTien = chiTiet.SoLuong * chiTiet.DonGia;
            }
            else
            {
                donHang.ChiTietDonHangs.Add(new ChiTietDonHang
                {
                    MonNuocId = monNuocId,
                    SoLuong = soLuong,
                    DonGia = mon.GiaBan,
                    ThanhTien = soLuong * mon.GiaBan
                });
            }

            donHang.TongTien = donHang.ChiTietDonHangs.Sum(ct => ct.ThanhTien);
            _donHangRepository.Update(donHang);
            return true;
        }

        public bool DoiBan(int donHangId, int targetBanId, out string error)
        {
            error = string.Empty;

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var donHang = _donHangRepository.GetById(donHangId);
                    if (donHang == null)
                    {
                        error = "Đơn hàng không tồn tại!";
                        return false;
                    }

                    if (donHang.TrangThai == TrangThaiDonHang.DaThanhToan || donHang.TrangThai == TrangThaiDonHang.DaHuy)
                    {
                        error = "Đơn hàng đã thanh toán hoặc hủy, không thể đổi bàn!";
                        return false;
                    }

                    var targetBan = _banRepository.GetById(targetBanId);
                    if (targetBan == null)
                    {
                        error = "Bàn đích không tồn tại!";
                        return false;
                    }

                    if (targetBan.TrangThai != TrangThaiBan.Trong)
                    {
                        error = "Bàn đích đang bận, không thể chuyển sang!";
                        return false;
                    }

                    int oldBanId = donHang.BanId;
                    var oldBan = _banRepository.GetById(oldBanId);

                    // Update states
                    donHang.BanId = targetBanId;
                    _donHangRepository.Update(donHang);

                    if (oldBan != null)
                    {
                        oldBan.TrangThai = TrangThaiBan.Trong;
                        _banRepository.Update(oldBan);
                    }

                    targetBan.TrangThai = TrangThaiBan.DangPhucVu;
                    _banRepository.Update(targetBan);

                    _context.SaveChanges();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    error = $"Lỗi hệ thống khi chuyển bàn: {ex.Message}";
                    return false;
                }
            }
        }

        public bool ThemBanMoi(string tenBan, int soChoNgoi, out string error)
        {
            error = string.Empty;

            if (string.IsNullOrWhiteSpace(tenBan))
            {
                error = "Tên bàn không được để trống!";
                return false;
            }

            if (soChoNgoi <= 0)
            {
                error = "Số chỗ ngồi phải lớn hơn 0!";
                return false;
            }

            bool isNameDuplicate = _banRepository.GetAll()
                .Any(b => string.Equals(b.TenBan.Trim(), tenBan.Trim(), StringComparison.OrdinalIgnoreCase));

            if (isNameDuplicate)
            {
                error = $"Tên bàn '{tenBan}' đã tồn tại trong hệ thống!";
                return false;
            }

            var banMoi = new Ban
            {
                TenBan = tenBan.Trim(),
                SoChoNgoi = soChoNgoi,
                TrangThai = TrangThaiBan.Trong
            };

            _banRepository.Add(banMoi);
            return true;
        }

        public bool SuaThongTinBan(int banId, string tenBan, int soChoNgoi, out string error)
        {
            error = string.Empty;

            if (string.IsNullOrWhiteSpace(tenBan))
            {
                error = "Tên bàn không được để trống!";
                return false;
            }

            if (soChoNgoi <= 0)
            {
                error = "Số chỗ ngồi phải lớn hơn 0!";
                return false;
            }

            var ban = _banRepository.GetById(banId);
            if (ban == null)
            {
                error = "Bàn không tồn tại!";
                return false;
            }

            bool isNameDuplicate = _banRepository.GetAll()
                .Any(b => b.Id != banId && string.Equals(b.TenBan.Trim(), tenBan.Trim(), StringComparison.OrdinalIgnoreCase));

            if (isNameDuplicate)
            {
                error = $"Tên bàn '{tenBan}' đã tồn tại trên một bàn khác!";
                return false;
            }

            ban.TenBan = tenBan.Trim();
            ban.SoChoNgoi = soChoNgoi;

            _banRepository.Update(ban);
            return true;
        }

        public bool XoaBan(int banId, out string error)
        {
            error = string.Empty;

            var ban = _banRepository.GetById(banId);
            if (ban == null)
            {
                error = "Bàn không tồn tại!";
                return false;
            }

            if (ban.TrangThai != TrangThaiBan.Trong)
            {
                error = "Bàn đang phục vụ hoặc chờ thanh toán, không thể xóa!";
                return false;
            }

            // Kiểm tra xem bàn có đơn hàng dang dở nào không
            bool coDonDangMo = _donHangRepository.GetAll()
                .Any(d => d.BanId == banId &&
                          d.TrangThai != TrangThaiDonHang.DaThanhToan &&
                          d.TrangThai != TrangThaiDonHang.DaHuy);

            if (coDonDangMo)
            {
                error = "Bàn này đang liên kết với đơn hàng chưa hoàn thành, không thể xóa!";
                return false;
            }

            _banRepository.Delete(banId);
            return true;
        }
    }
}

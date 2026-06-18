using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Application
{
    public class QuanLyThucDonUseCase
    {
        private readonly IMonNuocRepository _monNuocRepository;

        public QuanLyThucDonUseCase(IMonNuocRepository monNuocRepository)
        {
            _monNuocRepository = monNuocRepository;
        }

        public IEnumerable<MonNuoc> LayDanhSachThucDon(string searchKeyword = null, LoaiMon? loaiMon = null)
        {
            var list = _monNuocRepository.GetAll();

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                list = list.Where(m => m.TenMon.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase));
            }

            if (loaiMon.HasValue)
            {
                list = list.Where(m => m.LoaiMon == loaiMon.Value);
            }

            return list;
        }

        public MonNuoc LayMonNuocTheoId(int id)
        {
            return _monNuocRepository.GetById(id);
        }

        public bool ThemMonNuoc(MonNuoc monNuoc, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(monNuoc.TenMon))
            {
                error = "Tên món không được trống!";
                return false;
            }

            if (monNuoc.GiaBan <= 0)
            {
                error = "Giá bán phải lớn hơn 0!";
                return false;
            }

            _monNuocRepository.Add(monNuoc);
            return true;
        }

        public bool CapNhatMonNuoc(MonNuoc monNuoc, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(monNuoc.TenMon))
            {
                error = "Tên món không được trống!";
                return false;
            }

            if (monNuoc.GiaBan <= 0)
            {
                error = "Giá bán phải lớn hơn 0!";
                return false;
            }

            var dbMon = _monNuocRepository.GetById(monNuoc.Id);
            if (dbMon == null)
            {
                error = "Món nước không tồn tại!";
                return false;
            }

            dbMon.TenMon = monNuoc.TenMon;
            dbMon.LoaiMon = monNuoc.LoaiMon;
            dbMon.GiaBan = monNuoc.GiaBan;
            dbMon.MoTa = monNuoc.MoTa;
            dbMon.HinhAnh = monNuoc.HinhAnh;
            dbMon.ConBan = monNuoc.ConBan;

            _monNuocRepository.Update(dbMon);
            return true;
        }

        public bool XoaMonNuoc(int id, out string error)
        {
            error = string.Empty;
            try
            {
                _monNuocRepository.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                error = "Không thể xóa món này vì đã có lịch sử đặt hàng!";
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Application
{
    public class RevenueRecord
    {
        public string Label { get; set; }
        public decimal Revenue { get; set; }
    }

    public class ThongKeUseCase
    {
        private readonly IHoaDonRepository _hoaDonRepository;

        public ThongKeUseCase(IHoaDonRepository hoaDonRepository)
        {
            _hoaDonRepository = hoaDonRepository;
        }

        public decimal TinhTongDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            tuNgay = tuNgay.Date;
            denNgay = denNgay.Date.AddDays(1).AddTicks(-1);

            return _hoaDonRepository.GetAll()
                .Where(h => h.TrangThai == TrangThaiThanhToan.DaThanhToan && 
                            h.NgayThanhToan >= tuNgay && 
                            h.NgayThanhToan <= denNgay)
                .Sum(h => h.TongTien);
        }

        public IEnumerable<HoaDon> LayHoaDonThanhToan(DateTime tuNgay, DateTime denNgay)
        {
            tuNgay = tuNgay.Date;
            denNgay = denNgay.Date.AddDays(1).AddTicks(-1);

            return _hoaDonRepository.GetAll()
                .Where(h => h.TrangThai == TrangThaiThanhToan.DaThanhToan && 
                            h.NgayThanhToan >= tuNgay && 
                            h.NgayThanhToan <= denNgay)
                .OrderBy(h => h.NgayThanhToan);
        }

        public List<RevenueRecord> ThongKeTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            tuNgay = tuNgay.Date;
            denNgay = denNgay.Date;

            var activeHoaDons = _hoaDonRepository.GetAll()
                .Where(h => h.TrangThai == TrangThaiThanhToan.DaThanhToan && 
                            h.NgayThanhToan.Date >= tuNgay && 
                            h.NgayThanhToan.Date <= denNgay)
                .ToList();

            var result = new List<RevenueRecord>();
            for (var date = tuNgay; date <= denNgay; date = date.AddDays(1))
            {
                var revenue = activeHoaDons
                    .Where(h => h.NgayThanhToan.Date == date)
                    .Sum(h => h.TongTien);

                result.Add(new RevenueRecord
                {
                    Label = date.ToString("dd/MM"),
                    Revenue = revenue
                });
            }

            return result;
        }

        public List<RevenueRecord> ThongKeTheoThang(int nam)
        {
            var activeHoaDons = _hoaDonRepository.GetAll()
                .Where(h => h.TrangThai == TrangThaiThanhToan.DaThanhToan && 
                            h.NgayThanhToan.Year == nam)
                .ToList();

            var result = new List<RevenueRecord>();
            for (int month = 1; month <= 12; month++)
            {
                var revenue = activeHoaDons
                    .Where(h => h.NgayThanhToan.Month == month)
                    .Sum(h => h.TongTien);

                result.Add(new RevenueRecord
                {
                    Label = "Thg " + month,
                    Revenue = revenue
                });
            }

            return result;
        }

        public List<RevenueRecord> ThongKeTheoNam(int tuNam, int denNam)
        {
            var activeHoaDons = _hoaDonRepository.GetAll()
                .Where(h => h.TrangThai == TrangThaiThanhToan.DaThanhToan && 
                            h.NgayThanhToan.Year >= tuNam && 
                            h.NgayThanhToan.Year <= denNam)
                .ToList();

            var result = new List<RevenueRecord>();
            for (int year = tuNam; year <= denNam; year++)
            {
                var revenue = activeHoaDons
                    .Where(h => h.NgayThanhToan.Year == year)
                    .Sum(h => h.TongTien);

                result.Add(new RevenueRecord
                {
                    Label = year.ToString(),
                    Revenue = revenue
                });
            }

            return result;
        }

        public Dictionary<DateTime, decimal> ThongKeDoanhThuTheoNgay(int songay)
        {
            var end = DateTime.Today;
            var start = end.AddDays(-songay + 1);

            var activeHoaDons = _hoaDonRepository.GetAll()
                .Where(h => h.TrangThai == TrangThaiThanhToan.DaThanhToan && 
                             h.NgayThanhToan.Date >= start && 
                             h.NgayThanhToan.Date <= end)
                .ToList();

            var result = new Dictionary<DateTime, decimal>();
            for (var date = start; date <= end; date = date.AddDays(1))
            {
                var revenue = activeHoaDons
                    .Where(h => h.NgayThanhToan.Date == date)
                    .Sum(h => h.TongTien);

                result.Add(date, revenue);
            }

            return result;
        }

        public Dictionary<string, decimal> ThongKeDoanhThuTheoThang(int sothang)
        {
            var end = DateTime.Today;
            var start = end.AddMonths(-sothang + 1);

            var activeHoaDons = _hoaDonRepository.GetAll()
                .Where(h => h.TrangThai == TrangThaiThanhToan.DaThanhToan && 
                             h.NgayThanhToan.Date >= new DateTime(start.Year, start.Month, 1) && 
                             h.NgayThanhToan.Date <= end)
                .ToList();

            var result = new Dictionary<string, decimal>();
            for (var date = new DateTime(start.Year, start.Month, 1); date <= end; date = date.AddMonths(1))
            {
                var label = date.ToString("MM/yyyy");
                var revenue = activeHoaDons
                    .Where(h => h.NgayThanhToan.Year == date.Year && h.NgayThanhToan.Month == date.Month)
                    .Sum(h => h.TongTien);

                result.Add(label, revenue);
            }

            return result;
        }
    }
}

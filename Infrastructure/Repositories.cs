using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCafe.Domain;

namespace QuanLyQuanCafe.Infrastructure
{
    // Interface & Implementation cho NguoiDungRepository
    public interface INguoiDungRepository
    {
        IEnumerable<NguoiDung> GetAll();
        NguoiDung GetById(int id);
        void Add(NguoiDung entity);
        void Update(NguoiDung entity);
        void Delete(int id);
        void SaveChanges();
    }

    public class NguoiDungRepository : INguoiDungRepository
    {
        private readonly AppDbContext _context;
        public NguoiDungRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<NguoiDung> GetAll()
        {
            return _context.NguoiDungs.Include(n => n.TaiKhoan).ToList();
        }

        public NguoiDung GetById(int id)
        {
            return _context.NguoiDungs.Include(n => n.TaiKhoan).FirstOrDefault(n => n.Id == id);
        }

        public void Add(NguoiDung entity)
        {
            _context.NguoiDungs.Add(entity);
            SaveChanges();
        }

        public void Update(NguoiDung entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.NguoiDungs.Find(id);
            if (entity != null)
            {
                _context.NguoiDungs.Remove(entity);
                SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

    // Interface & Implementation cho TaiKhoanRepository
    public interface ITaiKhoanRepository
    {
        IEnumerable<TaiKhoan> GetAll();
        TaiKhoan GetById(int id);
        TaiKhoan GetByTenDangNhap(string username);
        void Add(TaiKhoan entity);
        void Update(TaiKhoan entity);
        void SaveChanges();
    }

    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        private readonly AppDbContext _context;
        public TaiKhoanRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TaiKhoan> GetAll()
        {
            return _context.TaiKhoans.Include(t => t.NguoiDung).ToList();
        }

        public TaiKhoan GetById(int id)
        {
            return _context.TaiKhoans.Include(t => t.NguoiDung).FirstOrDefault(t => t.Id == id);
        }

        public TaiKhoan GetByTenDangNhap(string username)
        {
            return _context.TaiKhoans.Include(t => t.NguoiDung)
                .FirstOrDefault(t => string.Equals(t.TenDangNhap, username));
        }

        public void Add(TaiKhoan entity)
        {
            _context.TaiKhoans.Add(entity);
            SaveChanges();
        }

        public void Update(TaiKhoan entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

    // Interface & Implementation cho MonNuocRepository
    public interface IMonNuocRepository
    {
        IEnumerable<MonNuoc> GetAll();
        MonNuoc GetById(int id);
        void Add(MonNuoc entity);
        void Update(MonNuoc entity);
        void Delete(int id);
        void SaveChanges();
    }

    public class MonNuocRepository : IMonNuocRepository
    {
        private readonly AppDbContext _context;
        public MonNuocRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MonNuoc> GetAll()
        {
            return _context.MonNuocs.ToList();
        }

        public MonNuoc GetById(int id)
        {
            return _context.MonNuocs.Find(id);
        }

        public void Add(MonNuoc entity)
        {
            _context.MonNuocs.Add(entity);
            SaveChanges();
        }

        public void Update(MonNuoc entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.MonNuocs.Find(id);
            if (entity != null)
            {
                _context.MonNuocs.Remove(entity);
                SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

    // Interface & Implementation cho BanRepository
    public interface IBanRepository
    {
        IEnumerable<Ban> GetAll();
        Ban GetById(int id);
        void Add(Ban entity);
        void Update(Ban entity);
        void Delete(int id);
        void SaveChanges();
    }

    public class BanRepository : IBanRepository
    {
        private readonly AppDbContext _context;
        public BanRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Ban> GetAll()
        {
            return _context.Bans.ToList();
        }

        public Ban GetById(int id)
        {
            return _context.Bans.Find(id);
        }

        public void Add(Ban entity)
        {
            _context.Bans.Add(entity);
            SaveChanges();
        }

        public void Update(Ban entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Bans.Find(id);
            if (entity != null)
            {
                _context.Bans.Remove(entity);
                SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

    // Interface & Implementation cho DonHangRepository
    public interface IDonHangRepository
    {
        IEnumerable<DonHang> GetAll();
        DonHang GetById(int id);
        void Add(DonHang entity);
        void Update(DonHang entity);
        void Delete(int id);
        void SaveChanges();
    }

    public class DonHangRepository : IDonHangRepository
    {
        private readonly AppDbContext _context;
        public DonHangRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<DonHang> GetAll()
        {
            return _context.DonHangs
                .Include(d => d.Ban)
                .Include(d => d.NhanVien)
                .Include(d => d.ChiTietDonHangs)
                    .ThenInclude(c => c.MonNuoc)
                .Include(d => d.HoaDon)
                .ToList();
        }

        public DonHang GetById(int id)
        {
            return _context.DonHangs
                .Include(d => d.Ban)
                .Include(d => d.NhanVien)
                .Include(d => d.ChiTietDonHangs)
                    .ThenInclude(c => c.MonNuoc)
                .Include(d => d.HoaDon)
                .FirstOrDefault(d => d.Id == id);
        }

        public void Add(DonHang entity)
        {
            _context.DonHangs.Add(entity);
            SaveChanges();
        }

        public void Update(DonHang entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            // Also need to save changes for detail additions/updates
            SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.DonHangs.Find(id);
            if (entity != null)
            {
                _context.DonHangs.Remove(entity);
                SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

    // Interface & Implementation cho HoaDonRepository
    public interface IHoaDonRepository
    {
        IEnumerable<HoaDon> GetAll();
        HoaDon GetById(int id);
        HoaDon GetByDonHangId(int donHangId);
        void Add(HoaDon entity);
        void SaveChanges();
    }

    public class HoaDonRepository : IHoaDonRepository
    {
        private readonly AppDbContext _context;
        public HoaDonRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<HoaDon> GetAll()
        {
            return _context.HoaDons.Include(h => h.DonHang).ThenInclude(d => d.Ban).ToList();
        }

        public HoaDon GetById(int id)
        {
            return _context.HoaDons.Include(h => h.DonHang).FirstOrDefault(h => h.Id == id);
        }

        public HoaDon GetByDonHangId(int donHangId)
        {
            return _context.HoaDons.FirstOrDefault(h => h.DonHangId == donHangId);
        }

        public void Add(HoaDon entity)
        {
            _context.HoaDons.Add(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

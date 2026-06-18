using Microsoft.EntityFrameworkCore;
using QuanLyQuanCafe.Domain;

namespace QuanLyQuanCafe.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<MonNuoc> MonNuocs { get; set; }
        public DbSet<Ban> Bans { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DbConfig.GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình NguoiDung
            modelBuilder.Entity<NguoiDung>()
                .HasIndex(n => n.Email)
                .IsUnique();

            // Cấu hình TaiKhoan
            modelBuilder.Entity<TaiKhoan>()
                .HasIndex(t => t.TenDangNhap)
                .IsUnique();

            modelBuilder.Entity<TaiKhoan>()
                .HasOne(t => t.NguoiDung)
                .WithOne(n => n.TaiKhoan)
                .HasForeignKey<TaiKhoan>(t => t.NguoiDungId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình MonNuoc
            modelBuilder.Entity<MonNuoc>()
                .Property(m => m.GiaBan)
                .HasColumnType("decimal(18,2)");

            // Cấu hình DonHang
            modelBuilder.Entity<DonHang>()
                .Property(d => d.TongTien)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<DonHang>()
                .HasOne(d => d.Ban)
                .WithMany(b => b.DonHangs)
                .HasForeignKey(d => d.BanId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DonHang>()
                .HasOne(d => d.NhanVien)
                .WithMany(n => n.DonHangs)
                .HasForeignKey(d => d.NhanVienId)
                .OnDelete(DeleteBehavior.SetNull);

            // Cấu hình ChiTietDonHang
            modelBuilder.Entity<ChiTietDonHang>()
                .Property(c => c.DonGia)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(c => c.ThanhTien)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ChiTietDonHang>()
                .HasOne(c => c.DonHang)
                .WithMany(d => d.ChiTietDonHangs)
                .HasForeignKey(c => c.DonHangId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChiTietDonHang>()
                .HasOne(c => c.MonNuoc)
                .WithMany(m => m.ChiTietDonHangs)
                .HasForeignKey(c => c.MonNuocId)
                .OnDelete(DeleteBehavior.Restrict);

            // Cấu hình HoaDon
            modelBuilder.Entity<HoaDon>()
                .Property(h => h.TongTien)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<HoaDon>()
                .HasIndex(h => h.MaGiaoDich)
                .IsUnique();

            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.DonHang)
                .WithOne(d => d.HoaDon)
                .HasForeignKey<HoaDon>(h => h.DonHangId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

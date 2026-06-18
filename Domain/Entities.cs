using System;
using System.Collections.Generic;

namespace QuanLyQuanCafe.Domain
{
    public class NguoiDung
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public VaiTro VaiTro { get; set; }

        // Navigation properties
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
    }

    public class TaiKhoan
    {
        public int Id { get; set; }
        public int NguoiDungId { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; } // Hashed using SHA256
        public TrangThaiTaiKhoan TrangThai { get; set; }

        // Navigation properties
        public virtual NguoiDung NguoiDung { get; set; }
    }

    public class MonNuoc
    {
        public int Id { get; set; }
        public string TenMon { get; set; }
        public LoaiMon LoaiMon { get; set; }
        public decimal GiaBan { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; } // Path to local or relative image file
        public bool ConBan { get; set; }

        // Navigation properties
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();
    }

    public class Ban
    {
        public int Id { get; set; }
        public string TenBan { get; set; }
        public int SoChoNgoi { get; set; }
        public TrangThaiBan TrangThai { get; set; }

        // Navigation properties
        public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
    }

    public class DonHang
    {
        public int Id { get; set; }
        public int BanId { get; set; }
        public int? NhanVienId { get; set; } // Nullable, if ordered online by guest or not yet assigned
        public DateTime NgayTao { get; set; }
        public decimal TongTien { get; set; }
        public TrangThaiDonHang TrangThai { get; set; }

        // Navigation properties
        public virtual Ban Ban { get; set; }
        public virtual NguoiDung NhanVien { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; } = new List<ChiTietDonHang>();
        public virtual HoaDon HoaDon { get; set; }
    }

    public class ChiTietDonHang
    {
        public int Id { get; set; }
        public int DonHangId { get; set; }
        public int MonNuocId { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; } // Store to DB or compute. We will store it for simplicity or make it computed in EF Core. Let's make it simple to set.

        // Navigation properties
        public virtual DonHang DonHang { get; set; }
        public virtual MonNuoc MonNuoc { get; set; }
    }

    public class HoaDon
    {
        public int Id { get; set; }
        public int DonHangId { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public decimal TongTien { get; set; }
        public PhuongThucThanhToan PhuongThuc { get; set; }
        public TrangThaiThanhToan TrangThai { get; set; }
        public string MaGiaoDich { get; set; } // Hóa đơn mã giao dịch duy nhất

        // Navigation properties
        public virtual DonHang DonHang { get; set; }
    }
}

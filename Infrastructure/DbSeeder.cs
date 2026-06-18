using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using QuanLyQuanCafe.Domain;

namespace QuanLyQuanCafe.Infrastructure
{
    public static class DbSeeder
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToHexString(bytes).ToLower();
            }
        }

        public static void Seed(AppDbContext context)
        {
            // Tự động tạo cơ sở dữ liệu nếu chưa tồn tại
            context.Database.EnsureCreated();

            // Nếu dữ liệu đã có thì bỏ qua
            if (context.NguoiDungs.Any())
            {
                return;
            }

            // 1. Seed NguoiDung & TaiKhoan
            var nguoiDungs = new List<NguoiDung>
            {
                new NguoiDung
                {
                    HoTen = "Quản Trị Viên",
                    Email = "admin@quanlyquancafe.com",
                    SoDienThoai = "0901234567",
                    DiaChi = "123 Đường Cà Phê, TP. HCM",
                    VaiTro = VaiTro.Admin,
                    TaiKhoan = new TaiKhoan
                    {
                        TenDangNhap = "admin",
                        MatKhau = HashPassword("admin123"),
                        TrangThai = TrangThaiTaiKhoan.HoatDong
                    }
                },
                new NguoiDung
                {
                    HoTen = "Nguyễn Văn Nhân Viên",
                    Email = "nhanvien@quanlyquancafe.com",
                    SoDienThoai = "0907654321",
                    DiaChi = "456 Đường Bạc Xỉu, TP. HCM",
                    VaiTro = VaiTro.NhanVien,
                    TaiKhoan = new TaiKhoan
                    {
                        TenDangNhap = "nhanvien",
                        MatKhau = HashPassword("nv123"),
                        TrangThai = TrangThaiTaiKhoan.HoatDong
                    }
                },
                new NguoiDung
                {
                    HoTen = "Trần Thị Khách Hàng",
                    Email = "khachhang@gmail.com",
                    SoDienThoai = "0988888888",
                    DiaChi = "789 Đường Trà Sữa, TP. HCM",
                    VaiTro = VaiTro.KhachHang,
                    TaiKhoan = new TaiKhoan
                    {
                        TenDangNhap = "khach",
                        MatKhau = HashPassword("kh123"),
                        TrangThai = TrangThaiTaiKhoan.HoatDong
                    }
                }
            };

            context.NguoiDungs.AddRange(nguoiDungs);
            context.SaveChanges();

            var nhanVienDb = context.NguoiDungs.First(n => n.VaiTro == VaiTro.NhanVien);

            // 2. Seed MonNuoc
            var monNuocs = new List<MonNuoc>
            {
                new MonNuoc { TenMon = "Cà Phê Sữa Đá", LoaiMon = LoaiMon.CaPhe, GiaBan = 29000, MoTa = "Cà phê đậm đà kết hợp sữa đặc và đá.", ConBan = true, HinhAnh = "caphesua" },
                new MonNuoc { TenMon = "Bạc Xỉu", LoaiMon = LoaiMon.CaPhe, GiaBan = 32000, MoTa = "Thức uống nhiều sữa ít cà phê.", ConBan = true, HinhAnh = "bacxiu" },
                new MonNuoc { TenMon = "Americano Đá", LoaiMon = LoaiMon.CaPhe, GiaBan = 35000, MoTa = "Espresso pha loãng với nước lạnh.", ConBan = true, HinhAnh = "americano" },
                new MonNuoc { TenMon = "Trà Đào Cam Sả", LoaiMon = LoaiMon.Tra, GiaBan = 45000, MoTa = "Trà đào thơm mát cùng cam và hương sả.", ConBan = true, HinhAnh = "tradao" },
                new MonNuoc { TenMon = "Trà Sữa Trân Châu", LoaiMon = LoaiMon.Tra, GiaBan = 39000, MoTa = "Trà sữa truyền thống kèm trân châu đen dai giòn.", ConBan = true, HinhAnh = "trasua" },
                new MonNuoc { TenMon = "Matcha Latte", LoaiMon = LoaiMon.Tra, GiaBan = 49000, MoTa = "Trà xanh Nhật Bản kết hợp sữa tươi ấm.", ConBan = true, HinhAnh = "matcha" },
                new MonNuoc { TenMon = "Bánh Mì Việt Nam", LoaiMon = LoaiMon.Banh, GiaBan = 25000, MoTa = "Bánh mì kẹp thịt xá xíu dăm bông đặc biệt.", ConBan = true, HinhAnh = "banhmi" },
                new MonNuoc { TenMon = "Bánh Croissant", LoaiMon = LoaiMon.Banh, GiaBan = 30000, MoTa = "Bánh sừng bò ngập vị bơ thơm lừng.", ConBan = true, HinhAnh = "croissant" },
                new MonNuoc { TenMon = "Tiramisu Cup", LoaiMon = LoaiMon.Banh, GiaBan = 42000, MoTa = "Bánh tiramisu béo ngậy vị phô mai mascarpone.", ConBan = true, HinhAnh = "tiramisu" },
                new MonNuoc { TenMon = "Nước Cam Ép", LoaiMon = LoaiMon.Khac, GiaBan = 35000, MoTa = "Nước cam tươi nguyên chất giàu vitamin C.", ConBan = true, HinhAnh = "nuoccam" }
            };

            context.MonNuocs.AddRange(monNuocs);
            context.SaveChanges();

            // 3. Seed Ban
            var bans = new List<Ban>
            {
                new Ban { TenBan = "Bàn 1", SoChoNgoi = 4, TrangThai = TrangThaiBan.Trong },
                new Ban { TenBan = "Bàn 2", SoChoNgoi = 2, TrangThai = TrangThaiBan.Trong },
                new Ban { TenBan = "Bàn 3", SoChoNgoi = 6, TrangThai = TrangThaiBan.Trong },
                new Ban { TenBan = "Bàn 4", SoChoNgoi = 4, TrangThai = TrangThaiBan.Trong },
                new Ban { TenBan = "Bàn 5", SoChoNgoi = 4, TrangThai = TrangThaiBan.Trong },
                new Ban { TenBan = "Bàn 6", SoChoNgoi = 2, TrangThai = TrangThaiBan.Trong },
                new Ban { TenBan = "Bàn 7", SoChoNgoi = 8, TrangThai = TrangThaiBan.Trong },
                new Ban { TenBan = "Bàn 8", SoChoNgoi = 4, TrangThai = TrangThaiBan.Trong }
            };

            context.Bans.AddRange(bans);
            context.SaveChanges();

            // 4. Seed DonHang & HoaDon mẫu cho thống kê (những ngày trước)
            var monNuocList = context.MonNuocs.ToList();
            var banList = context.Bans.ToList();

            var random = new Random();
            var dates = new List<DateTime>
            {
                DateTime.Today.AddDays(-4),
                DateTime.Today.AddDays(-3),
                DateTime.Today.AddDays(-2),
                DateTime.Today.AddDays(-1),
                DateTime.Today
            };

            int orderCounter = 1;
            foreach (var date in dates)
            {
                // Mỗi ngày 1-2 đơn hàng đã thanh toán
                int numOrders = random.Next(1, 3);
                for (int i = 0; i < numOrders; i++)
                {
                    var ban = banList[random.Next(banList.Count)];
                    var donHang = new DonHang
                    {
                        BanId = ban.Id,
                        NhanVienId = nhanVienDb.Id,
                        NgayTao = date.AddHours(random.Next(8, 20)),
                        TrangThai = TrangThaiDonHang.DaThanhToan,
                        TongTien = 0
                    };

                    int numDetails = random.Next(1, 4);
                    decimal tongTien = 0;
                    for (int j = 0; j < numDetails; j++)
                    {
                        var mon = monNuocList[random.Next(monNuocList.Count)];
                        int qty = random.Next(1, 3);
                        var detail = new ChiTietDonHang
                        {
                            MonNuocId = mon.Id,
                            SoLuong = qty,
                            DonGia = mon.GiaBan,
                            ThanhTien = qty * mon.GiaBan
                        };
                        donHang.ChiTietDonHangs.Add(detail);
                        tongTien += detail.ThanhTien;
                    }
                    donHang.TongTien = tongTien;

                    context.DonHangs.Add(donHang);
                    context.SaveChanges();

                    var hoaDon = new HoaDon
                    {
                        DonHangId = donHang.Id,
                        NgayThanhToan = donHang.NgayTao.AddMinutes(random.Next(15, 45)),
                        TongTien = donHang.TongTien,
                        PhuongThuc = (PhuongThucThanhToan)random.Next(3),
                        TrangThai = TrangThaiThanhToan.DaThanhToan,
                        MaGiaoDich = "GD" + date.ToString("yyyyMMdd") + orderCounter.ToString("D4")
                    };

                    context.HoaDons.Add(hoaDon);
                    context.SaveChanges();
                    orderCounter++;
                }
            }
        }
    }
}

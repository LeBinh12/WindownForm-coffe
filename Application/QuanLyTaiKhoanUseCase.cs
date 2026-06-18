using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Application
{
    public class QuanLyTaiKhoanUseCase
    {
        private readonly INguoiDungRepository _nguoiDungRepository;
        private readonly ITaiKhoanRepository _taiKhoanRepository;

        public QuanLyTaiKhoanUseCase(
            INguoiDungRepository nguoiDungRepository,
            ITaiKhoanRepository taiKhoanRepository)
        {
            _nguoiDungRepository = nguoiDungRepository;
            _taiKhoanRepository = taiKhoanRepository;
        }

        public IEnumerable<NguoiDung> LayDanhSachNguoiDung()
        {
            return _nguoiDungRepository.GetAll();
        }

        public bool ThemTaiKhoan(NguoiDung nguoiDung, string tenDangNhap, string matKhau, out string error)
        {
            error = string.Empty;

            if (string.IsNullOrWhiteSpace(nguoiDung.HoTen))
            {
                error = "Họ tên không được để trống!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
            {
                error = "Tên đăng nhập và mật khẩu không được để trống!";
                return false;
            }

            // SR-02: TenDangNhap duy nhất
            var existingAcc = _taiKhoanRepository.GetByTenDangNhap(tenDangNhap);
            if (existingAcc != null)
            {
                error = "Tên đăng nhập đã tồn tại!";
                return false;
            }

            if (!string.IsNullOrEmpty(nguoiDung.Email))
            {
                var existingUser = _nguoiDungRepository.GetAll().FirstOrDefault(n => string.Equals(n.Email, nguoiDung.Email, StringComparison.OrdinalIgnoreCase));
                if (existingUser != null)
                {
                    error = "Email đã tồn tại!";
                    return false;
                }
            }

            nguoiDung.TaiKhoan = new TaiKhoan
            {
                TenDangNhap = tenDangNhap,
                MatKhau = DbSeeder.HashPassword(matKhau),
                TrangThai = TrangThaiTaiKhoan.HoatDong
            };

            _nguoiDungRepository.Add(nguoiDung);
            return true;
        }

        public bool CapNhatNguoiDung(NguoiDung nguoiDung, out string error)
        {
            error = string.Empty;

            if (string.IsNullOrWhiteSpace(nguoiDung.HoTen))
            {
                error = "Họ tên không được để trống!";
                return false;
            }

            var dbUser = _nguoiDungRepository.GetById(nguoiDung.Id);
            if (dbUser == null)
            {
                error = "Người dùng không tồn tại!";
                return false;
            }

            if (!string.IsNullOrEmpty(nguoiDung.Email) && !string.Equals(dbUser.Email, nguoiDung.Email, StringComparison.OrdinalIgnoreCase))
            {
                var existingUser = _nguoiDungRepository.GetAll().FirstOrDefault(n => n.Id != nguoiDung.Id && string.Equals(n.Email, nguoiDung.Email, StringComparison.OrdinalIgnoreCase));
                if (existingUser != null)
                {
                    error = "Email đã tồn tại!";
                    return false;
                }
            }

            dbUser.HoTen = nguoiDung.HoTen;
            dbUser.Email = nguoiDung.Email;
            dbUser.SoDienThoai = nguoiDung.SoDienThoai;
            dbUser.DiaChi = nguoiDung.DiaChi;
            dbUser.VaiTro = nguoiDung.VaiTro;

            _nguoiDungRepository.Update(dbUser);
            return true;
        }

        public bool DoiMatKhau(int taiKhoanId, string matKhauMoi, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(matKhauMoi))
            {
                error = "Mật khẩu mới không được để trống!";
                return false;
            }

            var tk = _taiKhoanRepository.GetAll().FirstOrDefault(t => t.Id == taiKhoanId);
            if (tk == null)
            {
                error = "Tài khoản không tồn tại!";
                return false;
            }

            tk.MatKhau = DbSeeder.HashPassword(matKhauMoi);
            _taiKhoanRepository.Update(tk);
            return true;
        }

        // SR-04: Không xóa tài khoản, quản lý bằng trạng thái
        public bool DatTrangThaiTaiKhoan(int taiKhoanId, TrangThaiTaiKhoan trangThaiMoi, out string error)
        {
            error = string.Empty;
            var tk = _taiKhoanRepository.GetAll().FirstOrDefault(t => t.Id == taiKhoanId);
            if (tk == null)
            {
                error = "Tài khoản không tồn tại!";
                return false;
            }

            tk.TrangThai = trangThaiMoi;
            _taiKhoanRepository.Update(tk);
            return true;
        }

        public IEnumerable<TaiKhoan> LayDanhSachTaiKhoan()
        {
            return _taiKhoanRepository.GetAll();
        }

        public bool DangKyTaiKhoan(string tenDangNhap, string matKhau, string hoTen, string email, string soDienThoai, VaiTro vaiTro, out string error)
        {
            var nd = new NguoiDung
            {
                HoTen = hoTen,
                Email = email,
                SoDienThoai = soDienThoai,
                VaiTro = vaiTro
            };
            return ThemTaiKhoan(nd, tenDangNhap, matKhau, out error);
        }

        public bool CapNhatThongTin(int taiKhoanId, string hoTen, string email, string soDienThoai, VaiTro vaiTro, string matKhau, out string error)
        {
            error = string.Empty;
            var tk = _taiKhoanRepository.GetById(taiKhoanId);
            if (tk == null)
            {
                error = "Tài khoản không tồn tại!";
                return false;
            }

            var nd = tk.NguoiDung;
            if (nd == null)
            {
                error = "Không tìm thấy thông tin người dùng liên kết!";
                return false;
            }

            nd.HoTen = hoTen;
            nd.Email = email;
            nd.SoDienThoai = soDienThoai;
            nd.VaiTro = vaiTro;

            if (!CapNhatNguoiDung(nd, out error))
            {
                return false;
            }

            if (!string.IsNullOrEmpty(matKhau))
            {
                if (!DoiMatKhau(taiKhoanId, matKhau, out error))
                {
                    return false;
                }
            }

            return true;
        }

        public bool DoiTrangThaiTaiKhoan(int taiKhoanId, TrangThaiTaiKhoan trangThaiMoi, out string error)
        {
            return DatTrangThaiTaiKhoan(taiKhoanId, trangThaiMoi, out error);
        }
    }
}

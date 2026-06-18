using System;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Application
{
    public class DangNhapUseCase
    {
        private readonly ITaiKhoanRepository _taiKhoanRepository;

        public DangNhapUseCase(ITaiKhoanRepository taiKhoanRepository)
        {
            _taiKhoanRepository = taiKhoanRepository;
        }

        public TaiKhoan DangNhap(string tenDangNhap, string matKhau, out string message)
        {
            message = string.Empty;
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
            {
                message = "Tên đăng nhập và mật khẩu không được để trống!";
                return null;
            }

            var taiKhoan = _taiKhoanRepository.GetByTenDangNhap(tenDangNhap);
            if (taiKhoan == null)
            {
                message = "Tài khoản không tồn tại!";
                return null;
            }

            if (taiKhoan.TrangThai == TrangThaiTaiKhoan.BiKhoa)
            {
                message = "Tài khoản của bạn đã bị khóa! Vui lòng liên hệ Admin.";
                return null;
            }

            string hashedInput = DbSeeder.HashPassword(matKhau);
            if (taiKhoan.MatKhau != hashedInput)
            {
                message = "Mật khẩu không chính xác!";
                return null;
            }

            return taiKhoan;
        }
    }
}

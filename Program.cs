using System;
using System.Windows.Forms;
using QuanLyQuanCafe.Infrastructure;
using QuanLyQuanCafe.Application;
using QuanLyQuanCafe.Presentation;

namespace QuanLyQuanCafe
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            // Khởi tạo DbContext và nạp dữ liệu mẫu
            using (var context = new AppDbContext())
            {
                try
                {
                    DbSeeder.Seed(context);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khởi tạo cơ sở dữ liệu: {ex.Message}\n{ex.InnerException?.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Khởi tạo UseCase cần cho FormDangNhap
                var dangNhapUseCase = new DangNhapUseCase(new TaiKhoanRepository(context));

                // Khởi động FormDangNhap
                System.Windows.Forms.Application.Run(new FormDangNhap(dangNhapUseCase, context));
            }
        }
    }
}
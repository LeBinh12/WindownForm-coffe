using System;
using System.Windows.Forms;
using QuanLyQuanCafe.Application;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormDangNhap : Form
    {
        private readonly DangNhapUseCase _dangNhapUseCase;
        private readonly AppDbContext _context;

        public FormDangNhap(DangNhapUseCase dangNhapUseCase, AppDbContext context)
        {
            InitializeComponent();
            _dangNhapUseCase = dangNhapUseCase;
            _context = context;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            var taiKhoan = _dangNhapUseCase.DangNhap(username, password, out string errorMessage);

            if (taiKhoan == null)
            {
                MessageBox.Show(errorMessage, "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đăng nhập thành công -> Mở FormMain
            this.Hide();
            var formMain = new FormMain(taiKhoan, _context);
            formMain.FormClosed += (s, args) => {
                this.txtPassword.Clear();
                this.Show();
            };
            formMain.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }
    }
}

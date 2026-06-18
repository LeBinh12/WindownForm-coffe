using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;
using QuanLyQuanCafe.Application;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormMain : Form
    {
        private readonly TaiKhoan _currentUser;
        private readonly AppDbContext _context;
        private Form? _activeForm = null;
        private bool _isSidebarCollapsed = false;

        public FormMain(TaiKhoan currentUser, AppDbContext context)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _context = context;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin người dùng đăng nhập
            lblUserInfo.Text = $"Chào, {_currentUser.NguoiDung.HoTen} ({GetRoleString(_currentUser.NguoiDung.VaiTro)})";

            // Phân quyền hiển thị Menu
            ApplyPermissions(_currentUser.NguoiDung.VaiTro);

            // Mở màn hình Thực Đơn mặc định
            btnThucDon.PerformClick();
        }

        private string GetRoleString(VaiTro role)
        {
            return role switch
            {
                VaiTro.Admin => "Admin",
                VaiTro.NhanVien => "Nhân viên",
                VaiTro.KhachHang => "Khách hàng",
                _ => "Khách"
            };
        }

        private void ApplyPermissions(VaiTro role)
        {
            if (role == VaiTro.Admin)
            {
                // Admin hiển thị tất cả
                btnThucDon.Visible = true;
                btnQuanLyBan.Visible = true;
                btnDatMon.Visible = true;
                btnDonHang.Visible = true;
                btnHoaDon.Visible = true;
                btnQuanLyThucDon.Visible = true;
                btnQuanLyTaiKhoan.Visible = true;
                btnThongKe.Visible = true;
            }
            else if (role == VaiTro.NhanVien)
            {
                // Nhân viên không có chức năng quản trị
                btnThucDon.Visible = true;
                btnQuanLyBan.Visible = true;
                btnDatMon.Visible = true;
                btnDonHang.Visible = true;
                btnHoaDon.Visible = true;
                btnQuanLyThucDon.Visible = false;
                btnQuanLyTaiKhoan.Visible = false;
                btnThongKe.Visible = false;
            }
            else if (role == VaiTro.KhachHang)
            {
                // Khách hàng chỉ được xem thực đơn & xem đơn hàng của mình
                btnThucDon.Visible = true;
                btnQuanLyBan.Visible = false;
                btnDatMon.Visible = false;
                btnDonHang.Visible = true;
                btnHoaDon.Visible = false;
                btnQuanLyThucDon.Visible = false;
                btnQuanLyTaiKhoan.Visible = false;
                btnThongKe.Visible = false;
            }
        }

        public void OpenChildForm(Form childForm, string title)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            _activeForm = childForm;
            lblTitle.Text = title;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeBtn)
        {
            foreach (Control ctrl in panelSidebar.Controls)
            {
                if (ctrl is Guna.UI2.WinForms.Guna2Button btn)
                {
                    if (btn == activeBtn)
                    {
                        btn.Checked = true;
                        btn.CustomBorderColor = System.Drawing.Color.FromArgb(186, 151, 128);
                    }
                    else
                    {
                        btn.Checked = false;
                        btn.CustomBorderColor = System.Drawing.Color.Transparent;
                    }
                }
            }
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnThucDon);
            var useCase = new QuanLyThucDonUseCase(new MonNuocRepository(_context));
            OpenChildForm(new FormThucDon(useCase, _context, _currentUser), "Thực Đơn Quán");
        }

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnQuanLyBan);
            OpenChildForm(new FormQuanLyBan(_context, _currentUser, this), "Sơ Đồ Bàn Phục Vụ");
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDatMon);
            var datMonUseCase = new DatMonUseCase(new BanRepository(_context), new MonNuocRepository(_context), new DonHangRepository(_context));
            OpenChildForm(new FormDatMon(datMonUseCase, _currentUser), "Đặt Món Cho Bàn");
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDonHang);
            var donHangRepo = new DonHangRepository(_context);
            var banRepo = new BanRepository(_context);
            var useCase = new XuLyDonHangUseCase(donHangRepo, banRepo);
            OpenChildForm(new FormDonHang(useCase, _currentUser, _context), "Danh Sách Đơn Hàng");
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnHoaDon);
            OpenChildForm(new FormDanhSachHoaDon(_context, _currentUser), "Danh Sách Hóa Đơn");
        }

        private void btnQuanLyThucDon_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnQuanLyThucDon);
            var useCase = new QuanLyThucDonUseCase(new MonNuocRepository(_context));
            OpenChildForm(new FormQuanLyThucDon(useCase), "Quản Lý Danh Sách Thực Đơn");
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnQuanLyTaiKhoan);
            var useCase = new QuanLyTaiKhoanUseCase(new NguoiDungRepository(_context), new TaiKhoanRepository(_context));
            OpenChildForm(new FormQuanLyTaiKhoan(useCase), "Quản Lý Tài Khoản Người Dùng");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnThongKe);
            var useCase = new ThongKeUseCase(new HoaDonRepository(_context));
            OpenChildForm(new FormThongKe(useCase), "Báo Cáo Thống Kê Doanh Thu");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            if (_isSidebarCollapsed)
            {
                // Mở rộng sidebar
                panelSidebar.Width = 220;
                lblAppName.Visible = true;
                btnToggleSidebar.Location = new System.Drawing.Point(175, 15);
                foreach (Control ctrl in panelSidebar.Controls)
                {
                    if (ctrl is Guna.UI2.WinForms.Guna2Button btn)
                    {
                        btn.Text = btn.Tag?.ToString() ?? btn.Text;
                    }
                }
                _isSidebarCollapsed = false;
            }
            else
            {
                // Thu gọn sidebar
                panelSidebar.Width = 60;
                lblAppName.Visible = false;
                btnToggleSidebar.Location = new System.Drawing.Point(12, 15);
                foreach (Control ctrl in panelSidebar.Controls)
                {
                    if (ctrl is Guna.UI2.WinForms.Guna2Button btn)
                    {
                        if (btn.Tag == null)
                        {
                            btn.Tag = btn.Text;
                        }
                        if (!string.IsNullOrEmpty(btn.Text))
                        {
                            btn.Text = btn.Text.Length >= 2 ? btn.Text.Substring(0, 2).Trim() : btn.Text;
                        }
                    }
                }
                _isSidebarCollapsed = true;
            }
        }

        // Helper để các form con điều khiển mở form con khác qua main form
        public void SwitchToTab(string tabName, int? extraParam = null)
        {
            if (tabName == "DatMon")
            {
                btnDatMon.PerformClick();
                if (extraParam.HasValue && _activeForm is FormDatMon fdm)
                {
                    fdm.SelectBan(extraParam.Value);
                }
            }
            else if (tabName == "ThanhToan")
            {
                if (extraParam.HasValue)
                {
                    var ttUseCase = new ThanhToanUseCase(new DonHangRepository(_context), new HoaDonRepository(_context), new BanRepository(_context));
                    var ttForm = new FormThanhToan(ttUseCase, extraParam.Value, _context);
                    OpenChildForm(ttForm, "Thanh Toán Hóa Đơn");
                }
            }
            else if (tabName == "Ban")
            {
                btnQuanLyBan.PerformClick();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc chắn muốn thoát hệ thống?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

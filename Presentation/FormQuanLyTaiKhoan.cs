using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Application;
using QuanLyQuanCafe.Domain;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormQuanLyTaiKhoan : Form
    {
        private readonly QuanLyTaiKhoanUseCase _useCase;
        private List<TaiKhoan> _accountsList = new List<TaiKhoan>();
        private int? _selectedTaiKhoanId = null;

        public FormQuanLyTaiKhoan(QuanLyTaiKhoanUseCase useCase)
        {
            InitializeComponent();
            _useCase = useCase;
        }

        private void FormQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // Nạp ComboBox VaiTro
            cbVaiTro.Items.Clear();
            cbVaiTro.Items.Add("Khách hàng");
            cbVaiTro.Items.Add("Nhân viên");
            cbVaiTro.Items.Add("Admin");
            cbVaiTro.SelectedIndex = 0;

            // Nạp ComboBox TrangThai
            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Hoạt động");
            cbTrangThai.Items.Add("Bị khóa");
            cbTrangThai.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            _accountsList = _useCase.LayDanhSachTaiKhoan().ToList();

            gridTaiKhoan.Rows.Clear();
            foreach (var tk in _accountsList)
            {
                gridTaiKhoan.Rows.Add(
                    tk.Id,
                    tk.TenDangNhap,
                    tk.NguoiDung.HoTen,
                    tk.NguoiDung.Email,
                    tk.NguoiDung.SoDienThoai,
                    GetRoleString(tk.NguoiDung.VaiTro),
                    GetStateString(tk.TrangThai)
                );
            }

            CleanForm();
        }

        private string GetRoleString(VaiTro role)
        {
            return role switch
            {
                VaiTro.Admin => "Admin",
                VaiTro.NhanVien => "Nhân viên",
                VaiTro.KhachHang => "Khách hàng",
                _ => "Không rõ"
            };
        }

        private string GetStateString(TrangThaiTaiKhoan state)
        {
            return state switch
            {
                TrangThaiTaiKhoan.HoatDong => "Hoạt động",
                TrangThaiTaiKhoan.BiKhoa => "Bị khóa",
                _ => "Không rõ"
            };
        }

        private void gridTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (gridTaiKhoan.CurrentRow == null) return;

            int id = Convert.ToInt32(gridTaiKhoan.CurrentRow.Cells["colTKId"].Value);
            var tk = _accountsList.FirstOrDefault(t => t.Id == id);

            if (tk != null)
            {
                _selectedTaiKhoanId = tk.Id;
                txtTenDangNhap.Text = tk.TenDangNhap;
                txtTenDangNhap.Enabled = false; // Không cho sửa username
                txtMatKhau.Clear();            // Để trống nếu không muốn đổi mật khẩu
                txtHoTen.Text = tk.NguoiDung.HoTen;
                txtEmail.Text = tk.NguoiDung.Email;
                txtSoDienThoai.Text = tk.NguoiDung.SoDienThoai;
                cbVaiTro.SelectedIndex = (int)tk.NguoiDung.VaiTro;
                cbTrangThai.SelectedIndex = (int)tk.TrangThai;

                btnSua.Enabled = true;
                btnThem.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtSoDienThoai.Text.Trim();
            VaiTro role = (VaiTro)cbVaiTro.SelectedIndex;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên đăng nhập, Mật khẩu và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = _useCase.DangKyTaiKhoan(username, password, hoTen, email, phone, role, out string error);

            if (success)
            {
                MessageBox.Show("Đăng ký tài khoản người dùng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show(error, "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!_selectedTaiKhoanId.HasValue) return;

            string password = txtMatKhau.Text; // Nếu rỗng thì giữ nguyên mật khẩu cũ
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtSoDienThoai.Text.Trim();
            VaiTro role = (VaiTro)cbVaiTro.SelectedIndex;
            TrangThaiTaiKhoan state = (TrangThaiTaiKhoan)cbTrangThai.SelectedIndex;

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Cập nhật thông tin & mật khẩu (nếu có)
            bool success = _useCase.CapNhatThongTin(_selectedTaiKhoanId.Value, hoTen, email, phone, role, password, out string error);

            if (!success)
            {
                MessageBox.Show(error, "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Cập nhật trạng thái hoạt động / khóa
            _useCase.DoiTrangThaiTaiKhoan(_selectedTaiKhoanId.Value, state, out _);

            MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            _selectedTaiKhoanId = null;
            txtTenDangNhap.Clear();
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSoDienThoai.Clear();
            cbVaiTro.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;

            btnSua.Enabled = false;
            btnThem.Enabled = true;
        }
    }
}

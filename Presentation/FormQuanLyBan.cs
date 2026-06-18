using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;
using QuanLyQuanCafe.Application;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormQuanLyBan : Form
    {
        private readonly AppDbContext _context;
        private readonly TaiKhoan _currentUser;
        private readonly FormMain _mainForm;
        private readonly QuanLyBanUseCase _useCase;

        public FormQuanLyBan(AppDbContext context, TaiKhoan currentUser, FormMain mainForm)
        {
            InitializeComponent();
            _context = context;
            _currentUser = currentUser;
            _mainForm = mainForm;
            _useCase = new QuanLyBanUseCase(context);
        }

        private void FormQuanLyBan_Load(object sender, EventArgs e)
        {
            // Phân quyền hiển thị nút Thêm Bàn
            bool coQuyen = _currentUser.NguoiDung.VaiTro == VaiTro.Admin || _currentUser.NguoiDung.VaiTro == VaiTro.NhanVien;
            btnThemBan.Visible = coQuyen;

            LoadTables();
        }

        private void LoadTables()
        {
            flowBanPanel.Controls.Clear();
            var listBan = _useCase.LayDanhSachBan().ToList();

            foreach (var ban in listBan)
            {
                var btn = new Guna2Button
                {
                    Width = 130,
                    Height = 130,
                    BorderRadius = 12,
                    BorderThickness = 1,
                    BorderColor = Color.FromArgb(224, 215, 205),
                    Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                    ForeColor = Color.White,
                    Margin = new Padding(15),
                    Tag = ban
                };

                string trangThaiText = "";
                switch (ban.TrangThai)
                {
                    case TrangThaiBan.Trong:
                        btn.FillColor = Color.FromArgb(140, 140, 140);
                        btn.HoverState.FillColor = Color.FromArgb(160, 160, 160);
                        trangThaiText = "Trống";
                        break;
                    case TrangThaiBan.DangPhucVu:
                        btn.FillColor = Color.FromArgb(249, 168, 37);
                        btn.HoverState.FillColor = Color.FromArgb(251, 192, 45);
                        trangThaiText = "Phục Vụ";
                        break;
                    case TrangThaiBan.ChoThanhToan:
                        btn.FillColor = Color.FromArgb(255, 139, 148);
                        btn.HoverState.FillColor = Color.FromArgb(255, 170, 175);
                        trangThaiText = "Chờ T.Toán";
                        break;
                }

                btn.Text = $"{ban.TenBan}\n({trangThaiText})\n{ban.SoChoNgoi} chỗ";
                btn.Click += TableButton_Click;

                flowBanPanel.Controls.Add(btn);
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button btn && btn.Tag is Ban ban)
            {
                // Mở FormChiTietBan thay thế cho menu chuột phải cũ
                var result = FormChiTietMon.ShowWithOverlay(this, () => new FormChiTietBan(_useCase, ban.Id, _mainForm, _currentUser, _context));
                if (result == DialogResult.OK)
                {
                    LoadTables();
                }
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            var result = FormChiTietMon.ShowWithOverlay(this, () => new FormThemBan(_useCase));
            if (result == DialogResult.OK)
            {
                LoadTables();
            }
        }
    }
}

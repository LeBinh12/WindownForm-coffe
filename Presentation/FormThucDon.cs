using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Application;
using QuanLyQuanCafe.Domain;
using QuanLyQuanCafe.Infrastructure;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormThucDon : Form
    {
        private readonly QuanLyThucDonUseCase _useCase;
        private readonly AppDbContext _context;
        private readonly TaiKhoan _currentUser;

        public FormThucDon(QuanLyThucDonUseCase useCase, AppDbContext context, TaiKhoan currentUser)
        {
            InitializeComponent();
            _useCase = useCase;
            _context = context;
            _currentUser = currentUser;
        }

        private void FormThucDon_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu vào ComboBox loại món
            cbLoaiMon.Items.Clear();
            cbLoaiMon.Items.Add("Tất cả loại");
            cbLoaiMon.Items.Add("Cà phê");
            cbLoaiMon.Items.Add("Trà");
            cbLoaiMon.Items.Add("Bánh");
            cbLoaiMon.Items.Add("Khác");
            cbLoaiMon.SelectedIndex = 0;

            LoadMenu();
        }

        private void LoadMenu()
        {
            flowPanel.Controls.Clear();

            string keyword = txtSearch.Text.Trim();
            LoaiMon? selectedLoai = null;

            if (cbLoaiMon.SelectedIndex > 0)
            {
                selectedLoai = (LoaiMon)(cbLoaiMon.SelectedIndex - 1);
            }

            var thucDon = _useCase.LayDanhSachThucDon(keyword, selectedLoai);

            foreach (var mon in thucDon)
            {
                var card = new MonNuocCard();
                card.BindData(mon);
                card.CardClicked += Card_CardClicked;
                flowPanel.Controls.Add(card);
            }
        }

        private void Card_CardClicked(object sender, EventArgs e)
        {
            if (sender is MonNuocCard card)
            {
                var mainForm = this.FindForm();
                if (mainForm != null)
                {
                    FormChiTietMon.ShowWithOverlay(mainForm, () => new FormChiTietMon(card.MonNuoc, _context, _currentUser));
                }
                else
                {
                    using (var formChiTiet = new FormChiTietMon(card.MonNuoc, _context, _currentUser))
                    {
                        formChiTiet.ShowDialog();
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void cbLoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cbLoaiMon.SelectedIndex = 0;
            LoadMenu();
        }
    }
}

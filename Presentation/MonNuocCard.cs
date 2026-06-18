using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyQuanCafe.Domain;

namespace QuanLyQuanCafe.Presentation
{
    public partial class MonNuocCard : UserControl
    {
        public MonNuoc MonNuoc { get; private set; }

        public event EventHandler CardClicked;

        public MonNuocCard()
        {
            InitializeComponent();
            RegisterClickEvents(this);
        }

        public void BindData(MonNuoc monNuoc)
        {
            MonNuoc = monNuoc;
            lblTenMon.Text = monNuoc.TenMon;
            lblGia.Text = $"{monNuoc.GiaBan:N0} đ";
            lblLoai.Text = GetLoaiMonString(monNuoc.LoaiMon);

            if (monNuoc.ConBan)
            {
                lblTrangThai.Text = "Còn bán";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Hết bán";
                lblTrangThai.ForeColor = Color.Red;
            }

            // Thiết lập icon theo loại món
            lblImagePlaceholder.Text = monNuoc.LoaiMon switch
            {
                LoaiMon.CaPhe => "☕",
                LoaiMon.Tra => "🍵",
                LoaiMon.Banh => "🍰",
                _ => "🍹"
            };
        }

        private string GetLoaiMonString(LoaiMon loai)
        {
            return loai switch
            {
                LoaiMon.CaPhe => "Cà phê",
                LoaiMon.Tra => "Trà",
                LoaiMon.Banh => "Bánh",
                _ => "Khác"
            };
        }

        private void RegisterClickEvents(Control parent)
        {
            parent.Click += (s, e) => CardClicked?.Invoke(this, EventArgs.Empty);
            foreach (Control ctrl in parent.Controls)
            {
                RegisterClickEvents(ctrl);
            }
        }
    }
}

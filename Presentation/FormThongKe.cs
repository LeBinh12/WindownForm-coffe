using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCafe.Application;

namespace QuanLyQuanCafe.Presentation
{
    public partial class FormThongKe : Form
    {
        private readonly ThongKeUseCase _useCase;
        private Dictionary<string, decimal> _chartData = new Dictionary<string, decimal>();

        public FormThongKe(ThongKeUseCase useCase)
        {
            InitializeComponent();
            _useCase = useCase;
            // Kích hoạt DoubleBuffered để tránh giật hình khi vẽ biểu đồ
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            cbKieuThongKe.Items.Clear();
            cbKieuThongKe.Items.Add("7 ngày qua");
            cbKieuThongKe.Items.Add("6 tháng qua");
            cbKieuThongKe.SelectedIndex = 0;

            ThongKeBaoCao();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKeBaoCao();
        }

        private void ThongKeBaoCao()
        {
            decimal totalRevenue = 0;
            int totalInvoices = 0;
            decimal avgInvoice = 0;

            _chartData.Clear();

            if (cbKieuThongKe.SelectedIndex == 0)
            {
                // Thống kê 7 ngày qua
                var records = _useCase.ThongKeDoanhThuTheoNgay(7);
                if (records != null && records.Any())
                {
                    totalRevenue = records.Values.Sum();
                    totalInvoices = records.Count; // Số ngày có giao dịch hoặc đếm hóa đơn thực tế
                    avgInvoice = totalInvoices > 0 ? totalRevenue / totalInvoices : 0;

                    foreach (var pair in records)
                    {
                        _chartData.Add(pair.Key.ToString("dd/MM"), pair.Value);
                    }
                }
            }
            else
            {
                // Thống kê 6 tháng qua
                var records = _useCase.ThongKeDoanhThuTheoThang(6);
                if (records != null && records.Any())
                {
                    totalRevenue = records.Values.Sum();
                    totalInvoices = records.Count;
                    avgInvoice = totalInvoices > 0 ? totalRevenue / totalInvoices : 0;

                    foreach (var pair in records)
                    {
                        _chartData.Add(pair.Key, pair.Value);
                    }
                }
            }

            // Gán giá trị lên thẻ tổng hợp
            lblDoanhThuVal.Text = $"{totalRevenue:N0} đ";
            lblHoaDonVal.Text = totalInvoices.ToString("N0");
            lblTrungBinhVal.Text = $"{avgInvoice:N0} đ";

            // Yêu cầu vẽ lại biểu đồ
            panelChart.Invalidate();
        }

        private void panelChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            int width = panelChart.Width;
            int height = panelChart.Height;

            // 1. Vẽ tiêu đề biểu đồ
            using (Font titleFont = new Font("Segoe UI", 12F, FontStyle.Bold))
            using (Brush titleBrush = new SolidBrush(Color.FromArgb(78, 54, 41)))
            {
                g.DrawString("Biểu đồ cột doanh thu", titleFont, titleBrush, new PointF(20, 15));
            }

            if (_chartData == null || _chartData.Count == 0)
            {
                using (Font infoFont = new Font("Segoe UI", 10F, FontStyle.Italic))
                using (Brush infoBrush = new SolidBrush(Color.Gray))
                {
                    g.DrawString("Không có dữ liệu thống kê trong thời gian này", infoFont, infoBrush, new PointF(width / 3f, height / 2f));
                }
                return;
            }

            // 2. Thiết lập lề và trục vẽ
            int leftMargin = 70;
            int rightMargin = 30;
            int topMargin = 50;
            int bottomMargin = 50;

            int chartWidth = width - leftMargin - rightMargin;
            int chartHeight = height - topMargin - bottomMargin;

            // Vẽ trục tọa độ
            using (Pen axisPen = new Pen(Color.FromArgb(180, 180, 180), 2))
            {
                g.DrawLine(axisPen, leftMargin, topMargin, leftMargin, height - bottomMargin); // Trục Y
                g.DrawLine(axisPen, leftMargin, height - bottomMargin, width - rightMargin, height - bottomMargin); // Trục X
            }

            // Tìm giá trị lớn nhất để chia tỷ lệ
            decimal maxValue = _chartData.Values.Max();
            if (maxValue == 0) maxValue = 1; // tránh chia cho 0

            int itemCount = _chartData.Count;
            float spacing = chartWidth / (float)itemCount;
            float barWidth = spacing * 0.5f;

            // Vẽ lưới trục Y (4 mức chia)
            using (Pen gridPen = new Pen(Color.FromArgb(240, 240, 240), 1))
            using (Font labelFont = new Font("Segoe UI", 8.5F))
            using (Brush labelBrush = new SolidBrush(Color.FromArgb(100, 100, 100)))
            {
                gridPen.DashStyle = DashStyle.Dash;
                for (int i = 0; i <= 4; i++)
                {
                    float y = height - bottomMargin - (chartHeight * (i / 4f));
                    g.DrawLine(gridPen, leftMargin, y, width - rightMargin, y);
                    
                    decimal val = maxValue * i / 4;
                    string valText = val >= 1000000 ? $"{val / 1000000m:N1}M" : $"{val / 1000m:N0}K";
                    if (val == 0) valText = "0đ";
                    g.DrawString(valText, labelFont, labelBrush, new PointF(10, y - 7));
                }
            }

            // 3. Vẽ các cột dữ liệu
            int idx = 0;
            foreach (var pair in _chartData)
            {
                float x = leftMargin + (idx * spacing) + (spacing - barWidth) / 2f;
                float itemHeight = (float)(pair.Value / maxValue) * chartHeight;
                float y = height - bottomMargin - itemHeight;

                // Cột Gradient đẹp mắt
                RectangleF barRect = new RectangleF(x, y, barWidth, itemHeight);
                if (barRect.Height > 0)
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(
                        barRect,
                        Color.FromArgb(139, 103, 82), // Nâu nhạt
                        Color.FromArgb(78, 54, 41),   // Nâu đậm
                        LinearGradientMode.Vertical))
                    {
                        g.FillRectangle(brush, barRect);
                    }
                }

                // Vẽ viền cột
                using (Pen borderPen = new Pen(Color.FromArgb(78, 54, 41), 1))
                {
                    g.DrawRectangle(borderPen, x, y, barWidth, itemHeight);
                }

                // Vẽ giá trị trên đầu cột
                string valueText = pair.Value >= 1000000 ? $"{pair.Value / 1000000m:N1}M" : $"{pair.Value / 1000m:N0}k";
                if (pair.Value == 0) valueText = "";
                using (Font barValFont = new Font("Segoe UI Semibold", 8F, FontStyle.Bold))
                using (Brush barValBrush = new SolidBrush(Color.FromArgb(78, 54, 41)))
                {
                    SizeF valSize = g.MeasureString(valueText, barValFont);
                    g.DrawString(valueText, barValFont, barValBrush, new PointF(x + (barWidth - valSize.Width) / 2f, y - 16));
                }

                // Vẽ nhãn trục X (Ngày hoặc Tháng)
                using (Font xFont = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold))
                using (Brush xBrush = new SolidBrush(Color.FromArgb(50, 50, 50)))
                {
                    SizeF labelSize = g.MeasureString(pair.Key, xFont);
                    g.DrawString(pair.Key, xFont, xBrush, new PointF(x + (barWidth - labelSize.Width) / 2f, height - bottomMargin + 10));
                }

                idx++;
            }
        }
    }
}

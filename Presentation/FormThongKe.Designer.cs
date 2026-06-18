namespace QuanLyQuanCafe.Presentation
{
    partial class FormThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTieuChi = new System.Windows.Forms.Label();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.cbKieuThongKe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardDoanhThu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblDoanhThuVal = new System.Windows.Forms.Label();
            this.lblDoanhThuTitle = new System.Windows.Forms.Label();
            this.cardHoaDon = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblHoaDonVal = new System.Windows.Forms.Label();
            this.lblHoaDonTitle = new System.Windows.Forms.Label();
            this.cardTrungBinh = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTrungBinhVal = new System.Windows.Forms.Label();
            this.lblTrungBinhTitle = new System.Windows.Forms.Label();
            this.panelChart = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTop.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.cardDoanhThu.SuspendLayout();
            this.cardHoaDon.SuspendLayout();
            this.cardTrungBinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTieuChi);
            this.panelTop.Controls.Add(this.btnThongKe);
            this.panelTop.Controls.Add(this.cbKieuThongKe);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(880, 60);
            this.panelTop.TabIndex = 0;
            // 
            // lblTieuChi
            // 
            this.lblTieuChi.AutoSize = true;
            this.lblTieuChi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTieuChi.Location = new System.Drawing.Point(20, 22);
            this.lblTieuChi.Name = "lblTieuChi";
            this.lblTieuChi.Size = new System.Drawing.Size(126, 17);
            this.lblTieuChi.TabIndex = 2;
            this.lblTieuChi.Text = "Tiêu chí thống kê:";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BorderRadius = 8;
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(380, 12);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(120, 36);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Xem Báo Cáo";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // cbKieuThongKe
            // 
            this.cbKieuThongKe.BackColor = System.Drawing.Color.Transparent;
            this.cbKieuThongKe.BorderRadius = 8;
            this.cbKieuThongKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKieuThongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKieuThongKe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbKieuThongKe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbKieuThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbKieuThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbKieuThongKe.ItemHeight = 30;
            this.cbKieuThongKe.Location = new System.Drawing.Point(160, 12);
            this.cbKieuThongKe.Name = "cbKieuThongKe";
            this.cbKieuThongKe.Size = new System.Drawing.Size(200, 36);
            this.cbKieuThongKe.TabIndex = 0;
            // 
            // panelCards
            // 
            this.panelCards.ColumnCount = 3;
            this.panelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelCards.Controls.Add(this.cardDoanhThu, 0, 0);
            this.panelCards.Controls.Add(this.cardHoaDon, 1, 0);
            this.panelCards.Controls.Add(this.cardTrungBinh, 2, 0);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCards.Location = new System.Drawing.Point(0, 60);
            this.panelCards.Name = "panelCards";
            this.panelCards.Padding = new System.Windows.Forms.Padding(10);
            this.panelCards.RowCount = 1;
            this.panelCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelCards.Size = new System.Drawing.Size(880, 120);
            this.panelCards.TabIndex = 1;
            // 
            // cardDoanhThu
            // 
            this.cardDoanhThu.BorderRadius = 12;
            this.cardDoanhThu.Controls.Add(this.lblDoanhThuVal);
            this.cardDoanhThu.Controls.Add(this.lblDoanhThuTitle);
            this.cardDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardDoanhThu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cardDoanhThu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(103)))), ((int)(((byte)(82)))));
            this.cardDoanhThu.Location = new System.Drawing.Point(15, 15);
            this.cardDoanhThu.Margin = new System.Windows.Forms.Padding(5);
            this.cardDoanhThu.Name = "cardDoanhThu";
            this.cardDoanhThu.Size = new System.Drawing.Size(276, 90);
            this.cardDoanhThu.TabIndex = 0;
            // 
            // lblDoanhThuVal
            // 
            this.lblDoanhThuVal.BackColor = System.Drawing.Color.Transparent;
            this.lblDoanhThuVal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDoanhThuVal.ForeColor = System.Drawing.Color.White;
            this.lblDoanhThuVal.Location = new System.Drawing.Point(15, 42);
            this.lblDoanhThuVal.Name = "lblDoanhThuVal";
            this.lblDoanhThuVal.Size = new System.Drawing.Size(250, 35);
            this.lblDoanhThuVal.TabIndex = 1;
            this.lblDoanhThuVal.Text = "0đ";
            this.lblDoanhThuVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoanhThuTitle
            // 
            this.lblDoanhThuTitle.AutoSize = true;
            this.lblDoanhThuTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDoanhThuTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDoanhThuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.lblDoanhThuTitle.Location = new System.Drawing.Point(15, 15);
            this.lblDoanhThuTitle.Name = "lblDoanhThuTitle";
            this.lblDoanhThuTitle.Size = new System.Drawing.Size(126, 17);
            this.lblDoanhThuTitle.TabIndex = 0;
            this.lblDoanhThuTitle.Text = "TỔNG DOANH THU";
            // 
            // cardHoaDon
            // 
            this.cardHoaDon.BorderRadius = 12;
            this.cardHoaDon.Controls.Add(this.lblHoaDonVal);
            this.cardHoaDon.Controls.Add(this.lblHoaDonTitle);
            this.cardHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.cardHoaDon.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.cardHoaDon.Location = new System.Drawing.Point(301, 15);
            this.cardHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.cardHoaDon.Name = "cardHoaDon";
            this.cardHoaDon.Size = new System.Drawing.Size(276, 90);
            this.cardHoaDon.TabIndex = 1;
            // 
            // lblHoaDonVal
            // 
            this.lblHoaDonVal.BackColor = System.Drawing.Color.Transparent;
            this.lblHoaDonVal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoaDonVal.ForeColor = System.Drawing.Color.White;
            this.lblHoaDonVal.Location = new System.Drawing.Point(15, 42);
            this.lblHoaDonVal.Name = "lblHoaDonVal";
            this.lblHoaDonVal.Size = new System.Drawing.Size(250, 35);
            this.lblHoaDonVal.TabIndex = 1;
            this.lblHoaDonVal.Text = "0";
            this.lblHoaDonVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHoaDonTitle
            // 
            this.lblHoaDonTitle.AutoSize = true;
            this.lblHoaDonTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHoaDonTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoaDonTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.lblHoaDonTitle.Location = new System.Drawing.Point(15, 15);
            this.lblHoaDonTitle.Name = "lblHoaDonTitle";
            this.lblHoaDonTitle.Size = new System.Drawing.Size(126, 17);
            this.lblHoaDonTitle.TabIndex = 0;
            this.lblHoaDonTitle.Text = "TỔNG SỐ HÓA ĐƠN";
            // 
            // cardTrungBinh
            // 
            this.cardTrungBinh.BorderRadius = 12;
            this.cardTrungBinh.Controls.Add(this.lblTrungBinhVal);
            this.cardTrungBinh.Controls.Add(this.lblTrungBinhTitle);
            this.cardTrungBinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTrungBinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(67)))), ((int)(((byte)(21)))));
            this.cardTrungBinh.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(101)))));
            this.cardTrungBinh.Location = new System.Drawing.Point(587, 15);
            this.cardTrungBinh.Margin = new System.Windows.Forms.Padding(5);
            this.cardTrungBinh.Name = "cardTrungBinh";
            this.cardTrungBinh.Size = new System.Drawing.Size(278, 90);
            this.cardTrungBinh.TabIndex = 2;
            // 
            // lblTrungBinhVal
            // 
            this.lblTrungBinhVal.BackColor = System.Drawing.Color.Transparent;
            this.lblTrungBinhVal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrungBinhVal.ForeColor = System.Drawing.Color.White;
            this.lblTrungBinhVal.Location = new System.Drawing.Point(15, 42);
            this.lblTrungBinhVal.Name = "lblTrungBinhVal";
            this.lblTrungBinhVal.Size = new System.Drawing.Size(250, 35);
            this.lblTrungBinhVal.TabIndex = 1;
            this.lblTrungBinhVal.Text = "0đ";
            this.lblTrungBinhVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrungBinhTitle
            // 
            this.lblTrungBinhTitle.AutoSize = true;
            this.lblTrungBinhTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTrungBinhTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrungBinhTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.lblTrungBinhTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTrungBinhTitle.Name = "lblTrungBinhTitle";
            this.lblTrungBinhTitle.Size = new System.Drawing.Size(126, 17);
            this.lblTrungBinhTitle.TabIndex = 0;
            this.lblTrungBinhTitle.Text = "GIÁ TRỊ BILL TR.BÌNH";
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.White;
            this.panelChart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.panelChart.BorderRadius = 12;
            this.panelChart.BorderThickness = 1;
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(0, 180);
            this.panelChart.Margin = new System.Windows.Forms.Padding(15);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(880, 460);
            this.panelChart.TabIndex = 2;
            this.panelChart.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChart_Paint);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(880, 640);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.cardDoanhThu.ResumeLayout(false);
            this.cardDoanhThu.PerformLayout();
            this.cardHoaDon.ResumeLayout(false);
            this.cardHoaDon.PerformLayout();
            this.cardTrungBinh.ResumeLayout(false);
            this.cardTrungBinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label lblTieuChi;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2ComboBox cbKieuThongKe;
        private System.Windows.Forms.TableLayoutPanel panelCards;
        private Guna.UI2.WinForms.Guna2GradientPanel cardDoanhThu;
        private System.Windows.Forms.Label lblDoanhThuVal;
        private System.Windows.Forms.Label lblDoanhThuTitle;
        private Guna.UI2.WinForms.Guna2GradientPanel cardHoaDon;
        private System.Windows.Forms.Label lblHoaDonVal;
        private System.Windows.Forms.Label lblHoaDonTitle;
        private Guna.UI2.WinForms.Guna2GradientPanel cardTrungBinh;
        private System.Windows.Forms.Label lblTrungBinhVal;
        private System.Windows.Forms.Label lblTrungBinhTitle;
        private Guna.UI2.WinForms.Guna2Panel panelChart;
    }
}

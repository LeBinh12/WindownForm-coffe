namespace QuanLyQuanCafe.Presentation
{
    partial class MonNuocCard
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.panelImage = new Guna.UI2.WinForms.Guna2Panel();
            this.lblImagePlaceholder = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.panelMain.BorderRadius = 10;
            this.panelMain.BorderThickness = 1;
            this.panelMain.Controls.Add(this.lblTrangThai);
            this.panelMain.Controls.Add(this.lblLoai);
            this.panelMain.Controls.Add(this.lblGia);
            this.panelMain.Controls.Add(this.lblTenMon);
            this.panelMain.Controls.Add(this.panelImage);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(190, 240);
            this.panelMain.TabIndex = 0;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrangThai.ForeColor = System.Drawing.Color.Green;
            this.lblTrangThai.Location = new System.Drawing.Point(12, 214);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(49, 13);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "Còn Bán";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblLoai.ForeColor = System.Drawing.Color.Gray;
            this.lblLoai.Location = new System.Drawing.Point(12, 192);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(43, 15);
            this.lblLoai.TabIndex = 3;
            this.lblLoai.Text = "Cà phê";
            // 
            // lblGia
            // 
            this.lblGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGia.BackColor = System.Drawing.Color.Transparent;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblGia.Location = new System.Drawing.Point(80, 190);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(98, 20);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "29.000 đ";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenMon
            // 
            this.lblTenMon.BackColor = System.Drawing.Color.Transparent;
            this.lblTenMon.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.lblTenMon.Location = new System.Drawing.Point(12, 140);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(166, 45);
            this.lblTenMon.TabIndex = 1;
            this.lblTenMon.Text = "Cà Phê Sữa Đá";
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.panelImage.BorderRadius = 8;
            this.panelImage.Controls.Add(this.lblImagePlaceholder);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(190, 130);
            this.panelImage.TabIndex = 0;
            // 
            // lblImagePlaceholder
            // 
            this.lblImagePlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.lblImagePlaceholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblImagePlaceholder.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImagePlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblImagePlaceholder.Location = new System.Drawing.Point(0, 0);
            this.lblImagePlaceholder.Name = "lblImagePlaceholder";
            this.lblImagePlaceholder.Size = new System.Drawing.Size(190, 130);
            this.lblImagePlaceholder.TabIndex = 0;
            this.lblImagePlaceholder.Text = "☕";
            this.lblImagePlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonNuocCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "MonNuocCard";
            this.Size = new System.Drawing.Size(190, 240);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Panel panelImage;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblImagePlaceholder;
    }
}

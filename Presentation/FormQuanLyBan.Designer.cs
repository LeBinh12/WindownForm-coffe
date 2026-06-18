namespace QuanLyQuanCafe.Presentation
{
    partial class FormQuanLyBan
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
            this.panelStatusGuide = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThemBan = new Guna.UI2.WinForms.Guna2Button();
            this.lblChoThanhToanColor = new System.Windows.Forms.Label();
            this.lblDangPhucVuColor = new System.Windows.Forms.Label();
            this.lblTrongColor = new System.Windows.Forms.Label();
            this.lblGuide = new System.Windows.Forms.Label();
            this.flowBanPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelStatusGuide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStatusGuide
            // 
            this.panelStatusGuide.Controls.Add(this.btnThemBan);
            this.panelStatusGuide.Controls.Add(this.lblChoThanhToanColor);
            this.panelStatusGuide.Controls.Add(this.lblDangPhucVuColor);
            this.panelStatusGuide.Controls.Add(this.lblTrongColor);
            this.panelStatusGuide.Controls.Add(this.lblGuide);
            this.panelStatusGuide.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatusGuide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panelStatusGuide.Location = new System.Drawing.Point(0, 0);
            this.panelStatusGuide.Name = "panelStatusGuide";
            this.panelStatusGuide.Size = new System.Drawing.Size(880, 50);
            this.panelStatusGuide.TabIndex = 0;
            // 
            // btnThemBan
            // 
            this.btnThemBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemBan.BackColor = System.Drawing.Color.Transparent;
            this.btnThemBan.BorderRadius = 8;
            this.btnThemBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnThemBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemBan.ForeColor = System.Drawing.Color.White;
            this.btnThemBan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(75)))), ((int)(((byte)(52)))));
            this.btnThemBan.Location = new System.Drawing.Point(730, 9);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(130, 32);
            this.btnThemBan.TabIndex = 4;
            this.btnThemBan.Text = "➕ Thêm Bàn";
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // lblChoThanhToanColor
            // 
            this.lblChoThanhToanColor.AutoSize = true;
            this.lblChoThanhToanColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(148)))));
            this.lblChoThanhToanColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChoThanhToanColor.ForeColor = System.Drawing.Color.White;
            this.lblChoThanhToanColor.Location = new System.Drawing.Point(500, 18);
            this.lblChoThanhToanColor.Name = "lblChoThanhToanColor";
            this.lblChoThanhToanColor.Size = new System.Drawing.Size(124, 15);
            this.lblChoThanhToanColor.TabIndex = 3;
            this.lblChoThanhToanColor.Text = "  Chờ Thanh Toán (Đỏ)  ";
            // 
            // lblDangPhucVuColor
            // 
            this.lblDangPhucVuColor.AutoSize = true;
            this.lblDangPhucVuColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(37)))));
            this.lblDangPhucVuColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDangPhucVuColor.ForeColor = System.Drawing.Color.White;
            this.lblDangPhucVuColor.Location = new System.Drawing.Point(350, 18);
            this.lblDangPhucVuColor.Name = "lblDangPhucVuColor";
            this.lblDangPhucVuColor.Size = new System.Drawing.Size(126, 15);
            this.lblDangPhucVuColor.TabIndex = 2;
            this.lblDangPhucVuColor.Text = "  Đang Phục Vụ (Vàng)  ";
            // 
            // lblTrongColor
            // 
            this.lblTrongColor.AutoSize = true;
            this.lblTrongColor.BackColor = System.Drawing.Color.DarkGray;
            this.lblTrongColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrongColor.ForeColor = System.Drawing.Color.White;
            this.lblTrongColor.Location = new System.Drawing.Point(230, 18);
            this.lblTrongColor.Name = "lblTrongColor";
            this.lblTrongColor.Size = new System.Drawing.Size(95, 15);
            this.lblTrongColor.TabIndex = 1;
            this.lblTrongColor.Text = "  Bàn Trống (Xám) ";
            // 
            // lblGuide
            // 
            this.lblGuide.AutoSize = true;
            this.lblGuide.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGuide.Location = new System.Drawing.Point(20, 16);
            this.lblGuide.Name = "lblGuide";
            this.lblGuide.Size = new System.Drawing.Size(189, 17);
            this.lblGuide.TabIndex = 0;
            this.lblGuide.Text = "Chọn bàn để thao tác nghiệp vụ:";
            // 
            // flowBanPanel
            // 
            this.flowBanPanel.AutoScroll = true;
            this.flowBanPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.flowBanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowBanPanel.Location = new System.Drawing.Point(0, 50);
            this.flowBanPanel.Name = "flowBanPanel";
            this.flowBanPanel.Padding = new System.Windows.Forms.Padding(20);
            this.flowBanPanel.Size = new System.Drawing.Size(880, 590);
            this.flowBanPanel.TabIndex = 1;
            // 
            // FormQuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 640);
            this.Controls.Add(this.flowBanPanel);
            this.Controls.Add(this.panelStatusGuide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyBan";
            this.Text = "FormQuanLyBan";
            this.Load += new System.EventHandler(this.FormQuanLyBan_Load);
            this.panelStatusGuide.ResumeLayout(false);
            this.panelStatusGuide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelStatusGuide;
        private System.Windows.Forms.Label lblGuide;
        private System.Windows.Forms.Label lblChoThanhToanColor;
        private System.Windows.Forms.Label lblDangPhucVuColor;
        private System.Windows.Forms.Label lblTrongColor;
        private System.Windows.Forms.FlowLayoutPanel flowBanPanel;
        private Guna.UI2.WinForms.Guna2Button btnThemBan;
    }
}

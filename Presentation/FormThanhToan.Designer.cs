namespace QuanLyQuanCafe.Presentation
{
    partial class FormThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitleThanhToan = new System.Windows.Forms.Label();
            this.panelInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.lblDonHangId = new System.Windows.Forms.Label();
            this.gridDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colTTTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTTSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTTGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTTTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPayment = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.cbPhuongThuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).BeginInit();
            this.panelPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleThanhToan
            // 
            this.lblTitleThanhToan.AutoSize = true;
            this.lblTitleThanhToan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblTitleThanhToan.Location = new System.Drawing.Point(20, 20);
            this.lblTitleThanhToan.Name = "lblTitleThanhToan";
            this.lblTitleThanhToan.Size = new System.Drawing.Size(221, 30);
            this.lblTitleThanhToan.TabIndex = 0;
            this.lblTitleThanhToan.Text = "Thanh Toán Hóa Đơn";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.panelInfo.BorderRadius = 8;
            this.panelInfo.BorderThickness = 1;
            this.panelInfo.Controls.Add(this.lblNgayTao);
            this.panelInfo.Controls.Add(this.lblNhanVien);
            this.panelInfo.Controls.Add(this.lblTenBan);
            this.panelInfo.Controls.Add(this.lblDonHangId);
            this.panelInfo.Location = new System.Drawing.Point(20, 70);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(840, 60);
            this.panelInfo.TabIndex = 1;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNgayTao.Location = new System.Drawing.Point(600, 20);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(126, 17);
            this.lblNgayTao.TabIndex = 3;
            this.lblNgayTao.Text = "Giờ vào: 18/06 10:15";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNhanVien.Location = new System.Drawing.Point(400, 20);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(117, 17);
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "Nhân viên: NV001";
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblTenBan.Location = new System.Drawing.Point(180, 18);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(84, 20);
            this.lblTenBan.TabIndex = 1;
            this.lblTenBan.Text = "BÀN: Bàn 1";
            // 
            // lblDonHangId
            // 
            this.lblDonHangId.AutoSize = true;
            this.lblDonHangId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDonHangId.Location = new System.Drawing.Point(20, 20);
            this.lblDonHangId.Name = "lblDonHangId";
            this.lblDonHangId.Size = new System.Drawing.Size(111, 17);
            this.lblDonHangId.TabIndex = 0;
            this.lblDonHangId.Text = "Mã đơn hàng: #12";
            // 
            // gridDetails
            // 
            this.gridDetails.AllowUserToAddRows = false;
            this.gridDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDetails.ColumnHeadersHeight = 35;
            this.gridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTTTen,
            this.colTTSL,
            this.colTTGia,
            this.colTTTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDetails.Location = new System.Drawing.Point(20, 150);
            this.gridDetails.Name = "gridDetails";
            this.gridDetails.ReadOnly = true;
            this.gridDetails.RowHeadersVisible = false;
            this.gridDetails.RowTemplate.Height = 35;
            this.gridDetails.Size = new System.Drawing.Size(840, 310);
            this.gridDetails.TabIndex = 2;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridDetails.ThemeStyle.HeaderStyle.Height = 35;
            this.gridDetails.ThemeStyle.ReadOnly = true;
            this.gridDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridDetails.ThemeStyle.RowsStyle.Height = 35;
            this.gridDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colTTTen
            // 
            this.colTTTen.HeaderText = "Tên Món";
            this.colTTTen.Name = "colTTTen";
            this.colTTTen.ReadOnly = true;
            this.colTTTen.Width = 350;
            // 
            // colTTSL
            // 
            this.colTTSL.HeaderText = "Số Lượng";
            this.colTTSL.Name = "colTTSL";
            this.colTTSL.ReadOnly = true;
            this.colTTSL.Width = 120;
            // 
            // colTTGia
            // 
            this.colTTGia.HeaderText = "Đơn Giá";
            this.colTTGia.Name = "colTTGia";
            this.colTTGia.ReadOnly = true;
            this.colTTGia.Width = 150;
            // 
            // colTTTotal
            // 
            this.colTTTotal.HeaderText = "Thành Tiền";
            this.colTTTotal.Name = "colTTTotal";
            this.colTTTotal.ReadOnly = true;
            this.colTTTotal.Width = 200;
            // 
            // panelPayment
            // 
            this.panelPayment.BackColor = System.Drawing.Color.White;
            this.panelPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.panelPayment.BorderRadius = 8;
            this.panelPayment.BorderThickness = 1;
            this.panelPayment.Controls.Add(this.lblTongTien);
            this.panelPayment.Controls.Add(this.btnThanhToan);
            this.panelPayment.Controls.Add(this.lblPhuongThuc);
            this.panelPayment.Controls.Add(this.cbPhuongThuc);
            this.panelPayment.Location = new System.Drawing.Point(20, 480);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(840, 140);
            this.panelPayment.TabIndex = 3;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTongTien.Location = new System.Drawing.Point(380, 20);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(440, 40);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "TỔNG THANH TOÁN: 0 đ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BorderRadius = 8;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(580, 80);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(240, 45);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "XÁC NHẬN THANH TOÁN";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblPhuongThuc
            // 
            this.lblPhuongThuc.AutoSize = true;
            this.lblPhuongThuc.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhuongThuc.Location = new System.Drawing.Point(20, 20);
            this.lblPhuongThuc.Name = "lblPhuongThuc";
            this.lblPhuongThuc.Size = new System.Drawing.Size(167, 19);
            this.lblPhuongThuc.TabIndex = 1;
            this.lblPhuongThuc.Text = "Phương thức thanh toán:";
            // 
            // cbPhuongThuc
            // 
            this.cbPhuongThuc.BackColor = System.Drawing.Color.Transparent;
            this.cbPhuongThuc.BorderRadius = 8;
            this.cbPhuongThuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhuongThuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbPhuongThuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPhuongThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPhuongThuc.ItemHeight = 30;
            this.cbPhuongThuc.Location = new System.Drawing.Point(20, 50);
            this.cbPhuongThuc.Name = "cbPhuongThuc";
            this.cbPhuongThuc.Size = new System.Drawing.Size(240, 36);
            this.cbPhuongThuc.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 8;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(760, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 36);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(880, 640);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.gridDetails);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.lblTitleThanhToan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThanhToan";
            this.Text = "FormThanhToan";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).EndInit();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleThanhToan;
        private Guna.UI2.WinForms.Guna2Panel panelInfo;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Label lblDonHangId;
        private Guna.UI2.WinForms.Guna2DataGridView gridDetails;
        private Guna.UI2.WinForms.Guna2Panel panelPayment;
        private System.Windows.Forms.Label lblPhuongThuc;
        private Guna.UI2.WinForms.Guna2ComboBox cbPhuongThuc;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTTTotal;
    }
}

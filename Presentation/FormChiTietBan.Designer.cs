namespace QuanLyQuanCafe.Presentation
{
    partial class FormChiTietBan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBanInfo = new System.Windows.Forms.Label();
            this.gridDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panelActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDatMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnTangQty = new Guna.UI2.WinForms.Guna2Button();
            this.btnGiamQty = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoiBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 16;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panelHeader;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(740, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(740, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CHI TIẾT BÀN PHỤC VỤ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBanInfo
            // 
            this.lblBanInfo.AutoSize = true;
            this.lblBanInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBanInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblBanInfo.Location = new System.Drawing.Point(20, 65);
            this.lblBanInfo.Name = "lblBanInfo";
            this.lblBanInfo.Size = new System.Drawing.Size(325, 20);
            this.lblBanInfo.TabIndex = 1;
            this.lblBanInfo.Text = "Bàn: Bàn X | Số chỗ: Y chỗ | Trạng thái: ZZZZZZ";
            // 
            // gridDetails
            // 
            this.gridDetails.AllowUserToAddRows = false;
            this.gridDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetails.BackgroundColor = System.Drawing.Color.White;
            this.gridDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDetails.ColumnHeadersHeight = 32;
            this.gridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonName,
            this.colGia,
            this.colSoLuong,
            this.colThanhTien,
            this.colMonId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDetails.Location = new System.Drawing.Point(20, 100);
            this.gridDetails.MultiSelect = false;
            this.gridDetails.Name = "gridDetails";
            this.gridDetails.ReadOnly = true;
            this.gridDetails.RowHeadersVisible = false;
            this.gridDetails.RowTemplate.Height = 28;
            this.gridDetails.Size = new System.Drawing.Size(520, 280);
            this.gridDetails.TabIndex = 2;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.gridDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridDetails.ThemeStyle.ReadOnly = true;
            this.gridDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridDetails.ThemeStyle.RowsStyle.Height = 28;
            this.gridDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.gridDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            // 
            // colMonName
            // 
            this.colMonName.FillWeight = 140F;
            this.colMonName.HeaderText = "Tên Món Nước";
            this.colMonName.Name = "colMonName";
            this.colMonName.ReadOnly = true;
            // 
            // colGia
            // 
            this.colGia.FillWeight = 90F;
            this.colGia.HeaderText = "Đơn Giá";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FillWeight = 60F;
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.FillWeight = 110F;
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // colMonId
            // 
            this.colMonId.HeaderText = "MonId";
            this.colMonId.Name = "colMonId";
            this.colMonId.ReadOnly = true;
            this.colMonId.Visible = false;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.lblTongTien.Location = new System.Drawing.Point(20, 395);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(183, 21);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "TỔNG THANH TOÁN: 0 đ";
            // 
            // panelActions
            // 
            this.panelActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(235)))));
            this.panelActions.Controls.Add(this.btnDatMon);
            this.panelActions.Controls.Add(this.btnSuaBan);
            this.panelActions.Controls.Add(this.btnXoaBan);
            this.panelActions.Controls.Add(this.btnThemMon);
            this.panelActions.Controls.Add(this.btnTangQty);
            this.panelActions.Controls.Add(this.btnGiamQty);
            this.panelActions.Controls.Add(this.btnXoaMon);
            this.panelActions.Controls.Add(this.btnDoiBan);
            this.panelActions.Controls.Add(this.btnThanhToan);
            this.panelActions.Controls.Add(this.btnDong);
            this.panelActions.Location = new System.Drawing.Point(560, 65);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(160, 365);
            this.panelActions.TabIndex = 4;
            // 
            // btnDatMon
            // 
            this.btnDatMon.BorderRadius = 6;
            this.btnDatMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDatMon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatMon.ForeColor = System.Drawing.Color.White;
            this.btnDatMon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(75)))), ((int)(((byte)(52)))));
            this.btnDatMon.Location = new System.Drawing.Point(10, 10);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(140, 32);
            this.btnDatMon.TabIndex = 0;
            this.btnDatMon.Text = "☕ Đặt Món";
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.BorderRadius = 6;
            this.btnSuaBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnSuaBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuaBan.ForeColor = System.Drawing.Color.White;
            this.btnSuaBan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(165)))), ((int)(((byte)(145)))));
            this.btnSuaBan.Location = new System.Drawing.Point(10, 50);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Size = new System.Drawing.Size(140, 32);
            this.btnSuaBan.TabIndex = 1;
            this.btnSuaBan.Text = "✏️ Sửa Bàn";
            this.btnSuaBan.Click += new System.EventHandler(this.btnSuaBan_Click);
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.BorderRadius = 6;
            this.btnXoaBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnXoaBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaBan.ForeColor = System.Drawing.Color.White;
            this.btnXoaBan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnXoaBan.Location = new System.Drawing.Point(10, 90);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(140, 32);
            this.btnXoaBan.TabIndex = 2;
            this.btnXoaBan.Text = "✕ Xóa Bàn";
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BorderRadius = 6;
            this.btnThemMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnThemMon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(75)))), ((int)(((byte)(52)))));
            this.btnThemMon.Location = new System.Drawing.Point(10, 10);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(140, 32);
            this.btnThemMon.TabIndex = 3;
            this.btnThemMon.Text = "➕ Thêm Món";
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnTangQty
            // 
            this.btnTangQty.BorderRadius = 6;
            this.btnTangQty.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnTangQty.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTangQty.ForeColor = System.Drawing.Color.White;
            this.btnTangQty.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(165)))), ((int)(((byte)(145)))));
            this.btnTangQty.Location = new System.Drawing.Point(10, 50);
            this.btnTangQty.Name = "btnTangQty";
            this.btnTangQty.Size = new System.Drawing.Size(140, 32);
            this.btnTangQty.TabIndex = 4;
            this.btnTangQty.Text = "🔼 Tăng SL";
            this.btnTangQty.Click += new System.EventHandler(this.btnTangQty_Click);
            // 
            // btnGiamQty
            // 
            this.btnGiamQty.BorderRadius = 6;
            this.btnGiamQty.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnGiamQty.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiamQty.ForeColor = System.Drawing.Color.White;
            this.btnGiamQty.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(165)))), ((int)(((byte)(145)))));
            this.btnGiamQty.Location = new System.Drawing.Point(10, 90);
            this.btnGiamQty.Name = "btnGiamQty";
            this.btnGiamQty.Size = new System.Drawing.Size(140, 32);
            this.btnGiamQty.TabIndex = 5;
            this.btnGiamQty.Text = "🔽 Giảm SL";
            this.btnGiamQty.Click += new System.EventHandler(this.btnGiamQty_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BorderRadius = 6;
            this.btnXoaMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.btnXoaMon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaMon.ForeColor = System.Drawing.Color.White;
            this.btnXoaMon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnXoaMon.Location = new System.Drawing.Point(10, 130);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(140, 32);
            this.btnXoaMon.TabIndex = 6;
            this.btnXoaMon.Text = "🗑️ Xóa Món";
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnDoiBan
            // 
            this.btnDoiBan.BorderRadius = 6;
            this.btnDoiBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDoiBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoiBan.ForeColor = System.Drawing.Color.White;
            this.btnDoiBan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(75)))), ((int)(((byte)(52)))));
            this.btnDoiBan.Location = new System.Drawing.Point(10, 170);
            this.btnDoiBan.Name = "btnDoiBan";
            this.btnDoiBan.Size = new System.Drawing.Size(140, 32);
            this.btnDoiBan.TabIndex = 7;
            this.btnDoiBan.Text = "🔄 Đổi Bàn";
            this.btnDoiBan.Click += new System.EventHandler(this.btnDoiBan_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderRadius = 6;
            this.btnThanhToan.FillColor = System.Drawing.Color.Green;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.btnThanhToan.Location = new System.Drawing.Point(10, 210);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(140, 32);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "💳 Thanh Toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDong.BorderRadius = 6;
            this.btnDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btnDong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(125)))));
            this.btnDong.Location = new System.Drawing.Point(10, 320);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 32);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FormChiTietBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.gridDetails);
            this.Controls.Add(this.lblBanInfo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChiTietBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Bàn";
            this.Load += new System.EventHandler(this.FormChiTietBan_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBanInfo;
        private Guna.UI2.WinForms.Guna2DataGridView gridDetails;
        private System.Windows.Forms.Label lblTongTien;
        private Guna.UI2.WinForms.Guna2Panel panelActions;
        private Guna.UI2.WinForms.Guna2Button btnDatMon;
        private Guna.UI2.WinForms.Guna2Button btnSuaBan;
        private Guna.UI2.WinForms.Guna2Button btnXoaBan;
        private Guna.UI2.WinForms.Guna2Button btnThemMon;
        private Guna.UI2.WinForms.Guna2Button btnTangQty;
        private Guna.UI2.WinForms.Guna2Button btnGiamQty;
        private Guna.UI2.WinForms.Guna2Button btnXoaMon;
        private Guna.UI2.WinForms.Guna2Button btnDoiBan;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonId;
    }
}

namespace QuanLyQuanCafe.Presentation
{
    partial class FormDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cbFilterTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gridDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colDHId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDHBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDHNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDHNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDHTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDHTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridChiTiet = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCTMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCTTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThanhToanDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoanThanh = new Guna.UI2.WinForms.Guna2Button();
            this.btnTiepNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuyDon = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTiet)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblFilter);
            this.panelTop.Controls.Add(this.cbFilterTrangThai);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(880, 60);
            this.panelTop.TabIndex = 0;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilter.Location = new System.Drawing.Point(20, 22);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(107, 17);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Lọc trạng thái đơn";
            // 
            // cbFilterTrangThai
            // 
            this.cbFilterTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterTrangThai.BorderRadius = 8;
            this.cbFilterTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbFilterTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbFilterTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFilterTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilterTrangThai.ItemHeight = 30;
            this.cbFilterTrangThai.Location = new System.Drawing.Point(140, 12);
            this.cbFilterTrangThai.Name = "cbFilterTrangThai";
            this.cbFilterTrangThai.Size = new System.Drawing.Size(220, 36);
            this.cbFilterTrangThai.TabIndex = 0;
            this.cbFilterTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbFilterTrangThai_SelectedIndexChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 60);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gridDonHang);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gridChiTiet);
            this.splitContainer.Panel2.Controls.Add(this.panelActions);
            this.splitContainer.Size = new System.Drawing.Size(880, 580);
            this.splitContainer.SplitterDistance = 290;
            this.splitContainer.TabIndex = 1;
            // 
            // gridDonHang
            // 
            this.gridDonHang.AllowUserToAddRows = false;
            this.gridDonHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDonHang.ColumnHeadersHeight = 35;
            this.gridDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDHId,
            this.colDHBan,
            this.colDHNhanVien,
            this.colDHNgayTao,
            this.colDHTongTien,
            this.colDHTrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDonHang.Location = new System.Drawing.Point(0, 0);
            this.gridDonHang.MultiSelect = false;
            this.gridDonHang.Name = "gridDonHang";
            this.gridDonHang.ReadOnly = true;
            this.gridDonHang.RowHeadersVisible = false;
            this.gridDonHang.RowTemplate.Height = 35;
            this.gridDonHang.Size = new System.Drawing.Size(880, 290);
            this.gridDonHang.TabIndex = 0;
            this.gridDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridDonHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridDonHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDonHang.ThemeStyle.HeaderStyle.Height = 35;
            this.gridDonHang.ThemeStyle.ReadOnly = true;
            this.gridDonHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDonHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridDonHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridDonHang.ThemeStyle.RowsStyle.Height = 35;
            this.gridDonHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDonHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridDonHang.SelectionChanged += new System.EventHandler(this.gridDonHang_SelectionChanged);
            // 
            // colDHId
            // 
            this.colDHId.HeaderText = "Mã Đơn";
            this.colDHId.Name = "colDHId";
            this.colDHId.ReadOnly = true;
            this.colDHId.Width = 80;
            // 
            // colDHBan
            // 
            this.colDHBan.HeaderText = "Bàn";
            this.colDHBan.Name = "colDHBan";
            this.colDHBan.ReadOnly = true;
            this.colDHBan.Width = 100;
            // 
            // colDHNhanVien
            // 
            this.colDHNhanVien.HeaderText = "Nhân viên tạo";
            this.colDHNhanVien.Name = "colDHNhanVien";
            this.colDHNhanVien.ReadOnly = true;
            this.colDHNhanVien.Width = 180;
            // 
            // colDHNgayTao
            // 
            this.colDHNgayTao.HeaderText = "Ngày tạo";
            this.colDHNgayTao.Name = "colDHNgayTao";
            this.colDHNgayTao.ReadOnly = true;
            this.colDHNgayTao.Width = 180;
            // 
            // colDHTongTien
            // 
            this.colDHTongTien.HeaderText = "Tổng tiền";
            this.colDHTongTien.Name = "colDHTongTien";
            this.colDHTongTien.ReadOnly = true;
            this.colDHTongTien.Width = 140;
            // 
            // colDHTrangThai
            // 
            this.colDHTrangThai.HeaderText = "Trạng thái";
            this.colDHTrangThai.Name = "colDHTrangThai";
            this.colDHTrangThai.ReadOnly = true;
            this.colDHTrangThai.Width = 150;
            // 
            // gridChiTiet
            // 
            this.gridChiTiet.AllowUserToAddRows = false;
            this.gridChiTiet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridChiTiet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridChiTiet.ColumnHeadersHeight = 35;
            this.gridChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCTMon,
            this.colCTSL,
            this.colCTGia,
            this.colCTTotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChiTiet.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridChiTiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridChiTiet.Location = new System.Drawing.Point(0, 0);
            this.gridChiTiet.MultiSelect = false;
            this.gridChiTiet.Name = "gridChiTiet";
            this.gridChiTiet.ReadOnly = true;
            this.gridChiTiet.RowHeadersVisible = false;
            this.gridChiTiet.RowTemplate.Height = 35;
            this.gridChiTiet.Size = new System.Drawing.Size(630, 286);
            this.gridChiTiet.TabIndex = 1;
            this.gridChiTiet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridChiTiet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridChiTiet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridChiTiet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridChiTiet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridChiTiet.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridChiTiet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridChiTiet.ThemeStyle.HeaderStyle.Height = 35;
            this.gridChiTiet.ThemeStyle.ReadOnly = true;
            this.gridChiTiet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridChiTiet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridChiTiet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridChiTiet.ThemeStyle.RowsStyle.Height = 35;
            this.gridChiTiet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridChiTiet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colCTMon
            // 
            this.colCTMon.HeaderText = "Món Nước";
            this.colCTMon.Name = "colCTMon";
            this.colCTMon.ReadOnly = true;
            this.colCTMon.Width = 250;
            // 
            // colCTSL
            // 
            this.colCTSL.HeaderText = "SL";
            this.colCTSL.Name = "colCTSL";
            this.colCTSL.ReadOnly = true;
            this.colCTSL.Width = 70;
            // 
            // colCTGia
            // 
            this.colCTGia.HeaderText = "Đơn Giá";
            this.colCTGia.Name = "colCTGia";
            this.colCTGia.ReadOnly = true;
            this.colCTGia.Width = 130;
            // 
            // colCTTotal
            // 
            this.colCTTotal.HeaderText = "Thành Tiền";
            this.colCTTotal.Name = "colCTTotal";
            this.colCTTotal.ReadOnly = true;
            this.colCTTotal.Width = 150;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnThanhToanDon);
            this.panelActions.Controls.Add(this.btnHoanThanh);
            this.panelActions.Controls.Add(this.btnTiepNhan);
            this.panelActions.Controls.Add(this.btnHuyDon);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelActions.Location = new System.Drawing.Point(630, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(250, 286);
            this.panelActions.TabIndex = 0;
            // 
            // btnThanhToanDon
            // 
            this.btnThanhToanDon.BorderRadius = 8;
            this.btnThanhToanDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToanDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToanDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToanDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToanDon.FillColor = System.Drawing.Color.Green;
            this.btnThanhToanDon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToanDon.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanDon.Location = new System.Drawing.Point(15, 140);
            this.btnThanhToanDon.Name = "btnThanhToanDon";
            this.btnThanhToanDon.Size = new System.Drawing.Size(220, 40);
            this.btnThanhToanDon.TabIndex = 3;
            this.btnThanhToanDon.Text = "Thanh Toán Đơn";
            this.btnThanhToanDon.Click += new System.EventHandler(this.btnThanhToanDon_Click);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BorderRadius = 8;
            this.btnHoanThanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoanThanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoanThanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoanThanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoanThanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnHoanThanh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHoanThanh.ForeColor = System.Drawing.Color.White;
            this.btnHoanThanh.Location = new System.Drawing.Point(15, 80);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(220, 40);
            this.btnHoanThanh.TabIndex = 2;
            this.btnHoanThanh.Text = "Hoàn Thành Phục Vụ";
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.BorderRadius = 8;
            this.btnTiepNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTiepNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTiepNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTiepNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTiepNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnTiepNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTiepNhan.ForeColor = System.Drawing.Color.White;
            this.btnTiepNhan.Location = new System.Drawing.Point(15, 20);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(220, 40);
            this.btnTiepNhan.TabIndex = 1;
            this.btnTiepNhan.Text = "Tiếp Nhận Đơn Hàng";
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.BorderRadius = 8;
            this.btnHuyDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHuyDon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuyDon.ForeColor = System.Drawing.Color.White;
            this.btnHuyDon.Location = new System.Drawing.Point(15, 226);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(220, 40);
            this.btnHuyDon.TabIndex = 0;
            this.btnHuyDon.Text = "Hủy Đơn Hàng";
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(880, 640);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDonHang";
            this.Text = "FormDonHang";
            this.Load += new System.EventHandler(this.FormDonHang_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTiet)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label lblFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterTrangThai;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Guna.UI2.WinForms.Guna2DataGridView gridDonHang;
        private Guna.UI2.WinForms.Guna2DataGridView gridChiTiet;
        private Guna.UI2.WinForms.Guna2Panel panelActions;
        private Guna.UI2.WinForms.Guna2Button btnHuyDon;
        private Guna.UI2.WinForms.Guna2Button btnHoanThanh;
        private Guna.UI2.WinForms.Guna2Button btnTiepNhan;
        private Guna.UI2.WinForms.Guna2Button btnThanhToanDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDHId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDHBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDHNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDHNgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDHTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDHTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCTTotal;
    }
}

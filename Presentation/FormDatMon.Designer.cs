namespace QuanLyQuanCafe.Presentation
{
    partial class FormDatMon
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gridMonNuoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLeftTop = new Guna.UI2.WinForms.Guna2Panel();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.gridGioHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colGioMonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRightBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatMon = new Guna.UI2.WinForms.Guna2Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTableLabel = new System.Windows.Forms.Label();
            this.cbBan = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMonNuoc)).BeginInit();
            this.panelLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGioHang)).BeginInit();
            this.panelRightBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gridMonNuoc);
            this.splitContainer.Panel1.Controls.Add(this.panelLeftTop);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gridGioHang);
            this.splitContainer.Panel2.Controls.Add(this.panelRightBottom);
            this.splitContainer.Size = new System.Drawing.Size(880, 640);
            this.splitContainer.SplitterDistance = 440;
            this.splitContainer.TabIndex = 0;
            // 
            // gridMonNuoc
            // 
            this.gridMonNuoc.AllowUserToAddRows = false;
            this.gridMonNuoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridMonNuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMonNuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridMonNuoc.ColumnHeadersHeight = 35;
            this.gridMonNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridMonNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMonId,
            this.colTenMon,
            this.colLoaiMon,
            this.colGiaMon});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMonNuoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridMonNuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMonNuoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridMonNuoc.Location = new System.Drawing.Point(0, 70);
            this.gridMonNuoc.MultiSelect = false;
            this.gridMonNuoc.Name = "gridMonNuoc";
            this.gridMonNuoc.ReadOnly = true;
            this.gridMonNuoc.RowHeadersVisible = false;
            this.gridMonNuoc.RowTemplate.Height = 35;
            this.gridMonNuoc.Size = new System.Drawing.Size(440, 570);
            this.gridMonNuoc.TabIndex = 1;
            this.gridMonNuoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridMonNuoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridMonNuoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridMonNuoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridMonNuoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridMonNuoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridMonNuoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridMonNuoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridMonNuoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridMonNuoc.ThemeStyle.HeaderStyle.Height = 35;
            this.gridMonNuoc.ThemeStyle.ReadOnly = true;
            this.gridMonNuoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridMonNuoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridMonNuoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridMonNuoc.ThemeStyle.RowsStyle.Height = 35;
            this.gridMonNuoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridMonNuoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colMonId
            // 
            this.colMonId.HeaderText = "ID";
            this.colMonId.Name = "colMonId";
            this.colMonId.ReadOnly = true;
            this.colMonId.Width = 50;
            // 
            // colTenMon
            // 
            this.colTenMon.HeaderText = "Tên Món";
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            this.colTenMon.Width = 180;
            // 
            // colLoaiMon
            // 
            this.colLoaiMon.HeaderText = "Loại";
            this.colLoaiMon.Name = "colLoaiMon";
            this.colLoaiMon.ReadOnly = true;
            this.colLoaiMon.Width = 100;
            // 
            // colGiaMon
            // 
            this.colGiaMon.HeaderText = "Giá bán";
            this.colGiaMon.Name = "colGiaMon";
            this.colGiaMon.ReadOnly = true;
            this.colGiaMon.Width = 110;
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.Controls.Add(this.numSoLuong);
            this.panelLeftTop.Controls.Add(this.btnThem);
            this.panelLeftTop.Controls.Add(this.txtSearch);
            this.panelLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(440, 70);
            this.panelLeftTop.TabIndex = 0;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSoLuong.Location = new System.Drawing.Point(260, 22);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(60, 27);
            this.numSoLuong.TabIndex = 2;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BorderRadius = 8;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(330, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 36);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.txtSearch.Location = new System.Drawing.Point(12, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.txtSearch.PlaceholderText = "Tìm món nhanh...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(230, 36);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gridGioHang
            // 
            this.gridGioHang.AllowUserToAddRows = false;
            this.gridGioHang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridGioHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridGioHang.ColumnHeadersHeight = 35;
            this.gridGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGioMonId,
            this.colGioTen,
            this.colGioQty,
            this.colGioGia,
            this.colGioTotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridGioHang.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGioHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridGioHang.Location = new System.Drawing.Point(0, 0);
            this.gridGioHang.MultiSelect = false;
            this.gridGioHang.Name = "gridGioHang";
            this.gridGioHang.ReadOnly = true;
            this.gridGioHang.RowHeadersVisible = false;
            this.gridGioHang.RowTemplate.Height = 35;
            this.gridGioHang.Size = new System.Drawing.Size(436, 490);
            this.gridGioHang.TabIndex = 1;
            this.gridGioHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridGioHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridGioHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridGioHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridGioHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridGioHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridGioHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridGioHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridGioHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridGioHang.ThemeStyle.HeaderStyle.Height = 35;
            this.gridGioHang.ThemeStyle.ReadOnly = true;
            this.gridGioHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridGioHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridGioHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridGioHang.ThemeStyle.RowsStyle.Height = 35;
            this.gridGioHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridGioHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colGioMonId
            // 
            this.colGioMonId.HeaderText = "ID";
            this.colGioMonId.Name = "colGioMonId";
            this.colGioMonId.ReadOnly = true;
            this.colGioMonId.Width = 40;
            // 
            // colGioTen
            // 
            this.colGioTen.HeaderText = "Tên Món";
            this.colGioTen.Name = "colGioTen";
            this.colGioTen.ReadOnly = true;
            this.colGioTen.Width = 140;
            // 
            // colGioQty
            // 
            this.colGioQty.HeaderText = "SL";
            this.colGioQty.Name = "colGioQty";
            this.colGioQty.ReadOnly = true;
            this.colGioQty.Width = 50;
            // 
            // colGioGia
            // 
            this.colGioGia.HeaderText = "Đơn Giá";
            this.colGioGia.Name = "colGioGia";
            this.colGioGia.ReadOnly = true;
            this.colGioGia.Width = 90;
            // 
            // colGioTotal
            // 
            this.colGioTotal.HeaderText = "Thành Tiền";
            this.colGioTotal.Name = "colGioTotal";
            this.colGioTotal.ReadOnly = true;
            this.colGioTotal.Width = 110;
            // 
            // panelRightBottom
            // 
            this.panelRightBottom.Controls.Add(this.btnXoa);
            this.panelRightBottom.Controls.Add(this.btnDatMon);
            this.panelRightBottom.Controls.Add(this.lblTongTien);
            this.panelRightBottom.Controls.Add(this.lblTableLabel);
            this.panelRightBottom.Controls.Add(this.cbBan);
            this.panelRightBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRightBottom.Location = new System.Drawing.Point(0, 490);
            this.panelRightBottom.Name = "panelRightBottom";
            this.panelRightBottom.Size = new System.Drawing.Size(436, 150);
            this.panelRightBottom.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(10, 100);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa món";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDatMon
            // 
            this.btnDatMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatMon.BorderRadius = 8;
            this.btnDatMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDatMon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatMon.ForeColor = System.Drawing.Color.White;
            this.btnDatMon.Location = new System.Drawing.Point(276, 100);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(150, 40);
            this.btnDatMon.TabIndex = 3;
            this.btnDatMon.Text = "XÁC NHẬN ĐẶT";
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTongTien.Location = new System.Drawing.Point(150, 50);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(276, 30);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng cộng: 0đ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTableLabel
            // 
            this.lblTableLabel.AutoSize = true;
            this.lblTableLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTableLabel.Location = new System.Drawing.Point(10, 15);
            this.lblTableLabel.Name = "lblTableLabel";
            this.lblTableLabel.Size = new System.Drawing.Size(73, 19);
            this.lblTableLabel.TabIndex = 1;
            this.lblTableLabel.Text = "Chọn bàn:";
            // 
            // cbBan
            // 
            this.cbBan.BackColor = System.Drawing.Color.Transparent;
            this.cbBan.BorderRadius = 8;
            this.cbBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBan.ItemHeight = 30;
            this.cbBan.Location = new System.Drawing.Point(90, 8);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(200, 36);
            this.cbBan.TabIndex = 0;
            // 
            // FormDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(880, 640);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatMon";
            this.Text = "FormDatMon";
            this.Load += new System.EventHandler(this.FormDatMon_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMonNuoc)).EndInit();
            this.panelLeftTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGioHang)).EndInit();
            this.panelRightBottom.ResumeLayout(false);
            this.panelRightBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private Guna.UI2.WinForms.Guna2Panel panelLeftTop;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2DataGridView gridMonNuoc;
        private Guna.UI2.WinForms.Guna2DataGridView gridGioHang;
        private Guna.UI2.WinForms.Guna2Panel panelRightBottom;
        private System.Windows.Forms.Label lblTableLabel;
        private Guna.UI2.WinForms.Guna2ComboBox cbBan;
        private Guna.UI2.WinForms.Guna2Button btnDatMon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioMonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioTotal;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
    }
}

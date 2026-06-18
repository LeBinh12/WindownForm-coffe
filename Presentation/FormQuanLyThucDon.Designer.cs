namespace QuanLyQuanCafe.Presentation
{
    partial class FormQuanLyThucDon
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gridThucDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConBan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelControls = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClean = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.chkConBan = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLoaiMon = new System.Windows.Forms.Label();
            this.cbLoaiMon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDetailHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridThucDon)).BeginInit();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
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
            this.splitContainer.Panel1.Controls.Add(this.gridThucDon);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelControls);
            this.splitContainer.Size = new System.Drawing.Size(880, 640);
            this.splitContainer.SplitterDistance = 500;
            this.splitContainer.TabIndex = 0;
            // 
            // gridThucDon
            // 
            this.gridThucDon.AllowUserToAddRows = false;
            this.gridThucDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridThucDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridThucDon.ColumnHeadersHeight = 35;
            this.gridThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTen,
            this.colLoai,
            this.colGia,
            this.colConBan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridThucDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridThucDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridThucDon.Location = new System.Drawing.Point(0, 0);
            this.gridThucDon.MultiSelect = false;
            this.gridThucDon.Name = "gridThucDon";
            this.gridThucDon.ReadOnly = true;
            this.gridThucDon.RowHeadersVisible = false;
            this.gridThucDon.RowTemplate.Height = 35;
            this.gridThucDon.Size = new System.Drawing.Size(500, 640);
            this.gridThucDon.TabIndex = 0;
            this.gridThucDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridThucDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridThucDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridThucDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridThucDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridThucDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridThucDon.ThemeStyle.HeaderStyle.Height = 35;
            this.gridThucDon.ThemeStyle.ReadOnly = true;
            this.gridThucDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridThucDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridThucDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridThucDon.ThemeStyle.RowsStyle.Height = 35;
            this.gridThucDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridThucDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridThucDon.SelectionChanged += new System.EventHandler(this.gridThucDon_SelectionChanged);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên Món";
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            this.colTen.Width = 180;
            // 
            // colLoai
            // 
            this.colLoai.HeaderText = "Loại";
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            this.colLoai.Width = 90;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá bán";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            this.colGia.Width = 100;
            // 
            // colConBan
            // 
            this.colConBan.HeaderText = "Còn bán";
            this.colConBan.Name = "colConBan";
            this.colConBan.ReadOnly = true;
            this.colConBan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colConBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colConBan.Width = 80;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnClean);
            this.panelControls.Controls.Add(this.btnSua);
            this.panelControls.Controls.Add(this.btnXoa);
            this.panelControls.Controls.Add(this.btnThem);
            this.panelControls.Controls.Add(this.chkConBan);
            this.panelControls.Controls.Add(this.lblMoTa);
            this.panelControls.Controls.Add(this.txtMoTa);
            this.panelControls.Controls.Add(this.lblLoaiMon);
            this.panelControls.Controls.Add(this.cbLoaiMon);
            this.panelControls.Controls.Add(this.lblGia);
            this.panelControls.Controls.Add(this.numGia);
            this.panelControls.Controls.Add(this.lblTenMon);
            this.panelControls.Controls.Add(this.txtTenMon);
            this.panelControls.Controls.Add(this.lblDetailHeader);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(376, 640);
            this.panelControls.TabIndex = 0;
            // 
            // btnClean
            // 
            this.btnClean.BorderRadius = 8;
            this.btnClean.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClean.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClean.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClean.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClean.FillColor = System.Drawing.Color.DarkGray;
            this.btnClean.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(195, 540);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(150, 40);
            this.btnClean.TabIndex = 13;
            this.btnClean.Text = "Làm mới Form";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 8;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(30, 480);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 40);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Cập nhật món";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(195, 480);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa món";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 8;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(30, 540);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 40);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm món mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // chkConBan
            // 
            this.chkConBan.AutoSize = true;
            this.chkConBan.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.chkConBan.CheckedState.BorderRadius = 2;
            this.chkConBan.CheckedState.BorderThickness = 0;
            this.chkConBan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.chkConBan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkConBan.Location = new System.Drawing.Point(30, 430);
            this.chkConBan.Name = "chkConBan";
            this.chkConBan.Size = new System.Drawing.Size(139, 23);
            this.chkConBan.TabIndex = 9;
            this.chkConBan.Text = "Đang bán tại quán";
            this.chkConBan.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkConBan.UncheckedState.BorderRadius = 2;
            this.chkConBan.UncheckedState.BorderThickness = 0;
            this.chkConBan.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMoTa.Location = new System.Drawing.Point(30, 290);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(46, 19);
            this.lblMoTa.TabIndex = 8;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderRadius = 8;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.txtMoTa.Location = new System.Drawing.Point(30, 315);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.txtMoTa.PlaceholderText = "Mô tả hương vị món...";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(315, 95);
            this.txtMoTa.TabIndex = 7;
            // 
            // lblLoaiMon
            // 
            this.lblLoaiMon.AutoSize = true;
            this.lblLoaiMon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoaiMon.Location = new System.Drawing.Point(30, 215);
            this.lblLoaiMon.Name = "lblLoaiMon";
            this.lblLoaiMon.Size = new System.Drawing.Size(65, 19);
            this.lblLoaiMon.TabIndex = 6;
            this.lblLoaiMon.Text = "Loại món";
            // 
            // cbLoaiMon
            // 
            this.cbLoaiMon.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiMon.BorderRadius = 8;
            this.cbLoaiMon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiMon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbLoaiMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbLoaiMon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLoaiMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoaiMon.ItemHeight = 30;
            this.cbLoaiMon.Location = new System.Drawing.Point(30, 240);
            this.cbLoaiMon.Name = "cbLoaiMon";
            this.cbLoaiMon.Size = new System.Drawing.Size(315, 36);
            this.cbLoaiMon.TabIndex = 5;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGia.Location = new System.Drawing.Point(30, 140);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(56, 19);
            this.lblGia.TabIndex = 4;
            this.lblGia.Text = "Giá bán";
            // 
            // numGia
            // 
            this.numGia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGia.Location = new System.Drawing.Point(30, 165);
            this.numGia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(315, 27);
            this.numGia.TabIndex = 3;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenMon.Location = new System.Drawing.Point(30, 65);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(62, 19);
            this.lblTenMon.TabIndex = 2;
            this.lblTenMon.Text = "Tên món";
            // 
            // txtTenMon
            // 
            this.txtTenMon.BorderRadius = 8;
            this.txtTenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMon.DefaultText = "";
            this.txtTenMon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenMon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.txtTenMon.Location = new System.Drawing.Point(30, 90);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.PasswordChar = '\0';
            this.txtTenMon.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.txtTenMon.PlaceholderText = "Nhập tên món nước...";
            this.txtTenMon.SelectedText = "";
            this.txtTenMon.Size = new System.Drawing.Size(315, 36);
            this.txtTenMon.TabIndex = 1;
            // 
            // lblDetailHeader
            // 
            this.lblDetailHeader.AutoSize = true;
            this.lblDetailHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDetailHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblDetailHeader.Location = new System.Drawing.Point(30, 20);
            this.lblDetailHeader.Name = "lblDetailHeader";
            this.lblDetailHeader.Size = new System.Drawing.Size(189, 25);
            this.lblDetailHeader.TabIndex = 0;
            this.lblDetailHeader.Text = "Thông Tin Chi Tiết";
            // 
            // FormQuanLyThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 640);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyThucDon";
            this.Text = "FormQuanLyThucDon";
            this.Load += new System.EventHandler(this.FormQuanLyThucDon_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridThucDon)).EndInit();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private Guna.UI2.WinForms.Guna2DataGridView gridThucDon;
        private Guna.UI2.WinForms.Guna2Panel panelControls;
        private System.Windows.Forms.Label lblDetailHeader;
        private System.Windows.Forms.Label lblTenMon;
        private Guna.UI2.WinForms.Guna2TextBox txtTenMon;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Label lblLoaiMon;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiMon;
        private System.Windows.Forms.Label lblMoTa;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2CheckBox chkConBan;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnClean;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colConBan;
    }
}

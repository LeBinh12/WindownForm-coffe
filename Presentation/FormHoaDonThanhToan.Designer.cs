namespace QuanLyQuanCafe.Presentation
{
    partial class FormHoaDonThanhToan
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
            this.panelInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblBan = new System.Windows.Forms.Label();
            this.lblMaDon = new System.Windows.Forms.Label();
            this.gridDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTienThuaValue = new System.Windows.Forms.Label();
            this.lblTienThua = new System.Windows.Forms.Label();
            this.txtKhachDua = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblKhachDua = new System.Windows.Forms.Label();
            this.cbPhuongThuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).BeginInit();
            this.panelBottom.SuspendLayout();
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
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(700, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(240, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.panelInfo.Controls.Add(this.lblNgayTao);
            this.panelInfo.Controls.Add(this.lblNhanVien);
            this.panelInfo.Controls.Add(this.lblBan);
            this.panelInfo.Controls.Add(this.lblMaDon);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 50);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(700, 75);
            this.panelInfo.TabIndex = 1;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgayTao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblNgayTao.Location = new System.Drawing.Point(360, 45);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(60, 17);
            this.lblNgayTao.TabIndex = 3;
            this.lblNgayTao.Text = "Ngày tạo";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblNhanVien.Location = new System.Drawing.Point(360, 15);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(69, 17);
            this.lblNhanVien.TabIndex = 2;
            this.lblNhanVien.Text = "Nhân viên";
            // 
            // lblBan
            // 
            this.lblBan.AutoSize = true;
            this.lblBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblBan.Location = new System.Drawing.Point(25, 45);
            this.lblBan.Name = "lblBan";
            this.lblBan.Size = new System.Drawing.Size(31, 17);
            this.lblBan.TabIndex = 1;
            this.lblBan.Text = "Bàn";
            // 
            // lblMaDon
            // 
            this.lblMaDon.AutoSize = true;
            this.lblMaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblMaDon.Location = new System.Drawing.Point(25, 15);
            this.lblMaDon.Name = "lblMaDon";
            this.lblMaDon.Size = new System.Drawing.Size(56, 17);
            this.lblMaDon.TabIndex = 0;
            this.lblMaDon.Text = "Mã đơn";
            // 
            // gridDetails
            // 
            this.gridDetails.AllowUserToAddRows = false;
            this.gridDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDetails.ColumnHeadersHeight = 35;
            this.gridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMon,
            this.colGia,
            this.colSL,
            this.colThanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDetails.Location = new System.Drawing.Point(0, 125);
            this.gridDetails.Name = "gridDetails";
            this.gridDetails.ReadOnly = true;
            this.gridDetails.RowHeadersVisible = false;
            this.gridDetails.Size = new System.Drawing.Size(700, 245);
            this.gridDetails.TabIndex = 2;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.gridDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridDetails.ThemeStyle.HeaderStyle.Height = 35;
            this.gridDetails.ThemeStyle.ReadOnly = true;
            this.gridDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gridDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridDetails.ThemeStyle.RowsStyle.Height = 22;
            this.gridDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.gridDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colMon
            // 
            this.colMon.HeaderText = "Tên món";
            this.colMon.Name = "colMon";
            this.colMon.ReadOnly = true;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Đơn giá";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // 
            // colSL
            // 
            this.colSL.HeaderText = "Số lượng";
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panelBottom.Controls.Add(this.lblTienThuaValue);
            this.panelBottom.Controls.Add(this.lblTienThua);
            this.panelBottom.Controls.Add(this.txtKhachDua);
            this.panelBottom.Controls.Add(this.lblKhachDua);
            this.panelBottom.Controls.Add(this.cbPhuongThuc);
            this.panelBottom.Controls.Add(this.lblPhuongThuc);
            this.panelBottom.Controls.Add(this.lblTongTien);
            this.panelBottom.Controls.Add(this.btnHuy);
            this.panelBottom.Controls.Add(this.btnXacNhan);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 370);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(700, 180);
            this.panelBottom.TabIndex = 3;
            // 
            // lblTienThuaValue
            // 
            this.lblTienThuaValue.AutoSize = true;
            this.lblTienThuaValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTienThuaValue.ForeColor = System.Drawing.Color.Green;
            this.lblTienThuaValue.Location = new System.Drawing.Point(495, 68);
            this.lblTienThuaValue.Name = "lblTienThuaValue";
            this.lblTienThuaValue.Size = new System.Drawing.Size(35, 21);
            this.lblTienThuaValue.TabIndex = 8;
            this.lblTienThuaValue.Text = "0 đ";
            // 
            // lblTienThua
            // 
            this.lblTienThua.AutoSize = true;
            this.lblTienThua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTienThua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblTienThua.Location = new System.Drawing.Point(400, 71);
            this.lblTienThua.Name = "lblTienThua";
            this.lblTienThua.Size = new System.Drawing.Size(68, 17);
            this.lblTienThua.TabIndex = 7;
            this.lblTienThua.Text = "Tiền thừa:";
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.BorderRadius = 6;
            this.txtKhachDua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKhachDua.DefaultText = "";
            this.txtKhachDua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKhachDua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKhachDua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhachDua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhachDua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.txtKhachDua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKhachDua.ForeColor = System.Drawing.Color.Black;
            this.txtKhachDua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.txtKhachDua.Location = new System.Drawing.Point(495, 18);
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.PasswordChar = '\0';
            this.txtKhachDua.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.txtKhachDua.PlaceholderText = "Nhập số tiền";
            this.txtKhachDua.SelectedText = "";
            this.txtKhachDua.Size = new System.Drawing.Size(180, 36);
            this.txtKhachDua.TabIndex = 6;
            this.txtKhachDua.TextChanged += new System.EventHandler(this.txtKhachDua_TextChanged);
            this.txtKhachDua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhachDua_KeyPress);
            // 
            // lblKhachDua
            // 
            this.lblKhachDua.AutoSize = true;
            this.lblKhachDua.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKhachDua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblKhachDua.Location = new System.Drawing.Point(400, 27);
            this.lblKhachDua.Name = "lblKhachDua";
            this.lblKhachDua.Size = new System.Drawing.Size(76, 17);
            this.lblKhachDua.TabIndex = 5;
            this.lblKhachDua.Text = "Khách đưa:";
            // 
            // cbPhuongThuc
            // 
            this.cbPhuongThuc.BackColor = System.Drawing.Color.Transparent;
            this.cbPhuongThuc.BorderRadius = 6;
            this.cbPhuongThuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhuongThuc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbPhuongThuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPhuongThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPhuongThuc.ItemHeight = 30;
            this.cbPhuongThuc.Location = new System.Drawing.Point(145, 18);
            this.cbPhuongThuc.Name = "cbPhuongThuc";
            this.cbPhuongThuc.Size = new System.Drawing.Size(220, 36);
            this.cbPhuongThuc.TabIndex = 4;
            this.cbPhuongThuc.SelectedIndexChanged += new System.EventHandler(this.cbPhuongThuc_SelectedIndexChanged);
            // 
            // lblPhuongThuc
            // 
            this.lblPhuongThuc.AutoSize = true;
            this.lblPhuongThuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhuongThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblPhuongThuc.Location = new System.Drawing.Point(25, 27);
            this.lblPhuongThuc.Name = "lblPhuongThuc";
            this.lblPhuongThuc.Size = new System.Drawing.Size(114, 17);
            this.lblPhuongThuc.TabIndex = 3;
            this.lblPhuongThuc.Text = "P.thức thanh toán:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.lblTongTien.Location = new System.Drawing.Point(25, 68);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(262, 30);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "TỔNG TIỀN THANH TOÁN";
            // 
            // btnHuy
            // 
            this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.BorderThickness = 1;
            this.btnHuy.FillColor = System.Drawing.Color.Transparent;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnHuy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.btnHuy.Location = new System.Drawing.Point(365, 120);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(180, 45);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Đóng / Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderRadius = 8;
            this.btnXacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(71)))), ((int)(((byte)(54)))));
            this.btnXacNhan.Location = new System.Drawing.Point(155, 120);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(180, 45);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác Nhận Thanh Toán";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // FormHoaDonThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.gridDetails);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDonThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa Đơn Thanh Toán";
            this.Load += new System.EventHandler(this.FormHoaDonThanhToan_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel panelInfo;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblBan;
        private System.Windows.Forms.Label lblMaDon;
        private Guna.UI2.WinForms.Guna2DataGridView gridDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private Guna.UI2.WinForms.Guna2Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private System.Windows.Forms.Label lblTongTien;
        private Guna.UI2.WinForms.Guna2ComboBox cbPhuongThuc;
        private System.Windows.Forms.Label lblPhuongThuc;
        private System.Windows.Forms.Label lblTienThuaValue;
        private System.Windows.Forms.Label lblTienThua;
        private Guna.UI2.WinForms.Guna2TextBox txtKhachDua;
        private System.Windows.Forms.Label lblKhachDua;
    }
}

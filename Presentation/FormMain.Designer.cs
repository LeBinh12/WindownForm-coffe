namespace QuanLyQuanCafe.Presentation
{
    partial class FormMain
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyThucDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThucDon = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnToggleSidebar = new Guna.UI2.WinForms.Guna2Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelHeader = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.controlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlBoxMax = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlBoxMin = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.panelSidebar.Controls.Add(this.btnDangXuat);
            this.panelSidebar.Controls.Add(this.btnThongKe);
            this.panelSidebar.Controls.Add(this.btnQuanLyTaiKhoan);
            this.panelSidebar.Controls.Add(this.btnQuanLyThucDon);
            this.panelSidebar.Controls.Add(this.btnDonHang);
            this.panelSidebar.Controls.Add(this.btnHoaDon);
            this.panelSidebar.Controls.Add(this.btnDatMon);
            this.panelSidebar.Controls.Add(this.btnQuanLyBan);
            this.panelSidebar.Controls.Add(this.btnThucDon);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 700);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDangXuat.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.btnDangXuat.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnDangXuat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDangXuat.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 650);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(220, 50);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "🚪 Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.TextOffset = new System.Drawing.Point(15, 0);
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnThongKe.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FillColor = System.Drawing.Color.Transparent;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.btnThongKe.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnThongKe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnThongKe.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(0, 360);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(220, 50);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "📊 Thống Kê";
            this.btnThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.TextOffset = new System.Drawing.Point(15, 0);
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnQuanLyTaiKhoan.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnQuanLyTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyTaiKhoan.FillColor = System.Drawing.Color.Transparent;
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.btnQuanLyTaiKhoan.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnQuanLyTaiKhoan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnQuanLyTaiKhoan.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(0, 310);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(220, 50);
            this.btnQuanLyTaiKhoan.TabIndex = 6;
            this.btnQuanLyTaiKhoan.Text = "👥 Tài Khoản";
            this.btnQuanLyTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyTaiKhoan.TextOffset = new System.Drawing.Point(15, 0);
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnQuanLyThucDon
            // 
            this.btnQuanLyThucDon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnQuanLyThucDon.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnQuanLyThucDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyThucDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyThucDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyThucDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyThucDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyThucDon.FillColor = System.Drawing.Color.Transparent;
            this.btnQuanLyThucDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyThucDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.btnQuanLyThucDon.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnQuanLyThucDon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnQuanLyThucDon.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyThucDon.Location = new System.Drawing.Point(0, 260);
            this.btnQuanLyThucDon.Name = "btnQuanLyThucDon";
            this.btnQuanLyThucDon.Size = new System.Drawing.Size(220, 50);
            this.btnQuanLyThucDon.TabIndex = 5;
            this.btnQuanLyThucDon.Text = "⚙️ Thực Đơn";
            this.btnQuanLyThucDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyThucDon.TextOffset = new System.Drawing.Point(15, 0);
            this.btnQuanLyThucDon.Click += new System.EventHandler(this.btnQuanLyThucDon_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDonHang.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnDonHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDonHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDonHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDonHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonHang.FillColor = System.Drawing.Color.Transparent;
            this.btnDonHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDonHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.btnDonHang.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnDonHang.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDonHang.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDonHang.Location = new System.Drawing.Point(0, 210);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(220, 50);
            this.btnDonHang.TabIndex = 4;
            this.btnDonHang.Text = "🧾 Đơn Hàng";
            this.btnDonHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDonHang.TextOffset = new System.Drawing.Point(15, 0);
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnHoaDon.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FillColor = System.Drawing.Color.Transparent;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.btnHoaDon.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnHoaDon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnHoaDon.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 210);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(220, 50);
            this.btnHoaDon.TabIndex = 10;
            this.btnHoaDon.Text = "💵 Hóa Đơn";
            this.btnHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHoaDon.TextOffset = new System.Drawing.Point(15, 0);
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnDatMon
            // 
            this.btnDatMon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDatMon.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnDatMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatMon.FillColor = System.Drawing.Color.Transparent;
            this.btnDatMon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDatMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.btnDatMon.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnDatMon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDatMon.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDatMon.Location = new System.Drawing.Point(0, 160);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(220, 50);
            this.btnDatMon.TabIndex = 3;
            this.btnDatMon.Text = "☕ Đặt Món";
            this.btnDatMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDatMon.TextOffset = new System.Drawing.Point(15, 0);
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
            // 
            // btnQuanLyBan
            // 
            this.btnQuanLyBan.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnQuanLyBan.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnQuanLyBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyBan.FillColor = System.Drawing.Color.Transparent;
            this.btnQuanLyBan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.btnQuanLyBan.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnQuanLyBan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnQuanLyBan.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyBan.Location = new System.Drawing.Point(0, 110);
            this.btnQuanLyBan.Name = "btnQuanLyBan";
            this.btnQuanLyBan.Size = new System.Drawing.Size(220, 50);
            this.btnQuanLyBan.TabIndex = 2;
            this.btnQuanLyBan.Text = "📋 Sơ Đồ Bàn";
            this.btnQuanLyBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyBan.TextOffset = new System.Drawing.Point(15, 0);
            this.btnQuanLyBan.Click += new System.EventHandler(this.btnQuanLyBan_Click);
            // 
            // btnThucDon
            // 
            this.btnThucDon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnThucDon.CustomBorderThickness = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnThucDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThucDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThucDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThucDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThucDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThucDon.FillColor = System.Drawing.Color.Transparent;
            this.btnThucDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThucDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.btnThucDon.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.btnThucDon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnThucDon.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThucDon.Location = new System.Drawing.Point(0, 60);
            this.btnThucDon.Name = "btnThucDon";
            this.btnThucDon.Size = new System.Drawing.Size(220, 50);
            this.btnThucDon.TabIndex = 1;
            this.btnThucDon.Text = "📖 Menu Món";
            this.btnThucDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThucDon.TextOffset = new System.Drawing.Point(15, 0);
            this.btnThucDon.Click += new System.EventHandler(this.btnThucDon_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(32)))), ((int)(((byte)(24)))));
            this.panelLogo.Controls.Add(this.btnToggleSidebar);
            this.panelLogo.Controls.Add(this.lblAppName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // btnToggleSidebar
            // 
            this.btnToggleSidebar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToggleSidebar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToggleSidebar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToggleSidebar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToggleSidebar.FillColor = System.Drawing.Color.Transparent;
            this.btnToggleSidebar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToggleSidebar.ForeColor = System.Drawing.Color.White;
            this.btnToggleSidebar.Location = new System.Drawing.Point(175, 15);
            this.btnToggleSidebar.Name = "btnToggleSidebar";
            this.btnToggleSidebar.Size = new System.Drawing.Size(35, 30);
            this.btnToggleSidebar.TabIndex = 1;
            this.btnToggleSidebar.Text = "☰";
            this.btnToggleSidebar.Click += new System.EventHandler(this.btnToggleSidebar_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(15, 18);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(126, 25);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "COFFEE APP";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblUserInfo);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.controlBoxClose);
            this.panelHeader.Controls.Add(this.controlBoxMax);
            this.panelHeader.Controls.Add(this.controlBoxMin);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.panelHeader.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(71)))), ((int)(((byte)(54)))));
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(880, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.lblUserInfo.Location = new System.Drawing.Point(495, 18);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(250, 25);
            this.lblUserInfo.TabIndex = 4;
            this.lblUserInfo.Text = "Chào, Quản Trị Viên (Admin)";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Thực Đơn Quán";
            // 
            // 
            // controlBoxClose
            // 
            this.controlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.controlBoxClose.BorderRadius = 6;
            this.controlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.controlBoxClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(29)))), ((int)(((byte)(72)))));
            this.controlBoxClose.HoverState.IconColor = System.Drawing.Color.White;
            this.controlBoxClose.IconColor = System.Drawing.Color.White;
            this.controlBoxClose.Location = new System.Drawing.Point(830, 10);
            this.controlBoxClose.Name = "controlBoxClose";
            this.controlBoxClose.Size = new System.Drawing.Size(40, 40);
            this.controlBoxClose.TabIndex = 2;
            this.controlBoxClose.UseTransparentBackground = true;
            // 
            // controlBoxMax
            // 
            this.controlBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBoxMax.BackColor = System.Drawing.Color.Transparent;
            this.controlBoxMax.BorderRadius = 6;
            this.controlBoxMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.controlBoxMax.FillColor = System.Drawing.Color.Transparent;
            this.controlBoxMax.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(75)))), ((int)(((byte)(52)))));
            this.controlBoxMax.HoverState.IconColor = System.Drawing.Color.White;
            this.controlBoxMax.IconColor = System.Drawing.Color.White;
            this.controlBoxMax.Location = new System.Drawing.Point(785, 10);
            this.controlBoxMax.Name = "controlBoxMax";
            this.controlBoxMax.Size = new System.Drawing.Size(40, 40);
            this.controlBoxMax.TabIndex = 1;
            this.controlBoxMax.UseTransparentBackground = true;
            // 
            // controlBoxMin
            // 
            this.controlBoxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlBoxMin.BackColor = System.Drawing.Color.Transparent;
            this.controlBoxMin.BorderRadius = 6;
            this.controlBoxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlBoxMin.FillColor = System.Drawing.Color.Transparent;
            this.controlBoxMin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(75)))), ((int)(((byte)(52)))));
            this.controlBoxMin.HoverState.IconColor = System.Drawing.Color.White;
            this.controlBoxMin.IconColor = System.Drawing.Color.White;
            this.controlBoxMin.Location = new System.Drawing.Point(740, 10);
            this.controlBoxMin.Name = "controlBoxMin";
            this.controlBoxMin.Size = new System.Drawing.Size(40, 40);
            this.controlBoxMin.TabIndex = 0;
            this.controlBoxMin.UseTransparentBackground = true;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 60);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(880, 640);
            this.panelContent.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockForm = true;
            this.guna2DragControl1.TargetControl = this.panelHeader;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 12;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Quán Cafe";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panelSidebar;
        private Guna.UI2.WinForms.Guna2Button btnThucDon;
        private Guna.UI2.WinForms.Guna2Panel panelLogo;
        private System.Windows.Forms.Label lblAppName;
        private Guna.UI2.WinForms.Guna2GradientPanel panelHeader;
        private Guna.UI2.WinForms.Guna2ControlBox controlBoxClose;
        private Guna.UI2.WinForms.Guna2ControlBox controlBoxMax;
        private Guna.UI2.WinForms.Guna2ControlBox controlBoxMin;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyThucDon;
        private Guna.UI2.WinForms.Guna2Button btnDonHang;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnDatMon;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyBan;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnToggleSidebar;
        private System.Windows.Forms.Label lblUserInfo;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}

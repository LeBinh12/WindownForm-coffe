namespace QuanLyQuanCafe.Presentation
{
    partial class FormChiTietMon
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
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.lblImagePlaceholder = new System.Windows.Forms.Label();
            this.picMon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.cbBan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSelectBan = new System.Windows.Forms.Label();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatMon = new Guna.UI2.WinForms.Guna2Button();
            this.numSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMon)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
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
            this.guna2DragControl1.TargetControl = this;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.panelLeft.Controls.Add(this.lblImagePlaceholder);
            this.panelLeft.Controls.Add(this.picMon);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(240, 400);
            this.panelLeft.TabIndex = 0;
            // 
            // lblImagePlaceholder
            // 
            this.lblImagePlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.lblImagePlaceholder.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImagePlaceholder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(71)))), ((int)(((byte)(54)))));
            this.lblImagePlaceholder.Location = new System.Drawing.Point(12, 80);
            this.lblImagePlaceholder.Name = "lblImagePlaceholder";
            this.lblImagePlaceholder.Size = new System.Drawing.Size(216, 220);
            this.lblImagePlaceholder.TabIndex = 1;
            this.lblImagePlaceholder.Text = "☕";
            this.lblImagePlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMon
            // 
            this.picMon.BorderRadius = 12;
            this.picMon.FillColor = System.Drawing.Color.Transparent;
            this.picMon.ImageRotate = 0F;
            this.picMon.Location = new System.Drawing.Point(12, 12);
            this.picMon.Name = "picMon";
            this.picMon.Size = new System.Drawing.Size(216, 376);
            this.picMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMon.TabIndex = 0;
            this.picMon.TabStop = false;
            this.picMon.Visible = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panelRight.Controls.Add(this.cbBan);
            this.panelRight.Controls.Add(this.lblSelectBan);
            this.panelRight.Controls.Add(this.btnDong);
            this.panelRight.Controls.Add(this.btnDatMon);
            this.panelRight.Controls.Add(this.numSoLuong);
            this.panelRight.Controls.Add(this.lblQty);
            this.panelRight.Controls.Add(this.lblMoTa);
            this.panelRight.Controls.Add(this.lblGia);
            this.panelRight.Controls.Add(this.lblTrangThai);
            this.panelRight.Controls.Add(this.lblLoai);
            this.panelRight.Controls.Add(this.lblTenMon);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(240, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(360, 400);
            this.panelRight.TabIndex = 1;
            // 
            // cbBan
            // 
            this.cbBan.BackColor = System.Drawing.Color.Transparent;
            this.cbBan.BorderRadius = 6;
            this.cbBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.cbBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBan.ItemHeight = 30;
            this.cbBan.Location = new System.Drawing.Point(100, 230);
            this.cbBan.Name = "cbBan";
            this.cbBan.Size = new System.Drawing.Size(235, 36);
            this.cbBan.TabIndex = 10;
            // 
            // lblSelectBan
            // 
            this.lblSelectBan.AutoSize = true;
            this.lblSelectBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblSelectBan.Location = new System.Drawing.Point(20, 240);
            this.lblSelectBan.Name = "lblSelectBan";
            this.lblSelectBan.Size = new System.Drawing.Size(66, 17);
            this.lblSelectBan.TabIndex = 9;
            this.lblSelectBan.Text = "Chọn bàn:";
            // 
            // btnDong
            // 
            this.btnDong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDong.BorderRadius = 8;
            this.btnDong.BorderThickness = 1;
            this.btnDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDong.FillColor = System.Drawing.Color.Transparent;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDong.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(226)))), ((int)(((byte)(211)))));
            this.btnDong.Location = new System.Drawing.Point(190, 335);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(145, 45);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnDatMon
            // 
            this.btnDatMon.BorderRadius = 8;
            this.btnDatMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnDatMon.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatMon.ForeColor = System.Drawing.Color.White;
            this.btnDatMon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(71)))), ((int)(((byte)(54)))));
            this.btnDatMon.Location = new System.Drawing.Point(23, 335);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(145, 45);
            this.btnDatMon.TabIndex = 7;
            this.btnDatMon.Text = "Đặt Món";
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.numSoLuong.BorderRadius = 6;
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSoLuong.Location = new System.Drawing.Point(100, 280);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 36);
            this.numSoLuong.TabIndex = 6;
            this.numSoLuong.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblQty.Location = new System.Drawing.Point(20, 290);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(65, 17);
            this.lblQty.TabIndex = 5;
            this.lblQty.Text = "Số lượng:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoTa.ForeColor = System.Drawing.Color.DimGray;
            this.lblMoTa.Location = new System.Drawing.Point(20, 140);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(315, 80);
            this.lblMoTa.TabIndex = 4;
            this.lblMoTa.Text = "Mô tả hương vị món nước, thơm ngon, đậm đà.";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.lblGia.Location = new System.Drawing.Point(20, 100);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(99, 25);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "29.000 đ";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrangThai.ForeColor = System.Drawing.Color.Green;
            this.lblTrangThai.Location = new System.Drawing.Point(120, 68);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(63, 17);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Còn bán";
            // 
            // lblLoai
            // 
            this.lblLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(151)))), ((int)(((byte)(128)))));
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoai.ForeColor = System.Drawing.Color.White;
            this.lblLoai.Location = new System.Drawing.Point(20, 65);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(80, 22);
            this.lblLoai.TabIndex = 1;
            this.lblLoai.Text = "Cà phê";
            this.lblLoai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblTenMon.Location = new System.Drawing.Point(17, 20);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(193, 30);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Tên Món Nước Cực";
            // 
            // FormChiTietMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChiTietMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Món";
            this.Load += new System.EventHandler(this.FormChiTietMon_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMon)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private System.Windows.Forms.Label lblImagePlaceholder;
        private Guna.UI2.WinForms.Guna2PictureBox picMon;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblQty;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoLuong;
        private Guna.UI2.WinForms.Guna2Button btnDong;
        private Guna.UI2.WinForms.Guna2Button btnDatMon;
        private Guna.UI2.WinForms.Guna2ComboBox cbBan;
        private System.Windows.Forms.Label lblSelectBan;
    }
}

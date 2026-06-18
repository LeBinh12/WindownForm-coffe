namespace QuanLyQuanCafe.Presentation
{
    partial class FormThemBan
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
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.txtTenBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoChoNgoi = new System.Windows.Forms.Label();
            this.numSoCho = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCho)).BeginInit();
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
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(360, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(360, 50);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "THÔNG TIN BÀN";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblTenBan.Location = new System.Drawing.Point(30, 75);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(59, 17);
            this.lblTenBan.TabIndex = 1;
            this.lblTenBan.Text = "Tên bàn:";
            // 
            // txtTenBan
            // 
            this.txtTenBan.BorderRadius = 8;
            this.txtTenBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenBan.DefaultText = "";
            this.txtTenBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.txtTenBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenBan.ForeColor = System.Drawing.Color.Black;
            this.txtTenBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.txtTenBan.Location = new System.Drawing.Point(30, 98);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.PasswordChar = '\0';
            this.txtTenBan.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.txtTenBan.PlaceholderText = "Nhập tên bàn (ví dụ: Bàn 9)...";
            this.txtTenBan.SelectedText = "";
            this.txtTenBan.Size = new System.Drawing.Size(300, 36);
            this.txtTenBan.TabIndex = 2;
            // 
            // lblSoChoNgoi
            // 
            this.lblSoChoNgoi.AutoSize = true;
            this.lblSoChoNgoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoChoNgoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.lblSoChoNgoi.Location = new System.Drawing.Point(30, 155);
            this.lblSoChoNgoi.Name = "lblSoChoNgoi";
            this.lblSoChoNgoi.Size = new System.Drawing.Size(83, 17);
            this.lblSoChoNgoi.TabIndex = 3;
            this.lblSoChoNgoi.Text = "Số chỗ ngồi:";
            // 
            // numSoCho
            // 
            this.numSoCho.BackColor = System.Drawing.Color.Transparent;
            this.numSoCho.BorderRadius = 8;
            this.numSoCho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSoCho.Location = new System.Drawing.Point(30, 178);
            this.numSoCho.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoCho.Name = "numSoCho";
            this.numSoCho.Size = new System.Drawing.Size(300, 36);
            this.numSoCho.TabIndex = 4;
            this.numSoCho.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.numSoCho.UpDownButtonForeColor = System.Drawing.Color.White;
            this.numSoCho.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 8;
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(41)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(75)))), ((int)(((byte)(52)))));
            this.btnLuu.Location = new System.Drawing.Point(40, 245);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 36);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 8;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(175)))), ((int)(((byte)(165)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(125)))));
            this.btnHuy.Location = new System.Drawing.Point(200, 245);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 36);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormThemBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(360, 310);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.numSoCho);
            this.Controls.Add(this.lblSoChoNgoi);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.lblTenBan);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông Tin Bàn";
            this.Load += new System.EventHandler(this.FormThemBan_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSoCho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblTenBan;
        private Guna.UI2.WinForms.Guna2TextBox txtTenBan;
        private System.Windows.Forms.Label lblSoChoNgoi;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSoCho;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}

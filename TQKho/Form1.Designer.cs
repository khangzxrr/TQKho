namespace TQKho
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnMenu = new System.Windows.Forms.Panel();
            this.btnTrucQuan = new FontAwesome.Sharp.IconButton();
            this.btnXuatKho = new FontAwesome.Sharp.IconButton();
            this.btnNhapKho = new FontAwesome.Sharp.IconButton();
            this.btnTongQuan = new FontAwesome.Sharp.IconButton();
            this.PnLogo = new System.Windows.Forms.Panel();
            this.btnTrangChu = new System.Windows.Forms.PictureBox();
            this.PnTitlebar = new System.Windows.Forms.Panel();
            this.btnZoomOut = new FontAwesome.Sharp.IconButton();
            this.btnZoomIn = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.LbTrangChu = new System.Windows.Forms.Label();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnTatNguon = new System.Windows.Forms.Panel();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.PnMenu.SuspendLayout();
            this.PnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrangChu)).BeginInit();
            this.PnTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // PnMenu
            // 
            this.PnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PnMenu.Controls.Add(this.btnTrucQuan);
            this.PnMenu.Controls.Add(this.btnXuatKho);
            this.PnMenu.Controls.Add(this.btnNhapKho);
            this.PnMenu.Controls.Add(this.btnTongQuan);
            this.PnMenu.Controls.Add(this.PnLogo);
            this.PnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnMenu.Location = new System.Drawing.Point(0, 0);
            this.PnMenu.Name = "PnMenu";
            this.PnMenu.Size = new System.Drawing.Size(220, 617);
            this.PnMenu.TabIndex = 0;
            // 
            // btnTrucQuan
            // 
            this.btnTrucQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrucQuan.FlatAppearance.BorderSize = 0;
            this.btnTrucQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrucQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrucQuan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTrucQuan.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnTrucQuan.IconColor = System.Drawing.Color.White;
            this.btnTrucQuan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrucQuan.IconSize = 36;
            this.btnTrucQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrucQuan.Location = new System.Drawing.Point(0, 300);
            this.btnTrucQuan.Name = "btnTrucQuan";
            this.btnTrucQuan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTrucQuan.Size = new System.Drawing.Size(220, 60);
            this.btnTrucQuan.TabIndex = 4;
            this.btnTrucQuan.Text = "Trực Quan";
            this.btnTrucQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrucQuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrucQuan.UseVisualStyleBackColor = true;
            this.btnTrucQuan.Click += new System.EventHandler(this.btnTrucQuan_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXuatKho.FlatAppearance.BorderSize = 0;
            this.btnXuatKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXuatKho.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXuatKho.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnXuatKho.IconColor = System.Drawing.Color.White;
            this.btnXuatKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatKho.IconSize = 36;
            this.btnXuatKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatKho.Location = new System.Drawing.Point(0, 240);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnXuatKho.Size = new System.Drawing.Size(220, 60);
            this.btnXuatKho.TabIndex = 3;
            this.btnXuatKho.Text = "Xuất Kho";
            this.btnXuatKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatKho.UseVisualStyleBackColor = true;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhapKho.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhapKho.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btnNhapKho.IconColor = System.Drawing.Color.White;
            this.btnNhapKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapKho.IconSize = 36;
            this.btnNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapKho.Location = new System.Drawing.Point(0, 180);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhapKho.Size = new System.Drawing.Size(220, 60);
            this.btnNhapKho.TabIndex = 2;
            this.btnNhapKho.Text = "Nhập Kho";
            this.btnNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapKho.UseVisualStyleBackColor = true;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTongQuan.FlatAppearance.BorderSize = 0;
            this.btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTongQuan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTongQuan.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnTongQuan.IconColor = System.Drawing.Color.White;
            this.btnTongQuan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTongQuan.IconSize = 36;
            this.btnTongQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.Location = new System.Drawing.Point(0, 120);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTongQuan.Size = new System.Drawing.Size(220, 60);
            this.btnTongQuan.TabIndex = 1;
            this.btnTongQuan.Text = "Tổng Quan";
            this.btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTongQuan.UseVisualStyleBackColor = true;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // PnLogo
            // 
            this.PnLogo.Controls.Add(this.btnTrangChu);
            this.PnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLogo.Location = new System.Drawing.Point(0, 0);
            this.PnLogo.Name = "PnLogo";
            this.PnLogo.Size = new System.Drawing.Size(220, 120);
            this.PnLogo.TabIndex = 0;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Image = global::TQKho.Properties.Resources.pngaaa_com_3682042__1_;
            this.btnTrangChu.Location = new System.Drawing.Point(38, 26);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(138, 59);
            this.btnTrangChu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.TabStop = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // PnTitlebar
            // 
            this.PnTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.PnTitlebar.Controls.Add(this.btnZoomOut);
            this.PnTitlebar.Controls.Add(this.btnZoomIn);
            this.PnTitlebar.Controls.Add(this.btnExit);
            this.PnTitlebar.Controls.Add(this.LbTrangChu);
            this.PnTitlebar.Controls.Add(this.IconCurrentChildForm);
            this.PnTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnTitlebar.Location = new System.Drawing.Point(220, 0);
            this.PnTitlebar.Name = "PnTitlebar";
            this.PnTitlebar.Size = new System.Drawing.Size(1119, 80);
            this.PnTitlebar.TabIndex = 1;
            this.PnTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnTitlebar_MouseDown);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnZoomOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnZoomOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZoomOut.IconSize = 30;
            this.btnZoomOut.Location = new System.Drawing.Point(1029, 0);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(25, 25);
            this.btnZoomOut.TabIndex = 4;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIn.FlatAppearance.BorderSize = 0;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnZoomIn.IconColor = System.Drawing.Color.Gainsboro;
            this.btnZoomIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnZoomIn.IconSize = 30;
            this.btnZoomIn.Location = new System.Drawing.Point(1060, 3);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(25, 25);
            this.btnZoomIn.TabIndex = 3;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1091, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LbTrangChu
            // 
            this.LbTrangChu.AutoSize = true;
            this.LbTrangChu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbTrangChu.ForeColor = System.Drawing.Color.Gainsboro;
            this.LbTrangChu.Location = new System.Drawing.Point(53, 33);
            this.LbTrangChu.Name = "LbTrangChu";
            this.LbTrangChu.Size = new System.Drawing.Size(61, 15);
            this.LbTrangChu.TabIndex = 1;
            this.LbTrangChu.Text = "Trang chủ";
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconCurrentChildForm.ForeColor = System.Drawing.Color.DarkViolet;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.DarkViolet;
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(15, 26);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.IconCurrentChildForm.TabIndex = 0;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // pnTatNguon
            // 
            this.pnTatNguon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnTatNguon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTatNguon.Location = new System.Drawing.Point(220, 80);
            this.pnTatNguon.Name = "pnTatNguon";
            this.pnTatNguon.Size = new System.Drawing.Size(1119, 10);
            this.pnTatNguon.TabIndex = 2;
            // 
            // pnDesktop
            // 
            this.pnDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pnDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesktop.Location = new System.Drawing.Point(220, 90);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(1119, 527);
            this.pnDesktop.TabIndex = 3;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 617);
            this.Controls.Add(this.pnDesktop);
            this.Controls.Add(this.pnTatNguon);
            this.Controls.Add(this.PnTitlebar);
            this.Controls.Add(this.PnMenu);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.PnMenu.ResumeLayout(false);
            this.PnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnTrangChu)).EndInit();
            this.PnTitlebar.ResumeLayout(false);
            this.PnTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnMenu;
        private Panel PnLogo;
        private FontAwesome.Sharp.IconButton btnTrucQuan;
        private FontAwesome.Sharp.IconButton btnXuatKho;
        private FontAwesome.Sharp.IconButton btnNhapKho;
        private FontAwesome.Sharp.IconButton btnTongQuan;
        private PictureBox btnTrangChu;
        private Panel PnTitlebar;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private Label LbTrangChu;
        private Panel pnTatNguon;
        private Panel pnDesktop;
        private FontAwesome.Sharp.IconButton btnZoomOut;
        private FontAwesome.Sharp.IconButton btnZoomIn;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}
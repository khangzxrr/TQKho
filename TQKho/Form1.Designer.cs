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
            PnMenu = new Panel();
            btnTrucQuan = new FontAwesome.Sharp.IconButton();
            btnXuatKho = new FontAwesome.Sharp.IconButton();
            btnNhapKho = new FontAwesome.Sharp.IconButton();
            btnTongQuan = new FontAwesome.Sharp.IconButton();
            PnLogo = new Panel();
            btnTrangChu = new PictureBox();
            PnTitlebar = new Panel();
            btnZoomOut = new FontAwesome.Sharp.IconButton();
            btnZoomIn = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            LbTrangChu = new Label();
            IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            pnTatNguon = new Panel();
            pnDesktop = new Panel();
            PnMenu.SuspendLayout();
            PnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnTrangChu).BeginInit();
            PnTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // PnMenu
            // 
            PnMenu.BackColor = Color.FromArgb(31, 30, 68);
            PnMenu.Controls.Add(btnTrucQuan);
            PnMenu.Controls.Add(btnXuatKho);
            PnMenu.Controls.Add(btnNhapKho);
            PnMenu.Controls.Add(btnTongQuan);
            PnMenu.Controls.Add(PnLogo);
            PnMenu.Dock = DockStyle.Left;
            PnMenu.Location = new Point(0, 0);
            PnMenu.Margin = new Padding(3, 4, 3, 4);
            PnMenu.Name = "PnMenu";
            PnMenu.Size = new Size(251, 823);
            PnMenu.TabIndex = 0;
            // 
            // btnTrucQuan
            // 
            btnTrucQuan.Dock = DockStyle.Top;
            btnTrucQuan.FlatAppearance.BorderSize = 0;
            btnTrucQuan.FlatStyle = FlatStyle.Flat;
            btnTrucQuan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrucQuan.ForeColor = Color.Gainsboro;
            btnTrucQuan.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnTrucQuan.IconColor = Color.White;
            btnTrucQuan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTrucQuan.IconSize = 36;
            btnTrucQuan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrucQuan.Location = new Point(0, 400);
            btnTrucQuan.Margin = new Padding(3, 4, 3, 4);
            btnTrucQuan.Name = "btnTrucQuan";
            btnTrucQuan.Padding = new Padding(11, 0, 0, 0);
            btnTrucQuan.Size = new Size(251, 80);
            btnTrucQuan.TabIndex = 4;
            btnTrucQuan.Text = "Trực Quan";
            btnTrucQuan.TextAlign = ContentAlignment.MiddleLeft;
            btnTrucQuan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrucQuan.UseVisualStyleBackColor = true;
            btnTrucQuan.Click += btnTrucQuan_Click;
            // 
            // btnXuatKho
            // 
            btnXuatKho.Dock = DockStyle.Top;
            btnXuatKho.FlatAppearance.BorderSize = 0;
            btnXuatKho.FlatStyle = FlatStyle.Flat;
            btnXuatKho.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXuatKho.ForeColor = Color.Gainsboro;
            btnXuatKho.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            btnXuatKho.IconColor = Color.White;
            btnXuatKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnXuatKho.IconSize = 36;
            btnXuatKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatKho.Location = new Point(0, 320);
            btnXuatKho.Margin = new Padding(3, 4, 3, 4);
            btnXuatKho.Name = "btnXuatKho";
            btnXuatKho.Padding = new Padding(11, 0, 0, 0);
            btnXuatKho.Size = new Size(251, 80);
            btnXuatKho.TabIndex = 3;
            btnXuatKho.Text = "Xuất Kho";
            btnXuatKho.TextAlign = ContentAlignment.MiddleLeft;
            btnXuatKho.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuatKho.UseVisualStyleBackColor = true;
            btnXuatKho.Click += btnXuatKho_Click;
            // 
            // btnNhapKho
            // 
            btnNhapKho.Dock = DockStyle.Top;
            btnNhapKho.FlatAppearance.BorderSize = 0;
            btnNhapKho.FlatStyle = FlatStyle.Flat;
            btnNhapKho.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNhapKho.ForeColor = Color.Gainsboro;
            btnNhapKho.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            btnNhapKho.IconColor = Color.White;
            btnNhapKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhapKho.IconSize = 36;
            btnNhapKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapKho.Location = new Point(0, 240);
            btnNhapKho.Margin = new Padding(3, 4, 3, 4);
            btnNhapKho.Name = "btnNhapKho";
            btnNhapKho.Padding = new Padding(11, 0, 0, 0);
            btnNhapKho.Size = new Size(251, 80);
            btnNhapKho.TabIndex = 2;
            btnNhapKho.Text = "Nhập Kho";
            btnNhapKho.TextAlign = ContentAlignment.MiddleLeft;
            btnNhapKho.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhapKho.UseVisualStyleBackColor = true;
            btnNhapKho.Click += btnNhapKho_Click;
            // 
            // btnTongQuan
            // 
            btnTongQuan.Dock = DockStyle.Top;
            btnTongQuan.FlatAppearance.BorderSize = 0;
            btnTongQuan.FlatStyle = FlatStyle.Flat;
            btnTongQuan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTongQuan.ForeColor = Color.Gainsboro;
            btnTongQuan.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            btnTongQuan.IconColor = Color.White;
            btnTongQuan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTongQuan.IconSize = 36;
            btnTongQuan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTongQuan.Location = new Point(0, 160);
            btnTongQuan.Margin = new Padding(3, 4, 3, 4);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Padding = new Padding(11, 0, 0, 0);
            btnTongQuan.Size = new Size(251, 80);
            btnTongQuan.TabIndex = 1;
            btnTongQuan.Text = "Tổng Quan";
            btnTongQuan.TextAlign = ContentAlignment.MiddleLeft;
            btnTongQuan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTongQuan.UseVisualStyleBackColor = true;
            btnTongQuan.Click += btnTongQuan_Click;
            // 
            // PnLogo
            // 
            PnLogo.Controls.Add(btnTrangChu);
            PnLogo.Dock = DockStyle.Top;
            PnLogo.Location = new Point(0, 0);
            PnLogo.Margin = new Padding(3, 4, 3, 4);
            PnLogo.Name = "PnLogo";
            PnLogo.Size = new Size(251, 160);
            PnLogo.TabIndex = 0;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Image = Properties.Resources.pngaaa_com_3682042__1_;
            btnTrangChu.Location = new Point(43, 35);
            btnTrangChu.Margin = new Padding(3, 4, 3, 4);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(158, 79);
            btnTrangChu.SizeMode = PictureBoxSizeMode.Zoom;
            btnTrangChu.TabIndex = 0;
            btnTrangChu.TabStop = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // PnTitlebar
            // 
            PnTitlebar.BackColor = Color.FromArgb(26, 25, 62);
            PnTitlebar.Controls.Add(btnZoomOut);
            PnTitlebar.Controls.Add(btnZoomIn);
            PnTitlebar.Controls.Add(btnExit);
            PnTitlebar.Controls.Add(LbTrangChu);
            PnTitlebar.Controls.Add(IconCurrentChildForm);
            PnTitlebar.Dock = DockStyle.Top;
            PnTitlebar.Location = new Point(251, 0);
            PnTitlebar.Margin = new Padding(3, 4, 3, 4);
            PnTitlebar.Name = "PnTitlebar";
            PnTitlebar.Size = new Size(1279, 107);
            PnTitlebar.TabIndex = 1;
            PnTitlebar.MouseDown += PnTitlebar_MouseDown;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZoomOut.FlatAppearance.BorderSize = 0;
            btnZoomOut.FlatStyle = FlatStyle.Flat;
            btnZoomOut.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnZoomOut.IconColor = Color.Gainsboro;
            btnZoomOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnZoomOut.IconSize = 30;
            btnZoomOut.Location = new Point(1176, 0);
            btnZoomOut.Margin = new Padding(3, 4, 3, 4);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(29, 33);
            btnZoomOut.TabIndex = 4;
            btnZoomOut.UseVisualStyleBackColor = true;
            btnZoomOut.Click += btnZoomOut_Click;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnZoomIn.FlatAppearance.BorderSize = 0;
            btnZoomIn.FlatStyle = FlatStyle.Flat;
            btnZoomIn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnZoomIn.IconColor = Color.Gainsboro;
            btnZoomIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnZoomIn.IconSize = 30;
            btnZoomIn.Location = new Point(1211, 4);
            btnZoomIn.Margin = new Padding(3, 4, 3, 4);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(29, 33);
            btnZoomIn.TabIndex = 3;
            btnZoomIn.UseVisualStyleBackColor = true;
            btnZoomIn.Click += btnZoomIn_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 30;
            btnExit.Location = new Point(1247, 4);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 33);
            btnExit.TabIndex = 2;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LbTrangChu
            // 
            LbTrangChu.AutoSize = true;
            LbTrangChu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LbTrangChu.ForeColor = Color.Gainsboro;
            LbTrangChu.Location = new Point(61, 44);
            LbTrangChu.Name = "LbTrangChu";
            LbTrangChu.Size = new Size(78, 20);
            LbTrangChu.TabIndex = 1;
            LbTrangChu.Text = "Trang chủ";
            // 
            // IconCurrentChildForm
            // 
            IconCurrentChildForm.BackColor = Color.FromArgb(26, 25, 62);
            IconCurrentChildForm.ForeColor = Color.DarkViolet;
            IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            IconCurrentChildForm.IconColor = Color.DarkViolet;
            IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconCurrentChildForm.IconSize = 37;
            IconCurrentChildForm.Location = new Point(17, 35);
            IconCurrentChildForm.Margin = new Padding(3, 4, 3, 4);
            IconCurrentChildForm.Name = "IconCurrentChildForm";
            IconCurrentChildForm.Size = new Size(37, 43);
            IconCurrentChildForm.TabIndex = 0;
            IconCurrentChildForm.TabStop = false;
            // 
            // pnTatNguon
            // 
            pnTatNguon.BackColor = Color.FromArgb(26, 24, 58);
            pnTatNguon.Dock = DockStyle.Top;
            pnTatNguon.Location = new Point(251, 107);
            pnTatNguon.Margin = new Padding(3, 4, 3, 4);
            pnTatNguon.Name = "pnTatNguon";
            pnTatNguon.Size = new Size(1279, 13);
            pnTatNguon.TabIndex = 2;
            // 
            // pnDesktop
            // 
            pnDesktop.BackColor = Color.FromArgb(34, 33, 74);
            pnDesktop.Dock = DockStyle.Fill;
            pnDesktop.Location = new Point(251, 120);
            pnDesktop.Margin = new Padding(3, 4, 3, 4);
            pnDesktop.Name = "pnDesktop";
            pnDesktop.Size = new Size(1279, 703);
            pnDesktop.TabIndex = 3;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1530, 823);
            Controls.Add(pnDesktop);
            Controls.Add(pnTatNguon);
            Controls.Add(PnTitlebar);
            Controls.Add(PnMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenu";
            Text = "Menu";
            FormClosing += ClosingForm;
            PnMenu.ResumeLayout(false);
            PnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnTrangChu).EndInit();
            PnTitlebar.ResumeLayout(false);
            PnTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconCurrentChildForm).EndInit();
            ResumeLayout(false);
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
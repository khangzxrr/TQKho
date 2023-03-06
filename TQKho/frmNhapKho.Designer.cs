namespace TQKho
{
    partial class frmNhapKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            dataGridViewProducts = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            poCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shelfCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            iconToolStripButton2 = new FontAwesome.Sharp.IconToolStripButton();
            iconToolStripButton3 = new FontAwesome.Sharp.IconToolStripButton();
            iconToolStripButton4 = new FontAwesome.Sharp.IconToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            iconToolStripButton5 = new FontAwesome.Sharp.IconToolStripButton();
            groupBox2 = new GroupBox();
            exportBtn = new Button();
            productShelfTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            productQuantityTextBox = new TextBox();
            productCodeTextBox = new TextBox();
            productNameTextBox = new TextBox();
            poTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewProducts);
            groupBox1.Controls.Add(toolStrip1);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.ForeColor = Color.Gainsboro;
            groupBox1.Location = new Point(781, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(849, 651);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.BackgroundColor = SystemColors.MenuBar;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, poCodeDataGridViewTextBoxColumn, productCodeDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, shelfCodeDataGridViewTextBoxColumn });
            dataGridViewProducts.DataSource = productBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProducts.Location = new Point(3, 55);
            dataGridViewProducts.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.RowTemplate.Height = 25;
            dataGridViewProducts.Size = new Size(840, 591);
            dataGridViewProducts.TabIndex = 1;
            dataGridViewProducts.CellClick += cellClick;
            dataGridViewProducts.CellValidating += cellValidating;
            dataGridViewProducts.DataError += dataGridViewProducts_DataError;
            dataGridViewProducts.SelectionChanged += productGridView_SelectionChanged;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            productIdDataGridViewTextBoxColumn.HeaderText = "productId";
            productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Width = 103;
            // 
            // poCodeDataGridViewTextBoxColumn
            // 
            poCodeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            poCodeDataGridViewTextBoxColumn.DataPropertyName = "poCode";
            poCodeDataGridViewTextBoxColumn.HeaderText = "poCode";
            poCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            poCodeDataGridViewTextBoxColumn.Name = "poCodeDataGridViewTextBoxColumn";
            poCodeDataGridViewTextBoxColumn.ReadOnly = true;
            poCodeDataGridViewTextBoxColumn.Width = 91;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            productCodeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            productCodeDataGridViewTextBoxColumn.DataPropertyName = "productCode";
            productCodeDataGridViewTextBoxColumn.HeaderText = "productCode";
            productCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            productCodeDataGridViewTextBoxColumn.ReadOnly = true;
            productCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 92;
            // 
            // shelfCodeDataGridViewTextBoxColumn
            // 
            shelfCodeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            shelfCodeDataGridViewTextBoxColumn.DataPropertyName = "shelfCode";
            shelfCodeDataGridViewTextBoxColumn.HeaderText = "shelfCode";
            shelfCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            shelfCodeDataGridViewTextBoxColumn.Name = "shelfCodeDataGridViewTextBoxColumn";
            shelfCodeDataGridViewTextBoxColumn.ReadOnly = true;
            shelfCodeDataGridViewTextBoxColumn.Width = 104;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { iconToolStripButton1, iconToolStripButton2, iconToolStripButton3, iconToolStripButton4, toolStripSeparator1, toolStripLabel1, toolStripTextBox1, iconToolStripButton5 });
            toolStrip1.Location = new Point(3, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(843, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // iconToolStripButton1
            // 
            iconToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            iconToolStripButton1.IconColor = Color.Green;
            iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton1.IconSize = 30;
            iconToolStripButton1.ImageTransparentColor = Color.Magenta;
            iconToolStripButton1.Name = "iconToolStripButton1";
            iconToolStripButton1.Size = new Size(29, 24);
            iconToolStripButton1.Text = "iconToolStripButton1";
            iconToolStripButton1.Click += createButton_onClick;
            // 
            // iconToolStripButton2
            // 
            iconToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconToolStripButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconToolStripButton2.IconColor = Color.FromArgb(192, 0, 0);
            iconToolStripButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton2.IconSize = 30;
            iconToolStripButton2.ImageTransparentColor = Color.Magenta;
            iconToolStripButton2.Name = "iconToolStripButton2";
            iconToolStripButton2.Size = new Size(29, 24);
            iconToolStripButton2.Text = "iconToolStripButton2";
            iconToolStripButton2.Click += deleteButton_onClick;
            // 
            // iconToolStripButton3
            // 
            iconToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconToolStripButton3.IconChar = FontAwesome.Sharp.IconChar.Pen;
            iconToolStripButton3.IconColor = Color.Black;
            iconToolStripButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton3.IconSize = 30;
            iconToolStripButton3.ImageTransparentColor = Color.Magenta;
            iconToolStripButton3.Name = "iconToolStripButton3";
            iconToolStripButton3.Size = new Size(29, 24);
            iconToolStripButton3.Text = "iconToolStripButton3";
            iconToolStripButton3.Click += editButton_onClick;
            // 
            // iconToolStripButton4
            // 
            iconToolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconToolStripButton4.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconToolStripButton4.IconColor = Color.Navy;
            iconToolStripButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconToolStripButton4.IconSize = 30;
            iconToolStripButton4.ImageTransparentColor = Color.Magenta;
            iconToolStripButton4.Name = "iconToolStripButton4";
            iconToolStripButton4.Size = new Size(29, 24);
            iconToolStripButton4.Text = "iconToolStripButton4";
            iconToolStripButton4.Click += saveButton_clicked;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.ForeColor = Color.Black;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(73, 24);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            // 
            // iconToolStripButton5
            // 
            iconToolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconToolStripButton5.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            iconToolStripButton5.IconColor = Color.FromArgb(0, 192, 192);
            iconToolStripButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconToolStripButton5.IconSize = 30;
            iconToolStripButton5.ImageTransparentColor = Color.Magenta;
            iconToolStripButton5.Name = "iconToolStripButton5";
            iconToolStripButton5.Size = new Size(29, 24);
            iconToolStripButton5.Text = "iconToolStripButton5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(exportBtn);
            groupBox2.Controls.Add(productShelfTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(productQuantityTextBox);
            groupBox2.Controls.Add(productCodeTextBox);
            groupBox2.Controls.Add(productNameTextBox);
            groupBox2.Controls.Add(poTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.ForeColor = Color.Gainsboro;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(781, 224);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhập Thông Tin";
            // 
            // exportBtn
            // 
            exportBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            exportBtn.ForeColor = Color.Black;
            exportBtn.Location = new Point(502, 140);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(258, 77);
            exportBtn.TabIndex = 20;
            exportBtn.Text = "Xuat kho";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // productShelfTextBox
            // 
            productShelfTextBox.Location = new Point(569, 21);
            productShelfTextBox.Margin = new Padding(3, 4, 3, 4);
            productShelfTextBox.Name = "productShelfTextBox";
            productShelfTextBox.Size = new Size(191, 27);
            productShelfTextBox.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(502, 25);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 18;
            label6.Text = "Kệ hàng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(502, 97);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 17;
            label5.Text = "Barcode:";
            // 
            // productQuantityTextBox
            // 
            productQuantityTextBox.Location = new Point(89, 185);
            productQuantityTextBox.Margin = new Padding(3, 4, 3, 4);
            productQuantityTextBox.Name = "productQuantityTextBox";
            productQuantityTextBox.Size = new Size(54, 27);
            productQuantityTextBox.TabIndex = 16;
            // 
            // productCodeTextBox
            // 
            productCodeTextBox.Location = new Point(89, 94);
            productCodeTextBox.Margin = new Padding(3, 4, 3, 4);
            productCodeTextBox.Name = "productCodeTextBox";
            productCodeTextBox.Size = new Size(222, 27);
            productCodeTextBox.TabIndex = 15;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(89, 140);
            productNameTextBox.Margin = new Padding(3, 4, 3, 4);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(380, 27);
            productNameTextBox.TabIndex = 14;
            // 
            // poTextBox
            // 
            poTextBox.Location = new Point(89, 44);
            poTextBox.Margin = new Padding(3, 4, 3, 4);
            poTextBox.Name = "poTextBox";
            poTextBox.Size = new Size(222, 27);
            poTextBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(14, 188);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 12;
            label4.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(14, 97);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 11;
            label3.Text = "Mã vật tư:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(13, 143);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên vật tư:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(14, 47);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 9;
            label1.Text = "Mã P/O:";
            // 
            // groupBox3
            // 
            groupBox3.Dock = DockStyle.Top;
            groupBox3.ForeColor = Color.Gainsboro;
            groupBox3.Location = new Point(0, 224);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(781, 427);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Layout kho thành phẩm";
            // 
            // frmNhapKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1630, 651);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmNhapKho";
            Text = "Nhập Kho";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dataGridViewProducts;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton2;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton3;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton5;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox productQuantityTextBox;
        private TextBox productCodeTextBox;
        private TextBox productNameTextBox;
        private TextBox poTextBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Label label6;
        private TextBox productShelfTextBox;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn poCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shelfCodeDataGridViewTextBoxColumn;
        private Button exportBtn;
    }
}
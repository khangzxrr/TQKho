namespace TQKho.CustomControls
{
    partial class ShelfControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            shelfCode = new Label();
            poTextBox = new Label();
            productNameTextBox = new Label();
            percentTextBox = new Label();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // shelfCode
            // 
            shelfCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            shelfCode.BackColor = Color.MediumSeaGreen;
            shelfCode.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            shelfCode.ForeColor = SystemColors.Control;
            shelfCode.Location = new Point(-3, 0);
            shelfCode.Name = "shelfCode";
            shelfCode.Size = new Size(193, 47);
            shelfCode.TabIndex = 0;
            shelfCode.Text = "K7";
            shelfCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // poTextBox
            // 
            poTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            poTextBox.BackColor = Color.Transparent;
            poTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            poTextBox.ForeColor = Color.Black;
            poTextBox.Location = new Point(3, 54);
            poTextBox.Name = "poTextBox";
            poTextBox.Size = new Size(179, 32);
            poTextBox.TabIndex = 1;
            poTextBox.Text = "PO CODE";
            poTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productNameTextBox.BackColor = Color.Transparent;
            productNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productNameTextBox.ForeColor = Color.Black;
            productNameTextBox.Location = new Point(3, 86);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(179, 31);
            productNameTextBox.TabIndex = 2;
            productNameTextBox.Text = "PRODUCT NAME";
            productNameTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // percentTextBox
            // 
            percentTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            percentTextBox.BackColor = Color.Transparent;
            percentTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            percentTextBox.ForeColor = Color.Black;
            percentTextBox.Location = new Point(0, 117);
            percentTextBox.Name = "percentTextBox";
            percentTextBox.Size = new Size(190, 27);
            percentTextBox.TabIndex = 4;
            percentTextBox.Text = "14%";
            percentTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar.Location = new Point(7, 148);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(175, 31);
            progressBar.TabIndex = 5;
            progressBar.Value = 50;
            // 
            // ShelfControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(progressBar);
            Controls.Add(percentTextBox);
            Controls.Add(productNameTextBox);
            Controls.Add(poTextBox);
            Controls.Add(shelfCode);
            Name = "ShelfControl";
            Size = new Size(190, 183);
            ResumeLayout(false);
        }

        #endregion

        private Label shelfCode;
        private Label poTextBox;
        private Label productNameTextBox;
        private Label percentTextBox;
        private ProgressBar progressBar;
    }
}

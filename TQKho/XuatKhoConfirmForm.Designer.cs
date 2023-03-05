namespace TQKho
{
    partial class XuatKhoConfirmForm
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
            label1 = new Label();
            quantityTextbox = new TextBox();
            confirmBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(374, 35);
            label1.TabIndex = 0;
            label1.Text = "Vui lòng nhập số lượng xuất kho";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quantityTextbox
            // 
            quantityTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            quantityTextbox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            quantityTextbox.Location = new Point(105, 47);
            quantityTextbox.Name = "quantityTextbox";
            quantityTextbox.Size = new Size(184, 38);
            quantityTextbox.TabIndex = 1;
            // 
            // confirmBtn
            // 
            confirmBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            confirmBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            confirmBtn.Location = new Point(132, 91);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(126, 42);
            confirmBtn.TabIndex = 2;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // XuatKhoConfirmForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(398, 148);
            Controls.Add(confirmBtn);
            Controls.Add(quantityTextbox);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "XuatKhoConfirmForm";
            Text = "XuatKhoConfirmForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox quantityTextbox;
        private Button confirmBtn;
    }
}
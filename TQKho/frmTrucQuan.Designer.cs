namespace TQKho
{
    partial class frmTrucQuan
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
            flowLayoutPanel = new FlowLayoutPanel();
            shelfComboBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(12, 84);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(1214, 546);
            flowLayoutPanel.TabIndex = 5;
            // 
            // shelfComboBox
            // 
            shelfComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            shelfComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            shelfComboBox.FormattingEnabled = true;
            shelfComboBox.Location = new Point(135, 18);
            shelfComboBox.Name = "shelfComboBox";
            shelfComboBox.Size = new Size(151, 36);
            shelfComboBox.TabIndex = 6;
            shelfComboBox.SelectedValueChanged += shelfCodeComboboxValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 7;
            label1.Text = "Select shelf";
            // 
            // frmTrucQuan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 33, 74);
            ClientSize = new Size(1238, 651);
            Controls.Add(label1);
            Controls.Add(shelfComboBox);
            Controls.Add(flowLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTrucQuan";
            Text = "Trực Quan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private ComboBox shelfComboBox;
        private Label label1;
    }
}
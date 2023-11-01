namespace orderMaker
{
    partial class Form1
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
            lbStaffName = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbStaffName
            // 
            lbStaffName.AutoSize = true;
            lbStaffName.Location = new Point(1080, 9);
            lbStaffName.Name = "lbStaffName";
            lbStaffName.Size = new Size(119, 32);
            lbStaffName.TabIndex = 0;
            lbStaffName.Text = "username";
            lbStaffName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 70);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 2;
            label1.Text = "customer";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 485);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(lbStaffName);
            Name = "Form1";
            Text = "making Order";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStaffName;
        private ComboBox comboBox1;
        private Label label1;
    }
}
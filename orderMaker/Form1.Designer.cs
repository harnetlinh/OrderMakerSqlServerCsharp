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
            cbCustomer = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cbStore = new ComboBox();
            dgvListItem = new DataGridView();
            label3 = new Label();
            cbProduct = new ComboBox();
            textBox1 = new TextBox();
            btnAddItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListItem).BeginInit();
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
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(170, 67);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(242, 40);
            cbCustomer.TabIndex = 1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 159);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 4;
            label2.Text = "store";
            // 
            // cbStore
            // 
            cbStore.FormattingEnabled = true;
            cbStore.Location = new Point(170, 156);
            cbStore.Name = "cbStore";
            cbStore.Size = new Size(242, 40);
            cbStore.TabIndex = 3;
            // 
            // dgvListItem
            // 
            dgvListItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListItem.Location = new Point(685, 67);
            dgvListItem.Name = "dgvListItem";
            dgvListItem.RowHeadersWidth = 82;
            dgvListItem.RowTemplate.Height = 41;
            dgvListItem.Size = new Size(588, 406);
            dgvListItem.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 253);
            label3.Name = "label3";
            label3.Size = new Size(97, 32);
            label3.TabIndex = 7;
            label3.Text = "product";
            // 
            // cbProduct
            // 
            cbProduct.FormattingEnabled = true;
            cbProduct.Location = new Point(170, 250);
            cbProduct.Name = "cbProduct";
            cbProduct.Size = new Size(130, 40);
            cbProduct.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 39);
            textBox1.TabIndex = 8;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(512, 253);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(150, 46);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "add item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 485);
            Controls.Add(btnAddItem);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(cbProduct);
            Controls.Add(dgvListItem);
            Controls.Add(label2);
            Controls.Add(cbStore);
            Controls.Add(label1);
            Controls.Add(cbCustomer);
            Controls.Add(lbStaffName);
            Name = "Form1";
            Text = "making Order";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStaffName;
        private ComboBox cbCustomer;
        private Label label1;
        private Label label2;
        private ComboBox cbStore;
        private DataGridView dgvListItem;
        private Label label3;
        private ComboBox cbProduct;
        private TextBox textBox1;
        private Button btnAddItem;
    }
}
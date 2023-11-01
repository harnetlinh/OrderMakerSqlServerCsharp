namespace orderMaker
{
    partial class Login
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
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(230, 100);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(200, 39);
            tbEmail.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(232, 180);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(200, 39);
            tbPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 103);
            label1.Name = "label1";
            label1.Size = new Size(72, 32);
            label1.TabIndex = 2;
            label1.Text = "email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 180);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 3;
            label2.Text = "password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(102, 268);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 419);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmail;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Button btnLogin;
    }
}
namespace EmployeeSalaryManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            picLogo = new PictureBox();
            pnlLogin = new Panel();
            btnLogin = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(207, 9);
            picLogo.Margin = new Padding(2, 3, 2, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(200, 200);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(picLogo);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Margin = new Padding(2, 3, 2, 3);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(623, 435);
            pnlLogin.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(217, 319);
            btnLogin.Margin = new Padding(2, 3, 2, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(185, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 263);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 19);
            label2.TabIndex = 4;
            label2.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Azure;
            txtPassword.Location = new Point(179, 281);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(271, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 209);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 2;
            label1.Text = "USERNAME";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Azure;
            txtUsername.Location = new Point(179, 227);
            txtUsername.Margin = new Padding(2, 3, 2, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(271, 27);
            txtUsername.TabIndex = 1;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(623, 435);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 3, 2, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payroll";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picLogo;
        private Panel pnlLogin;
        private TextBox txtUsername;
        private Label label1;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPassword;
    }
}
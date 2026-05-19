namespace EmployeeSalaryManagement.Notification
{
    partial class ChangePassword
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
            pnlLogin = new Panel();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            txtCurrentPassword = new TextBox();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(label3);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(txtCurrentPassword);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Margin = new Padding(2, 3, 2, 3);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(365, 303);
            pnlLogin.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 52);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 19);
            label3.TabIndex = 9;
            label3.Text = "Change Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Azure;
            txtUsername.Location = new Point(47, 72);
            txtUsername.Margin = new Padding(2, 3, 2, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(271, 27);
            txtUsername.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 159);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 19);
            label2.TabIndex = 7;
            label2.Text = "Change Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Azure;
            txtPassword.Location = new Point(47, 179);
            txtPassword.Margin = new Padding(2, 3, 2, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(271, 27);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(90, 221);
            btnLogin.Margin = new Padding(2, 3, 2, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(185, 27);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Change Password";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 109);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 19);
            label1.TabIndex = 2;
            label1.Text = "Current Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BackColor = Color.Azure;
            txtCurrentPassword.Location = new Point(47, 129);
            txtCurrentPassword.Margin = new Padding(2, 3, 2, 3);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(271, 27);
            txtCurrentPassword.TabIndex = 1;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // ChangePassword
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 303);
            Controls.Add(pnlLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassword";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Button btnLogin;
        private Label label1;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtCurrentPassword;
        private Label label2;
        private TextBox txtPassword;
    }
}
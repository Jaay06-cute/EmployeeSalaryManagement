namespace EmployeeSalaryManagement.Notification
{
    partial class AddLocation
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
            btnLogin = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            txtUsername = new TextBox();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Margin = new Padding(2, 2, 2, 2);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(335, 266);
            pnlLogin.TabIndex = 2;
            pnlLogin.ParentChanged += pnlLogin_ParentChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(89, 146);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 20);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "+ Add Location";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += AddingLoc;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 13);
            label2.TabIndex = 4;
            label2.Text = "Address";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Azure;
            txtPassword.Location = new Point(56, 119);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(238, 23);
            txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 64);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 13);
            label1.TabIndex = 2;
            label1.Text = "Location Name";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Azure;
            txtUsername.Location = new Point(56, 79);
            txtUsername.Margin = new Padding(2, 2, 2, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(238, 23);
            txtUsername.TabIndex = 1;
            // 
            // AddLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 266);
            Controls.Add(pnlLogin);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "AddLocation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Location";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtUsername;
    }
}
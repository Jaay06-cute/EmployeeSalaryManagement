namespace EmployeeSalaryManagement.Notification
{
    partial class AddPosition
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
            txtSalary = new TextBox();
            label1 = new Label();
            txtPosition = new TextBox();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(txtSalary);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(txtPosition);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Margin = new Padding(2, 3, 2, 3);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(365, 303);
            pnlLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(102, 195);
            btnLogin.Margin = new Padding(2, 3, 2, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(185, 33);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "+ Add Position";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 140);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 4;
            label2.Text = "Salary";
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.Azure;
            txtSalary.Location = new Point(64, 159);
            txtSalary.Margin = new Padding(2, 3, 2, 3);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(271, 27);
            txtSalary.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 85);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.TabIndex = 2;
            label1.Text = "Add Position";
            // 
            // txtPosition
            // 
            txtPosition.BackColor = Color.Azure;
            txtPosition.Location = new Point(64, 105);
            txtPosition.Margin = new Padding(2, 3, 2, 3);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(271, 27);
            txtPosition.TabIndex = 1;
            // 
            // AddPosition
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 303);
            Controls.Add(pnlLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddPosition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPosition";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Button btnLogin;
        private Label label2;
        private TextBox txtSalary;
        private Label label1;
        private TextBox txtPosition;
    }
}
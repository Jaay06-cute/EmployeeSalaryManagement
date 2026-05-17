namespace EmployeeSalaryManagement.Notification
{
    partial class UpdateInfo
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
            label2 = new Label();
            textBox1 = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            txtName = new TextBox();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(textBox1);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(txtName);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Margin = new Padding(2, 4, 2, 4);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(456, 378);
            pnlLogin.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 165);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 7;
            label2.Text = "Salary";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Azure;
            textBox1.Location = new Point(80, 190);
            textBox1.Margin = new Padding(2, 4, 2, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 31);
            textBox1.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(120, 243);
            btnLogin.Margin = new Padding(2, 4, 2, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(231, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Update";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 106);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.Azure;
            txtName.Location = new Point(80, 131);
            txtName.Margin = new Padding(2, 4, 2, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(338, 31);
            txtName.TabIndex = 1;
            // 
            // UpdateInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 378);
            Controls.Add(pnlLogin);
            Name = "UpdateInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateInfo";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Label label2;
        private TextBox textBox1;
        private Button btnLogin;
        private Label label1;
        private TextBox txtName;
    }
}
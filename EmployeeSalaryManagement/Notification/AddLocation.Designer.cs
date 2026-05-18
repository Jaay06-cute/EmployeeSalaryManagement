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
            btnSubmit = new Button();
            label2 = new Label();
            txtAddress = new TextBox();
            label1 = new Label();
            txtLocation = new TextBox();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(btnSubmit);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(txtAddress);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(txtLocation);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Margin = new Padding(2, 3, 2, 3);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(383, 355);
            pnlLogin.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.BackgroundImageLayout = ImageLayout.Zoom;
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(98, 195);
            btnSubmit.Margin = new Padding(2, 3, 2, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(185, 35);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "+ Add Location";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 140);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 4;
            label2.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.Azure;
            txtAddress.Location = new Point(55, 159);
            txtAddress.Margin = new Padding(2, 3, 2, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(271, 27);
            txtAddress.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 85);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 2;
            label1.Text = "Location Name";
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.Azure;
            txtLocation.Location = new Point(55, 105);
            txtLocation.Margin = new Padding(2, 3, 2, 3);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(271, 27);
            txtLocation.TabIndex = 1;
            // 
            // AddLocation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 355);
            Controls.Add(pnlLogin);
            Margin = new Padding(2, 3, 2, 3);
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
        private Button btnSubmit;
        private Label label2;
        private TextBox txtAddress;
        private Label label1;
        private TextBox txtLocation;
    }
}
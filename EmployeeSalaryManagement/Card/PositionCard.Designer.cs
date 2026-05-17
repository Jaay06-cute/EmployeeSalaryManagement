namespace EmployeeSalaryManagement.Card
{
    partial class PositionCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PositionCard));
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            lblSalary = new Label();
            label8 = new Label();
            lblEmployee = new Label();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            lblPosition = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblSalary);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblEmployee);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(lblPosition);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 167);
            panel2.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(167, 19);
            button2.Name = "button2";
            button2.Size = new Size(66, 26);
            button2.TabIndex = 12;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(95, 19);
            button1.Name = "button1";
            button1.Size = new Size(66, 26);
            button1.TabIndex = 11;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.BackColor = Color.DarkSlateGray;
            lblSalary.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalary.ForeColor = Color.White;
            lblSalary.Location = new Point(156, 140);
            lblSalary.Margin = new Padding(2, 0, 2, 0);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(61, 20);
            lblSalary.TabIndex = 10;
            lblSalary.Text = "P45, 000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 140);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 9;
            label8.Text = "Avg Salary";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.BackColor = Color.DarkSlateGray;
            lblEmployee.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployee.ForeColor = Color.White;
            lblEmployee.Location = new Point(176, 122);
            lblEmployee.Margin = new Padding(2, 0, 2, 0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(16, 20);
            lblEmployee.TabIndex = 6;
            lblEmployee.Text = "6";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(12, 122);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 4;
            label9.Text = "Employees";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 10);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.BackColor = Color.DarkSlateGray;
            lblPosition.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosition.ForeColor = Color.White;
            lblPosition.Location = new Point(11, 56);
            lblPosition.Margin = new Padding(2, 0, 2, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(74, 20);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Supervisor";
            // 
            // PositionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "PositionCard";
            Size = new Size(236, 167);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        public Label lblSalary;
        private Label label8;
        public Label lblEmployee;
        private Label label9;
        private PictureBox pictureBox4;
        public Label lblPosition;
        private Button button1;
        private Button button2;
    }
}

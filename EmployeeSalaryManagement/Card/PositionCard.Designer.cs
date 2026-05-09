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
            lblSalary = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            this.lblEmployee = new Label();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            lblPosition = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(lblSalary);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(this.lblEmployee);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(lblPosition);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 223);
            panel2.TabIndex = 12;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.BackColor = Color.DarkSlateGray;
            lblSalary.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalary.ForeColor = Color.White;
            lblSalary.Location = new Point(178, 186);
            lblSalary.Margin = new Padding(2, 0, 2, 0);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(76, 24);
            lblSalary.TabIndex = 10;
            lblSalary.Text = "P45, 000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(14, 186);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(90, 24);
            label8.TabIndex = 9;
            label8.Text = "Avg Salary";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(214, 14);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 38);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.BackColor = Color.DarkSlateGray;
            this.lblEmployee.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblEmployee.ForeColor = Color.White;
            this.lblEmployee.Location = new Point(201, 163);
            this.lblEmployee.Margin = new Padding(2, 0, 2, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new Size(19, 24);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "6";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(14, 163);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(92, 24);
            label9.TabIndex = 4;
            label9.Text = "Employees";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(19, 13);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 60);
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
            lblPosition.Location = new Point(13, 75);
            lblPosition.Margin = new Padding(2, 0, 2, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(87, 24);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Supervisor";
            // 
            // PositionCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "PositionCard";
            Size = new Size(270, 223);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        public Label lblSalary;
        private Label label8;
        private PictureBox pictureBox2;
        public Label lblEmployee;
        private Label label9;
        private PictureBox pictureBox4;
        public Label lblPosition;
    }
}

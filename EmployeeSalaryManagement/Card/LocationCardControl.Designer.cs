namespace EmployeeSalaryManagement.Card
{
    partial class LocationCardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationCardControl));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            this.lblJobs = new Label();
            lblEmployees = new Label();
            lblAdress = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblLocation = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(this.lblJobs);
            panel1.Controls.Add(lblEmployees);
            panel1.Controls.Add(lblAdress);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblLocation);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 217);
            panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(215, 13);
            pictureBox3.Margin = new Padding(2, 3, 2, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // lblJobs
            // 
            this.lblJobs.AutoSize = true;
            this.lblJobs.BackColor = SystemColors.Window;
            this.lblJobs.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblJobs.ForeColor = Color.FromArgb(64, 64, 64);
            this.lblJobs.Location = new Point(175, 173);
            this.lblJobs.Margin = new Padding(2, 0, 2, 0);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new Size(53, 24);
            this.lblJobs.TabIndex = 6;
            this.lblJobs.Text = "4 jobs";
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.BackColor = SystemColors.Window;
            lblEmployees.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployees.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmployees.Location = new Point(57, 173);
            lblEmployees.Margin = new Padding(2, 0, 2, 0);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(113, 24);
            lblEmployees.TabIndex = 5;
            lblEmployees.Text = "28 employees";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdress.ForeColor = Color.White;
            lblAdress.Location = new Point(9, 141);
            lblAdress.Margin = new Padding(2, 0, 2, 0);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(174, 23);
            lblAdress.TabIndex = 4;
            lblAdress.Text = "123 Main St. City Center";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 13);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 171);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.ForeColor = Color.White;
            lblLocation.Location = new Point(7, 109);
            lblLocation.Margin = new Padding(2, 0, 2, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(214, 32);
            lblLocation.TabIndex = 3;
            lblLocation.Text = "Downtown Office";
            // 
            // LocationCardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "LocationCardControl";
            Size = new Size(263, 217);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        public Label lblJobs;
        public Label lblEmployees;
        public Label lblAdress;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public Label lblLocation;
    }
}

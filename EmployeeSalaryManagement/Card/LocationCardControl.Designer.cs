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
            button2 = new Button();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            lblJobs = new Label();
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
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblJobs);
            panel1.Controls.Add(lblEmployees);
            panel1.Controls.Add(lblAdress);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblLocation);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 163);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(161, 10);
            button2.Name = "button2";
            button2.Size = new Size(66, 26);
            button2.TabIndex = 10;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnDeleteLocation_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(89, 10);
            button1.Name = "button1";
            button1.Size = new Size(66, 26);
            button1.TabIndex = 9;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnUpdateLocation_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(187, 82);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // lblJobs
            // 
            lblJobs.AutoSize = true;
            lblJobs.BackColor = SystemColors.Window;
            lblJobs.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJobs.ForeColor = Color.FromArgb(64, 64, 64);
            lblJobs.Location = new Point(153, 130);
            lblJobs.Margin = new Padding(2, 0, 2, 0);
            lblJobs.Name = "lblJobs";
            lblJobs.Size = new Size(46, 20);
            lblJobs.TabIndex = 6;
            lblJobs.Text = "4 jobs";
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.BackColor = SystemColors.Window;
            lblEmployees.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployees.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmployees.Location = new Point(50, 130);
            lblEmployees.Margin = new Padding(2, 0, 2, 0);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(95, 20);
            lblEmployees.TabIndex = 5;
            lblEmployees.Text = "28 employees";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdress.ForeColor = Color.White;
            lblAdress.Location = new Point(8, 106);
            lblAdress.Margin = new Padding(2, 0, 2, 0);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(141, 20);
            lblAdress.TabIndex = 4;
            lblAdress.Text = "123 Main St. City Center";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 10);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 128);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.ForeColor = Color.White;
            lblLocation.Location = new Point(6, 82);
            lblLocation.Margin = new Padding(2, 0, 2, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(168, 25);
            lblLocation.TabIndex = 3;
            lblLocation.Text = "Downtown Office";
            // 
            // LocationCardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "LocationCardControl";
            Size = new Size(230, 163);
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
        private Button button2;
        private Button button1;
    }
}

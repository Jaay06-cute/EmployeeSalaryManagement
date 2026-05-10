namespace EmployeeSalaryManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlSide = new Panel();
            btnAttendance = new Button();
            btnSignout = new Button();
            btnSettings = new Button();
            btnArchive = new Button();
            btnLocation = new Button();
            pictureBox1 = new PictureBox();
            btnDashboard = new Button();
            pnlMain = new Panel();
            pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.DarkSlateGray;
            pnlSide.Controls.Add(btnAttendance);
            pnlSide.Controls.Add(btnSignout);
            pnlSide.Controls.Add(btnSettings);
            pnlSide.Controls.Add(btnArchive);
            pnlSide.Controls.Add(btnLocation);
            pnlSide.Controls.Add(pictureBox1);
            pnlSide.Controls.Add(btnDashboard);
            pnlSide.Dock = DockStyle.Left;
            pnlSide.Location = new Point(0, 0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(365, 844);
            pnlSide.TabIndex = 0;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.DarkSlateGray;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(-6, 356);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(365, 73);
            btnAttendance.TabIndex = 7;
            btnAttendance.Text = "Attendance";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnSignout
            // 
            btnSignout.BackColor = Color.DarkSlateGray;
            btnSignout.FlatAppearance.BorderSize = 0;
            btnSignout.FlatStyle = FlatStyle.Flat;
            btnSignout.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignout.ForeColor = Color.White;
            btnSignout.Location = new Point(0, 735);
            btnSignout.Name = "btnSignout";
            btnSignout.Size = new Size(365, 73);
            btnSignout.TabIndex = 6;
            btnSignout.Text = "Signout";
            btnSignout.UseVisualStyleBackColor = false;
            btnSignout.Click += SignOutClick;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.DarkSlateGray;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(0, 561);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(365, 73);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnArchive
            // 
            btnArchive.BackColor = Color.DarkSlateGray;
            btnArchive.FlatAppearance.BorderSize = 0;
            btnArchive.FlatStyle = FlatStyle.Flat;
            btnArchive.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArchive.ForeColor = Color.White;
            btnArchive.Location = new Point(1, 494);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(365, 73);
            btnArchive.TabIndex = 4;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = false;
            btnArchive.Click += btnArchive_Click;
            // 
            // btnLocation
            // 
            btnLocation.BackColor = Color.DarkSlateGray;
            btnLocation.FlatAppearance.BorderSize = 0;
            btnLocation.FlatStyle = FlatStyle.Flat;
            btnLocation.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocation.ForeColor = Color.White;
            btnLocation.Location = new Point(0, 422);
            btnLocation.Name = "btnLocation";
            btnLocation.Size = new Size(365, 73);
            btnLocation.TabIndex = 3;
            btnLocation.Text = "Location";
            btnLocation.UseVisualStyleBackColor = false;
            btnLocation.Click += btnLocation_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.DarkSlateGray;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(1, 287);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(365, 73);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Azure;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(365, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1113, 844);
            pnlMain.TabIndex = 1;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 844);
            Controls.Add(pnlMain);
            Controls.Add(pnlSide);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payroll";
            pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSide;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnSignout;
        private Button btnSettings;
        private Button btnArchive;
        private Button btnLocation;
        private Panel pnlMain;
        private Button btnAttendance;
    }
}
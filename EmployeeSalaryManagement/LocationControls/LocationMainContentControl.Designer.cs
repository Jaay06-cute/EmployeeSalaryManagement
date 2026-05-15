namespace EmployeeSalaryManagement.LocationControls
{
    partial class LocationMainContentControl
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
            LocationMainContent = new Panel();
            flpLocation = new FlowLayoutPanel();
            btnAddLocation = new Button();
            label11 = new Label();
            label12 = new Label();
            LocationMainContent.SuspendLayout();
            SuspendLayout();
            // 
            // LocationMainContent
            // 
            LocationMainContent.AutoScroll = true;
            LocationMainContent.BackColor = Color.Azure;
            LocationMainContent.Controls.Add(flpLocation);
            LocationMainContent.Controls.Add(btnAddLocation);
            LocationMainContent.Controls.Add(label11);
            LocationMainContent.Controls.Add(label12);
            LocationMainContent.Dock = DockStyle.Fill;
            LocationMainContent.Location = new Point(0, 0);
            LocationMainContent.Margin = new Padding(2, 2, 2, 2);
            LocationMainContent.Name = "LocationMainContent";
            LocationMainContent.Size = new Size(779, 428);
            LocationMainContent.TabIndex = 4;
            // 
            // flpLocation
            // 
            flpLocation.AutoScroll = true;
            flpLocation.Location = new Point(20, 74);
            flpLocation.Margin = new Padding(3, 2, 3, 2);
            flpLocation.Name = "flpLocation";
            flpLocation.Size = new Size(733, 334);
            flpLocation.TabIndex = 12;
            // 
            // btnAddLocation
            // 
            btnAddLocation.BackColor = Color.DarkSlateGray;
            btnAddLocation.FlatAppearance.BorderSize = 0;
            btnAddLocation.FlatStyle = FlatStyle.Flat;
            btnAddLocation.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddLocation.ForeColor = Color.White;
            btnAddLocation.Location = new Point(540, 15);
            btnAddLocation.Margin = new Padding(2, 2, 2, 2);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(213, 34);
            btnAddLocation.TabIndex = 11;
            btnAddLocation.Text = "+ Add Location";
            btnAddLocation.UseVisualStyleBackColor = false;
            btnAddLocation.Click += AddLocationClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(20, 36);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(386, 21);
            label11.TabIndex = 7;
            label11.Text = "Select a location to view job categories and employees";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkSlateGray;
            label12.Location = new Point(20, 7);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(161, 32);
            label12.TabIndex = 6;
            label12.Text = "All Locations";
            // 
            // LocationMainContentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LocationMainContent);
            Margin = new Padding(2, 2, 2, 2);
            Name = "LocationMainContentControl";
            Size = new Size(779, 428);
            LocationMainContent.ResumeLayout(false);
            LocationMainContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LocationMainContent;
        private Label label11;
        private Label label12;
        private Button btnAddLocation;
        private FlowLayoutPanel flpLocation;
    }
}

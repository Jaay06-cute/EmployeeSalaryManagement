namespace EmployeeSalaryManagement.LocationControls
{
    partial class DowntownOfficeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DowntownOfficeControl));
            DowntownContent = new Panel();
            flpPosition = new FlowLayoutPanel();
            button2 = new Button();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            label11 = new Label();
            lblHeader = new Label();
            DowntownContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // DowntownContent
            // 
            DowntownContent.BackColor = Color.Azure;
            DowntownContent.Controls.Add(flpPosition);
            DowntownContent.Controls.Add(button2);
            DowntownContent.Controls.Add(label1);
            DowntownContent.Controls.Add(pictureBox10);
            DowntownContent.Controls.Add(label11);
            DowntownContent.Controls.Add(lblHeader);
            DowntownContent.Location = new Point(0, 0);
            DowntownContent.Margin = new Padding(2, 2, 2, 2);
            DowntownContent.Name = "DowntownContent";
            DowntownContent.Size = new Size(779, 428);
            DowntownContent.TabIndex = 4;
            // 
            // flpPosition
            // 
            flpPosition.Location = new Point(21, 112);
            flpPosition.Margin = new Padding(3, 2, 3, 2);
            flpPosition.Name = "flpPosition";
            flpPosition.Size = new Size(740, 296);
            flpPosition.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = Color.White;
            button2.Location = new Point(628, 20);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(133, 38);
            button2.TabIndex = 14;
            button2.Text = "+ Add Position";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(57, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 18);
            label1.TabIndex = 9;
            label1.Text = "Back to Locations";
            label1.Click += BackClick;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(20, 16);
            pictureBox10.Margin = new Padding(2, 2, 2, 2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(32, 28);
            pictureBox10.TabIndex = 9;
            pictureBox10.TabStop = false;
            pictureBox10.Click += BackArrowClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(21, 79);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(286, 21);
            label11.TabIndex = 7;
            label11.Text = "Select a job category to view employees";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.DarkSlateGray;
            lblHeader.Location = new Point(18, 52);
            lblHeader.Margin = new Padding(2, 0, 2, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(214, 32);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "Downtown Office";
            // 
            // DowntownOfficeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(DowntownContent);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DowntownOfficeControl";
            Size = new Size(779, 428);
            DowntownContent.ResumeLayout(false);
            DowntownContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel DowntownContent;
        private Label label11;
        private Label lblHeader;
        private Label label1;
        private PictureBox pictureBox10;
        private Button button2;
        private FlowLayoutPanel flpPosition;
    }
}

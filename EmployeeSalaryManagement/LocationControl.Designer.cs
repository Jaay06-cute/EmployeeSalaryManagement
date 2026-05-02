namespace EmployeeSalaryManagement
{
    partial class LocationControl
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
            TopBar = new Panel();
            label10 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            LocationContent = new Panel();
            TopBar.SuspendLayout();
            SuspendLayout();
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.Azure;
            TopBar.Controls.Add(label10);
            TopBar.Controls.Add(button1);
            TopBar.Controls.Add(textBox1);
            TopBar.Controls.Add(label1);
            TopBar.Dock = DockStyle.Top;
            TopBar.Location = new Point(0, 0);
            TopBar.Margin = new Padding(2);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(779, 78);
            TopBar.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(20, 47);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(322, 21);
            label10.TabIndex = 3;
            label10.Text = "Manage employees across different locations";
            label10.Click += label10_Click;
            // 
            // button1
            // 
            button1.Location = new Point(662, 43);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(76, 19);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(423, 43);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search location...";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(20, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 0;
            label1.Text = "Locations";
            // 
            // LocationContent
            // 
            LocationContent.AutoScroll = true;
            LocationContent.BackColor = Color.Azure;
            LocationContent.Dock = DockStyle.Fill;
            LocationContent.Location = new Point(0, 78);
            LocationContent.Margin = new Padding(2);
            LocationContent.Name = "LocationContent";
            LocationContent.Size = new Size(779, 428);
            LocationContent.TabIndex = 3;
            // 
            // LocationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LocationContent);
            Controls.Add(TopBar);
            Margin = new Padding(2);
            Name = "LocationControl";
            Size = new Size(779, 506);
            TopBar.ResumeLayout(false);
            TopBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopBar;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label10;
        private Panel LocationContent;
    }
}

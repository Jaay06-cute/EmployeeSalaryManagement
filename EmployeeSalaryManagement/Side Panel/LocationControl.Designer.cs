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
            TopBar.Margin = new Padding(2, 3, 2, 3);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(890, 104);
            TopBar.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(23, 63);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(404, 28);
            label10.TabIndex = 3;
            label10.Text = "Manage employees across different locations";
            // 
            // button1
            // 
            button1.Location = new Point(757, 57);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(87, 31);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(483, 57);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search location...";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(23, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 41);
            label1.TabIndex = 0;
            label1.Text = "Locations";
            // 
            // LocationContent
            // 
            LocationContent.BackColor = Color.Azure;
            LocationContent.Dock = DockStyle.Fill;
            LocationContent.Location = new Point(0, 104);
            LocationContent.Margin = new Padding(2, 3, 2, 3);
            LocationContent.Name = "LocationContent";
            LocationContent.Size = new Size(890, 571);
            LocationContent.TabIndex = 3;
            // 
            // LocationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LocationContent);
            Controls.Add(TopBar);
            Margin = new Padding(2, 3, 2, 3);
            Name = "LocationControl";
            Size = new Size(890, 675);
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

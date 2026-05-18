namespace EmployeeSalaryManagement.Notification
{
    partial class ViewEmployee
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
            TopBar = new Panel();
            button2 = new Button();
            lblID = new Label();
            button1 = new Button();
            lblName = new Label();
            button3 = new Button();
            button4 = new Button();
            MainContentView = new Panel();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            button5 = new Button();
            TopBar.SuspendLayout();
            MainContentView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.Azure;
            TopBar.Controls.Add(button5);
            TopBar.Controls.Add(button2);
            TopBar.Controls.Add(lblID);
            TopBar.Controls.Add(button1);
            TopBar.Controls.Add(lblName);
            TopBar.Dock = DockStyle.Top;
            TopBar.Location = new Point(0, 0);
            TopBar.Margin = new Padding(2);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(702, 74);
            TopBar.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(511, 20);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(95, 35);
            button2.TabIndex = 4;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.DarkSlateGray;
            lblID.Location = new Point(10, 46);
            lblID.Margin = new Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(93, 23);
            lblID.TabIndex = 3;
            lblID.Text = "ID- 521321";
            // 
            // button1
            // 
            button1.Location = new Point(757, 58);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(87, 26);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.DarkSlateGray;
            lblName.Location = new Point(10, 15);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(179, 32);
            lblName.TabIndex = 0;
            lblName.Text = "John Martinez";
            // 
            // button3
            // 
            button3.Location = new Point(0, 79);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(114, 38);
            button3.TabIndex = 4;
            button3.Text = "Attendance";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(118, 79);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(114, 38);
            button4.TabIndex = 5;
            button4.Text = "Transaction";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MainContentView
            // 
            MainContentView.BackColor = Color.White;
            MainContentView.Controls.Add(dataGridView1);
            MainContentView.Location = new Point(0, 122);
            MainContentView.Margin = new Padding(2);
            MainContentView.Name = "MainContentView";
            MainContentView.Size = new Size(702, 314);
            MainContentView.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Status });
            dataGridView1.Location = new Point(2, 2);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(700, 311);
            dataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            Date.HeaderText = "Attendance";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 270;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 600;
            // 
            // button5
            // 
            button5.BackColor = Color.LawnGreen;
            button5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(607, 20);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(95, 35);
            button5.TabIndex = 5;
            button5.Text = "EDIT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ViewEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 435);
            Controls.Add(MainContentView);
            Controls.Add(button4);
            Controls.Add(TopBar);
            Controls.Add(button3);
            Margin = new Padding(2);
            Name = "ViewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewEmployee";
            TopBar.ResumeLayout(false);
            TopBar.PerformLayout();
            MainContentView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopBar;
        private Label lblID;
        private Button button1;
        private Label lblName;
        private Button button3;
        private Button button2;
        private Button button4;
        private Panel MainContentView;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status;
        private Button button5;
    }
}
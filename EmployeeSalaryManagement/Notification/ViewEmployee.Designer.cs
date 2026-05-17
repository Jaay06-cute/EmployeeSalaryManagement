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
            btnUpdate = new Button();
            button2 = new Button();
            label10 = new Label();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            MainContentView = new Panel();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            TopBar.SuspendLayout();
            MainContentView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.Azure;
            TopBar.Controls.Add(btnUpdate);
            TopBar.Controls.Add(button2);
            TopBar.Controls.Add(label10);
            TopBar.Controls.Add(button1);
            TopBar.Controls.Add(label1);
            TopBar.Dock = DockStyle.Top;
            TopBar.Location = new Point(0, 0);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(878, 93);
            TopBar.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkGreen;
            btnUpdate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(552, 24);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 44);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Edit Information";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(747, 24);
            button2.Name = "button2";
            button2.Size = new Size(119, 44);
            button2.TabIndex = 4;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(12, 57);
            label10.Name = "label10";
            label10.Size = new Size(110, 28);
            label10.TabIndex = 3;
            label10.Text = "ID- 521321";
            // 
            // button1
            // 
            button1.Location = new Point(946, 72);
            button1.Name = "button1";
            button1.Size = new Size(109, 32);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(206, 38);
            label1.TabIndex = 0;
            label1.Text = "John Martinez";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(0, 99);
            button3.Name = "button3";
            button3.Size = new Size(142, 47);
            button3.TabIndex = 4;
            button3.Text = "Attendance";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(148, 99);
            button4.Name = "button4";
            button4.Size = new Size(142, 47);
            button4.TabIndex = 5;
            button4.Text = "Transaction";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MainContentView
            // 
            MainContentView.BackColor = Color.White;
            MainContentView.Controls.Add(dataGridView1);
            MainContentView.Location = new Point(0, 152);
            MainContentView.Name = "MainContentView";
            MainContentView.Size = new Size(878, 392);
            MainContentView.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Status });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(875, 389);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // ViewEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(MainContentView);
            Controls.Add(button4);
            Controls.Add(TopBar);
            Controls.Add(button3);
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
        private Label label10;
        private Button button1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Panel MainContentView;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status;
        private Button button5;
        private Button btnUpdate;
    }
}
namespace EmployeeSalaryManagement
{
    partial class DashboardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardControl));
            MainContent = new Panel();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            lblCount = new Label();
            label12 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            this.lblBalance = new Label();
            label7 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblSalary = new Label();
            label5 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblEmployee = new Label();
            label2 = new Label();
            TopBar = new Panel();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            label1 = new Label();
            MainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MainContent
            // 
            MainContent.BackColor = Color.Azure;
            MainContent.Controls.Add(dataGridView2);
            MainContent.Controls.Add(label9);
            MainContent.Controls.Add(panel5);
            MainContent.Controls.Add(panel3);
            MainContent.Controls.Add(panel2);
            MainContent.Controls.Add(panel1);
            MainContent.Dock = DockStyle.Fill;
            MainContent.Location = new Point(0, 0);
            MainContent.Margin = new Padding(2);
            MainContent.Name = "MainContent";
            MainContent.Size = new Size(890, 675);
            MainContent.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView2.Location = new Point(15, 365);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(863, 294);
            dataGridView2.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Location";
            Column3.HeaderText = "Location";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Position";
            Column4.HeaderText = "Position";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TransactionType";
            Column5.HeaderText = "Transaction Type";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 175;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Amount";
            Column6.HeaderText = "Amount";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Azure;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(14, 330);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(252, 32);
            label9.TabIndex = 5;
            label9.Text = "Previous Transaction";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(lblCount);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(678, 116);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 200);
            panel5.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 13);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 60);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.ForeColor = Color.White;
            lblCount.Location = new Point(14, 147);
            lblCount.Margin = new Padding(2, 0, 2, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(52, 41);
            lblCount.TabIndex = 3;
            lblCount.Text = "67";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(2, 122);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(89, 28);
            label12.TabIndex = 3;
            label12.Text = "Cash-out";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(this.lblBalance);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(458, 116);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 200);
            panel3.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 13);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblBalance.ForeColor = Color.White;
            this.lblBalance.Location = new Point(3, 146);
            this.lblBalance.Margin = new Padding(2, 0, 2, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new Size(129, 41);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "P89,320";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(5, 122);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 3;
            label7.Text = "Salary Balance";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblSalary);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(235, 116);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 200);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 13);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.BackColor = Color.Transparent;
            lblSalary.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalary.ForeColor = Color.White;
            lblSalary.Location = new Point(2, 147);
            lblSalary.Margin = new Padding(2, 0, 2, 0);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(137, 41);
            lblSalary.TabIndex = 3;
            lblSalary.Text = "P 12,450";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2, 122);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(205, 28);
            label5.TabIndex = 3;
            label5.Text = "Monthly Cash Advance";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblEmployee);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.DarkSlateGray;
            panel1.Location = new Point(14, 116);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 200);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.BackColor = Color.Transparent;
            lblEmployee.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployee.ForeColor = Color.White;
            lblEmployee.Location = new Point(11, 149);
            lblEmployee.Margin = new Padding(2, 0, 2, 0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(52, 41);
            lblEmployee.TabIndex = 3;
            lblEmployee.Text = "67";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 123);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 3;
            label2.Text = "Total Employees";
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.Azure;
            TopBar.Controls.Add(dataGridView1);
            TopBar.Controls.Add(label10);
            TopBar.Controls.Add(label1);
            TopBar.Dock = DockStyle.Top;
            TopBar.Location = new Point(0, 0);
            TopBar.Margin = new Padding(2);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(890, 104);
            TopBar.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(573, 89);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(6, 6);
            dataGridView1.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Azure;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(15, 60);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(359, 23);
            label10.TabIndex = 3;
            label10.Text = "Overview of your workforce and salary metrics";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Azure;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(10, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 41);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TopBar);
            Controls.Add(MainContent);
            Margin = new Padding(2);
            Name = "DashboardControl";
            Size = new Size(890, 675);
            MainContent.ResumeLayout(false);
            MainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TopBar.ResumeLayout(false);
            TopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainContent;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblEmployee;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label lblSalary;
        private Label label7;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label lblBalance;
        private Label label5;
        private Panel TopBar;
        private Label label10;
        private Label label1;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label lblCount;
        private Label label12;
        private DataGridView dataGridView1;
        private Label label9;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}

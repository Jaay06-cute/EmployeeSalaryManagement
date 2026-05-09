namespace EmployeeSalaryManagement.LocationControls
{
    partial class LaborEmployeesController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaborEmployeesController));
            DowntownContent = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            label11 = new Label();
            lblLabor = new Label();
            DowntownContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // DowntownContent
            // 
            DowntownContent.BackColor = Color.Azure;
            DowntownContent.Controls.Add(button2);
            DowntownContent.Controls.Add(button1);
            DowntownContent.Controls.Add(textBox1);
            DowntownContent.Controls.Add(dataGridView1);
            DowntownContent.Controls.Add(label1);
            DowntownContent.Controls.Add(pictureBox10);
            DowntownContent.Controls.Add(label11);
            DowntownContent.Controls.Add(lblLabor);
            DowntownContent.Dock = DockStyle.Fill;
            DowntownContent.Location = new Point(0, 0);
            DowntownContent.Margin = new Padding(2, 3, 2, 3);
            DowntownContent.Name = "DowntownContent";
            DowntownContent.Size = new Size(893, 661);
            DowntownContent.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.ForeColor = Color.White;
            button2.Location = new Point(727, 69);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(152, 51);
            button2.TabIndex = 13;
            button2.Text = "+ Add Employee";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(751, 161);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 31);
            button1.TabIndex = 12;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 161);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by name.....";
            textBox1.Size = new Size(713, 27);
            textBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(18, 211);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(861, 424);
            dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "EMPLOYEE ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 160;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "FULL NAME";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 400;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Salary";
            Column3.HeaderText = "SALARY";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 170;
            // 
            // Column4
            // 
            Column4.HeaderText = "CASH ADVANCE";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 170;
            // 
            // Column5
            // 
            Column5.HeaderText = "SALARY BALANCE";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 170;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(65, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 9;
            label1.Text = "Back to Locations";
            label1.Click += BackClick;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(23, 21);
            pictureBox10.Margin = new Padding(2, 3, 2, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(37, 37);
            pictureBox10.TabIndex = 9;
            pictureBox10.TabStop = false;
            pictureBox10.Click += BackArrowClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(21, 108);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(179, 28);
            label11.TabIndex = 7;
            label11.Text = "0 employees found";
            // 
            // lblLabor
            // 
            lblLabor.AutoSize = true;
            lblLabor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLabor.Location = new Point(21, 69);
            lblLabor.Margin = new Padding(2, 0, 2, 0);
            lblLabor.Name = "lblLabor";
            lblLabor.Size = new Size(284, 41);
            lblLabor.TabIndex = 6;
            lblLabor.Text = "Laborer Employees";
            // 
            // LaborEmployeesController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DowntownContent);
            Margin = new Padding(2, 3, 2, 3);
            Name = "LaborEmployeesController";
            Size = new Size(893, 661);
            DowntownContent.ResumeLayout(false);
            DowntownContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel DowntownContent;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox10;
        private Label label11;
        private Label lblLabor;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}

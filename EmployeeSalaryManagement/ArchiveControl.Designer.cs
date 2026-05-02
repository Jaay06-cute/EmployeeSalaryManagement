namespace EmployeeSalaryManagement
{
    partial class ArchiveControl
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
            label1 = new Label();
            DowntownContent = new Panel();
            label3 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            Column6 = new DataGridViewButtonColumn();
            button3 = new Button();
            textBox2 = new TextBox();
            TopBar.SuspendLayout();
            DowntownContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // TopBar
            // 
            TopBar.BackColor = Color.Azure;
            TopBar.Controls.Add(label10);
            TopBar.Controls.Add(label1);
            TopBar.Dock = DockStyle.Top;
            TopBar.Location = new Point(0, 0);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(1113, 130);
            TopBar.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(27, 87);
            label10.Name = "label10";
            label10.Size = new Size(425, 32);
            label10.TabIndex = 3;
            label10.Text = "View and manage archived employees";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 42);
            label1.Name = "label1";
            label1.Size = new Size(173, 48);
            label1.TabIndex = 0;
            label1.Text = "ARCHIVE";
            // 
            // DowntownContent
            // 
            DowntownContent.BackColor = Color.Azure;
            DowntownContent.Controls.Add(label3);
            DowntownContent.Controls.Add(label2);
            DowntownContent.Controls.Add(dataGridView2);
            DowntownContent.Controls.Add(button3);
            DowntownContent.Controls.Add(textBox2);
            DowntownContent.Dock = DockStyle.Fill;
            DowntownContent.Location = new Point(0, 130);
            DowntownContent.Name = "DowntownContent";
            DowntownContent.Size = new Size(1113, 714);
            DowntownContent.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(141, 668);
            label3.Name = "label3";
            label3.Size = new Size(42, 32);
            label3.TabIndex = 14;
            label3.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(17, 668);
            label2.Name = "label2";
            label2.Size = new Size(133, 28);
            label2.TabIndex = 4;
            label2.Text = "Total Archive: ";
            label2.Click += label2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4, Column5, Column6 });
            dataGridView2.GridColor = Color.White;
            dataGridView2.Location = new Point(17, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.Size = new Size(1079, 600);
            dataGridView2.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.DividerWidth = 1;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 150;
            // 
            // Column3
            // 
            Column3.DividerWidth = 1;
            Column3.HeaderText = "Location";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.Width = 175;
            // 
            // Column2
            // 
            Column2.DividerWidth = 1;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.Width = 300;
            // 
            // Column4
            // 
            Column4.DividerWidth = 1;
            Column4.HeaderText = "Position";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.Width = 175;
            // 
            // Column5
            // 
            Column5.HeaderText = "Retrieve";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 137;
            // 
            // Column6
            // 
            Column6.HeaderText = "Detele";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 137;
            // 
            // button3
            // 
            button3.Location = new Point(935, 622);
            button3.Name = "button3";
            button3.Size = new Size(161, 33);
            button3.TabIndex = 12;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 624);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search archived employees.....";
            textBox2.Size = new Size(912, 31);
            textBox2.TabIndex = 11;
            // 
            // ArchiveControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(DowntownContent);
            Controls.Add(TopBar);
            Name = "ArchiveControl";
            Size = new Size(1113, 844);
            TopBar.ResumeLayout(false);
            TopBar.PerformLayout();
            DowntownContent.ResumeLayout(false);
            DowntownContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopBar;
        private Label label10;
        private Label label1;
        private Panel DowntownContent;
        private Button button3;
        private TextBox textBox2;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Column5;
        private DataGridViewButtonColumn Column6;
    }
}

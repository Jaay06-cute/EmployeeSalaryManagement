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
            lblList = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewButtonColumn();
            Column6 = new DataGridViewButtonColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
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
            TopBar.Margin = new Padding(2);
            TopBar.Name = "TopBar";
            TopBar.Size = new Size(890, 104);
            TopBar.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(22, 70);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(344, 28);
            label10.TabIndex = 3;
            label10.Text = "View and manage archived employees";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 41);
            label1.TabIndex = 0;
            label1.Text = "ARCHIVE";
            // 
            // DowntownContent
            // 
            DowntownContent.BackColor = Color.Azure;
            DowntownContent.Controls.Add(lblList);
            DowntownContent.Controls.Add(label2);
            DowntownContent.Controls.Add(dataGridView2);
            DowntownContent.Controls.Add(btnSearch);
            DowntownContent.Controls.Add(txtSearch);
            DowntownContent.Dock = DockStyle.Fill;
            DowntownContent.Location = new Point(0, 104);
            DowntownContent.Margin = new Padding(2);
            DowntownContent.Name = "DowntownContent";
            DowntownContent.Size = new Size(890, 571);
            DowntownContent.TabIndex = 6;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblList.ForeColor = Color.FromArgb(64, 64, 64);
            lblList.Location = new Point(133, 534);
            lblList.Margin = new Padding(2, 0, 2, 0);
            lblList.Name = "lblList";
            lblList.Size = new Size(36, 28);
            lblList.TabIndex = 14;
            lblList.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(14, 534);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 4;
            label2.Text = "Total Archive: ";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column4, Column5, Column6 });
            dataGridView2.GridColor = Color.White;
            dataGridView2.Location = new Point(14, 5);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.Size = new Size(863, 480);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
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
            Column3.DataPropertyName = "Location";
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
            Column2.DataPropertyName = "Name";
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
            Column4.DataPropertyName = "Position";
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
            // btnSearch
            // 
            btnSearch.Location = new Point(748, 498);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 26);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(14, 499);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search archived employees.....";
            txtSearch.Size = new Size(730, 27);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // ArchiveControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(DowntownContent);
            Controls.Add(TopBar);
            Margin = new Padding(2);
            Name = "ArchiveControl";
            Size = new Size(890, 675);
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
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label2;
        private DataGridView dataGridView2;
        public Label lblList;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Column5;
        private DataGridViewButtonColumn Column6;
    }
}

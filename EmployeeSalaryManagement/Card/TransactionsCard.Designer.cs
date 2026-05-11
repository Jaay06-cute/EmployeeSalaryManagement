namespace EmployeeSalaryManagement.Card
{
    partial class TransactionsCard
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
            panel1 = new Panel();
            lblAmount = new Label();
            lblTransactionType = new Label();
            lblDate = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblAmount);
            panel1.Controls.Add(lblTransactionType);
            panel1.Controls.Add(lblDate);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 67);
            panel1.TabIndex = 1;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.ForeColor = Color.Black;
            lblAmount.Location = new Point(569, 26);
            lblAmount.Margin = new Padding(2, 0, 2, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(39, 22);
            lblAmount.TabIndex = 7;
            lblAmount.Text = "-$50";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionType.ForeColor = Color.Black;
            lblTransactionType.Location = new Point(10, 36);
            lblTransactionType.Margin = new Padding(2, 0, 2, 0);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(102, 22);
            lblTransactionType.TabIndex = 6;
            lblTransactionType.Text = "Cash Advance";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(10, 12);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(131, 25);
            lblDate.TabIndex = 5;
            lblDate.Text = "May 05, 2026";
            // 
            // TransactionsCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "TransactionsCard";
            Size = new Size(700, 67);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label lblAmount;
        public Label lblTransactionType;
        public Label lblDate;
    }
}

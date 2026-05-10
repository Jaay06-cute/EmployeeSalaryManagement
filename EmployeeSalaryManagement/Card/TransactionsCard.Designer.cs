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
            label1 = new Label();
            lblAdress = new Label();
            lblLocation = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblAdress);
            panel1.Controls.Add(lblLocation);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 84);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(803, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 24);
            label1.TabIndex = 7;
            label1.Text = "-$50";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdress.ForeColor = Color.Black;
            lblAdress.Location = new Point(13, 45);
            lblAdress.Margin = new Padding(2, 0, 2, 0);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(117, 24);
            lblAdress.TabIndex = 6;
            lblAdress.Text = "Cash Advance";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.ForeColor = Color.Black;
            lblLocation.Location = new Point(13, 15);
            lblLocation.Margin = new Padding(2, 0, 2, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(154, 30);
            lblLocation.TabIndex = 5;
            lblLocation.Text = "May 05, 2026";
            // 
            // TransactionsCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "TransactionsCard";
            Size = new Size(875, 84);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Label label1;
        public Label lblAdress;
        public Label lblLocation;
    }
}

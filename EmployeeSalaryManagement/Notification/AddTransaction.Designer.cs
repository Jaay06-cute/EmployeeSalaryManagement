namespace EmployeeSalaryManagement.Notification
{
    partial class AddTransaction
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            nudAmount = new NumericUpDown();
            label3 = new Label();
            rdPayOut = new RadioButton();
            rdCashAdvance = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            lblName = new Label();
            lblAdress = new Label();
            lblLocation = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(nudAmount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rdPayOut);
            panel1.Controls.Add(rdCashAdvance);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblAdress);
            panel1.Controls.Add(lblLocation);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 369);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGreen;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(259, 316);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(150, 35);
            button2.TabIndex = 18;
            button2.Text = "Add Transactions";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(49, 316);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(156, 35);
            button1.TabIndex = 17;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(17, 274);
            nudAmount.Margin = new Padding(2);
            nudAmount.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(392, 27);
            nudAmount.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(17, 246);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 22);
            label3.TabIndex = 15;
            label3.Text = "Amount";
            // 
            // rdPayOut
            // 
            rdPayOut.AutoSize = true;
            rdPayOut.Location = new Point(265, 200);
            rdPayOut.Margin = new Padding(2);
            rdPayOut.Name = "rdPayOut";
            rdPayOut.Size = new Size(80, 24);
            rdPayOut.TabIndex = 14;
            rdPayOut.TabStop = true;
            rdPayOut.Text = "Pay Out";
            rdPayOut.UseVisualStyleBackColor = true;
            // 
            // rdCashAdvance
            // 
            rdCashAdvance.AutoSize = true;
            rdCashAdvance.Location = new Point(79, 200);
            rdCashAdvance.Margin = new Padding(2);
            rdCashAdvance.Name = "rdCashAdvance";
            rdCashAdvance.Size = new Size(122, 24);
            rdCashAdvance.TabIndex = 13;
            rdCashAdvance.TabStop = true;
            rdCashAdvance.Text = "Cash Advance";
            rdCashAdvance.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(17, 149);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(17, 127);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 11;
            label2.Text = "Present Date";
            // 
            // label1
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(17, 78);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "label1";
            lblName.Size = new Size(124, 23);
            lblName.TabIndex = 10;
            lblName.Text = "John Martinez";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdress.ForeColor = Color.Black;
            lblAdress.Location = new Point(17, 59);
            lblAdress.Margin = new Padding(2, 0, 2, 0);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(117, 22);
            lblAdress.TabIndex = 9;
            lblAdress.Text = "Employee Name";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.ForeColor = Color.Black;
            lblLocation.Location = new Point(17, 18);
            lblLocation.Margin = new Padding(2, 0, 2, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(157, 25);
            lblLocation.TabIndex = 8;
            lblLocation.Text = "Add Transaction";
            // 
            // AddTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 369);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "AddTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTransaction";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown nudAmount;
        public Label label3;
        private RadioButton rdPayOut;
        private RadioButton rdCashAdvance;
        private DateTimePicker dateTimePicker1;
        public Label label2;
        public Label lblName;
        public Label lblAdress;
        public Label lblLocation;
        private Button button2;
        private Button button1;
    }
}
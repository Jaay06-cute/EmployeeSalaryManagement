namespace EmployeeSalaryManagement.LocationControls
{
    partial class ViewEmployeeTransactionControl
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
            button1 = new Button();
            lblBalance = new Label();
            comboBox1 = new ComboBox();
            floTransaction = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(552, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(141, 34);
            button1.TabIndex = 1;
            button1.Text = "Add Transactions";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.Black;
            lblBalance.Location = new Point(361, 8);
            lblBalance.Margin = new Padding(2, 0, 2, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(39, 22);
            lblBalance.TabIndex = 8;
            lblBalance.Text = "-$50";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 7);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 28);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Date";
            // 
            // floTransaction
            // 
            floTransaction.AutoScroll = true;
            floTransaction.FlowDirection = FlowDirection.TopDown;
            floTransaction.Location = new Point(0, 52);
            floTransaction.Name = "floTransaction";
            floTransaction.Size = new Size(700, 259);
            floTransaction.TabIndex = 10;
            floTransaction.WrapContents = false;
            // 
            // ViewEmployeeTransactionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(floTransaction);
            Controls.Add(comboBox1);
            Controls.Add(lblBalance);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "ViewEmployeeTransactionControl";
            Size = new Size(702, 314);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        public Label lblBalance;
        private ComboBox comboBox1;
        private FlowLayoutPanel floTransaction;
    }
}

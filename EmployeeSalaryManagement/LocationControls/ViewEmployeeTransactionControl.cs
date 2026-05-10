using EmployeeSalaryManagement.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement.LocationControls
{
    public partial class ViewEmployeeTransactionControl : UserControl
    {
        public ViewEmployeeTransactionControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction();
            addTransaction.Show();
        }
    }
}

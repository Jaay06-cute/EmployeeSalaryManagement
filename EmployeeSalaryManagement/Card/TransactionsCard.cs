using EmployeeSalaryManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement.Card
{
    public partial class TransactionsCard : UserControl
    { 
        private Checkout _checkout;
        public TransactionsCard(Checkout checkout)
        {
            InitializeComponent();
            _checkout = checkout;
            SetData(_checkout);
        }
        private void SetData(Checkout checkout)
        {
            lblDate.Text = checkout.TransactionDate.ToString("MMMM dd, yyyy");
            lblTransactionType.Text = checkout.TransactionType;
            lblAmount.Text = $"-Php  {checkout.Amount:N2}";
            lblAmount.ForeColor = checkout.TransactionType == "Pay Out" ? Color.Green : Color.Red;
        }
    }
}

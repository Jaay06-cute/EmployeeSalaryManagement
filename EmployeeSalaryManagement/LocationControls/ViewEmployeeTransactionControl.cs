using EmployeeSalaryManagement.Card;
using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Notification;
using EmployeeSalaryManagement.Repository;
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
        private int _employeeID;
        private readonly IEmployeeRepository _repository = new EmployeeRepository(new SalaryDbContext());
        public ViewEmployeeTransactionControl(int employeeID)
        {
            InitializeComponent();
            _employeeID = employeeID;
            LoadTransactions();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction(_employeeID);
            addTransaction.ShowDialog();
            LoadTransactions();
        }
        private async void LoadTransactions()
        {
            floTransaction.Controls.Clear();
            var repo = new CheckoutRepository(new SalaryDbContext());
            var transactions = await repo.GetByEmployeeIdAsync(_employeeID);
            var employee = await _repository.GetByIdAsync(_employeeID);
            lblBalance.Text = $"Current Balance : P{employee.Balance}";
            foreach (var item in transactions)
            {
                var card = new TransactionsCard(item);
                card.Width = floTransaction.Width - 25;
                floTransaction.Controls.Add(card);
            }
        }
    }
}

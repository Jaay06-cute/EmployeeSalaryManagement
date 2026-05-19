using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using EmployeeSalaryManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement
{
    public partial class DashboardControl : UserControl
    {
        private readonly ICheckoutRepository _checkoutRepository = new CheckoutRepository(new SalaryDbContext());
        private readonly IEmployeeRepository _employee = new EmployeeRepository(new SalaryDbContext());
        public DashboardControl()
        {
            InitializeComponent();
            Info();
        }
        private async void Info()
        {
            var transactions = await _checkoutRepository.GetAllTransactionsAsync();
            double montly = await _checkoutRepository.GetTotalTransactionAmountThisMonthAsync();
            double amount = await _employee.GetTotalEmployeeBalanceAsync();
            double tramsactionCount = await _checkoutRepository.GetTransactionCountThisMonthAsync();
            lblEmployee.Text = _employee.GetAllEmployeesAsync().Result.Count().ToString();
            lblSalary.Text = "Php  " + montly.ToString();
            lblBalance.Text = "Php  " + amount.ToString();
            lblCount.Text = tramsactionCount.ToString();
            dataGridView2.DataSource = transactions.Select(c => new
            {
                ID = c.EmployeeId,
                Location = c.Employee?.Position?.Location?.LocationName ?? "N/A",
                Name = c.Employee?.EmployeeName ?? "Unknown",
                Position = c.Employee?.Position?.WorkPosition ?? "N/A",
                TransactionType = c.TransactionType,
                Amount = c.Amount,
            }).ToList();
        }
    }
}

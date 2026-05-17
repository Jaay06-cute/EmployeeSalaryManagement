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

namespace EmployeeSalaryManagement.Notification
{
    public partial class AddTransaction : Form
    {
        private int _employeeId;
        IEmployeeRepository _repo = new EmployeeRepository(new SalaryDbContext());
        public AddTransaction(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            var employee = _repo.GetByIdAsync(employeeId).Result;
            lblName.Text = $"{employee.EmployeeName}";
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = (double)nudAmount.Value;
                string type = rdCashAdvance.Checked ? "Cash Advance" : "Pay Out";
                var checkout = new Checkout
                {
                    EmployeeId = _employeeId,
                    Amount = amount,
                    TransactionType = type,
                    TransactionDate = dateTimePicker1.Value,
                };

                ICheckoutRepository checkoutRepo = new CheckoutRepository(new SalaryDbContext());
                await checkoutRepo.AddAsync(checkout);
                await checkoutRepo.SaveAsync();

                MessageBox.Show("Transaction saved and balance updated!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

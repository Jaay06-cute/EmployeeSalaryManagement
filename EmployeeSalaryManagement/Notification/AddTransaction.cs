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
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = (double)nudAmount.Value;
                if (amount <= 0)
                {
                    MessageBox.Show("Please enter an amount greater than zero.");
                    return;
                }
                if (!rdCashAdvance.Checked && !rdPayOut.Checked)
                {
                    MessageBox.Show("Please select a transaction type (Cash Advance or Pay Out).");
                    return;
                }
                string type = rdCashAdvance.Checked ? "Cash Advance" : "Pay Out";
                var employee = await _repo.GetByIdAsync(_employeeId);
                if(employee == null)
                {
                    MessageBox.Show("Employee not found.");
                    return;
                }
                if (employee.Balance < amount)
                { 
                    MessageBox.Show("Insufficient balance for this transaction.");
                    return;
                }
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

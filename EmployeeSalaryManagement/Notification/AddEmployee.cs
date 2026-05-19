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
    public partial class AddEmployee : Form
    {
        private int _positionId;
        private bool isUpdateMode = false;
        private Employee _existingEmployee;

        public AddEmployee(int positionId)
        {
            InitializeComponent();
            _positionId = positionId;
            isUpdateMode = false;
            lblBalance.Visible = false;
            txtBalance.Visible = false;
            btnLogin.Location = new Point(99, 147);
            this.Text = "Add New Employee";
            btnLogin.Text = "Save Employee";
        }

        public AddEmployee(Employee employeeToEdit)
        {
            InitializeComponent();
            isUpdateMode = true;
            _existingEmployee = employeeToEdit;
            _positionId = employeeToEdit.PositionId;

            lblBalance.Visible = true;
            txtBalance.Visible = true;

            btnLogin.Location = new Point(99, 223);

            this.Text = "Update Employee Details";
            btnLogin.Text = "Update";
            txtName.Text = _existingEmployee.EmployeeName;
            txtBalance.Text = _existingEmployee.Balance.ToString();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IEmployeeRepository repo = new EmployeeRepository(new SalaryDbContext());

            try
            {
                if (isUpdateMode)
                {
                    _existingEmployee.EmployeeName = txtName.Text;
                    if (double.TryParse(txtBalance.Text, out double updatedBalance))
                    {
                        _existingEmployee.Balance = updatedBalance;
                    }

                    repo.Update(_existingEmployee);
                    MessageBox.Show("Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    double.TryParse(txtBalance.Text, out double initialBalance);

                    var newEmployee = new Model.Employee
                    {
                        EmployeeName = txtName.Text,
                        PositionId = _positionId,
                        Balance = initialBalance
                    };

                    await repo.AddAsync(newEmployee);
                    MessageBox.Show("Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                await repo.SaveAsync();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
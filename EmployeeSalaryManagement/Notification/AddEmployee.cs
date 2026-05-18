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
            this.Text = "Add New Employee";
            btnLogin.Text = "Save Employee";
        }
        public AddEmployee(Employee employeeToEdit)
        {
            InitializeComponent();
            isUpdateMode = true;
            _existingEmployee = employeeToEdit;
            _positionId = employeeToEdit.PositionId;
            this.Text = "Update Employee Details";
            btnLogin.Text = "Update";
            txtName.Text = _existingEmployee.EmployeeName;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a valid Employee Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IEmployeeRepository repo = new EmployeeRepository(new SalaryDbContext());

            try
            {
                if (isUpdateMode)
                {
                    _existingEmployee.EmployeeName = txtName.Text;
                    _existingEmployee.PositionId = _positionId; // Kept intact

                    repo.Update(_existingEmployee);
                    await repo.SaveAsync(); 
                    MessageBox.Show("Employee records updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var newEmployee = new Model.Employee
                    {
                        EmployeeName = txtName.Text,
                        PositionId = _positionId
                    };

                    await repo.AddAsync(newEmployee);
                    MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                await repo.SaveAsync();

                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving employee data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
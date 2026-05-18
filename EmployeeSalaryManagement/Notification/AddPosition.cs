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
    public partial class AddPosition : Form
    {
        private int _locationID;
        private bool isUpdateMode = false;
        private Position _existingPosition; 
        public AddPosition(int locationID)
        {
            InitializeComponent();
            _locationID = locationID;
            isUpdateMode = false;
            this.Text = "Add New Position";
            btnLogin.Text = "Save Position"; 
        }
        public AddPosition(Position positionToEdit)
        {
            InitializeComponent();
            isUpdateMode = true;
            _existingPosition = positionToEdit;
            _locationID = positionToEdit.LocationId;
            this.Text = "Update Position";
            btnLogin.Text = "Update";
            txtPosition.Text = _existingPosition.WorkPosition;
            txtSalary.Text = _existingPosition.Salary.ToString();
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Please input a valid Position title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double parsingSalary = 0;
            if (!double.TryParse(txtSalary.Text, out parsingSalary))
            {
                MessageBox.Show("Please input a valid numeric Salary amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IPositionRepository repo = new PositionRepository(new SalaryDbContext());
            try
            {
                if (isUpdateMode)
                {
                    _existingPosition.WorkPosition = txtPosition.Text;
                    _existingPosition.Salary = parsingSalary;
                    _existingPosition.LocationId = _locationID;

                    repo.Update(_existingPosition); 
                    await repo.SaveAsync(); 
                    MessageBox.Show("Position updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var newPosition = new Model.Position
                    {
                        WorkPosition = txtPosition.Text,
                        Salary = parsingSalary,
                        LocationId = _locationID
                    };

                    await repo.AddAsync(newPosition);
                    MessageBox.Show("Position added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                await repo.SaveAsync();

                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
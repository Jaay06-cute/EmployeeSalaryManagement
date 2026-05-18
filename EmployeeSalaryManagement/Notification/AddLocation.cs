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
    public partial class AddLocation : Form
    {
        
        private bool isUpdateMode = false;
        private Location _existingLocation;
        public AddLocation()
        {
            InitializeComponent();
            isUpdateMode = false;
            this.Text = "Add New Location";
            btnSubmit.Text = "Save Location"; 
        }
        public AddLocation(Location locationToEdit)
        {
            InitializeComponent();
            isUpdateMode = true;
            _existingLocation = locationToEdit;
            this.Text = "Update Location";
            btnSubmit.Text = "Update";
            txtLocation.Text = _existingLocation.LocationName;
            txtAddress.Text = _existingLocation.LocationAddress;
        }
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please input a valid Address and Location Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ILocationRepository repo = new LocationRepository(new SalaryDbContext());
            try
            {
                if (isUpdateMode)
                {
                    _existingLocation.LocationName = txtLocation.Text;
                    _existingLocation.LocationAddress = txtAddress.Text;

                    repo.Update(_existingLocation);
                    await repo.SaveAsync(); 
                    MessageBox.Show("Location updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var newLocation = new Location
                    {
                        LocationName = txtLocation.Text,
                        LocationAddress = txtAddress.Text
                    };
                    await repo.AddAsync(newLocation);
                    MessageBox.Show("Location added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                await repo.SaveAsync();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
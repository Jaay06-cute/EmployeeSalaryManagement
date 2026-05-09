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
        public AddLocation()
        {
            InitializeComponent();
        }

        private async void AddingLoc(object sender, EventArgs e)
        {
            ILocationRepository repo = new LocationRepository( new SalaryDbContext());
            var location = new Location
            {
                LocationName = txtLocation.Text,
                LocationAddress = txtAddress.Text
            };
            await repo.AddAsync(location);
            await repo.SaveAsync();
            this.Hide();
        }
    }
}

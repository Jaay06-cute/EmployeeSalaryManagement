using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.LocationControls;
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
        public AddPosition(int locationID)
        {
            InitializeComponent();
            _locationID = locationID;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new SalaryDbContext();
            var position = new Model.Position
            {
                WorkPosition = txtPosition.Text,
                Salary = (double)decimal.Parse(txtSalary.Text),
                LocationId = _locationID
            };
            db.Positions.Add(position);
            db.SaveChanges();
            this.Hide();
        }
    }
}

using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.Model;
using EmployeeSalaryManagement.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement.LocationControls
{
    public partial class LaborEmployeesController : UserControl
    {
        private int _PositionId;
        private string _Location;
        private int _LocationId;
        public LaborEmployeesController(int positionId, string positionName, string Location, int locationId)
        {
            InitializeComponent();
            _PositionId = positionId;
            _Location = Location;
            _LocationId = locationId;
            lblLabor.Text = positionName + " Employee";
            Info();
        }
        private void LoadControl(UserControl uc)
        {
            DowntownContent.Controls.Clear();   // remove old page
            uc.Dock = DockStyle.Fill;     // fill panel
            DowntownContent.Controls.Add(uc);
        }

        private void BackClick(object sender, EventArgs e)
        {
            LoadControl(new DowntownOfficeControl(_LocationId, _Location));
        }

        private void BackArrowClick(object sender, EventArgs e)
        {
            LoadControl(new DowntownOfficeControl(_LocationId, _Location));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployee main = new AddEmployee(_PositionId);
            main.ShowDialog();
            Info();
        }
        private void Info()
        {
            var db = new SalaryDbContext();
            dataGridView1.DataSource = db.Employees.Where(e => e.PositionId == _PositionId).Select(e => new
            {
                ID = e.EmployeeID,
                Name = e.EmployeeName,
                Salary = e.Position.Salary
            }).ToList();
        }
    }
}

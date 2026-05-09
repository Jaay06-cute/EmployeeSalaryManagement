using EmployeeSalaryManagement.EmployeeManagementDbContext;
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
        private int _PositionId;
        public AddEmployee(int PositionId)
        {
            InitializeComponent();
            _PositionId = PositionId;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new SalaryDbContext();
            var employee = new Model.Employee
            {
                EmployeeName = txtName.Text,
                PositionId = _PositionId,
            };
            db.Employees.Add(employee);
            db.SaveChanges();
            this.Hide();
        }
    }
}

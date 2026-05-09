using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
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
        private int _PositionId;
        public AddEmployee(int PositionId)
        {
            InitializeComponent();
            _PositionId = PositionId;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            IEmployeeRepository repo = new EmployeeRepository(new SalaryDbContext());
            var employee = new Model.Employee
            {
                EmployeeName = txtName.Text,
                PositionId = _PositionId,
            };
            await repo.AddAsync(employee);
            await repo.SaveAsync();
            this.Hide();
        }
    }
}

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

namespace EmployeeSalaryManagement
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            Info();
        }
        private async void Info()
        {
            IEmployeeRepository employee = new EmployeeRepository(new SalaryDbContext());
            lblEmployee.Text = employee.GetAllAsync().Result.Count().ToString();
            IPositionRepository position = new PositionRepository(new SalaryDbContext());
            lblSalary.Text ="P" + await position.GetTotalCompanyPayrollAsync();
        }
    }
}

using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.LocationControls;
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
    public partial class ViewEmployee : Form
    {
        private int _employeeId;
        private readonly IEmployeeRepository _employeeRepo = new EmployeeRepository(new SalaryDbContext());
        public ViewEmployee(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            LoadControl(new ViewEmployeeAttendanceControl(_employeeId));
            lblName.Text = _employeeRepo.GetNameByIdAsync(employeeId).Result;
            lblID.Text = "ID - " + employeeId.ToString();
        }
        private void LoadControl(UserControl uc)
        {
            MainContentView.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            MainContentView.Controls.Add(uc);
        }
        private void button4_Click(object sender, EventArgs e)
        {

            LoadControl(new ViewEmployeeTransactionControl(_employeeId));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadControl(new ViewEmployeeAttendanceControl(_employeeId));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                isDeleted = true
            };
            _employeeRepo.SoftDeleteAsync(employee, _employeeId);
            MessageBox.Show("Employee Deleted Successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var employee = _employeeRepo.GetByIdAsync(_employeeId).Result;
            if(employee == null) return;
            AddEmployee updadateEmployee = new AddEmployee(employee);
            updadateEmployee.ShowDialog();
        }
    }
}

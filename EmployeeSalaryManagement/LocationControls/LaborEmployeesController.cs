using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
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
        private readonly IEmployeeRepository _employeeRepo;

        public LaborEmployeesController(int positionId, string positionName, string Location, int locationId)
        {
            InitializeComponent();
            _PositionId = positionId;
            _Location = Location;
            _LocationId = locationId;
            lblLabor.Text = positionName + " Employee";
            _employeeRepo = new Repository.EmployeeRepository(new SalaryDbContext());
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
        private async void Info()
        {
            try
            {
                var employees = await _employeeRepo.GetEmployeesByPositionAsync(_PositionId);
                dataGridView1.DataSource = employees.Select(e => new
                {
                    ID = e.EmployeeID,
                    Name = e.EmployeeName,
                    Salary = e.Position.Salary
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

       
        

        //VIEW NI SYA SA EMPLOYEE IKAW LNG NAVIGATE SA EACH EMPLOYTEE EVERY CLICK CELL
        private void gridClick(object sender, EventArgs e)
        {
            ViewEmployee employee = new ViewEmployee();
            employee.Show();
        }
    }
}

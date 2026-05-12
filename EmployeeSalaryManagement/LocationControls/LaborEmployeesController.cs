using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using EmployeeSalaryManagement.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement.LocationControls
{
    public partial class LaborEmployeesController : UserControl
    {
        private string _searchTerm;
        private int _PositionId;
        private string _Location;
        private int _LocationId;
        private readonly IEmployeeRepository _employeeRepo;

        public LaborEmployeesController(int positionId, string positionName, string Location, int locationId, string searchTerm = "")
        {
            InitializeComponent();
            _PositionId = positionId;
            _Location = Location;
            _LocationId = locationId;
            _searchTerm = searchTerm;
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
            LoadControl(new DowntownOfficeControl(_LocationId, _Location, _searchTerm));
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
                var employees = await _employeeRepo.SearchEmployeesInPositionAsync(_PositionId, _searchTerm);
                int count = employees.Count();
                label11.Text = $"{count} employees found";
                dataGridView1.DataSource = employees.Select(e => new
                {
                    ID = e.EmployeeID,
                    Name = e.EmployeeName,
                    Salary = e.Position.Salary,
                    SalaryBalance = e.Balance
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                dynamic selectedItem = row.DataBoundItem;
                int employeeId = selectedItem.ID;
                ViewEmployee employee = new ViewEmployee(employeeId);
                employee.ShowDialog();
                Info();
            }
        }
    }
}

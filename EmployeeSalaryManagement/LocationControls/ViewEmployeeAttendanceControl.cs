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

namespace EmployeeSalaryManagement.LocationControls
{

    public partial class ViewEmployeeAttendanceControl : UserControl
    {
        private int _employeeID;
        private readonly IAttendanceRepository _attendanceRepo = new AttendanceRepository(new SalaryDbContext());
        public ViewEmployeeAttendanceControl(int employeeID)
        {
            InitializeComponent();
            _employeeID = employeeID;
            Info();
        }
        public async void Info()
        {
            try
            {
                var history = await _attendanceRepo.GetEmployeeWorkHistoryAsync(_employeeID);
                dataGridView1.DataSource = history.Select(a => new
                {
                    Date = a.Date.ToString("MMMM dd, yyyy"),
                    Status = a.Status
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading history: {ex.Message}");
            }
        }
    }
}

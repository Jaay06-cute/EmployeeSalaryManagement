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

namespace EmployeeSalaryManagement
{
    public partial class AttendanceControl : UserControl
    {
        private readonly ILocationRepository locationrepo = new LocationRepository(new SalaryDbContext());
        private readonly IEmployeeRepository employeerepo = new EmployeeRepository(new SalaryDbContext());
        private readonly IAttendanceRepository attendancerepo = new AttendanceRepository(new SalaryDbContext());
        private int _locationId;
        public AttendanceControl()
        {
            InitializeComponent();
            Info();
            Load();
        }
        private async void Info()
        {
            DateTime date = DateTime.Now;
            lblDay.Text = date.Day.ToString();
            lblMonth.Text = date.ToString("MMMM");
            lblWhatDay.Text = date.DayOfWeek.ToString();
            var locations = await locationrepo.GetAllAsync();
            comboBox1.DataSource = locations;
            comboBox1.DisplayMember = "LocationName";
            comboBox1.ValueMember = "LocationId";
        }
        private async void Load()
        {
            var employees = await employeerepo.GetEmployeesByLocationAsync(_locationId);
            dataGridView1.DataSource = employees.Select(e => new
            {
                ID = e.EmployeeID,
                Name = e.EmployeeName,
                Position = e.Position.WorkPosition,
            }).ToList();
            if (dataGridView1.Columns["Column3"] is DataGridViewComboBoxColumn statusCol)
            {
                statusCol.Items.Clear();
                statusCol.Items.Add("No Work");
                statusCol.Items.Add("Present");
                statusCol.Items.Add("Absent");
                statusCol.Items.Add("Late");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int id)
            {
                _locationId = id;
                Load();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var attendanceList = new List<Attendance>();
                DateTime currentDay = DateTime.Now.Date;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Use the column name "ID" from your anonymous object binding
                    if (row.Cells["ID"].Value != null)
                    {
                        int empId = Convert.ToInt32(row.Cells["ID"].Value);

                        // Get status from your ComboBox column (Column3)
                        string status = row.Cells["Column3"]?.Value?.ToString() ?? "No Work";

                        attendanceList.Add(new Attendance
                        {
                            EmployeeId = empId,
                            Date = currentDay,
                            Status = status
                        });
                    }
                }

                if (attendanceList.Count > 0)
                {
                    await attendancerepo.AddRangeAsync(attendanceList);
                    MessageBox.Show("Attendance and Employee Balances updated!", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

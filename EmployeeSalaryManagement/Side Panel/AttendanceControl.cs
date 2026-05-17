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
        private List<Attendance> _currentExistingAttendance = new();
        private int _locationId;
        public AttendanceControl()
        {
            InitializeComponent();
            Info();
            Load();
        }
        private async void Info()
        {
            lblDay.Text = DateTime.Now.ToString("dddd, MMMM d");
            var locations = (await locationrepo.GetAllAsync()).ToList();
            comboBox1.DataSource = locations;
            comboBox1.DisplayMember = "LocationName";
            comboBox1.ValueMember = "LocationId";
            if (locations.Count > 0)
            {
                _locationId = locations[0].LocationId;
                Load();
            }
        }
        private async void Load()
        {
            if (_locationId <= 0) return;
            DateTime currentDay = DateTime.Now.Date;

            var employees = await employeerepo.GetEmployeesByLocationAsync(_locationId);

            // Store this in the class field so the DataBindingComplete event can see it
            _currentExistingAttendance = (await attendancerepo.GetAttendanceByDateAndLocationAsync(currentDay, _locationId)).ToList();

            // Trigger the binding
            dataGridView1.DataSource = employees.Select(e => new
            {
                ID = e.EmployeeID,
                Name = e.EmployeeName,
                Position = e.Position?.WorkPosition ?? "N/A",
            }).ToList();

            // Update Button
            if (_currentExistingAttendance.Any())
            {
                button1.Text = "Edit Attendance";
                button1.BackColor = Color.Orange;
            }
            else
            {
                button1.Text = "Submit Attendance";
                button1.BackColor = Color.Green;
            }
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Columns["Column3"] is DataGridViewComboBoxColumn statusCol)
            {
                // 1. Ensure Items exist
                if (statusCol.Items.Count == 0)
                {
                    statusCol.Items.AddRange(new object[] { "No Work", "Present", "Absent", "Late" });
                }

                // 2. Loop through the rows now that binding is 100% finished
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ID"].Value == null) continue;

                    int empId = (int)row.Cells["ID"].Value;
                    var savedRecord = _currentExistingAttendance.FirstOrDefault(a => a.EmployeeId == empId);

                    // 3. Force the value. 
                    // Note: Use .ToString() to ensure the type matches the ComboBox Item type exactly.
                    row.Cells["Column3"].Value = savedRecord?.Status ?? "No Work";
                }
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

                    if (row.Cells["ID"].Value != null)
                    {
                        int empId = Convert.ToInt32(row.Cells["ID"].Value);
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
                    if (button1.Text == "Edit Attendance")
                    {
                        await attendancerepo.UpdateRangeAsync(attendanceList);
                        MessageBox.Show("Attendance updated successfully!", "Update");
                    }
                    else
                    {
                        await attendancerepo.AddRangeAsync(attendanceList);
                        MessageBox.Show("Attendance saved successfully!", "Success");
                    }
                }
                Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

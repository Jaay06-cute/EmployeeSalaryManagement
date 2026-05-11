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
    public partial class ArchiveControl : UserControl
    {
        public readonly IEmployeeRepository _employeeRepo = new EmployeeRepository(new SalaryDbContext());
        public ArchiveControl()
        {
            InitializeComponent();
            LoadArchive();
        }
        public async void LoadArchive()
        {
            var archivedList = await _employeeRepo.GetArchivedEmployeesAsync();
            lblList.Text = archivedList.Count().ToString();
            dataGridView2.DataSource = archivedList.Select(e => new
            {
                ID = e.EmployeeID,
                Location = e.Position?.Location?.LocationName ?? "No Location",
                Name = e.EmployeeName,
                Position = e.Position?.WorkPosition ?? "No Position"
            }).ToList();
        }

        private async void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on headers or empty rows
            if (e.RowIndex < 0) return;

            // 1. Get the Employee ID from the hidden or visible ID column
            // Replace "ID" with the actual (Name) of your ID column from the designer
            int employeeId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Column1"].Value);

            if (dataGridView2.Columns[e.ColumnIndex].HeaderText == "Retrieve")
            {
                await _employeeRepo.RestoreEmployeeAsync(employeeId);
                MessageBox.Show("Employee restored to active list.");
                LoadArchive(); // Refresh the grid
            }

            if (dataGridView2.Columns[e.ColumnIndex].HeaderText == "Detele") // Match your typo 'Detele' from screenshot
            {
                var confirm = MessageBox.Show("Are you sure you want to PERMANENTLY delete this record?",
                                            "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    await _employeeRepo.HardDeleteEmployeeAsync(employeeId);
                    LoadArchive(); 
                }
            }
        }
    }
}

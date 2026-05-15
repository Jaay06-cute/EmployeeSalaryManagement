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
        // Update your LoadArchive to accept an optional search term
        public async void LoadArchive(string term = "")
        {
            try
            {
                // Call the new search method
                var archivedList = await _employeeRepo.SearchArchivedEmployeesAsync(term);

                lblList.Text = archivedList.Count().ToString();

                dataGridView2.DataSource = archivedList.Select(e => new
                {
                    ID = e.EmployeeID,
                    Location = e.Position?.Location?.LocationName ?? "No Location",
                    Name = e.EmployeeName,
                    Position = e.Position?.WorkPosition ?? "No Position"
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching archive: " + ex.Message);
            }
        }

        // 1. LIVE FILTERING: Add this event from the Designer
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadArchive(txtSearch.Text.Trim());
        }

        // 2. SEARCH BUTTON: For the "Teleport" or manual click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadArchive(txtSearch.Text.Trim());
        }

        private async void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

       
            int employeeId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Column1"].Value);

            if (dataGridView2.Columns[e.ColumnIndex].HeaderText == "Retrieve")
            {
                await _employeeRepo.RestoreEmployeeAsync(employeeId);
                MessageBox.Show("Employee restored to active list.");
                LoadArchive();
            }
            if (dataGridView2.Columns[e.ColumnIndex].HeaderText == "Detele") 
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

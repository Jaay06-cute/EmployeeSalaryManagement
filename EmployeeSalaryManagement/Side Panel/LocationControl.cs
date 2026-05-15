using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.LocationControls;
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
    public partial class LocationControl : UserControl
    {
        public LocationControl()
        {
            InitializeComponent();
            LoadControl(new LocationMainContentControl());
        }

        private void LoadControl(UserControl uc)
        {
            LocationContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            LocationContent.Controls.Add(uc);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string term = textBox1.Text.Trim();
            var repo = new LocationRepository(new SalaryDbContext());
            var locations = await repo.SearchLocationsAsync(term);

            if (locations.Count() == 1)
            {
                var loc = locations.First();

                // FIX: Include loc.LocationName in the check
                var matchingPositions = loc.Positions.Where(p =>
                    loc.LocationName.Contains(term, StringComparison.OrdinalIgnoreCase) || // <--- Added this
                    p.WorkPosition.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                    p.Employees.Any(emp => emp.EmployeeName.Contains(term, StringComparison.OrdinalIgnoreCase))
                ).ToList();

                if (matchingPositions.Count == 1)
                {
                    var pos = matchingPositions.First();
                    LoadControl(new LaborEmployeesController(pos.PositionId, pos.WorkPosition, loc.LocationName, loc.LocationId, term));
                }
                else
                {
                    // If there are multiple positions (or it's just a general location search), 
                    // show the Office view with all positions.
                    LoadControl(new DowntownOfficeControl(loc.LocationId, loc.LocationName, term));
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string term = textBox1.Text.Trim();
            LoadControl(new LocationMainContentControl(term));
        }
    }
}

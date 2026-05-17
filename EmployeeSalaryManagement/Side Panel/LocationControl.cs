using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.LocationControls;
using EmployeeSalaryManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement
{
    public partial class LocationControl : UserControl
    {
        // Define our possible sub-views
        public enum LocationViewMode
        {
            MainDashboard,
            OfficePositions,
            LaborEmployees
        }

        // Track the current view mode explicitly
        private LocationViewMode _currentViewMode = LocationViewMode.MainDashboard;
        private bool _isSearchingViaButton = false;

        public LocationControl()
        {
            InitializeComponent();
            LoadDefaultView();
        }

        private void LoadDefaultView()
        {
            _currentViewMode = LocationViewMode.MainDashboard;
            LocationContent.Controls.Clear();
            var uc = new LocationMainContentControl();
            uc.Dock = DockStyle.Fill;
            LocationContent.Controls.Add(uc);
        }

        // Use this method to change views from back buttons or card clicks
        public void LoadControl(UserControl uc, LocationViewMode viewMode)
        {
            _currentViewMode = viewMode;
            LocationContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            LocationContent.Controls.Add(uc);

            // Optional: clear the search box text when switching screens completely
            _isSearchingViaButton = true;
            textBox1.Clear();
            _isSearchingViaButton = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string term = textBox1.Text.Trim();
            _isSearchingViaButton = true;

            try
            {
                var repo = new LocationRepository(new SalaryDbContext());
                var locations = await repo.SearchLocationsAsync(term);

                if (locations.Count() == 1)
                {
                    var loc = locations.First();
                    var matchingPositions = loc.Positions.Where(p =>
                        loc.LocationName.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                        p.WorkPosition.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                        p.Employees.Any(emp => emp.EmployeeName.Contains(term, StringComparison.OrdinalIgnoreCase))
                    ).ToList();

                    if (matchingPositions.Count == 1)
                    {
                        var pos = matchingPositions.First();
                        LoadControl(new LaborEmployeesController(pos.PositionId, pos.WorkPosition, loc.LocationName, loc.LocationId, term), LocationViewMode.LaborEmployees);
                    }
                    else
                    {
                        LoadControl(new DowntownOfficeControl(loc.LocationId, loc.LocationName, term), LocationViewMode.OfficePositions);
                    }
                }
            }
            finally
            {
                _isSearchingViaButton = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_isSearchingViaButton) return;
            string term = textBox1.Text.Trim();

            if (LocationContent.Controls.Count > 0)
            {
                Control currentControl = LocationContent.Controls[0];

                switch (_currentViewMode)
                {
                    case LocationViewMode.MainDashboard:
                        // ONLY reload the main dashboard if we are explicitly in dashboard mode
                        LocationContent.Controls.Clear();
                        var mainGrid = new LocationMainContentControl(term);
                        mainGrid.Dock = DockStyle.Fill;
                        LocationContent.Controls.Add(mainGrid);
                        break;

                    case LocationViewMode.LaborEmployees:
                        // Safely filter employee grid view using dynamic invocation
                        try { ((dynamic)currentControl).UpdateSearchFromParent(term); } catch { }
                        break;

                    case LocationViewMode.OfficePositions:
                        // Safely filter position cards using dynamic invocation
                        try { ((dynamic)currentControl).UpdateSearchFromParent(term); } catch { }
                        break;
                }
            }
        }
    }
}
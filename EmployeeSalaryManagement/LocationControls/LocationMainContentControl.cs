using EmployeeSalaryManagement.Card;
using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.Notification;
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
    public partial class LocationMainContentControl : UserControl
    {
        private string _searchTerm;
        public LocationMainContentControl(string searchTerm = "")
        {
            InitializeComponent();
            _searchTerm = searchTerm;
            LoadLocations();
        }
        private void LoadControl(UserControl uc)
        {
            LocationMainContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            LocationMainContent.Controls.Add(uc);
        }
        public async void LoadLocations()
        {
            flpLocation.Controls.Clear();
            var repo = new LocationRepository(new SalaryDbContext());
            var locations = await repo.SearchLocationsAsync(_searchTerm);
            foreach (var loc in locations)
            {
                var card = new LocationCardControl(loc, repo);
                int positionCount = loc.Positions.Count;
                int totalEmployeeCount = loc.Positions.Sum(p => p.Employees.Count);
                card.lblJobs.Text = $"Jobs: {positionCount}";
                card.lblEmployees.Text = $"Employees: {totalEmployeeCount}";
                int currentId = loc.LocationId;
                string currentName = loc.LocationName;
                card.CardClicked += (s, e) => {
                    var masterParent = this.ParentForm?.Controls.Find("LocationControl", true).FirstOrDefault() as LocationControl;
                    if (masterParent != null)
                    {
                        masterParent.LoadControl(new DowntownOfficeControl(currentId, currentName, _searchTerm), LocationControl.LocationViewMode.OfficePositions);
                    }
                };

                flpLocation.Controls.Add(card);
            }
        }
        private void AddLocationClick(object sender, EventArgs e)
        {
            AddLocation location = new AddLocation();
            location.ShowDialog();
            LoadLocations();
        }
    }
}

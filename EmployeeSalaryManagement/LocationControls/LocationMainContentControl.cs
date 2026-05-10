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

        public LocationMainContentControl()
        {
            InitializeComponent();
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
            var locations = await repo.GetLocationsWithDetailsAsync();

            foreach (var loc in locations)
            {
                int positionCount = loc.Positions.Count;
                int totalEmployeeCount = loc.Positions.Sum(p => p.Employees.Count);

                var card = new LocationCardControl();
                card.lblLocation.Text = loc.LocationName;
                card.lblAdress.Text = loc.LocationAddress;
                card.lblJobs.Text = $"Jobs: {positionCount}";
                card.lblEmployees.Text = $"Employees: {totalEmployeeCount}";

                int currentId = loc.LocationId;
                string currentName = loc.LocationName;

                card.CardClicked += (s, e) => {
                    LoadControl(new DowntownOfficeControl(currentId, currentName));
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

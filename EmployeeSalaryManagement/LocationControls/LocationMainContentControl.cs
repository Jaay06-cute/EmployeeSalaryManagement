using EmployeeSalaryManagement.Card;
using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.Notification;
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
        public void LoadLocations()
        {
            flpLocation.Controls.Clear();

            using (var context = new SalaryDbContext())
            {
                var locations = context.Locations.ToList();

                foreach (var loc in locations)
                {
                    var positionIdsForThisLocation = context.Positions
            .Where(p => p.LocationId == loc.LocationId)
            .Select(p => p.PositionId)
            .ToList();

                    int positionCount = positionIdsForThisLocation.Count;

                    int totalEmployeeCount = context.Employees
                        .Count(e => positionIdsForThisLocation.Contains(e.PositionId));
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
        }
        private void AddLocationClick(object sender, EventArgs e)
        {
            AddLocation location = new AddLocation();
            location.ShowDialog();
            LoadLocations();
        }
    }
}

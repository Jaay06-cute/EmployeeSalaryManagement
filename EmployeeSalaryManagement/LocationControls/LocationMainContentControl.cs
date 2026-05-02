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
        }
        private void LoadControl(UserControl uc)
        {
            LocationMainContent.Controls.Clear();   // remove old page
            uc.Dock = DockStyle.Fill;     // fill panel
            LocationMainContent.Controls.Add(uc);   // add new page
        }

        private void DowntownClick(object sender, EventArgs e)
        {
            LoadControl(new DowntownOfficeControl());
        }



        private void AddLocationClick(object sender, EventArgs e)
        {
            AddLocation location = new AddLocation();
            location.Show();
        }

        private void WarehouseClick(object sender, EventArgs e)
        {
            LoadControl(new DowntownOfficeControl());
        }

        private void TechClick(object sender, EventArgs e)
        {
            LoadControl(new DowntownOfficeControl());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlLocation(object sender, EventArgs e)
        {
            LoadControl(new DowntownOfficeControl());
        }
    }
}

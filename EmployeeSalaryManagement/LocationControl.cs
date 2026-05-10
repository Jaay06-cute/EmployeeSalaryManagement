using EmployeeSalaryManagement.LocationControls;
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

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

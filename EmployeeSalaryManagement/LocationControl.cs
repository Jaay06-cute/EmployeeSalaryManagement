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
            LocationContent.Controls.Clear();   // remove old page
            uc.Dock = DockStyle.Fill;     // fill panel
            LocationContent.Controls.Add(uc);   // add new page
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLocation(object sender, EventArgs e)
        {
            LoadControl(new LaborEmployeesController());
        }
    }
}

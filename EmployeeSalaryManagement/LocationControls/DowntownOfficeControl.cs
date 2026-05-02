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
    public partial class DowntownOfficeControl : UserControl
    {
        public DowntownOfficeControl()
        {
            InitializeComponent();
        }
        private void LoadControl(UserControl uc)
        {
            DowntownContent.Controls.Clear();   // remove old page
            uc.Dock = DockStyle.Fill;     // fill panel
            DowntownContent.Controls.Add(uc);   // add new page
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LocationContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackClick(object sender, EventArgs e)
        {
            LoadControl(new LocationMainContentControl());
        }

        private void BackArrowClick(object sender, EventArgs e)
        {
            LoadControl(new LocationMainContentControl());
        }

        private void WorkClick(object sender, EventArgs e)
        {
            LoadControl(new LaborEmployeesController());
        }

        private void pnlLabor(object sender, EventArgs e)
        {
            LoadControl(new LaborEmployeesController());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPosition main = new AddPosition();
            main.Show();
        }
    }
}

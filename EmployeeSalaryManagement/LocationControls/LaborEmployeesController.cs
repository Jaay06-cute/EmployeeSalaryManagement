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
    public partial class LaborEmployeesController : UserControl
    {
        public LaborEmployeesController()
        {
            InitializeComponent();
        }
        private void LoadControl(UserControl uc)
        {
            DowntownContent.Controls.Clear();   // remove old page
            uc.Dock = DockStyle.Fill;     // fill panel
            DowntownContent.Controls.Add(uc);   // add new page
        }

        private void BackClick(object sender, EventArgs e)
        {
            LoadControl(new DowntownOfficeControl());
        }

        private void BackArrowClick(object sender, EventArgs e)
        {
            LoadControl(new DowntownOfficeControl());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployee main = new AddEmployee();
            main.Show();
        }
    }
}

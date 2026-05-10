using EmployeeSalaryManagement.LocationControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement.Notification
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
            LoadControl(new ViewEmployeeAttendanceControl());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadControl(UserControl uc)
        {
            MainContentView.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            MainContentView.Controls.Add(uc);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            LoadControl(new ViewEmployeeTransactionControl());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadControl(new ViewEmployeeAttendanceControl());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadForm(new DashboardControl());
        }
        private void LoadForm(object Form)
        {
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);

            UserControl uc = Form as UserControl;
            uc.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(uc);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadForm(new DashboardControl());
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            LoadForm(new LocationControl());
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            LoadForm(new ArchiveControl());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadForm(new SettingsControl());
        }

        private void SignOutClick(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to sign out?",
                "Confirm Sign Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close(); 
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            LoadForm(new AttendanceControl());
        }
    }
}


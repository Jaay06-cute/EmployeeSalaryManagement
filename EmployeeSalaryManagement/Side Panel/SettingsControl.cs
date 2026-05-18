using EmployeeSalaryManagement.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            AssignPanelClickEvent(panel7);
        }
        private void AssignPanelClickEvent(Control container)
        {
            if (container == null) return;
            container.Click += pnlPassword;
            foreach (Control c in container.Controls)
            {
                c.Click += pnlPassword;
                if (c.HasChildren)
                {
                    AssignPanelClickEvent(c);
                }
            }
        }

        private void pnlPassword(object sender, EventArgs e)
        {
            ChangePassword password = new ChangePassword();
            password.ShowDialog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // SIMPLE HARD-CODED LOGIN (MVP ONLY)
            if (username == "admin" && password == "1234")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}

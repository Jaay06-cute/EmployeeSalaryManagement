using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.Repository;
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
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUser = txtUsername.Text.Trim();
            string inputPass = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(inputUser) || string.IsNullOrEmpty(inputPass))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (var db = new SalaryDbContext())
            {
                var repo = new UserRepository(db);
                var user = await repo.AuthenticateAsync(inputUser, inputPass);

                if (user != null)
                {
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.");
                }
            }
        }
    }
}

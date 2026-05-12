using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement.Notification
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username and Password cannot be empty.");
                return;
            }

            string newUsername = txtUsername.Text.Trim();
            string newPass = txtPassword.Text.Trim();
            string currentPass = txtCurrentPassword.Text.Trim();

            try
            {
                using (var db = new SalaryDbContext())
                {
                    var repo = new UserRepository(db);

                    if (await repo.VerifyLoginAsync("staff", currentPass))
                    {
                        bool success = await repo.UpdateStaffAccountAsync(newUsername, newPass);
                        if (success)
                        {
                            MessageBox.Show("Staff account updated successfully!");
                            this.Close(); 
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current password does not match.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }

}

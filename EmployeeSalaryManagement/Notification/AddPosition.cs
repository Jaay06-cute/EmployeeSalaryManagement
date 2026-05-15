using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.LocationControls;
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
    public partial class AddPosition : Form
    {
        private int _locationID;
        public AddPosition(int locationID)
        {
            InitializeComponent();
            _locationID = locationID;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPosition.Text != "")
                {
                    IPositionRepository repo = new PositionRepository(new SalaryDbContext());
                    var position = new Model.Position
                    {
                        WorkPosition = txtPosition.Text,
                        Salary = (double)decimal.Parse(txtSalary.Text),
                        LocationId = _locationID
                    };
                    await repo.AddAsync(position);
                    await repo.SaveAsync();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Please Input a Valid Position");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input a valid Salary");
            }
        }
    }
}

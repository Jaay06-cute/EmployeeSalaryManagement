using EmployeeSalaryManagement.Card;
using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.Model;
using EmployeeSalaryManagement.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement.LocationControls
{
    public partial class DowntownOfficeControl : UserControl
    {
        private int _locationId;
        private string _locationName;

        public DowntownOfficeControl(int locationId, string locationName)
        {
            InitializeComponent();
            _locationId = locationId;
            _locationName = locationName;
            LoadPosition();
            lblHeader.Text = locationName;
        }
        private void LoadControl(UserControl uc)
        {
            DowntownContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            DowntownContent.Controls.Add(uc);
        }
        private void BackClick(object sender, EventArgs e)
        {
            LoadControl(new LocationMainContentControl());
        }

        private void BackArrowClick(object sender, EventArgs e)
        {
            LoadControl(new LocationMainContentControl());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddPosition main = new AddPosition(_locationId);
            main.ShowDialog();
            LoadPosition();
        }
        public void LoadPosition()
        {
            try
            {
                flpPosition.Controls.Clear();

                using (var context = new SalaryDbContext())
                {
                    var positions = context.Positions
                                   .Where(p => p.LocationId == _locationId)
                                   .ToList();
                   
                    foreach (var pos in positions)
                    {
                        int employeeCount = context.Employees
                                   .Count(e => e.PositionId == pos.PositionId);
                        var card = new PositionCard();
                        card.lblPosition.Text = pos.WorkPosition;
                        card.lblSalary.Text = "P" + pos.Salary.ToString();
                        card.lblEmployee.Text = employeeCount.ToString();

                        int currentId = pos.PositionId;
                        string currentName = pos.WorkPosition;

                        card.CardClicked += (s, e) =>
                        {
                            LoadControl(new LaborEmployeesController(currentId, currentName, _locationName, _locationId));
                        };

                        flpPosition.Controls.Add(card);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using EmployeeSalaryManagement.Card;
using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
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
        private readonly IPositionRepository _positionRepo;
        private string _searchTerm;

        public DowntownOfficeControl(int locationId, string locationName, string searchTerm = "")
        {
            InitializeComponent();
            _locationId = locationId;
            _searchTerm = searchTerm;
            _locationName = locationName;
            _positionRepo = new Repository.PositionRepository(new SalaryDbContext());
            LoadPosition();
            lblHeader.Text = locationName;
        }
        private void LoadControl(UserControl uc)
        {
            DowntownContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            DowntownContent.Controls.Add(uc);
        }
        public void UpdateSearchFromParent(string term)
        {
            _searchTerm = term;
            LoadPosition(); 
        }
        private void BackClick(object sender, EventArgs e)
        {
            var masterParent = this.ParentForm?.Controls.Find("LocationControl", true).FirstOrDefault() as LocationControl;
            if (masterParent != null)
            {
                masterParent.LoadControl(new LocationMainContentControl(_searchTerm), LocationControl.LocationViewMode.MainDashboard);
            }
        }
        private void BackArrowClick(object sender, EventArgs e)
        {
            var masterParent = this.ParentForm?.Controls.Find("LocationControl", true).FirstOrDefault() as LocationControl;
            if (masterParent != null)
            {
                masterParent.LoadControl(new LocationMainContentControl(_searchTerm), LocationControl.LocationViewMode.MainDashboard);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddPosition main = new AddPosition(_locationId);
            main.ShowDialog();
            LoadPosition();
        }
        public async void LoadPosition()
        {
            try
            {
                flpPosition.Controls.Clear();
                var positions = await _positionRepo.SearchPositionsInLocationAsync(_locationId, _searchTerm);
                foreach (var pos in positions)
                {
                    int employeeCount = pos.Employees.Count;
                    var card = new PositionCard(pos, _positionRepo);
                    card.lblEmployee.Text = employeeCount.ToString();
                    int currentId = pos.PositionId;
                    string currentName = pos.WorkPosition;
                    card.CardClicked += (s, e) =>
                    {
                        var masterParent = this.ParentForm?.Controls.Find("LocationControl", true).FirstOrDefault() as LocationControl;
                        if (masterParent != null)
                        {
                            masterParent.LoadControl(new LaborEmployeesController(currentId, currentName, _locationName, _locationId, _searchTerm), LocationControl.LocationViewMode.LaborEmployees);
                        }
                    };

                    flpPosition.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

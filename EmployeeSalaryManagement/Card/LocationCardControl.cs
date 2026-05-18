using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using EmployeeSalaryManagement.Notification;
using System;
using System.Windows.Forms;

namespace EmployeeSalaryManagement.Card
{
    public partial class LocationCardControl : UserControl
    {
        private Location _currentLocation;
        private readonly ILocationRepository _locationRepository;
        public event EventHandler CardClicked;
        public LocationCardControl(Location location, ILocationRepository locationRepository)
        {
            InitializeComponent();
            _currentLocation = location;
            _locationRepository = locationRepository;
            lblLocation.Text = _currentLocation.LocationName;
            lblAdress.Text = _currentLocation.LocationAddress;
            AssignClickEvent(this);
        }
        public LocationCardControl()
        {
            InitializeComponent();
        }
        private void AssignClickEvent(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is Button || c == EditPicture || c == XPicture) continue;

                c.Click += (s, e) => this.OnHeaderClick(e);
                if (c.HasChildren) AssignClickEvent(c);
            }
        }

        protected virtual void OnHeaderClick(EventArgs e)
        {
            CardClicked?.Invoke(this, e);
        }
        private async void pictureBox4_Click(object sender, EventArgs e)
        {
            if (_currentLocation == null) return;
            AddLocation location = new AddLocation(_currentLocation);
            location.ShowDialog();
        }

        private async void pictureBox5_Click(object sender, EventArgs e)
        {
            if (_currentLocation == null) return;

            var confirm = MessageBox.Show($"Delete {_currentLocation.LocationName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                await _locationRepository.DeleteAsync(_currentLocation.LocationId);
                await _locationRepository.SaveAsync();
                this.Parent?.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}

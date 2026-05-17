using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using System;
using System.Windows.Forms;

namespace EmployeeSalaryManagement.Card
{
    public partial class LocationCardControl : UserControl
    {
        private Location _currentLocation;
        private readonly ILocationRepository _locationRepository;

        // 1. Declare the event so other forms can listen for card clicks
        public event EventHandler CardClicked;

        // Main Constructor for dynamic card generation
        public LocationCardControl(Location location, ILocationRepository locationRepository)
        {
            InitializeComponent();
            _currentLocation = location;
            _locationRepository = locationRepository;

            // Map data to labels
            lblLocation.Text = _currentLocation.LocationName;
            lblAdress.Text = _currentLocation.LocationAddress;

            // 2. Initialize the click listener for the whole card
            AssignClickEvent(this);
        }

        // Default Constructor for the Visual Studio Designer
        public LocationCardControl()
        {
            InitializeComponent();
        }

        // 3. Helper methods to handle clicking anywhere on the card
        private void AssignClickEvent(Control container)
        {
            foreach (Control c in container.Controls)
            {
                // Skip buttons so they only perform their specific Update/Delete actions
                if (c is Button) continue;

                c.Click += (s, e) => this.OnHeaderClick(e);
                if (c.HasChildren) AssignClickEvent(c);
            }
        }

        protected virtual void OnHeaderClick(EventArgs e)
        {
            CardClicked?.Invoke(this, e);
        }

        // THE UPDATE BUTTON LOGIC
        private async void btnUpdateLocation_Click(object sender, EventArgs e)
        {
            if (_currentLocation == null) return;

            string newName = Microsoft.VisualBasic.Interaction.InputBox("Edit Name:", "Update", _currentLocation.LocationName);
            string newAddr = Microsoft.VisualBasic.Interaction.InputBox("Edit Address:", "Update", _currentLocation.LocationAddress);

            if (!string.IsNullOrWhiteSpace(newName))
            {
                _currentLocation.LocationName = newName;
                _currentLocation.LocationAddress = newAddr;

                _locationRepository.Update(_currentLocation);
                await _locationRepository.SaveAsync();

                // Refresh UI immediately
                lblLocation.Text = newName;
                lblAdress.Text = newAddr;
                MessageBox.Show("Updated successfully!");
            }
        }

        // THE DELETE BUTTON LOGIC
        private async void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            if (_currentLocation == null) return;

            var confirm = MessageBox.Show($"Delete {_currentLocation.LocationName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                await _locationRepository.DeleteAsync(_currentLocation.LocationId);
                await _locationRepository.SaveAsync();

                // Remove the card from the UI
                this.Parent?.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}

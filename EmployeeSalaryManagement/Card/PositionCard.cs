using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using System;
using System.Windows.Forms;

namespace EmployeeSalaryManagement.Card
{
    public partial class PositionCard : UserControl
    {
        private Position _currentPosition;
        private readonly IPositionRepository _positionRepo;

        public event EventHandler CardClicked;

        public PositionCard(Position position, IPositionRepository positionRepo)
        {
            InitializeComponent();
            _currentPosition = position;
            _positionRepo = positionRepo;

            // Load data into labels
            lblPosition.Text = _currentPosition.WorkPosition;
            lblSalary.Text = "P" + _currentPosition.Salary.ToString();

            AssignClickEvent(this);
        }

        public PositionCard()
        {
            InitializeComponent();
        }

        private void AssignClickEvent(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is Button) continue; // Skip buttons
                c.Click += (s, e) => this.OnHeaderClick(e);
                if (c.HasChildren) AssignClickEvent(c);
            }
        }

        protected virtual void OnHeaderClick(EventArgs e)
        {
            CardClicked?.Invoke(this, e);
        }

        // UPDATE BUTTON (Usually button1 or your teal button)
        private async void button1_Click(object sender, EventArgs e)
        {
            if (_currentPosition == null) return;

            string newTitle = Microsoft.VisualBasic.Interaction.InputBox("Edit Position Name:", "Update", _currentPosition.WorkPosition);
            string newSalaryStr = Microsoft.VisualBasic.Interaction.InputBox("Edit Salary:", "Update", _currentPosition.Salary.ToString());

            if (!string.IsNullOrWhiteSpace(newTitle) && decimal.TryParse(newSalaryStr, out decimal newSalary))
            {
                _currentPosition.WorkPosition = newTitle;
                _currentPosition.Salary = (double)newSalary;

                _positionRepo.Update(_currentPosition);
                await _positionRepo.SaveAsync();

                lblPosition.Text = newTitle;
                lblSalary.Text = "P" + newSalary.ToString();
                MessageBox.Show("Position updated!");
            }
        }

        // DELETE BUTTON (Usually button2 or your red button)
        private async void button2_Click(object sender, EventArgs e)
        {
            if (_currentPosition == null) return;

            var confirm = MessageBox.Show($"Delete {_currentPosition.WorkPosition} and all associated data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                await _positionRepo.DeleteAsync(_currentPosition.PositionId);
                await _positionRepo.SaveAsync();

                this.Parent?.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}
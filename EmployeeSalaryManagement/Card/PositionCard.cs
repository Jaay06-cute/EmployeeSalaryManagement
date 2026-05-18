using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using EmployeeSalaryManagement.Notification;
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
                if ((c is Button || c == EditPicture || c == XPicture)) 
                    continue; 
                c.Click += (s, e) => this.OnHeaderClick(e);
                if (c.HasChildren) AssignClickEvent(c);
            }
        }
        protected virtual void OnHeaderClick(EventArgs e)
        {
            CardClicked?.Invoke(this, e);
        }
        private async void EditPicture_Click(object sender, EventArgs e)
        {
            if (_currentPosition == null) return;
            AddPosition addPosition = new AddPosition(_currentPosition);
            addPosition.ShowDialog();
        }
        private async void XPicture_Click(object sender, EventArgs e)
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
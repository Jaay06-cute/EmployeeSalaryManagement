using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSalaryManagement.Card
{
    public partial class LocationCardControl : UserControl
    {
        public LocationCardControl()
        {
            InitializeComponent();
            AssignClickEvent(this);
        }
        private void AssignClickEvent(Control container)
        {
            foreach (Control c in container.Controls)
            {
                c.Click += (s, e) => this.OnHeaderClick(e); 
                if (c.HasChildren) AssignClickEvent(c);
            }
        }

        public event EventHandler CardClicked;

        protected virtual void OnHeaderClick(EventArgs e)
        {
            CardClicked?.Invoke(this, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; } = null!;
        public int PositionId { get; set; }
        public Position Position { get; set; } = null!;
        public List<Attendance> Attendances { get; set; } = new();
        public List<Checkout> Checkouts { get; set; } = new();
        public double Balance { get; set; }
        public bool isDeleted { get; set; } = false;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.Model
{
    public class Position
    {
        public int PositionId { get; set; }
        public string WorkPosition { get; set; } = null!;
        public double Salary { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;
        public List<Employee> Employees { get; set; } = new();
    }
}

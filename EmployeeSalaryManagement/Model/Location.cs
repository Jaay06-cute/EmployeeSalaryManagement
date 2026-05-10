using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.Model
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; } = null!;
        public string LocationAddress { get; set; } = null!;
        public List<Position> Positions { get; set; } = new();
    }
}

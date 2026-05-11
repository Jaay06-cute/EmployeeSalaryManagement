using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.Model
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Status { get; set; } = null!;
    }
}

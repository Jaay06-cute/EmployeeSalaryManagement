using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.Model
{
    public class Checkout
    {
        public int CheckoutId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
        public double Amount { get; set; }
        public string TransactionType { get; set; } = null!; 
        public DateTime TransactionDate { get; set; } = DateTime.Now; 
    }
}

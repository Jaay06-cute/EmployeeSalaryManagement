using EmployeeSalaryManagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.IRepository
{
    public interface ICheckoutRepository: IRepository<Checkout>
    {
        Task<IEnumerable<Checkout>> GetByEmployeeIdAsync(int employeeId);
        Task<List<Checkout>> GetAllTransactionsAsync();
        Task<double> GetTotalTransactionAmountThisMonthAsync();
        Task<int> GetTransactionCountThisMonthAsync();
    }
}

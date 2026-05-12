using EmployeeSalaryManagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.IRepository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeesByPositionAsync(int positionId);
        Task<IEnumerable<Employee>> GetEmployeesByLocationAsync(int locationId);
        Task<string> GetNameByIdAsync(int id);
        Task SoftDeleteAsync(Employee employee, int id);
        Task<List<Employee>> GetArchivedEmployeesAsync();
        Task<List<Employee>> GetAllEmployeesAsync();
        Task RestoreEmployeeAsync(int id);
        Task HardDeleteEmployeeAsync(int id);
        Task<double> GetTotalEmployeeBalanceAsync();
        Task<IEnumerable<Employee>> SearchEmployeesInPositionAsync(int positionId, string term);
        Task<IEnumerable<Employee>> SearchArchivedEmployeesAsync(string term);
    }
}

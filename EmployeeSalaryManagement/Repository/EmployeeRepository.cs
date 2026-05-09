using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(SalaryDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByPositionAsync(int positionId)
        {
            return await _context.Employees
                .Include(e => e.Position)
                .Where(e => e.PositionId == positionId)
                .ToListAsync();
        }
    }
}

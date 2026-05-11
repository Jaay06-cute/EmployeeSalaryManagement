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
                .Where(e => e.PositionId == positionId && e.isDeleted == false)
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<IEnumerable<Employee>> GetEmployeesByLocationAsync(int locationId)
        {
            return await _context.Employees
                .Where(e => e.isDeleted == false)
                .Include(e => e.Position)
                .Where(e => e.Position.LocationId == locationId) 
                .ToListAsync();
        }
        public async Task<string> GetNameByIdAsync(int id)
        {
            return await _context.Employees
                .Where(e => e.EmployeeID == id)
                .Select(e => e.EmployeeName)
                .FirstOrDefaultAsync();
        }
        public async Task SoftDeleteAsync(Employee employee, int id)
        {
            var existingEmployee = await _context.Employees.FindAsync(id);

            if (existingEmployee != null)
            {
                existingEmployee.isDeleted = employee.isDeleted;
                _context.Employees.Update(existingEmployee);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<Employee>> GetArchivedEmployeesAsync()
        {
            return await _context.Employees
         .Include(e => e.Position)
             .ThenInclude(p => p.Location)
         .Where(e => e.isDeleted == true)
         .ToListAsync();
        }
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees
         .Include(e => e.Position)
             .ThenInclude(p => p.Location)
         .Where(e => e.isDeleted == false)
         .ToListAsync();
        }
        public async Task RestoreEmployeeAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                employee.isDeleted = false;
                await _context.SaveChangesAsync();
            }
        }

        public async Task HardDeleteEmployeeAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<double> GetTotalEmployeeBalanceAsync()
        {
            return await _context.Employees
                .Where(e => e.isDeleted == false)
                .SumAsync(e => e.Balance);
        }
    }
}

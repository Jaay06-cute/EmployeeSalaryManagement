using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using Microsoft.EntityFrameworkCore;
namespace EmployeeSalaryManagement.Repository
{
    public class PositionRepository: Repository<Position>, IPositionRepository
    {
        public PositionRepository(SalaryDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Position>> GetPositionsByLocationAsync(int locationId)
        {
            return await _context.Positions
                .Include(p => p.Employees) 
            .Where(p => p.LocationId == locationId)
            .ToListAsync();
        }
        public async Task<decimal> GetTotalCompanyPayrollAsync()
        {
            // Fetch all locations, their positions, and their employees
            var data = await _context.Locations
                .Include(l => l.Positions)
                    .ThenInclude(p => p.Employees)
                .ToListAsync();

            decimal grandTotal = (decimal)data
                .SelectMany(l => l.Positions) 
                .Sum(p => p.Salary * p.Employees.Count);

            return grandTotal;
        }
    }
}

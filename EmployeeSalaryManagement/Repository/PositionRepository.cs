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
                .Include(p => p.Employees.Where(e => e.isDeleted == false)) 
            .Where(p => p.LocationId == locationId)
            .ToListAsync();
        }
        public async Task<decimal> GetTotalCompanyPayrollAsync()
        {
            var data = await _context.Locations
                .Include(l => l.Positions)
                    .ThenInclude(p => p.Employees)
                .ToListAsync();

            decimal grandTotal = (decimal)data
                .SelectMany(l => l.Positions) 
                .Sum(p => p.Salary * p.Employees.Count);

            return grandTotal;
        }
        public async Task<IEnumerable<Position>> SearchPositionsInLocationAsync(int locationId, string term)
        {
            var query = _context.Positions
                .Include(p => p.Employees)
                .Include(p => p.Location) // Include Location to check its name
                .Where(p => p.LocationId == locationId);

            if (!string.IsNullOrWhiteSpace(term))
            {
                string lowerTerm = term.ToLower();
                query = query.Where(p =>
                    p.WorkPosition.ToLower().Contains(lowerTerm) ||
                    p.Employees.Any(e => e.EmployeeName.ToLower().Contains(lowerTerm)) ||
                    p.Location.LocationName.ToLower().Contains(lowerTerm) // <--- ADD THIS
                );
            }

            return await query.ToListAsync();
        }
    }
}

using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using Microsoft.EntityFrameworkCore;
namespace EmployeeSalaryManagement.Repository
{
    public class LocationRepository : Repository<Location>, ILocationRepository
    {
        public LocationRepository(SalaryDbContext context) : base(context)
        {
        }
        public async Task<List<Location>> GetLocationsListAsync()
        {
            return await _context.Locations.ToListAsync();
        }
        public async Task<Location> GetLocationStatsAsync(int locationId)
        {
            return await _context.Locations
                .Include(l => l.Positions)
                    .ThenInclude(p => p.Employees)
                .FirstOrDefaultAsync(l => l.LocationId == locationId);
        }
        public async Task<IEnumerable<Location>> GetLocationsWithDetailsAsync()
        {
            return await _context.Locations
                .Include(l => l.Positions)
                    .ThenInclude(p => p.Employees)
                .ToListAsync();
        }
        public async Task<Location> GetByNameAsync(string name)
        {
            return await _context.Locations
                .FirstOrDefaultAsync(l => l.LocationName == name);
        }
        public async Task<IEnumerable<Location>> SearchLocationsAsync(string term)
        {
            var query = _context.Locations
                .Include(l => l.Positions)
                    .ThenInclude(p => p.Employees)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(term))
            {
                string lowerTerm = term.ToLower();
                query = query.Where(l =>
                    l.LocationName.ToLower().Contains(lowerTerm) ||
                    l.Positions.Any(p => p.WorkPosition.ToLower().Contains(lowerTerm) ||
                    p.Employees.Any(e => e.EmployeeName.ToLower().Contains(lowerTerm)))
                );
            }

            return await query.ToListAsync();
        }
    }
}

using EmployeeSalaryManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.IRepository
{
    public interface ILocationRepository : IRepository<Location>
    {
        Task<IEnumerable<Location>> GetLocationsWithDetailsAsync();
        Task<Location> GetLocationStatsAsync(int locationId);
        Task<Location> GetByNameAsync(string name);
        Task<IEnumerable<Location>> SearchLocationsAsync(string term);
    }
}

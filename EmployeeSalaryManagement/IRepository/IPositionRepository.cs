using EmployeeSalaryManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.IRepository
{
    public interface IPositionRepository: IRepository<Position>
    {
        Task<IEnumerable<Position>> GetPositionsByLocationAsync(int locationId);
        Task<decimal> GetTotalCompanyPayrollAsync();
        Task<IEnumerable<Position>> SearchPositionsInLocationAsync(int locationId, string term);
    }
}

using EmployeeSalaryManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.IRepository
{
    public interface IAttendanceRepository : IRepository<Attendance>
    {
        Task AddRangeAsync(IEnumerable<Attendance> attendances);
        Task<IEnumerable<Attendance>> GetEmployeeWorkHistoryAsync(int employeeId);
        Task<List<Attendance>> GetAttendanceByDateAndLocationAsync(DateTime date, int locationId);
        Task UpdateRangeAsync(IEnumerable<Attendance> attendances);
    }
}

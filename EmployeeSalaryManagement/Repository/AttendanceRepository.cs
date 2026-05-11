using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using Microsoft.EntityFrameworkCore;
namespace EmployeeSalaryManagement.Repository
{
    public class AttendanceRepository : Repository<Attendance>, IAttendanceRepository
    {
        public AttendanceRepository(SalaryDbContext context) : base(context) { }

        public async Task AddRangeAsync(IEnumerable<Attendance> attendances)
        {
            foreach (var attendance in attendances)
            {
                if (attendance.Status == "Present")
                {
                    var employee = await _context.Employees
                        .Include(e => e.Position)
                        .FirstOrDefaultAsync(e => e.EmployeeID == attendance.EmployeeId);

                    if (employee != null && employee.Position != null)
                    {
                        employee.Balance += employee.Position.Salary;
                    }
                }
            }

            await _context.Attendances.AddRangeAsync(attendances);
            await _context.SaveChangesAsync(); // Saves both Attendance and the new Balance
        }
        public async Task<IEnumerable<Attendance>> GetEmployeeWorkHistoryAsync(int employeeId)
        {
            return await _context.Attendances
                .Where(a => a.EmployeeId == employeeId && a.Status != "No Work")
                .OrderByDescending(a => a.Date) // Show newest records first
                .ToListAsync();
        }
        // Inside AttendanceRepository.cs
        public async Task<double> GetMonthlySalaryCalculationAsync(int employeeId, int month, int year)
        {
            var employee = await _context.Employees
                .Include(e => e.Position)
                .FirstOrDefaultAsync(e => e.EmployeeID == employeeId);

            if (employee == null) return 0;

            int presentDays = await _context.Attendances
                .Where(a => a.EmployeeId == employeeId &&
                            a.Status == "Present" &&
                            a.Date.Month == month &&
                            a.Date.Year == year)
                .CountAsync();

            return presentDays * employee.Position.Salary;
        }

    }

}

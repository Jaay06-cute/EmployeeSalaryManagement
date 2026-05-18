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
                bool exists = await _context.Attendances.AnyAsync(a =>
                    a.EmployeeId == attendance.EmployeeId &&
                    a.Date.Date == attendance.Date.Date);

                if (exists) continue;

                var employee = await _context.Employees.Include(e => e.Position)
                    .FirstOrDefaultAsync(e => e.EmployeeID == attendance.EmployeeId);

                if (employee?.Position != null)
                {
                    if (attendance.Status == "Present")
                    {
                        employee.Balance += employee.Position.Salary;
                    }
                    else if (attendance.Status == "Late")
                    {
                        employee.Balance += (employee.Position.Salary * 0.5);
                    }
                }
                await _context.Attendances.AddAsync(attendance);
            }
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Attendance>> GetEmployeeWorkHistoryAsync(int employeeId)
        {
            return await _context.Attendances
                .Where(a => a.EmployeeId == employeeId && a.Status != "No Work")
                .OrderByDescending(a => a.Date) 
                .ToListAsync();
        }     
        public async Task<List<Attendance>> GetAttendanceByDateAndLocationAsync(DateTime date, int locationId)
        {
            return await _context.Attendances
                .Where(a => a.Date.Date == date.Date && a.Employee.Position.LocationId == locationId)
                .ToListAsync();
        }
        public async Task UpdateRangeAsync(IEnumerable<Attendance> attendances)
        {
            foreach (var attendance in attendances)
            {
                var existing = await _context.Attendances.FirstOrDefaultAsync(a =>
                    a.EmployeeId == attendance.EmployeeId &&
                    a.Date.Date == attendance.Date.Date);

                if (existing != null)
                {
                    var employee = await _context.Employees.Include(e => e.Position)
                        .FirstOrDefaultAsync(e => e.EmployeeID == attendance.EmployeeId);

                    if (employee?.Position != null)
                    {
                        if (existing.Status == "Present")
                            employee.Balance -= employee.Position.Salary;
                        else if (existing.Status == "Late")
                            employee.Balance -= (employee.Position.Salary * 0.5);

                        if (attendance.Status == "Present")
                            employee.Balance += employee.Position.Salary;
                        else if (attendance.Status == "Late")
                            employee.Balance += (employee.Position.Salary * 0.5);
                    }
                    existing.Status = attendance.Status;
                }
                else
                {
                    await AddSingleAttendanceWithBalanceAsync(attendance);
                }
            }
            await _context.SaveChangesAsync();
        }

        private async Task AddSingleAttendanceWithBalanceAsync(Attendance attendance)
        {
            var employee = await _context.Employees.Include(e => e.Position)
                .FirstOrDefaultAsync(e => e.EmployeeID == attendance.EmployeeId);

            if (employee?.Position != null)
            {
                if (attendance.Status == "Present") employee.Balance += employee.Position.Salary;
                else if (attendance.Status == "Late") employee.Balance += (employee.Position.Salary * 0.5);
            }
            await _context.Attendances.AddAsync(attendance);
        }
    }

}

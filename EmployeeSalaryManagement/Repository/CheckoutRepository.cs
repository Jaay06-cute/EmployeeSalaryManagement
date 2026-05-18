using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using Microsoft.EntityFrameworkCore;
namespace EmployeeSalaryManagement.Repository
{
    public class CheckoutRepository : Repository<Checkout>, ICheckoutRepository
    {
        public CheckoutRepository(SalaryDbContext context) : base(context)
        {
        }
        public new async Task AddAsync(Checkout checkout)
        {
            var employee = await _context.Employees
                .FirstOrDefaultAsync(e => e.EmployeeID == checkout.EmployeeId);

            if (employee != null)
            {
                employee.Balance -= checkout.Amount;
            }
            await _context.Checkouts.AddAsync(checkout);
        }
        public async Task<IEnumerable<Checkout>> GetByEmployeeIdAsync(int employeeId)
        {
            return await _context.Checkouts
                .Where(c => c.EmployeeId == employeeId)
                .OrderByDescending(c => c.TransactionDate)
                .ToListAsync();
        }
        public async Task<List<Checkout>> GetAllTransactionsAsync()
        {
            return await _context.Checkouts
                .Include(c => c.Employee)
                    .ThenInclude(e => e.Position)
                        .ThenInclude(p => p.Location)
                .OrderByDescending(c => c.TransactionDate) 
                .ToListAsync();
        }
        public async Task<double> GetTotalTransactionAmountThisMonthAsync()
        {
            var today = DateTime.Now;

            return await _context.Checkouts
                .Where(c => c.TransactionDate.Month == today.Month &&
                            c.TransactionDate.Year == today.Year)
                .SumAsync(c => c.Amount);
        }
        public async Task<int> GetTransactionCountThisMonthAsync()
        {
            var now = DateTime.Now;

            return await _context.Checkouts
                .Where(c => c.TransactionDate.Month == now.Month &&
                            c.TransactionDate.Year == now.Year)
                .CountAsync();
        }
    }
}

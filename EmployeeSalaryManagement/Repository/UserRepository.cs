using EmployeeSalaryManagement.EmployeeManagementDbContext;
using EmployeeSalaryManagement.IRepository;
using EmployeeSalaryManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSalaryManagement.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SalaryDbContext context) : base(context)
        {
        }
        public async Task<bool> VerifyLoginAsync(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);
            if (user == null) return false;

            return BCrypt.Net.BCrypt.Verify(password, user.Password); 
        }

        public async Task<bool> UpdateStaffAccountAsync(string newName, string newPass)
        {
            var user = await _context.Users.FindAsync(2); 
            if (user == null) return false;

            user.UserName = newName;
            user.Password = BCrypt.Net.BCrypt.HashPassword(newPass); 
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<User?> AuthenticateAsync(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);

            if (user != null)
            {
                bool isValid = BCrypt.Net.BCrypt.Verify(password, user.Password);
                if (isValid) return user;
            }

            return null; // Fail
        }
    }
}

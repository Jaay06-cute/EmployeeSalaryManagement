using EmployeeSalaryManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalaryManagement.IRepository
{
    public interface IUserRepository: IRepository<User>
    {

        Task<User?> AuthenticateAsync(string username, string password);
        Task<bool> UpdateStaffAccountAsync(string newName, string newPass);
        Task<bool> VerifyLoginAsync(string username, string password);
    }
}

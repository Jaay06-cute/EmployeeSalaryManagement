using EmployeeSalaryManagement.EmployeeManagementDbContext;

namespace EmployeeSalaryManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new SalaryDbContext())
            {
                context.Database.EnsureCreated();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
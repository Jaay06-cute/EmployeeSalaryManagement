using EmployeeSalaryManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeSalaryManagement.EmployeeManagementDbContext
{
    public class SalaryDbContext : DbContext
    {
        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Attendance> Attendances { get; set; } = null!;
        public DbSet<Checkout> Checkouts { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .HasIndex(a => new { a.EmployeeId, a.Date })
                .IsUnique();
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    UserName = "admin",
                    Password = BCrypt.Net.BCrypt.HashPassword("master123")
                },
                new User
                {
                    UserId = 2,
                    UserName = "staff",
                    Password = BCrypt.Net.BCrypt.HashPassword("staff123")
                }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SalaryManagement.db");
        }
    }
}

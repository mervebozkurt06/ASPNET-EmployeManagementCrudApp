using EmployeeManagementApp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApp.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}

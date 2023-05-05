using Employee_management.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Employee_management.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

using Employee_Manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Manager.Data
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        { }

            public DbSet<Employee> Employees { get; set; }
    }
    }


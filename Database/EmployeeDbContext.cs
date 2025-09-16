using Employeemanagement.models;
using Microsoft.EntityFrameworkCore;
namespace Employeemanagement.Database
{
    public class EmployeeDbContext:DbContext
    {

        public EmployeeDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            // We need to pass connectionstring to base class with the help of constructor chaning
        }
        public DbSet<Employee>Employees { get; set; } // Employees will be table name
    }

}

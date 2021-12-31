using Microsoft.EntityFrameworkCore;

namespace HRM_SEM3_PVHung_T2009A.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees => Set<Employee>();
    }
}

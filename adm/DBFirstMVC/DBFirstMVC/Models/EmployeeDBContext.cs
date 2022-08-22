using Microsoft.EntityFrameworkCore;

namespace CodeFirstMVC.Models
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<DeptInfo> Department { get; set; }

        public DbSet<EmpInfo> Employees { get; set; }

        //public EmployeeDBContext()
        //{

        //}

        public EmployeeDBContext(DbContextOptions options):base(options)
        {

        }

    }
}

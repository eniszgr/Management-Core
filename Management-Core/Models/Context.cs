using Microsoft.EntityFrameworkCore;

namespace Management_Core.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-NJT7QHD1\\SQLEXPRESS01; database=employeemanagement; integrated security=true;TrustServerCertificate = True;");
        }

        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}

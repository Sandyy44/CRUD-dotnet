using Microsoft.EntityFrameworkCore;

namespace CRUDdotnet.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MU5JGBB\\SQLEXPRESS;Database=StdDeptDb;Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}

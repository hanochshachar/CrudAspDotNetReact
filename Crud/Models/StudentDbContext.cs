using Microsoft.EntityFrameworkCore;

namespace Crud.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;initial Catalog=course; User Id= hanoch; password= 1234; TrustServerCertificate= True");
        }
    }
}

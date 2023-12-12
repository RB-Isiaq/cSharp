
using Academy.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Academy.Repositories.Data
{
    public class AcademyContext : DbContext
    {
        public AcademyContext(DbContextOptions<AcademyContext> options) : base(options)
        {

        }

        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Program> Programs { get; set; }
    }
}
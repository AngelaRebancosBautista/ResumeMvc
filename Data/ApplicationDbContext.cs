using Microsoft.EntityFrameworkCore;
using ResumeMvc.Models;

namespace ResumeMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Ilike> Ilike { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<My_Skills> My_Skills { get; set; }
    }
}

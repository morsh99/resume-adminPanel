using Microsoft.EntityFrameworkCore;
using resumePresentation.Models.Entites.Education;
using resumePresentation.Models.Entites.Experience;
using resumePresentation.Models.Entites.MySkill;

namespace resumePresentation.Models.Entites.ResumeDbContext
{
    public class ResumeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=DESKTOP-73VTHTD;Initial Catalog=Resume;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Educations> Educations { get; set; }
        public DbSet<Experiences> Experiences { get; set; }
        public DbSet<MySkills> MySkills { get; set; }
    }

    

}

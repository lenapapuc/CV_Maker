using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace CV_Maker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<СV>? CVs { get; set; } 
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillCategory> SkillCategories { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<UserInfo> UsersInfo { get; set; }
        public DbSet<Responsibility> Responsibilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<СV>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<СV>()
                .HasMany(e => e.Skills)
                .WithMany(e => e.CVs);
            modelBuilder.Entity<СV>()
               .HasMany(e => e.Education)
               .WithOne()
               .IsRequired();
            modelBuilder.Entity<СV>()
               .HasMany(e => e.Experience)
               .WithOne()
               .IsRequired();
            modelBuilder.Entity<Skill>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<SkillCategory>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<SkillCategory>()
                .HasMany(e => e.Skill)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.CategoryId)
                .IsRequired(false);
               
               
            modelBuilder.Entity<Experience>()
                .HasKey(e => e.Id);
            
            modelBuilder.Entity<Experience>()
                .HasMany(e => e.Responsiblities)
                .WithOne(e => e.Experience)
                .HasForeignKey(e=> e.ExperienceId)
                .IsRequired();

            modelBuilder.Entity<Education>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Address>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<UserInfo>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Responsibility>().
                HasKey(e => e.Id);
          
            base.OnModelCreating(modelBuilder);

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
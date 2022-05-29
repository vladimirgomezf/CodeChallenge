using BugsWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BugsWebAPI.Data
{
    public class BugsContext: DbContext
    {
        public BugsContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<ProjectModel> ProjectModels { get; set; }
        public DbSet<BugModel> BugModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().ToTable("Users");
            modelBuilder.Entity<ProjectModel>().ToTable("Projects");
            modelBuilder.Entity<BugModel>().ToTable("Bugs");
        }
    }
}

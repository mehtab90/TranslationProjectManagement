using Microsoft.EntityFrameworkCore;
using TranslationProjectManagement.Models;
namespace TranslationProjectManagement.Data
{
    public class TranslationDbContext:DbContext 
    {
        public TranslationDbContext(DbContextOptions<TranslationDbContext> options) : base(options) { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Taks> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "Alice Johnson", Role = "Project Manager" },
                new User { Id = 2, UserName = "Bob Smith", Role = "Translator" },
                new User { Id = 3, UserName = "Charlie Brown", Role = "Translator" }
            );

            // Seed Projects
            modelBuilder.Entity<Project>().HasData(
                new Project { Id = 1, Name = "Project Alpha", Description = "Description for Project Alpha", Status = "In Progress", StartDate = DateTime.Now.AddMonths(-1), EndDate = DateTime.Now.AddMonths(2) },
                new Project { Id = 2, Name = "Project Beta", Description = "Description for Project Beta", Status = "Not Started", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(6) }
            );

            // Seed Tasks
            modelBuilder.Entity<Taks>().HasData(
                new Taks { Id = 1, ProjectId = 1, Name = "Design UI", AssignedTo = "Alice Johnson", Status = "Completed", Deadline = DateTime.Now.AddDays(-10) },
                new Taks { Id = 2, ProjectId = 1, Name = "Develop Backend", AssignedTo = "Bob Smith", Status = "In Progress", Deadline = DateTime.Now.AddDays(10) },
                new Taks { Id = 3, ProjectId = 2, Name = "Gather Requirements", AssignedTo = "Charlie Brown", Status = "Not Started", Deadline = DateTime.Now.AddDays(20) }
            );

            // Seed Reports
            modelBuilder.Entity<Report>().HasData(
                new Report { Id = 1, ProjectId = 1, GeneratedOn = DateTime.Now.AddDays(-5), ReportData = "Report data for Project Alpha" },
                new Report { Id = 2, ProjectId = 2, GeneratedOn = DateTime.Now, ReportData = "Report data for Project Beta" }
            );
        }
    }
}

using FIQ.Interview.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FIQ.Interview.Api
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Project.db");
        }
    }
}

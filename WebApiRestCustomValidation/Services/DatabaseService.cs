using Microsoft.EntityFrameworkCore;
using WebApiRestCustomValidation.Models;
using WebApiRestCustomValidation.Models.Mappings;

namespace WebApiRestCustomValidation.Services
{
    public class DatabaseService : DbContext
    {
        public DatabaseService(DbContextOptions<DatabaseService> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<People> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PeopleMapping());
        }
    }
}

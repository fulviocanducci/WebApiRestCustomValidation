using Microsoft.EntityFrameworkCore;
using WebApiRestCustomValidation.Models;

namespace WebApiRestCustomValidation.Services
{
    public class DatabaseService : DbContext
    {
        public DatabaseService(DbContextOptions<DatabaseService> options) : base(options)
        {

        }

        public DbSet<People> People { get; set; }
    }
}

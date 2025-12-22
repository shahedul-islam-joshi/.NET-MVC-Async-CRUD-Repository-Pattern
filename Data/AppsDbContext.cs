using Microsoft.EntityFrameworkCore;
using test_apps_3.Models.DomainModel;

namespace test_apps_3.Data
{
    public class AppsDbContext : DbContext
    {
        public AppsDbContext(DbContextOptions options) : base (options) 
        {
        }
        public DbSet<Student> _Students { get; set; }
    }
}

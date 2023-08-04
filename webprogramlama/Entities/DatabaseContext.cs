
using Microsoft.EntityFrameworkCore;
namespace MHRS.Entities
{
    public class DatabaseContext:DbContext
    {

        public DatabaseContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<User> Users { get; set; }
    }
}

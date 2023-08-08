using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication12.Entities
{
    public class DatabaseContext: DbContext 
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User>Users { get; set; }

        public DbSet<Doktor> Doktorlar { get; set; }

        public DbSet<Randevu> Randevular { get; set; }

        public DbSet<Poliklinik> Poliklinikler { get; set; }

    }


}

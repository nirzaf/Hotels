using Hotels.Data;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Country>().HasData(new Country
            {
                Id = 1,
                Name = "Sri Lanka",
                ShortName = "SL"
            },
            new Country{
                Id = 2,
                Name = "India",
                ShortName = "IN"
            }, new Country
            {
                Id = 3,
                Name = "Canada",
                ShortName = "CN"
            });
        }
    }
}
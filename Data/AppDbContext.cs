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

            builder.Entity<Hotel>().HasData(new Hotel
                {
                    Id = 1,
                    Name = "Queens Hotel",
                    Address = "Kandy",
                    Rating = 4,
                    CountryId = 1 
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Taj Hotel",
                    Address = "Chennai",
                    Rating = 3.5,
                    CountryId = 2
                }, new Hotel
                {
                    Id = 3,
                    Name = "British Columbia",
                    Address = "BC Canada",
                    Rating = 5,
                    CountryId = 3
                });
        }
    }
}
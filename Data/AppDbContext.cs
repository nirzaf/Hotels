using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotels.Data;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Country>  Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

    }
}

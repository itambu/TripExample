using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripExample.DataModel
{
    public class TripDbContext : DbContext
    {
        public DbSet<Trip>? Trips { get;set; }
        public DbSet<Driver>? Drivers { get;set; }
        public DbSet<DriverExpirience>? DriverExpiriences { get;set; }
        public DbSet<Route>? Routes { get;set; }
        
        public TripDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=helloapp.db");
        }


    }
}

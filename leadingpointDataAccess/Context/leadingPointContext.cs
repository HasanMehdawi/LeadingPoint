using leadingpointDataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leadingpointDataAccess.Context
{
    public class leadingPointContext:DbContext
    {
        public leadingPointContext(DbContextOptions<leadingPointContext>options):base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Lookup> lookups { get; set; }
        public DbSet<LookupCategory> lookupcategories { get; set; }
      
    }
}

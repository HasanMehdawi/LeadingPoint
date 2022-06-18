using leadingPointDataClass.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace leadingPointDataClass.Context
{
    public class LeadingPointContext:DbContext
    {
        public LeadingPointContext(DbContextOptions<LeadingPointContext> options) : base(options)
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

using System;
using Microsoft.EntityFrameworkCore;
using Country.Models.CountryModel;

namespace Country.Models
{
    public class CountryDBContext : DbContext
    {
        public CountryDBContext(DbContextOptions<CountryDBContext> options) : base(options)
        {

        }

        public DbSet<Cities> Cities { get; set; }
        public DbSet<Regions> Regions { get; set; }
        public DbSet<CountryModel.Country> Country { get; set; }
    }
}

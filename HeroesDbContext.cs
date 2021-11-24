using HeroesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HeroesAPI
{
    public class HeroesDbContext : DbContext
    {
        public HeroesDbContext(DbContextOptions<HeroesDbContext> options) :base(options)
        {
            
        }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
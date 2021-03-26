using Microsoft.EntityFrameworkCore;
using ProjDotNetCoreApi.Models;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;

namespace ProjDotNetCoreApi.Dal
{
    public class PetContext : DbContext
    {
        public PetContext(DbContextOptions<PetContext> options) : base(options)
        {
        }
        public DbSet<Dog> Dogs {set; get;} 

        public DbSet<Breed> Breeds {set; get;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dog>()
            .HasOne(b => b.Breed);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
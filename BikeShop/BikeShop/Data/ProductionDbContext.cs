using BikeShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BikeShop.Data
{
    public class ProductionDbContext : DbContext
    {
        public ProductionDbContext(DbContextOptions<ProductionDbContext> options):base(options) 
        {
        
        }


        public DbSet<Category?> categories { get; set; }

        public DbSet<Product?> products { get; set; }

        public DbSet<Brand?> brands { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().Property(m=>m.CREATETIME).HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<Brand>().Property(m =>m.CREATETIME).HasDefaultValue(DateTime.Now);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(msg=>Debug.WriteLine(msg)); //콘솔창에 디버깅 

        }


    }
}

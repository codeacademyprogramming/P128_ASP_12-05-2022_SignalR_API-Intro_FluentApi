using Microsoft.EntityFrameworkCore;
using P224FirstApi.Configurations;
using P224FirstApi.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224FirstApi.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.Entity<Category>().HasData(
            //    new Category { Name = "Test" },
            //    new Category { Name = "Test" },
            //    new Category { Name = "Test" },
            //    new Category { Name = "Test" },
            //    new Category { Name = "Test" },
            //    new Category { Name = "Test" },
            //    new Category { Name = "Test" }
            //        );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}

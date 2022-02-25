using Microsoft.EntityFrameworkCore;
using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Stock.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
    
        public DbSet<Product> Products { get; set; }

        public DbSet<StockInfo> Stock { get; set; }
    
        public DbSet<Variant> Variants { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}

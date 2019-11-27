using Microsoft.EntityFrameworkCore;
using Senkul.Database.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senkul.Database.DataAccess.Concrate.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         //   optionsBuilder.UseSqlServer(@"Server?(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

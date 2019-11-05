using System;
using Microsoft.EntityFrameworkCore;

namespace MVCpresent.Models
{
    public class ProductCon : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{   
             optionsBuilder.UseSqlite(@"Data source=database/productDB.db");
}
        public DbSet<ProductModel> products { get; set; }
    }
   
}
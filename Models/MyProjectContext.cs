using System;
using Microsoft.EntityFrameworkCore;

namespace MVCpresent.Models
{
    public class MyProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=database/myDB.db");
        }

        public DbSet<MovieModel> Movie { get; set; }
    }
   
}
using System;
using Microsoft.EntityFrameworkCore;

namespace BollMVC.Models
{
    public class MyEmployee : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=database/EmpData/Myemployee.db");
        }

        public DbSet<EmployeeData> Employee { get; set; }
    }
   
}
using System;
using System.Collections.Generic;
using System.Text;
using Demonstracao1.Models;
using Microsoft.EntityFrameworkCore;

namespace Demonstracao1.DataBase
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocaldb;Database=MyFirstEF;Trusted_Connection=True;");
        }
    }
}

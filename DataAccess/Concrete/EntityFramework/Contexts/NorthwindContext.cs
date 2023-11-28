using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext : DbContext
    {
        //override on yazdığımızda intellisense sayesinde metodumuz otomatik oluşturulacaktır.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-PBE5IS4\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");
        }
        
        public DbSet<Product> Products { get; set; }
    }
}

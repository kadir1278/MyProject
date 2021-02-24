using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    /********************
    
    Context : Db tabloları ile proje classlarını bağlamak

    ********************/
    
    
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MAU-BIM5\MSSQLSERVER01;Database=Northwind;Trusted_Connection=True");
        }
        /********************
         
        //DbSet<projedeki class ismi> veritabanındaki tablo ismi 
        //Eşitleme İşlemi Yapıldı

        ********************/
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}

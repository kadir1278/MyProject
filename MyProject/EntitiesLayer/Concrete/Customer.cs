using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.Concrete
{
    public class Customer:IEntity
    {
        public string CustomerId { get; set; } 
        // northwind veritabanında customerıd string olarak tanımlanmıştır o yüzden int değil
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}

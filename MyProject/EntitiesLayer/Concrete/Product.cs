using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesLayer.Concrete
{
    public class Product:IEntity 
        //public == diğer katmanların ulaşabileceği katmanlar demektir, default değeri internal değeridir.
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductName { get; set; }
    }
}

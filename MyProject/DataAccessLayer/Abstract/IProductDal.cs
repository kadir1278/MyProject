using CoreLayer.DataAccess;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal:IEntityRepository<Product> 
        // interface metotları default olarak public gelir
    {
        List<ProductDetailDto> GetProductDetails();        
    }
}

using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using EntitiesLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal; // bana erişim kodu ver
        }

        public List<Product> GetAll()
        {
            // İş Kodları Yazılacak Bölüm
            // Yetkisi var mı ? gibi gibi
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            // benim gönderdiğim id değerine eşit olan categoryıd leri filtrele
            return _productDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            // fiyat aralığına uyan ürünleri getir
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}

using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll(); // bana tüm kategori bilgilerini getir
        Category GetById(int categoryId); // bana bir adet kategori bilgisi getir

    }
}

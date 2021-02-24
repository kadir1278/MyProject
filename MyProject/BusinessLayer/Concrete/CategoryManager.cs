using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal category)
        {
            _categorydal = category;
        }

        public List<Category> GetAll()
        {
            // iş kodları
            return _categorydal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            // select * from categories where CategoryId=categoryId;
            return _categorydal.Get(c => c.CategoryId == categoryId);

        }
    }
}

using CoreLayer.DataAccess;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //List<Category> GetAll();
        //void Add(Category category);
        //void Delete(Category category);
        //void Update(Category category);
    }
}

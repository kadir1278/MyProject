using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CoreLayer.DataAccess
{
    // generic kısıtlama
    // class : referans tip olabilir
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    // T sadece IEntity veyahut buraya bağlı class değerleri alabilir
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

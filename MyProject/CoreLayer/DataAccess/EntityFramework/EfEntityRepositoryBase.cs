using CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CoreLayer.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity: class,IEntity,new() // buraya bir tablo adı yazılabilir sadece
        where TContext:DbContext,new()// buraya sadece veritabanı bağlantısı yazılabilir
    {
        public void Add(TEntity entity)
        {
            //NorthwindContext işi bitince bellekten atılacak. Using kullanımı performans artışı sağladı.Using ifadesi bittiği zaman bellekten atılır.IDisposable pattern implementation of c#.
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); // veri referenasını yakala
                addedEntity.State = EntityState.Added; // veriyi veritabanına ekle
                context.SaveChanges(); // veritabanını kaydet
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); // veri referenasını yakala
                deletedEntity.State = EntityState.Deleted; // veriyi veritabanından sil
                context.SaveChanges(); // veritabanını kaydet
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                // product tablomda filter değerime uyan ilk değeri getir.
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        // bir filtre versin ama vermezse bütün veriyi getir
        {
            using (TContext context = new TContext())
            {
                // filtre null ise DbSet'te bulunan product tablosuna yerleş ve listeye çevir getir.
                // filtre null değil ise filter değerine uyan tüm verileri getir.
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntitiy = context.Entry(entity); // veri referenasını yakala
                updatedEntitiy.State = EntityState.Modified; // veriyi veritabanından güncelle
                context.SaveChanges(); // veritabanını kaydet
            }
        }
    }
}

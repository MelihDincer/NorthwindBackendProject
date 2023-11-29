using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    //Burada TEntity(varlık veya veritabanı nesnesi diyebiliriz buna) ve TContext değişkenlik gösteren ifadelerdir. Bu yüzden Core katmanına yazılmıştır ve projeden ayrı çalışır. Başlarına T harfi koymamızın sebebi Type kelimesinden türemesidir. Genel olarak bu isim kullanılır.
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>  //Bu class IEntityRepository de bulunan operasyonları içerecektir.
        where TEntity : class, IEntity, new() //TEntity bir referans tiptir(class), IEntity den implemente edilmiş olmalıdır.Fakat IEntity olamaz çünkü newlenebilir olması gerekir. Interfaceler newlenemez! Yani burada birnevi filtreleme yapmış olduk.IEntity, new() dememizle TEntity'nin bir Interface olamayacağını belirttik.
        where TContext : DbContext, new() //Burada ise; TContext'in, DbContext'ten implemente edilmesi ve newlenebilmesi gerektiğini belirttik.
    {
        public void Add(TEntity entity)
        {
            //Disposable Pattern'ı uygulayarak; nesnenin hayatını sonlandırmasını Garbage Collector'a bırakmayıp, using bloğu bittikten sonra bellekten silinmesini sağladık.
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity); //Bu nesne ile ilgili işlem yapacağımızı addedEntity değişkenine bildirdik.Yani eklenecek entity i tuttuk diyebiliriz.
                addedEntity.State = EntityState.Added; //Tuttuğumuz bu Entity nin State propertysine EntityState lerinden ekleme seçeneğini bildirdik.
                context.SaveChanges(); //Değişiklikleri veritabanına kaydettik.
            }
        }

        public void Delete(TEntity entity)
        {
            using(var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter); //verdiğimiz filtreye göre gelecek verinin(tekil) gelmesini sağladık.
            }
        }

        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null) 
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

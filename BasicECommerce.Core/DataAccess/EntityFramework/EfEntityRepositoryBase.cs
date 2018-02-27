using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BasicECommerce.Core.Entites;

namespace BasicECommerce.Core.DataAccess.EntityFramework
{
    public abstract class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity> 
        where TEntity : class, IEntity, new()
        where TContext: DbContext, new ()

    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter != null
                    ? context.Set<TEntity>().Where(filter).ToList()
                    : context.Set<TEntity>().ToList();
            }
        }

        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var currentEntity = context.Entry(entity);
                currentEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var currentEntity = context.Entry(entity);
                currentEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var currentEntity = context.Entry(entity);
                currentEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}

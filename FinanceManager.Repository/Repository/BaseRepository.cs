using FinanceManager.Domain.Base;
using FinanceManager.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly MySqlContext _mySQLContext;

        public BaseRepository(MySqlContext mySQLContext)
        {
            _mySQLContext = mySQLContext;
        }                        

        public void AttachObject(object obj)
        {
            _mySQLContext.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _mySQLContext.ChangeTracker.Clear();
        }

        public void Update(TEntity entity)
        {
            _mySQLContext.Entry(entity).State = EntityState.Modified;
            _mySQLContext.SaveChanges();
        }

        public void Delete(object id)
        {
            var entity = Select(id);
            if (entity != null)
            {
                _mySQLContext.Set<TEntity>().Remove(entity);
                _mySQLContext.SaveChanges();
            }
        }

        public void Insert(TEntity entity)
        {
            _mySQLContext.Set<TEntity>().Add(entity);
            _mySQLContext.SaveChanges();
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var dbContext = _mySQLContext.Set<TEntity>().AsQueryable();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }

            return dbContext.ToList();
        }

        public TEntity Select(object id, IList<string>? includes = null)
        {
            var dbContext = _mySQLContext.Set<TEntity>().AsQueryable();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }

            return dbContext.FirstOrDefault(x => x.Id == (int)id);
        }
    }
}

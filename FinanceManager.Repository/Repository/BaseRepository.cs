using FinanceManager.Domain.Base;
using FinanceManager.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity<int>
    {
        protected readonly MySqlContext _mySqlcontext;

        public BaseRepository(MySqlContext mySqlcontext)
        {
            _mySqlcontext = mySqlcontext;
        }

        public void AttachObject(object obj)
        {
            _mySqlcontext.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _mySqlcontext.ChangeTracker.Clear();
        }

        public void Insert(TEntity entity)
        {
            try
            {
                _mySqlcontext.Set<TEntity>().Add(entity);
                _mySqlcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir a entidade: {ex.Message}", ex);
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                _mySqlcontext.Entry(entity).State = EntityState.Modified;
                _mySqlcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar a entidade: {ex.Message}", ex);
            }
        }

        public void Delete(object id)
        {
            try
            {
                var entity = Select(id);
                if (entity != null)
                {
                    _mySqlcontext.Set<TEntity>().Remove(entity);
                    _mySqlcontext.SaveChanges();
                }
                else
                {
                    throw new Exception("Entidade não encontrada para exclusão.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir a entidade: {ex.Message}", ex);
            }
        }

        public IList<TEntity> Select(bool tracking = true, IList<string>? includes = null)
        {
            try
            {
                IQueryable<TEntity> dbContext = tracking
                    ? _mySqlcontext.Set<TEntity>().AsQueryable()
                    : _mySqlcontext.Set<TEntity>().AsNoTracking();

                if (includes != null)
                {
                    foreach (var include in includes)
                    {
                        dbContext = dbContext.Include(include);
                    }
                }

                return dbContext.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao selecionar entidades: {ex.Message}", ex);
            }
        }

        public TEntity Select(object id, bool tracking = true, IList<string>? includes = null)
        {
            try
            {
                IQueryable<TEntity> dbContext = tracking
                    ? _mySqlcontext.Set<TEntity>().AsQueryable()
                    : _mySqlcontext.Set<TEntity>().AsNoTracking();

                if (includes != null)
                {
                    foreach (var include in includes)
                    {
                        dbContext = dbContext.Include(include);
                    }
                }

                return dbContext.FirstOrDefault(x => x.Id == (int)id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao selecionar a entidade com ID {id}: {ex.Message}", ex);
            }
        }
    }
}

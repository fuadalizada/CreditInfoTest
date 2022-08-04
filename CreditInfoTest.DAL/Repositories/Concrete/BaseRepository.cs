using CreditInfoTest.DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CreditInfoTest.DAL.Repositories.Concrete
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        protected readonly Microsoft.EntityFrameworkCore.DbContext Context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(Microsoft.EntityFrameworkCore.DbContext context)
        {
            Context = context;
            _dbSet = Context.Set<TEntity>();
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            var result = await _dbSet.AddAsync(entity);
            await Context.SaveChangesAsync();
            return result.Entity;
        }

        public virtual async Task<bool> DeleteAsync(Guid id)
        {
            var result = await FindByIdAsync(id);
            if (result != null)
            {
                _dbSet.Remove(result);
                await Context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual async Task<TEntity> FindByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);            
        }

        public virtual async Task<IQueryable<TEntity>> GetAllAsync()
        {
            var result = await _dbSet.ToListAsync();
            return result.AsQueryable();
        }
    }
}

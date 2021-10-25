using Experity.Infrastructure.Domain;
using Experity.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Experity.Infrastructure.Repositories
{
    internal class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly ExperityDBContext dbContext;
        private DbSet<T> entitySet;

        protected DbSet<T> EntitySet
        {
            get { return entitySet ??= dbContext.Set<T>(); }
        }
        public Repository(ExperityDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(T entity)
        {
            EntitySet.Add(entity);
        }

        public void Update(T entity)
        {
            var entry = dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                EntitySet.Attach(entity);
                entry = dbContext.Entry(entity);
            }
            entry.State = EntityState.Modified;
        }
        public T GetById(object id)
        {
           return EntitySet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return EntitySet.AsEnumerable();
        }

        public void Remove(T entity)
        {
            EntitySet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            EntitySet.RemoveRange(entities);
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await EntitySet.FindAsync(id).ConfigureAwait(false);
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await EntitySet.ToListAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<T>> GetAllAsync<TProperty>(Expression<Func<T, TProperty>> include)
        {
            IQueryable<T> query = EntitySet.Include(include);
            return await query.ToListAsync().ConfigureAwait(false);
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await EntitySet.SingleOrDefaultAsync(predicate).ConfigureAwait(false);
        }

        public async Task<T> AddAsync(T entity)
        {
            EntitySet.Add(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }


    }
}

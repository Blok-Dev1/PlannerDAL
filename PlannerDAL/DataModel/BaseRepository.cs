using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _dbContext;

        protected readonly DbSet<T> _dbSet;

        public DbContext Context
        {
            get
            {
                return _dbContext ?? null;
            }
        }

        public BaseRepository(DbContext context)
        {
            _dbContext = context ?? throw new ArgumentException(nameof(context));

            _dbSet = _dbContext.Set<T>();
        }

        public IEnumerable<T> GetList(Expression<Func<T, bool>> predicate = null,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           int? top = null,
           Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool disableTracking = true)
        {
            IQueryable<T> query = _dbSet;

            if (disableTracking) 
                query = query.AsNoTracking();

            if (include != null) 
                query = include(query);

            if (predicate != null) 
                query = query.Where(predicate);

            if (top.HasValue)
                query = query.Take(top.Value);

            return orderBy != null ? orderBy(query) : query;
        }


        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Add(params T[] entities)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }

        public void BulkAdd(IEnumerable<T> entities)
        {
            _dbSet.BulkInsert(entities);
        }

        public void BulkMerge(IEnumerable<T> entities)
        {
            _dbSet.BulkMerge(entities);
        }

        public void Delete(T entity)
        {
            var existing = _dbSet.Find(entity);

            if (existing != null)
                _dbSet.Remove(existing); 
        }

        public void Delete(object id)
        {
            var typeInfo = typeof(T).GetTypeInfo();

            var key = _dbContext.Model.FindEntityType(typeInfo).FindPrimaryKey().Properties.FirstOrDefault();

            var property = typeInfo.GetProperty(key?.Name);

            if (property != null)
            {
                var entity = Activator.CreateInstance<T>();
                property.SetValue(entity, id);
                _dbContext.Entry(entity).State = EntityState.Deleted;
            }
            else
            {
                var entity = _dbSet.Find(id);
                if (entity != null) Delete(entity);
            }
        }

        public void Delete(params T[] entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

        public T Search(params object[] keyValues) => _dbSet.Find(keyValues);

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Update(params T[] entities)
        {
            _dbSet.UpdateRange(entities);
        }

        public void Update(IEnumerable<T> entities)
        {
            _dbSet.UpdateRange(entities);
        }
    }
}

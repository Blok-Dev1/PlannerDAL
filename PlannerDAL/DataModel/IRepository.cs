using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public interface IRepository<T> : IDisposable where T : class
    {
       
        IEnumerable<T> GetList(Expression<Func<T, bool>> predicate = null,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           int? top = null,
           Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool disableTracking = true);
        
        void Add(T entity);
        void Add(params T[] entities);
        void Add(IEnumerable<T> entities);

        void BulkAdd(IEnumerable<T> entities);

        void Delete(T entity);
        void Delete(object id);
        void Delete(params T[] entities);
        void Delete(IEnumerable<T> entities);


        void Update(T entity);
        void Update(params T[] entities);
        void Update(IEnumerable<T> entities);
        void BulkMerge(IEnumerable<T> entities);
    }
}

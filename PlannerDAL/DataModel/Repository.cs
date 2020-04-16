using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Repository<T> : BaseRepository<T>, IRepository<T> where T : class
    {
        public Repository(DbContext context) : base(context)
        {

        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsEnumerable();
        }
    }
}

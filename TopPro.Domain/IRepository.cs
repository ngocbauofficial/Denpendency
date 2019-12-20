using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopPro.Domain
{

        public interface IRepository<TEntity> where TEntity : class
        {
            IQueryable<TEntity> GetAll();
            TEntity GetById(object id);
            void Insert(TEntity entity);
            void Update(TEntity entity);
            void Delete(TEntity entity);
        void Delete(IEnumerable<TEntity>entity);
        IQueryable<TEntity> Table { get; }
        IQueryable<TEntity> TableNoTracking { get; }
    }

}

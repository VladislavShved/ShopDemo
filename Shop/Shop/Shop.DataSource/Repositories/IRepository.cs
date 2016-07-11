using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DataSource.Entities;

namespace Shop.DataSource.Repositories
{
    public interface IRepository<T> where T: class, IEntity
    {
        void Add(T entity);

        void Update(T oldEntity, T newEntity);

        T GetById(Guid id);

        IQueryable<T> GetAll(Func<T, bool> predicate = null);

        void Delete(T entity);

        void Delete(Guid id);
    }
}

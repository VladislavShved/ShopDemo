using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DataSource.Context;
using Shop.DataSource.Entities;

namespace Shop.DataSource.Repositories
{
    public abstract class BaseRepository<T> : IDisposable, IRepository<T> where T : class, IEntity
    {
        private readonly ShopContext _context;

        protected BaseRepository(ShopContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T oldEntity, T newEntity)
        {
            _context.Set<T>().Remove(oldEntity);
            _context.Set<T>().Add(newEntity);
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().FirstOrDefault(m => m.Id == id);
        }

        public IQueryable<T> GetAll(Func<T, bool> predicate = null)
        {
            if (predicate == null)
            {
                return _context.Set<T>();
            }
            return _context.Set<T>().Where(predicate).AsQueryable();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Delete(Guid id)
        {
            var entity = _context.Set<T>().FirstOrDefault(m => m.Id == id);
            _context.Set<T>().Remove(entity);
        }

        public void Dispose()
        {
            _context.SaveChanges();
            _context.Dispose();
        }
    }
}

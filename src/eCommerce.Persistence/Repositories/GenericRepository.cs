using eCommerce.Core.Contracts.Persistence;
using eCommerce.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IBaseDomainEntity
    {
        private readonly ECommerceDbContext _dbContext;

        public GenericRepository(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T Add(T entity)
        {
            _dbContext.Add(entity);
            return entity;
        }

        public bool Exists(int id)
        {
            return _dbContext.Set<T>().Any(e => e.Id == id);
        }

        public T? Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IReadOnlyList<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }
    }
}

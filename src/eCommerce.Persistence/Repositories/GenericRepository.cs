using eCommerce.Core.Contracts.Persistence;
using eCommerce.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IBaseDomainEntity
    {
        private readonly ECommerceDbContext dbContext;

        public GenericRepository(ECommerceDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public T Add(T entity)
        {
            dbContext.Add(entity);
            dbContext.SaveChanges();
            return entity;
        }

        public bool Exists(int id)
        {
            return dbContext.Set<T>().Any(e => e.Id == id);
        }

        public T? Get(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public IReadOnlyList<T> GetAll()
        {
            return dbContext.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            dbContext.SaveChanges();
        }
    }
}

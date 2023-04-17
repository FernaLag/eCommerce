namespace eCommerce.Core.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        IReadOnlyList<T> GetAll();
        T Get(int id);        
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
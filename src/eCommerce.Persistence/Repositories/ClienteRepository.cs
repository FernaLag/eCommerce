using eCommerce.Domain;
using eCommerce.Core.Contracts.Persistence;

namespace eCommerce.Persistence.Repositories
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        private readonly ECommerceDbContext _dbContext;

        public ClienteRepository(ECommerceDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
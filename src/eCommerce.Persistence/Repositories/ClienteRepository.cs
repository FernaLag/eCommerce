using eCommerce.Domain;
using eCommerce.Core.Contracts.Persistence;

namespace eCommerce.Persistence.Repositories
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ECommerceDbContext dbContext) : base(dbContext)
        {
        }
    }
}
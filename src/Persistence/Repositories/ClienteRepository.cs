using Domain;
using Infrastructure;

namespace Persistence.Repositories
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

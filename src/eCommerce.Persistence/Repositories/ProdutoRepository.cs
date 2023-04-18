using eCommerce.Domain;
using eCommerce.Core.Contracts.Persistence;

namespace eCommerce.Persistence.Repositories
{
    public class ProdutoRepository : GenericRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ECommerceDbContext dbContext) : base(dbContext)
        {
        }
    }
}
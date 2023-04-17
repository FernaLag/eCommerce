using eCommerce.Domain.Common;

namespace eCommerce.Domain
{
    public class ProdutoPedido : BaseDomainEntity
    {
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
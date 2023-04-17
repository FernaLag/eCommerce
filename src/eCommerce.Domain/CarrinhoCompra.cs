using eCommerce.Domain.Common;

namespace eCommerce.Domain
{
    public class CarrinhoCompra : BaseDomainEntity
    {
        public int ClienteId { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
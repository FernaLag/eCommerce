using Domain.Common;

namespace Domain
{
    public class CarrinhoCompra : BaseDomainEntity
    {
        public int ClienteId { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
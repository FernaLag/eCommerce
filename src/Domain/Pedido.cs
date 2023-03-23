using Domain.Common;

namespace Domain
{
    public class Pedido : BaseDomainEntity
    {
        public int ClienteId { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
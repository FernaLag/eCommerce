using eCommerce.Domain;
using eCommerce.Core.Contracts.Persistence;

namespace eCommerce.Core.Services
{
    public class PedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IReadOnlyList<Pedido> GetPedidoList()
        {
            return _pedidoRepository.GetAll();
        }

        public Pedido GetPedido(int id)
        {
            var pedido = _pedidoRepository.Get(id);
            return pedido;
        }

        public Pedido CreatePedido(Pedido pedido)
        {
            var result = _pedidoRepository.Add(pedido);
            return result;
        }

        public void UpdatePedido(Pedido pedido)
        {
            _pedidoRepository.Update(pedido);
        }

        public void DeletePedido(Pedido pedido)
        {
            _pedidoRepository.Delete(pedido);
        }

    }
}

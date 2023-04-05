using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public List<Pedido> GetPedidoList()
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
            var result = _pedidoRepository.Create(pedido);
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

using Domain;
using Application.Contracts.Persistence;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tests.Mocks
{
    public class MockPedidoRepository
    {
        public static Mock<IPedidoRepository> GetPedidoRepository()
        {
            var mock = new Mock<IPedidoRepository>();
            var pedidos = new List<Pedido>
            {
                new Pedido
                {
                    Id = 1,
                    ClienteId = 1,
                    ValorTotal= 20,
                },
                new Pedido
                {
                    Id = 2,
                    ClienteId = 2,
                    ValorTotal= 30,
                },
                new Pedido
                {
                    Id = 3,
                    ClienteId = 3,
                    ValorTotal= 55,
                }
            };
            mock.Setup(x => x.GetAll()).Returns(pedidos);

            mock.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) =>
            {
                return pedidos.Single(x => x.Id == id);
            });

            mock.Setup(x => x.Add(It.IsAny<Pedido>())).Returns((Pedido pedido) =>
            {
                pedidos.Add(pedido);
                return pedido;
            });

            mock.Setup(x => x.Update(It.IsAny<Pedido>())).Callback((Pedido pedidoAlterado) =>
            {
                var pedido = pedidos.Single(x => x.Id == pedidoAlterado.Id);
                pedido = pedidoAlterado;
            });

            mock.Setup(x => x.Delete(It.IsAny<Pedido>())).Callback((Pedido pedido) =>
            {
                pedidos.Remove(pedido);
            });

            return mock;

        }
    }
}

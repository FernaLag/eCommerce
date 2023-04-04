using Application;
using Application.Tests.Mocks;
using Domain;
using Infrastructure;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Application.Tests.Features
{
    public class PedidoApplicationTests
    {
        private readonly Mock<IPedidoRepository> mock;
        private readonly PedidoService pedidoService;

        public PedidoApplicationTests()
        {
            mock = MockPedidoRepository.GetPedidoRepository();
            pedidoService = new PedidoService(mock.Object);
        }

        [Fact]
        public void GetPedidoListTest()
        {
            var result = pedidoService.GetPedidoList();
            result.Count.ShouldBe(3);
            result.ShouldBeOfType<List<Pedido>>();
        }

        [Fact]
        public void GetPedidoTest()
        {
            var result = pedidoService.GetPedido(3);
            result.ValorTotal.ShouldBe(55);
            result.ShouldBeOfType<Pedido>();
        }

        [Fact]
        public void CreatePedidoTest()
        {
            var pedidos = pedidoService.GetPedidoList();
            var pedido = new Pedido();
            pedido.ClienteId = 1;
            pedido.ValorTotal = 20;

            pedidoService.CreatePedido(pedido);
            pedidos.Count.ShouldBe(4);
        }

        [Fact]

        public void UpdatePedidoTest()
        {
            var pedido = pedidoService.GetPedido(1);

            pedido.ClienteId = 1;

            pedidoService.UpdatePedido(pedido);

            var pedidoAlterado = pedidoService.GetPedido(1);

            pedidoAlterado.Id.ShouldBe(1);
            pedidoAlterado.ClienteId.ShouldBe(1);
        }

        [Fact]

        public void DeletePedidoTest()
        {
            var pedidos = pedidoService.GetPedidoList();
            var pedidoExcluir = pedidos.Find(x => x.Id == 2);
            pedidoService.DeletePedido(pedidoExcluir);
        }
    }
  
}

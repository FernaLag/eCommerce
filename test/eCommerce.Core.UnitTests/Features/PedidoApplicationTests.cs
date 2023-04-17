using eCommerce.Core.Services;
using eCommerce.Core.UnitTests.Mocks;
using eCommerce.Domain;
using eCommerce.Core.Contracts.Persistence;
using Moq;
using Shouldly;
using Xunit;

namespace eCommerce.Core.UnitTests.Features
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
            var pedidoExcluir = pedidoService.GetPedido(2);
            pedidoService.DeletePedido(pedidoExcluir);
        }
    }
  
}

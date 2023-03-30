using Application.Tests.Mocks;
using Domain;
using Infrastructure;
using Moq;
using Shouldly;
using Xunit;

namespace Application.Tests.Features
{
    public class ClienteApplicationTests
    {
        private readonly Mock<IClienteRepository> mock;
        private readonly ClienteService clienteService;

        public ClienteApplicationTests()
        {
            mock = MockClienteRepository.GetClienteRepository();
            clienteService = new ClienteService(mock.Object);
        }

        [Fact]
        public void GetClienteListTest()
        {
            var result = clienteService.GetClienteList();
            result.Count.ShouldBe(3);
            result.ShouldBeOfType<List<Cliente>>();
        }

        [Fact]
        public void GetClienteTest()
        {
            var result = clienteService.GetCliente(3);
            result.NomeCompleto.ShouldBe("Ferna");
            result.ShouldBeOfType<Cliente>();
        }

        [Fact]
        public void CreateClienteTest()
        {
            var clientes = clienteService.GetClienteList();
            var cliente = new Cliente();
            cliente.Id = 4;
            cliente.NomeCompleto = "Pedro";
            cliente.Idade = 1;
            cliente.CPF = "12345";

            clienteService.CreateCliente(cliente);
            clientes.Count.ShouldBe(4);
        }

        [Fact]
        public void UpdateClienteTest()
        {
            var cliente = clienteService.GetCliente(1);

            cliente.NomeCompleto = "Silvio Santos";

            clienteService.UpdateCliente(cliente);

            var clienteAlterado = clienteService.GetCliente(1);

            clienteAlterado.Id.ShouldBe(1);
            clienteAlterado.NomeCompleto.ShouldBe("Silvio Santos");
        }

        [Fact]
        public void DeleteClienteTest()
        {
            var clientes = clienteService.GetClienteList();
            var clienteExcluir = clientes.Find(x => x.Id == 2);
            clienteService.DeleteCliente(clienteExcluir);

            clientes.Count.ShouldBe(2);
        }
    }
}
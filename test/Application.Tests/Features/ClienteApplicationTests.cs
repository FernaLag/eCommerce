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
        public void GetClienteTest()
        {
            var result = clienteService.GetCliente(3);
            result.NomeCompleto.ShouldBe("Ferna");
            result.ShouldBeOfType<Cliente>();
        }
        [Fact]
        public void CreateClienteTest()
        {
            var clientes = clienteService.GetAll();
            var cliente = new Cliente();
            cliente.Id = 4;
            cliente.NomeCompleto = "Pedro";
            cliente.Idade = 1;
            cliente.CPF = "12345";

            clienteService.CreateCliente(cliente);
            clientes.Count.ShouldBe(4);
        }

           
    }

}

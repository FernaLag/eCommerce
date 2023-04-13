using Domain;
using Application.Contracts.Persistence;
using Moq;

namespace Application.Tests.Mocks
{
    public static class MockClienteRepository
    {
        public static Mock<IClienteRepository> GetClienteRepository()
        {
            var mock = new Mock<IClienteRepository>();
            var clientes = new List<Cliente> 
            {
                new Cliente
                {
                    Id = 1,
                    NomeCompleto = "Xande",
                    Idade = 22,
                    CPF = "09841937905",
                },
                new Cliente
                {
                    Id = 2,
                    NomeCompleto = "Gabe",
                    Idade = 18,
                    CPF = "123"
                },
                new Cliente
                {
                    Id = 3,
                    NomeCompleto = "Ferna",
                    Idade = 30,
                    CPF = "1234",
                }
            };

            mock.Setup(x => x.GetAll()).Returns(clientes);

            mock.Setup(x => x.Get(It.IsAny<int>())).Returns((int id)  =>
            {
                return clientes.Single(x => x.Id == id);
            });

            mock.Setup(x => x.Add(It.IsAny<Cliente>())).Returns((Cliente cliente) =>
            {
                clientes.Add(cliente);
                return cliente;
            });

            mock.Setup(x => x.Update(It.IsAny<Cliente>())).Callback((Cliente clienteAlterado) =>
            {
                var cliente = clientes.Single(x => x.Id == clienteAlterado.Id);
                cliente = clienteAlterado;
            });

            mock.Setup(x => x.Delete(It.IsAny<Cliente>())).Callback((Cliente cliente) =>
            {
                clientes.Remove(cliente);
            });

            return mock;
        }
    }
}

using Domain;
using Infrastructure;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tests.Mocks
{
    public static class MockEnderecoRepository
    {
        public static Mock<IEnderecoRepository> GetEnderecoRepository()
        {
            var mock = new Mock<IEnderecoRepository>();
            var enderecos = new List<Endereco>
            {

                new Endereco
                {
                    Id = 1,
                    Rua = "Italia Piovesan Pasquali",
                    NumeroCasa = 12,
                    Bairro = "Gisele",
                    CEP = "13165-000",
                    Cidade = "Toledo",
                    Estado = "Paraná",
                },
                new Endereco
                {
                    Id = 2,
                    Rua =  "Portugal",
                    NumeroCasa = 315,
                    Bairro = "Jardim Banderantes",
                    CEP = "11546-157",
                    Cidade = "Toledo",
                    Estado = "Paraná",
                }
            };

            mock.Setup(x => x.GetAll()).Returns(enderecos);

            mock.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) =>
            {
                return enderecos.Single(x => x.Id == id);
            });

            mock.Setup(x => x.Create(It.IsAny<Endereco>())).Returns((Endereco endereco) =>
            {
                enderecos.Add(endereco);
                return endereco;
            });

            mock.Setup(x => x.Update(It.IsAny<Endereco>())).Callback((Endereco enderecoAlterado) =>
            {
                var endereco = enderecos.Single(x => x.Id == enderecoAlterado.Id);
                endereco = enderecoAlterado;
            });

            mock.Setup(x => x.Delete(It.IsAny<Endereco>())).Callback((Endereco endereco) =>
            {
                enderecos.Remove(endereco);
            });

            return mock;            
        }
    }
}

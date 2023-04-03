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
    public class EnderecoApplicationTests

    {
        private readonly Mock<IEnderecoRepository> mock;
        private readonly EnderecoService enderecoService;

        public EnderecoApplicationTests()
        {
            mock = MockEnderecoRepository.GetEnderecoRepository();
            enderecoService = new EnderecoService(mock.Object);
        }

        [Fact]
        public void GetEnderecoListTest()
        {
            var result = enderecoService.GetEnderecoList();
            result.Count.ShouldBe(2);
            result.ShouldBeOfType<List<Endereco>>();
        }

        [Fact]
        public void GetEnderecoTest()
        {
            var result = enderecoService.GetEndereco(2);
            result.Bairro.ShouldBe("Jardim Banderantes");
            result.ShouldBeOfType<Endereco>();
        }

        [Fact]
        public void CreateEnderecoTest()
        {
            var enderecos = enderecoService.GetEnderecoList();
            var endereco = new Endereco();
            endereco.Id = 3;
            endereco.Rua = "Santa Rosa";
            endereco.NumeroCasa = 129;
            endereco.Bairro = "Lago";
            endereco.CEP = "74125-984";
            endereco.Cidade = "Cascavel";
            endereco.Estado = "Paraná";

            enderecoService.CreateEndereco(endereco);
            enderecos.Count.ShouldBe(3);
        }
        [Fact]
        public void UpdateEnderecoTest()
        {
            var endereco = enderecoService.GetEndereco(1);

            endereco.Rua = "Gisele";

            enderecoService.UpdateEndereco(endereco);

            var enderecoAlterado = enderecoService.GetEndereco(1);

            enderecoAlterado.Id.ShouldBe(1);
            enderecoAlterado.Rua.ShouldBe("Gisele");
        }
        [Fact]
        public void DeleteEnderecoTest()
        {
            var enderecos = enderecoService.GetEnderecoList();
            var enderecoExcluir = enderecos.Find(x => x.Id == 2);
            enderecoService.DeleteEndereco(enderecoExcluir);

            enderecos.Count.ShouldBe(1);
        }



    }

}

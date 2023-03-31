using Application;
using Application.Tests.Mocks;
using Domain;
using Infrastructure;
using Moq;
using Shouldly;
using System;
using Xunit;

namespace Application.Tests.Features
{
    public class ProdutoApplicationTests
    {
        private readonly ProdutoService produtoService;
        private readonly Mock<IProdutoRepository> mock;


        public ProdutoApplicationTests()
        {
            mock = MockProdutoRepository.GetProdutoRepository();
            produtoService = new ProdutoService(mock.Object);
        }

        [Fact]
        public void GetProdutoTest()
        {
            var result = produtoService.GetProduto(1);
            result.ShouldBeOfType<Produto>();
            result.Nome.ShouldBe("Camiseta");
        }

        [Fact]
        public void GetProdutoListTest()
        {
            var result = produtoService.GetProdutoList();
            result.Count.ShouldBe(2);
            result.ShouldBeOfType<List<Produto>>();
        }


    }
}


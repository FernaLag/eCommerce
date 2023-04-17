using eCommerce.Core.Services;
using eCommerce.Core.UnitTests.Mocks;
using eCommerce.Domain;
using eCommerce.Core.Contracts.Persistence;
using Moq;
using Shouldly;
using Xunit;

namespace eCommerce.Core.UnitTests.Features
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

        [Fact]
        public void CreateProdutoTest()
        {
            var produtos = produtoService.GetProdutoList();
            var produto = new Produto();
            produto.Id = 3;
            produto.Nome = "Calca";
            produto.Cor = "Verde";
            produto.Preco = 90;

            produtoService.CreateProduto(produto);
            produtos.Count.ShouldBe(3);
        }

        [Fact]
       public void UpdateProdutoTest()
        {
            var produto = produtoService.GetProduto(1);
            produto.Nome = "Regata";
            produtoService.UpdateProduto(produto);
            var produtoAlterado = produtoService.GetProduto(1);

            produtoAlterado.Id.ShouldBe(1);
            produtoAlterado.Nome.ShouldBe("Regata");

        }

        [Fact]
        public void DeleteProdutoTest()
        {
            var produtos = produtoService.GetProdutoList();
            var produtoExcluir = produtoService.GetProduto(1);
            produtoService.DeleteProduto(produtoExcluir);

            produtos.Count.ShouldBe(1);
        }
    }
}


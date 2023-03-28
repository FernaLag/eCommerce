using Application;
using Application.Tests.Mocks;
using Domain;
using Infrastructure;
using Moq;
using Shouldly;
using System;
using Xunit;


public class ProdutoApplicationTests
{
    private ProdutoService produtoService;
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






}


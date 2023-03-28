using Application;
using Domain;
using Shouldly;
using System;
using Xunit;

public class ProdutoApplicationTests
{
	private readonly ProdutoService _produtoService;
	public ProdutoApplicationTests()
	{
		_produtoService = new ProdutoService();
	}

	[Fact] 
	public void GetProdutoTest()
	{
		var result = _produtoService.GetProduto();
		result.ShouldBeOfType<Produto>();
		result.Nome.ShouldBe("Camiseta");
	}






}


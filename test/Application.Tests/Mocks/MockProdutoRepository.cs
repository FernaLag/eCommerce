using Domain;
using Application.Contracts.Persistence;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tests.Mocks
{
    public static class MockProdutoRepository
    {
        public static Mock<IProdutoRepository> GetProdutoRepository()
            
        {
            var mock = new Mock<IProdutoRepository>();
            var produtos = new List<Produto>()
            {
                new Produto
                {
                    Id = 1,
                    Nome = "Camiseta",
                    Preco = 20,
                    Cor = "Vermelho",
                },
                new Produto
                {
                    Id = 2,
                    Nome = "Regata",
                    Preco = 30,
                    Cor = "Preta",
                }
            };

            mock.Setup(x => x.GetAll()).Returns(produtos);

            mock.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) =>
            {
                return produtos.Single(x => x.Id == id);
            });

            mock.Setup(x => x.Add(It.IsAny<Produto>())).Returns((Produto produto) =>
            {
                produtos.Add(produto);
                return produto;
            });

            mock.Setup(x => x.Update(It.IsAny<Produto>())).Callback((Produto ProdutoAlterado) =>
            {
                var produto = produtos.Single(x => x.Id == ProdutoAlterado.Id);
                produto = ProdutoAlterado;
            });

            mock.Setup(x => x.Delete(It.IsAny<Produto>())).Callback((Produto produto) =>
            {
                produtos.Remove(produto);
            });

            return mock;
        } 
        
    }
}

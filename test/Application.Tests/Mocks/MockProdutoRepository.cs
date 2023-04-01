﻿using Domain;
using Infrastructure;
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

            mock.Setup(x => x.GetList()).Returns(produtos);

            mock.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) =>
            {
                return produtos.Single(x => x.Id == id);
            });
            return mock;

            mock.Setup(x => x.Create(It.IsAny<Produto>())).Returns((Produto produto) =>
            {
                produtos.Add(produto);
                return produto;
            });


        } 
        
    }
}

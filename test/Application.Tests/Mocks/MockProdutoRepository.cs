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
            var produtos = new List<Produto>();
            {
                new Produto
                {
                    Id = 1,
                    Nome = "Camiseta",
                    Preco = 20,
                    Cor = "Vermelho",
                };
            }

            mock.Setup(x => x.Get(It.IsAny<int>())).Returns((int id) =>
            {
                return produtos.Single(x => x.Id == id);
            });
            return mock;
        } 
        
    }
}
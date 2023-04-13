﻿using Domain;
using Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public Produto GetProduto(int id)
        {
            var produto = _produtoRepository.Get(id);
            return produto;
        }
        public IReadOnlyList<Produto> GetProdutoList()
        {
            return _produtoRepository.GetAll();
        }
        public void UpdateProduto(Produto produto)
        {
            _produtoRepository.Update(produto);
        }

        public Produto CreateProduto(Produto produto)
        {
            var result = _produtoRepository.Add(produto);
            return result;
        }

        public void DeleteProduto(Produto produto)
        {
            _produtoRepository.Delete(produto);
        }



    }
}
//Produto produto = new Produto();
//produto.Nome = "Camiseta";
//return produto;
using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
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
        public List<Produto> GetProdutoList()
        {
            return _produtoRepository.GetList();
        }
        



    }
}
//Produto produto = new Produto();
//produto.Nome = "Camiseta";
//return produto;
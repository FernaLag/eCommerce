using eCommerce.Domain;
using eCommerce.Core.Contracts.Persistence;

namespace eCommerce.Core.Services
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
            var produtos = _produtoRepository.GetAll();
            return produtos;

        }
        public IReadOnlyList<Produto> GetFilteredProdutoList(string nome)
        {
            var produtos = _produtoRepository.GetAll();
            if (!string.IsNullOrEmpty(nome))
            {
                produtos = produtos.Where(p => p.Nome.Contains(nome)).ToList();
            }
            return produtos;

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
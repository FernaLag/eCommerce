using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ProdutoService
    {
        public Produto GetProduto()
        {
            Produto produto = new Produto();
            produto.Nome = "Camiseta";
            return produto;
        }
    }
}

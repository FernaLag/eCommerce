﻿using eCommerce.Domain.Common;

namespace eCommerce.Domain
{
    public class ProdutoCarrinho : BaseDomainEntity
    {
        public int CarrinhoCompraId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
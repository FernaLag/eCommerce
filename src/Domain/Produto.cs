using Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Produto : BaseDomainEntity
    {
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public string Material { get; set; }
        public string Cor { get; set; }
        public Produto()
        {
            Id = 0;
            Nome = "";
            Tamanho = "";
            Material = "";
            Cor = "";
        }
    }
}
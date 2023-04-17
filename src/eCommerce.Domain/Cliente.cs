using eCommerce.Domain.Common;

namespace eCommerce.Domain
{
    public class Cliente : BaseDomainEntity
    {
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string? Email { get; set; }
        public Endereco Endereco { get; set; }

        public Cliente()
        {
            NomeCompleto = "";
            Idade = 0;
            DataNascimento = DateTime.MinValue;
            CPF = "";
            Email = "";
            Endereco = new Endereco();
        }
    }
}
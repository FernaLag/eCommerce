using eCommerce.Domain.Common;

namespace eCommerce.Domain
{
    public class Endereco : BaseDomainEntity
    {
        public string Rua {get;set;}
        public int NumeroCasa {get;set;}
        public string Bairro  {get;set;}
        public string CEP {get;set;}
        public string Cidade {get;set;}
        public string Estado {get;set;}

        public Endereco()
        {
            Rua = "";
            NumeroCasa = 0;
            Bairro = "";
            CEP = "";
            Cidade = "";
            Estado = "";
        }
    }
}
namespace Domain
{
    public class Produto
    {
        public string Nome {get;set;}
        public string Tamanho {get;set;}
        public decimal Preco {get;set;}
        public int QuantidadeDisponivel {get;set;}
        public string Material {get;set;}
        public string Cor {get;set;}

        public Produto()
        {
            Nome = "";
            Tamanho = "";
            Material = "";
            Cor = "";
        }
    }

}
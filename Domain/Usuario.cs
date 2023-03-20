namespace Domain
{
    public class Usuario
    {
        public string Nome{get;set;}
        public int Idade{get;set;}
        public DateTime DataDeNascimento{get;set;}
        public decimal cpf{get;set;}
        public string email{get;set;}

        public Usuario()
        {
            Nome = "";
            Idade = "";
            DataDeNascimento = "";
            cpf = "";
            email = "";
        }

    }

}
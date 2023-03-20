namespace Domain
{
    public class Cliente
    {
        public string NomeCompleto{get;set;}
        public int Idade{get;set;}
        public DateTime DataNascimento{get;set;}
        public string CPF{get;set;}
        public string Email{get;set;}

        public Cliente()
        {
            NomeCompleto = "";
            Idade = "";
            DataNascimento = "";
            CPF = "";
            Email = "";
        }

    }

}
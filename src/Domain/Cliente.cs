using Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
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
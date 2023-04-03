﻿using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class EnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
        public List<Endereco> GetEnderecoList()
        {
            return _enderecoRepository.GetAll();
        }
        public Endereco GetEndereco(int id)
        {
            var endereco = _enderecoRepository.Get(id);
            return endereco;
        }
        public Endereco CreateEndereco(Endereco endereco)
        {
            var result = _enderecoRepository.Create(endereco);
            return result;
        }
        public void UpdateEndereco(Endereco endereco)
        {
            _enderecoRepository.Update(endereco);
        }
        public void DeleteEndereco(Endereco endereco)
        {
            _enderecoRepository.Delete(endereco);
        }

    }
}

﻿using eCommerce.Domain;
using eCommerce.Core.Contracts.Persistence;

namespace eCommerce.Core.Services
{
    public class EnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
        public IReadOnlyList<Endereco> GetEnderecoList()
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
            var result = _enderecoRepository.Add(endereco);
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

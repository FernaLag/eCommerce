﻿using Domain;
using Infrastructure;
using System.Security;

namespace Application.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public IReadOnlyList<Cliente> GetClienteList()
        {
            return _clienteRepository.GetAll();
        }
        public Cliente GetCliente(int id)
        {
            var cliente = _clienteRepository.Get(id);
            return cliente;
        }
        public Cliente CreateCliente(Cliente cliente)
        {
            //erificationException se o clienta já existe..

            //se o usuário tá logado, tem permissão cliente..

            var result = _clienteRepository.Add(cliente);
            return result;
        }
        public void UpdateCliente(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
        }
        public void DeleteCliente(Cliente cliente)
        {
            _clienteRepository.Delete(cliente);
        }
    }
}
using Domain;
using Infrastructure;

namespace Application
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public Cliente CreateCliente(Cliente cliente)
        {
            var result = _clienteRepository.Create(cliente);
            return result;
        }
        public Cliente GetCliente(int id)
        {
            var cliente = _clienteRepository.Get(id);
            return cliente;
        }

        public List<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }
    }
}
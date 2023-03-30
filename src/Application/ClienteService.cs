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
        public List<Cliente> GetClienteList()
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
            var result = _clienteRepository.Create(cliente);
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
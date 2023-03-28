using Domain;

namespace Infrastructure
{
    public interface IClienteRepository
    {
        Cliente Get(int id);
        Cliente Create(Cliente cliente);
        List<Cliente> GetAll();

        void Delete(Cliente cliente);
        
    }
}
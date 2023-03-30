using Domain;

namespace Infrastructure
{
    public interface IClienteRepository
    {
        List<Cliente> GetAll();
        Cliente Get(int id);
        Cliente Create(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(Cliente cliente);        
    }
}
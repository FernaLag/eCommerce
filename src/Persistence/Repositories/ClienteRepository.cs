using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ClienteRepository
    {
        private readonly ECommerceDbContext _dbContext;

        public List<Cliente> GetAll()
        {
            return _dbContext.Clientes.ToList();
        }

        public Cliente Get(int id)
        {
            return _dbContext.Clientes.Find(id);
        }

        public Cliente Create(Cliente cliente)
        {
            _dbContext.Add(cliente);
            return cliente;
        }
        public void Update(Cliente cliente)
        {
            _dbContext.Entry(cliente).State = EntityState.Modified;
        }
        public void Delete(Cliente cliente)
        {
            _dbContext.Remove(cliente);
        }
    }
}

using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IEnderecoRepository
    {
        List<Endereco> GetAll();
        Endereco Get(int id);
        Endereco Create(Endereco endereco);
        void Update(Endereco endereco);
        void Delete(Endereco endereco);
    }
}

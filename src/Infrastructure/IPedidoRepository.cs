using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IPedidoRepository
    {
        List<Pedido> GetAll();
        Pedido Get(int id);
        Pedido Create(Pedido pedido);
        void Update(Pedido pedido);
        void Delete(Pedido pedido);

    }
}

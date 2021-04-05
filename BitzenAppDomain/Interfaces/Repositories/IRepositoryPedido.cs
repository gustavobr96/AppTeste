using BitzenAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppDomain.Interfaces.Repositories
{
    public interface IRepositoryPedido : IRepository<Pedido>
    {
        bool RealizarPedido(Pedido p);
    }
}

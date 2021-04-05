using BitzenAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppDomain.Interfaces.Services
{
    public interface IServicePedido : IDisposable
    {
        bool RealizarPedido(Pedido p);
    }
}

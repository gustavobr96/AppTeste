using BitzenAppApplication.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppApplication.Interfaces
{
    public interface IApplicationPedido : IDisposable
    {
        bool RealizarPedido (PedidoDto pedido);

    }
}

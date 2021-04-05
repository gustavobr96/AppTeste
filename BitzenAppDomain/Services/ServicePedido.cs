using BitzenAppDomain.Entities;
using BitzenAppDomain.Interfaces.Repositories;
using BitzenAppDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppDomain.Services
{
    public class ServicePedido : IServicePedido
    {

        private readonly IRepositoryPedido _repoRelatorio;

        public ServicePedido(IRepositoryPedido repoRelatorio)
        {
            _repoRelatorio = repoRelatorio;
        }
      

        public bool RealizarPedido(Pedido p)
        {
            return _repoRelatorio.RealizarPedido(p);
        }

        public void Dispose()
        {
            _repoRelatorio.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}

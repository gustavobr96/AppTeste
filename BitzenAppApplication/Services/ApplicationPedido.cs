using BitzenAppApplication.Dto;
using BitzenAppApplication.Interfaces;
using BitzenAppDomain.Entities;
using BitzenAppDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppApplication.Services
{
    public class ApplicationPedido : IApplicationPedido
    {
        private readonly IServicePedido _servicePedido;

        public ApplicationPedido(IServicePedido servicePedido)
        {
            _servicePedido = servicePedido;
        }

        public bool RealizarPedido(PedidoDto p)
        {

            Pedido pedido = new Pedido();
            pedido.PrepararDados(p.Codigo, p.Pessoa, p.Curso, p.Turmas);
            return  _servicePedido.RealizarPedido(pedido);
        }

        public void Dispose()
        {
            _servicePedido.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}

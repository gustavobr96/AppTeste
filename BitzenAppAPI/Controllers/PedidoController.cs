using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitzenAppApplication.Dto;
using BitzenAppApplication.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BitzenAppAPI.Controllers
{
    [Route("api/relatorio")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IApplicationPedido _appPedido;

        public PedidoController(IApplicationPedido appPedido)
        {
            _appPedido = appPedido;
        }

        [HttpPost]
        [Route("realizarPedido")]
        public bool RealizarPedido([FromBody] PedidoDto p)
        {
            return _appPedido.RealizarPedido(p);
        }
      


    }
}
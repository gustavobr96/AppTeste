using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BitzenApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BitzenApp.Controllers
{
    [Route("cadastro/relatorio")]
    public class PedidoController : Controller
    {

        [Route("realizarPedido")]
        [HttpPost]
        public JsonResult RealizarPedido([FromBody] Pedido pedido)
        { 
    
            string url = "https://localhost:44336/api/pedido/realizarpedido";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsync(url,
                new StringContent(JsonConvert.SerializeObject(pedido), Encoding.UTF8, "application/json")).Result;

                string json = response.Content.ReadAsStringAsync().Result;
                int result = JsonConvert.DeserializeObject<int>(json);

                var jsettings = new JsonSerializerSettings();

                return Json(result, jsettings);
            }

        }


        [Route("abastecimento")]
        public IActionResult Abastecimento()
        {
            return View("Abastecimento");
        }
    }
}
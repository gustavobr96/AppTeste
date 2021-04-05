using BitzenAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppApplication.Dto
{
    public class PedidoDto
    {
        public string Codigo { get; set; }
        public Pessoa Pessoa { get; set; }
        public Curso Curso { get; set; }
        public List<Turma> Turmas { get; set; }
        public string Tipo { get; set; } // F - Fisico, J - Juridico



        public static explicit operator PedidoDto(Pedido p)
        {
            return new PedidoDto
            {
                Codigo = p.Codigo.ToString(),
                Pessoa = p.Pessoa,
                Curso = p.Curso,
                Turmas = p.Turmas,
                
            };
        }

    }
}

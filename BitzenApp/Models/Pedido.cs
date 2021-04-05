using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitzenApp.Models
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public Pessoa Pessoa { get; set; }
        public Curso Curso { get; set; }
        public List<Turma> Turmas { get; set; }
        public char Tipo { get; set; } // F - Fisico, J - Juridico
    }
}

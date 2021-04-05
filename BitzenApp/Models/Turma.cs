using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitzenApp.Models
{
    public class Turma
    {
        public int Codigo { get; set; }
        public List<Pessoa> Pessoas { get; set; }
        public Curso Curso { get; set; }
        public char Modalidade { get; set; } // O - Online,  P - Presencial
        public double Preco { get; set; }
    }
}

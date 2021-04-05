using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitzenApp.Models
{
    public class Funcionario
    {
        public int codigo { get; set; }
        public Pessoa Pessoa { get; set; }
        public Empresa Empresa { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppDomain.Entities
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public Pessoa Pessoa { get; set; }
        public Empresa Empresa { get; set; }

    }
}

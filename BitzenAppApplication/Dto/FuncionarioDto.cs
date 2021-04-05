using BitzenAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppApplication.Dto
{
    public class FuncionarioDto
    {
        public string Codigo { get; set; }
        public Pessoa Pessoa { get; set; }
        public Empresa Empresa { get; set; }


        public static explicit operator FuncionarioDto(Funcionario f)
        {
            return new FuncionarioDto
            {
                Codigo = f.Codigo.ToString(),
                Pessoa = f.Pessoa,
                Empresa = f.Empresa
            };
        }
    }
}

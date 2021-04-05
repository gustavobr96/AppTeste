using BitzenAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppApplication.Dto
{
    public class PessoaDto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }



        public static explicit operator PessoaDto(Pessoa p)
        {
            return new PessoaDto
            {
                Codigo = p.Codigo.ToString(),
                Nome = p.Nome,
                Sobrenome = p.Sobrenome
            };
        }


    }
}

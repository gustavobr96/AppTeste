using BitzenAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppApplication.Dto
{
    public class EmpresaDto
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string CNPJ { get; set; }


        public static explicit operator EmpresaDto(Empresa e)
        {
            return new EmpresaDto
            {
                Codigo = e.Codigo.ToString(),
                Descricao = e.Descricao,
                CNPJ = e.CNPJ.ToString()
            };
        }
    }
}

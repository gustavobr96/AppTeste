using BitzenAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppApplication.Dto
{
    public class CursoDto
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Horario { get; set; }

        public static explicit operator CursoDto(Curso c)
        {
            return new CursoDto
            {
                Codigo = c.Codigo.ToString(),
                Descricao = c.Descricao,
                Horario = c.Horario.ToString()
            };
        }
    }
}

using BitzenAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppApplication.Dto
{
    public class TurmaDto
    {
        public string Codigo { get; set; }
        public List<Pessoa> Pessoas { get; set; }
        public Curso Curso { get; set; }
        public string Modalidade { get; set; } // O - Online,  P - Presencial
        public string Preco { get; set; }


        public static explicit operator TurmaDto(Turma t)
        {
            return new TurmaDto
            {
                Codigo = t.Codigo.ToString(),
                Pessoas = t.Pessoas,
                Curso = t.Curso,
                Modalidade = t.Modalidade.ToString(),
                Preco = t.Preco.ToString()

            };
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BitzenAppDomain.Entities
{
    public class Pedido
    {
        public int Codigo { get; set; }
        public Pessoa Pessoa { get; set; }
        public Curso Curso { get; set; }
        public List<Turma> Turmas { get; set; }



        public void PrepararDados(string codigo, Pessoa p, Curso c, List<Turma> t)
        {

            validarCodigo(codigo);
            validarPessoa(p);
            validarCurso(c);
            validarTurma(t);

        }

        #region validações 

        private void validarCodigo(string codigo)
        {
            int auxnCod;
            if (int.TryParse(codigo, out auxnCod))
                Codigo = auxnCod;
            else
                Codigo = 0;


        }

        private void validarPessoa(Pessoa p)
        {
            Pessoa = p;
        }
        private void validarCurso(Curso c)
        {
            Curso = c;
        }

        private void validarTurma(List<Turma> t)
        {
            Turmas = t;
        }
        #endregion

    }






}

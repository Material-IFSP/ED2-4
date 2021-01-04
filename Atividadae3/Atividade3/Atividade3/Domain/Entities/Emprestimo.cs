using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3.Domain.Entities
{
    public class Emprestimo
    {
        #region Construtores
        public Emprestimo()
        {
            DtEmprestimo = null;
            DtDevolucao = null;
        }

        public Emprestimo(DateTime? dtEmprestimo, DateTime? dtDevolucao)
        {
            DtEmprestimo = dtEmprestimo;
            DtDevolucao = dtDevolucao;
        }
        #endregion

        #region Atributos
        public DateTime? DtEmprestimo { get; private set; }
        public DateTime? DtDevolucao { get; private set; }
        #endregion

        #region Metodos
        public void setEmprestimo(DateTime? dateTime)
        {
            DtEmprestimo = dateTime;
        }
        public void setDevolucao(DateTime? dateTime)
        {
            DtDevolucao = dateTime;
        }
        #endregion
    }
}

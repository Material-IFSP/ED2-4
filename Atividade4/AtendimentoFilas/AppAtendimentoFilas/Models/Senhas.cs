using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAtendimentoFilas
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        #region CONSTRUTORES
        public Senhas()
        {
            this.filaSenhas = new Queue<Senha>();
            this.proximoAtendimento = 1;
        }
        #endregion

        #region GETTERS AND SETTERS
        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        internal Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }
        #endregion

        #region METODOS
        public void Gerar()
        {
            this.filaSenhas.Enqueue(new Senha(this.ProximoAtendimento));
            this.proximoAtendimento++;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAtendimentoFilas
{
    class Guiches
    {
        private List<Guiche> listaGuiches;

        #region CONSTRUTORES
        public Guiches()
        {
            this.listaGuiches = new List<Guiche>();
        }
        #endregion

        #region GETTERS AND SETTERS
        internal List<Guiche> ListaGuiches { get => listaGuiches; set => listaGuiches = value; }
        #endregion

        #region METODOS
        public void Adicionar(Guiche guiche)
        {
            this.listaGuiches.Add(guiche);
        }
        #endregion
    }
}

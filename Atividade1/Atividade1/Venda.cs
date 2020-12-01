using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Venda
    {
        #region Atributos
        private int Qtde;
        private double Valor;
        private int Dia;
        #endregion

        #region setando propriedades get set 
        public int qtde
         {
         get { return Qtde; }
         set { Qtde = value; }
        }

        public double valor
        {
         get { return Valor; }
         set { Valor = value; }
         }

        public int dia
        {
            get { return Dia; }
            set { Dia = value; }
        }

        #endregion


        #region metodos e construtores
        public Venda(int quantidade, double preco, int dia)
        {
            Qtde = quantidade;
            Valor = preco;
            Dia = dia;
        }
        public Venda()
        {
            Qtde = 0;
            valor = 0;
            Dia = 0;
        }


        public double valorMedio()
        {            
            return Valor / Qtde;
        }
        #endregion

    }
}

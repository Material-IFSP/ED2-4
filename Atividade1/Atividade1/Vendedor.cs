using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Vendedor
    {
        #region Atributos
        private int Id;
        private string Nome;
        private double PercComissao;

        private static readonly int QuantidadeMaxima = 31; // setando quantidade maxima de 31 vendas com a palavra reservada ReadOnly
        // a palavra reservada readonly torna a variavel imutavel, como sugerido no seu nome, o valor pode ser apenas lido.


        public Venda[] AsVendas { get; private set; } //get setado como publico e set como private , todos setados na mesma linha;
        #endregion

        #region setando propriedades get set
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
 
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        public double percComissao
        {
            get { return PercComissao; }
            set { PercComissao = value; }
        }
        #endregion


        #region Construtores
        public Vendedor(int _id, string _nome, double _percComission, Venda[] _asVendas)
        {
            Id = _id;
            Nome = _nome;
            PercComissao = _percComission;
            AsVendas = _asVendas;
        }

        public Vendedor(int _id, string _nome, double _percComission)
        {
            Id = _id;
            Nome = _nome;
            percComissao = _percComission;
            AsVendas = new Venda[10];
            for (int i = 0; i <= 9; i++)
            {
                AsVendas[i] = new Venda(0, 0,0);
            }
        }

        public Vendedor(int _id, string _nome)
        {
            Id = _id;
            Nome = _nome;
            percComissao = 0;
            AsVendas = new Venda[10];
            for (int i = 0; i <= 9; i++)
            {
                AsVendas[i] = new Venda(0, 0,0);
            }
        }

        public Vendedor()
        {
            AsVendas = new Venda[10];
            for (int i = 0; i <= 9; i++)
            {
                AsVendas[i] = new Venda(0, 0,0);
            }
        }
        #endregion

        #region metodos
        

        public double valorVendas()
        {       
           return  this.AsVendas.Select(AsVendas => AsVendas.valor).Sum();
        }

        public double valorComissao()
        {
            return this.AsVendas.Select(AsVendas => AsVendas.valor * this.percComissao).Sum();
        }
        #endregion
    }
}

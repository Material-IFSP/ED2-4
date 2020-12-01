using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Vendedores
    {
        #region Atributos
        public Vendedor[] osVendedores { get; private set; }
        private int Max = 3;
        private int Qtde = 0;
        #endregion


        #region setando propriedades get set 
        public int max
        {
            get { return Max; }
            set { Max = value; }
        }

        public int qtde
        {
            get { return Qtde; }
            set { Qtde = value; }
        }
        #endregion

        #region
        public Vendedores()
        {
            osVendedores = new Vendedor[max];
            for (int i = 0; i < max; i++)
            {
                osVendedores[i] = new Vendedor(-1, "...");
            }

        }

        public Vendedores(int _qntd)
        {
            qtde = _qntd;
            osVendedores = new Vendedor[max];
            for (int i = 0; i < max; i++)
            {
                osVendedores[i] = new Vendedor(-1, "...");
            }
        }


        #endregion

        #region metodos publicos
        public bool addVendedor(Vendedor v)
        {
            if (qtde < 3)
            {
                for (int i = 0; i < osVendedores.Length; i++)
                {
                    if (osVendedores[i].id == -1)
                    {
                        osVendedores[i] = v;
                        qtde++;
                        break;
                    }
                }
                return true;
            }
            return false;
        }

        public bool delVendedor(int id)
        {
            var IdVendedor = retornarIdVendedor(id);
            bool deletar = (qtde > 0);

            if (deletar)
            {
                for (int i = 0; i < osVendedores.Length; i++)
                {
                    foreach (var item in IdVendedor.AsVendas)
                    {
                        if (item.dia > 0)
                        {
                            return false;
                        }
                        break;
                    }
                }

                for (int i = 0; i < osVendedores.Length; i++)
                {

                    if (osVendedores[i] == IdVendedor)
                    {
                        IdVendedor = new Vendedor(-1, "...");
                        osVendedores[i] = IdVendedor;
                        qtde--;
                        deletar = true;
                    }
                }
            }
            return deletar;
        }

        public Vendedor searchVendedor(Vendedor v)
        {
            foreach (var item in osVendedores)
            {
                if (item.id == v.id)
                {
                    return item;
                }
            }
            return null;
        }
        #endregion

        public double valorVendas()
        {
            return this.osVendedores.Select(osVendedores => osVendedores.valorVendas()).Sum();
        }

        public double valorComissao()
        {
            return this.osVendedores.Select(osVendedores => osVendedores.valorComissao()).Sum();
        }

        public void registarVendas(int id, Venda venda)
        {
            var vendedor = retornarIdVendedor(id);

            for (int i = 0; i < vendedor.AsVendas.Length; i++)
            {
                if (vendedor.AsVendas[i].dia == 0)
                {
                    vendedor.AsVendas[i] = venda;
                    break;
                }
            }
        }

        #region Demais metodos
        public Vendedor retornarIdVendedor(int _id)
        {

            foreach (var item in osVendedores)
            {
                if (item.id == _id)
                {
                    return item;
                }
            }
            return null;
        }
        public Vendedor[] RetornarVendedores()
        {
            return osVendedores;
        }
        #endregion
    }
}

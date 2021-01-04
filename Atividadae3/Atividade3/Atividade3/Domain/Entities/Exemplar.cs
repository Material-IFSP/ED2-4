using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3.Domain.Entities
{
    public class Exemplar
    {
        #region Construtores e atributos estaticos
        private static int count = 0;
        public Exemplar()
        {
            AdicionarExemplar();
        }
        #endregion

        #region Atributos
        public int Tombo { get; set; }
        public List<Emprestimo> Emprestimos { get; private set; }
        public bool disponivel { get; private set; }
        #endregion

        #region Metodos
        public bool Emprestar()
        {
            if (Emprestimos.Count == 0)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (disponivel)
                    {
                        Emprestimos.Add(new Emprestimo(DateTime.Now, null));

                        return true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Emprestimos.Count; i++)
                {
                    if (disponivel)
                    {
                        Emprestimos.Add(new Emprestimo(DateTime.Now, null));
                        return true;
                    }
                }
            }
            return false;
        }
        public bool Devolver()
        {
            for (int i = 0; i < Emprestimos.Count; i++)
            {
                if (!disponivel)
                {
                    Emprestimos[i].setDevolucao(DateTime.Now);
                    return true;
                }
            }
            return false;
        }
        public bool Disponivel(bool estaDiponivel)
        {
            disponivel = estaDiponivel;
            return disponivel;
        }
        public int QtdeEmprestimo()
        {
            return Emprestimos.Count;
        }
        private void AdicionarExemplar()
        {
            Emprestimos = new List<Emprestimo>();
            disponivel = true;
            count++;
            Tombo = count;
        }
        #endregion
    }
}

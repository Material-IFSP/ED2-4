using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3.Domain.Entities
{
    public class Livros
    {
        public Livros()
        {
            Acervo = new List<Livro>();
        }

        public List<Livro> Acervo { get; private set; }

        #region Metodos
        public void Adicionar(Livro livro)
        {
            Acervo.Add(livro);
        }
        public Livro Pesquisar(Livro livro)
        {
            foreach (var item in Acervo)
            {
                if (item == livro)
                {
                    return item;
                }
            }
            return null;
        }
        public Livro getLivroPorISBN(int ibsn)
        {
            foreach (var item in Acervo)
            {
                if (item.ISBN == ibsn)
                {

                    return item;
                }
            }
            return null;
        }
        #endregion
    }
}

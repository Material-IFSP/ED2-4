using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3.Domain.Entities
{
    public class Livro
    {
        private static int countEmprestimo = 0;
        #region Construtores
        public Livro(int isbn, string titulo, string autor, string editora)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Exemplares = new List<Exemplar>();
        }
        public Livro()
        {
            ISBN = 123456789;
            Titulo = "Livro do marquinhos";
            Autor = "Pedro Alvares MeuPau";
            Editora = "Editora Abril, Maio , Junho";
            Exemplares = new List<Exemplar>();
        }
        #endregion

        #region Atributos
        public int ISBN { get; private set; }
        public string Titulo { get;private set; }
        public string Autor { get;private set; }
        public string Editora { get;private set; }
        public List<Exemplar> Exemplares { get;private set; }
        #endregion

        #region Metodos
        public void AdicionarExemplar()
        {
            Exemplares.Add(new Exemplar());
        }
        public bool Emprestar()
        {

            for (int i = 0; i < Exemplares.Count; i++)
            {

                if (Exemplares[i].Emprestar())
                {
                    Exemplares[i].Disponivel(false);
                    countEmprestimo++;
                    return true;
                }
            }
            return false;
        }
        public bool Devolver()
        {
            for (int i = 0; i < Exemplares.Count; i++)
            {

                if (Exemplares[i].Devolver())
                {
                    Exemplares[i].Disponivel(true);
                    return true;
                }
            }
            return false;
        }
        public int QtdeExemplares()
        {
            return Exemplares.Count;
        }

        public int QtdeDisponiveis()
        {
            return Exemplares.Count;
        }
        public int QtdeEmprestimos()
        {
            return 1;
        }

        public double PercDisponibilidade() {
            int disp = 0;
            for (int i = 0; i < Exemplares.Count; i++)
            {
                if (Exemplares[i].disponivel)
                {
                    disp++;
                }

            }

            return (disp / Exemplares.Count * 100);
        }
       

        public string sintetico()
        {
            var livro = $"titulo = {this.Titulo}\n" +
            $"Quantidade de livros disponiveis = {QtdeDisponiveis()}\n" +
            $"Quantidade de emprestimos = {Exemplares[0].QtdeEmprestimo()}\n" +
            $"Percentual disponibilidade = {PercDisponibilidade()}% \n";
                return livro;
        }

        public string analitico()
        {
            string emprestimos = "";
            var contador = Exemplares.Count;
            for (int i = 0; i < contador; i++)
            {
                for (int j = 0; j < Exemplares[i].QtdeEmprestimo(); j++)
                {
                    emprestimos += $"\nEmprestimo Nº {j + 1} = {Exemplares[i].Emprestimos[j].DtEmprestimo}\n" +
                    $"A Devolução Nº {j + 1} = {Exemplares[i].Emprestimos[j].DtDevolucao}";
                }
            }
            var livro = $"Titulo = {this.Titulo}, \nAutor = {Autor},\n Editora= {Editora}, \nISBN = {ISBN}\n" +
            $"Quantidade de Livros disponiveis = {QtdeDisponiveis()}\n" +
            $"Quantidade de emprestimos = {Exemplares[0].QtdeEmprestimo()}\n" +
            $"Percentual disponibilidade = {PercDisponibilidade()}%\n" +
            $"Emprestimos: \n{emprestimos}";

            return livro;
        }
        #endregion
    }
}

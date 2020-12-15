using System.Collections.Generic;
using System.Linq;

namespace Agenda.Domain
{
    public class Contatos
    {
        private readonly List<Contato> _agenda;

        public Contatos()
        {
            _agenda = new List<Contato>();
        }

        public bool Adicionar(Contato contato)
        {
            if (contato.Nome == "" || contato.Email == "" || contato.Telefone == null || contato.DtNascimento == null) return false;
            _agenda.Add(new Contato(contato.Nome, contato.Email, contato.Telefone, contato.DtNascimento));
            return true;
        }
        public List<Contato> Pesquisar(Contato contato)
        {
            var x = _agenda.FindIndex(0, x => x.Email == contato.Email);
            if (x == -1) return null;
            return _agenda.Where(x => x.Email == contato.Email).ToList();
        }
        public bool Alterar(Contato contato)
        {
            var x = findContato(contato);
            if (x == -1) return false;
            _agenda[x] = new Contato(contato.Nome, contato.Email, contato.Telefone, contato.DtNascimento);
            return true;
        }
        public bool Remover(Contato c)
        {
            var x = findContato(c);
            if (x == -1) return false;
            _agenda.RemoveAt(x);
            return true;
        }
        public List<Contato> getAllContacts()
        {
            return _agenda;
        }
        private int findContato(Contato c)
        {           
            return _agenda.FindIndex(0, x => (x.Email == c.Email) && (x.Nome == c.Nome));
        }
        public override bool Equals(object obj)
        {

            return base.Equals(obj);
        }
    }
}

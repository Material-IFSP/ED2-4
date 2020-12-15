using System;

namespace Agenda.Domain
{
    public class Contato
    {
        public Contato(string nome, string email, string telefone, Data dtNascimento)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            DtNascimento = dtNascimento;
        }

        public Contato()
        {
            Nome = "";
            Email = "";
            Telefone = "";
            DtNascimento = new Data();
        }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public Data DtNascimento { get; private set; }

        public int getIdade()
        {            
            return (int.Parse(DateTime.Now.ToString().Substring(6,4)) - DtNascimento.Ano);
        }
        public override string ToString()
        {
            return $"| Nome= {Nome} | Email= {Email}| Telefone= {Telefone}| Data de Nascimento= { DtNascimento }|";
        }
    }
}

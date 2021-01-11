using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAtendimentoFilas
{
    class Senha
    {
        #region ATRIBUTOS
        private int id;
        private string dataGerac;
        private string horaGerac;
        private string dataAtend;
        private string horaAtend;
        #endregion

        #region CONSTUTORES
        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now.ToString("dd/MM/yyyy");
            this.horaGerac = DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion

        #region GETTERS AND SETTERS
        public int Id { get => id; set => id = value; }
        public string DataGerac { get => dataGerac; set => dataGerac = value; }
        public string HoraGerac { get => horaGerac; set => horaGerac = value; }
        public string DataAtend { get => dataAtend; set => dataAtend = value; }
        public string HoraAtend { get => horaAtend; set => horaAtend = value; }
        #endregion

        #region METODOS
        public string DadosParciais()
        {
            return $"{this.id} - {this.dataGerac} - {this.horaGerac}";
        }

        public string DadosCompletos()
        {
            return $"{this.id} - {this.dataGerac} - {this.horaGerac} / {this.DataAtend} - {this.horaAtend}";
        }
        #endregion
    }
}

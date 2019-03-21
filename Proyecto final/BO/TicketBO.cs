using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.BO
{
    class TicketBO
    {
        private int codigo_ticket;
        private string hora_entrada;
        private string hora_salida;
        private string tiempo_transcurrido;
        private DateTime fecha;

        public TicketBO()
        {

        }

        public int Codigo_ticket { get => codigo_ticket; set => codigo_ticket = value; }
        public string Hora_entrada { get => hora_entrada; set => hora_entrada = value; }
        public string Hora_salida { get => hora_salida; set => hora_salida = value; }
        public string Tiempo_transcurrido { get => tiempo_transcurrido; set => tiempo_transcurrido = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}

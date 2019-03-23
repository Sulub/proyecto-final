using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.BO
{
    class HoraTrabajoBO
    {
        private int codigo_hora;
        private string hora_dia;
        private string hora_noche;

        public HoraTrabajoBO()
        {

        }

        public int Codigo_hora { get => codigo_hora; set => codigo_hora = value; }
        public string Hora_dia { get => hora_dia; set => hora_dia = value; }
        public string Hora_noche { get => hora_noche; set => hora_noche = value; }
    }
}

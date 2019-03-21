using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.BO
{
    class RentaBO
    {
        private int codigo_renta;
        private string fecha_salida;
        private string dias_trancurrido; 

        public RentaBO()
        {

        }

        public int Codigo_renta { get => codigo_renta; set => codigo_renta = value; }
        public string Fecha_salida { get => fecha_salida; set => fecha_salida = value; }
        public string Dias_trancurrido { get => dias_trancurrido; set => dias_trancurrido = value; }
    }
}

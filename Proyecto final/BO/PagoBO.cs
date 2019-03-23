using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.BO
{
    class PagoBO
    {
        private int codigo_pago;
        private string tarifa_dia;
        private string tarifa_nocturna;

        public PagoBO()
        {

        }

        public int Codigo_pago { get => codigo_pago; set => codigo_pago = value; }
        public string Tarifa_dia { get => tarifa_dia; set => tarifa_dia = value; }
        public string Tarifa_nocturna { get => tarifa_nocturna; set => tarifa_nocturna = value; }
    }
}

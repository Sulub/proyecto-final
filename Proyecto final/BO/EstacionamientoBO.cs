using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.BO
{
    class EstacionamientoBO
    {
        private int codigo_estacionamiento;
        private string direccion;
        private string telefono;

        public EstacionamientoBO()
        {

        }

        public int Codigo_estacionamiento { get => codigo_estacionamiento; set => codigo_estacionamiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}

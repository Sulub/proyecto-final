using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.BO
{
    class MantenimientoBO
    {
        private int no_actividad;
        private string nombre_actividad;

        public MantenimientoBO()
        {

        }

        public int No_actividad { get => no_actividad; set => no_actividad = value; }
        public string Nombre_actividad { get => nombre_actividad; set => nombre_actividad = value; }
    }
}

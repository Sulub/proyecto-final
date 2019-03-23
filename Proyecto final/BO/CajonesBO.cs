using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.BO
{
    class CajonesBO
    {
        private int no_cajon;
        private string disponible;
        private string ocupado;

        public int No_cajon { get => no_cajon; set => no_cajon = value; }
        public string Disponible { get => disponible; set => disponible = value; }
        public string Ocupado { get => ocupado; set => ocupado = value; }
    }
}

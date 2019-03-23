using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.BO
{
    class ContratoBO
    {
        private int codigo_contrato;
        private string fecha_entrada;

        public ContratoBO()
        {

        }

        public int Codigo_contrato { get => codigo_contrato; set => codigo_contrato = value; }
        public string Fecha_entrada { get => fecha_entrada; set => fecha_entrada = value; }
    }
}

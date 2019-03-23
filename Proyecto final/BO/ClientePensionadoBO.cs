using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.BO
{
    class ClientePensionadoBO : PersonaBO
    {
        private int id_cliente_pensionado;

        public ClientePensionadoBO()
        {

        }

        public int Id_cliente_pensionado { get => id_cliente_pensionado; set => id_cliente_pensionado = value; }
    }
}

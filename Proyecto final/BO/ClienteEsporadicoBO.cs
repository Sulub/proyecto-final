using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.BO
{
    class ClienteEsporadicoBO:PersonaBO
    {
        private int id_cliente_esporadico;

        public ClienteEsporadicoBO()
        {

        }
            

        public int Id_cliente_esporadico { get => id_cliente_esporadico; set => id_cliente_esporadico = value; }
    }
}

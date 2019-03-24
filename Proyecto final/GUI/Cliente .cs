using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Cliente : MetroFramework.Forms.MetroForm
    {
        public Cliente()
        {
            InitializeComponent();
       
           cbo_Tipocli.Items.Add("Seleccionar");
            cbo_Tipocli.Items.Add("Esporádico");
            cbo_Tipocli.Items.Add("Pencionado");

            cbo_Tipovehi.Items.Add("Seleccionar");
            cbo_Tipovehi.Items.Add("Coche");
            cbo_Tipovehi.Items.Add("MOto");


        }

        private void cbo_Tipocli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Buscar2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

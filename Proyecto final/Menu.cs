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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Cajon_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            Cliente obj_Cliente = new Cliente();
            obj_Cliente.Show();
            this.Hide();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            Empleado obj_Empleado = new Empleado();
            obj_Empleado.Show();
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        if (panel1.Width==174)
            {

                panel1.Width = 18;
                panel2.Width = 18;
            }
        else

            {
                panel1.Width = 174;
                panel2.Width = 174;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

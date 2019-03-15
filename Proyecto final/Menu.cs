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

       

       
        
       

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 174)
            {

                panel1.Width = 18;
                panel2.Width = 18;
                panel3.Width = 709;

            }
            else

            {
                panel1.Width = 174;
                panel2.Width = 174;
                panel3.Width = 560;
            }
        }
        private void abrirFormulario(object formhija)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form empe = formhija as Form;
            empe.TopLevel = false;
            empe.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(empe);
            this.panel3.Tag = empe;
            empe.Show();
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Empleado());
            
            
        }

       
    }
    
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string usuario = txt_Contraseña.Text;
            string contraseña = txt_Contraseña.Text;


            if (usuario == "Margely" || contraseña == "12345")
            {
                MessageBox.Show("Bienvenido administrador");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("La contraseña o el nombre de usuario es incorrecta");
            }
            
            
            
            
        }

        private void txt_Contraseña_Usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
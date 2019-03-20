using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_final
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Maximizar.Visible = false;
            btn_Restaurar.Visible = true;
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Restaurar.Visible = false;
            btn_Maximizar.Visible = true;
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barra_Titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barra_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Login salir = new Login();
            salir.Show();
            this.Hide();
        }
        private void AbrirFormularioEnPanel(object Formhijo)
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
                this.Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.Panel_Contenedor.Controls.Add(fh);
            this.Panel_Contenedor.Tag = fh;
            fh.Show();

        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Empleado());
        }

        private void btn_Contractil_Click(object sender, EventArgs e)
        {
            if (Marco_Menu.Width == 193)
            {
                Marco_Menu.Width = 10;
                perfil.Width = 10;
            }
            else
            {
                Marco_Menu.Width = 193;
                perfil.Width = 193;
            }
        }

        private void Panel_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}

using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI
{
    
    public partial class FrmModificarUsuario : Form
    {
        BEUser UsuarioLogueado;
        public FrmModificarUsuario()
        {
            InitializeComponent();
            CargarUsuarioLogueado();
        }

        private void CargarUsuarioLogueado()
        {
            BLLUsuario bllUsuario = new BLLUsuario();
            UsuarioLogueado = bllUsuario.ObtenerUsuarioLogueado();

            metroTextBox1.Text = UsuarioLogueado.Nombre;
            metroTextBox2.Text = UsuarioLogueado.Apellido;
            metroTextBox4.Text = UsuarioLogueado.Mail;
        }

       

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string Nombre = metroTextBox1.Text;
            string Apellido = metroTextBox2.Text;
            string Mail = metroTextBox4.Text;

            if (Nombre == "" & Apellido == "" & Mail == "")
            {
                MessageBox.Show("Datos no válidos");
                return;
            }

            if (Nombre == UsuarioLogueado.Nombre & Apellido == UsuarioLogueado.Apellido & Mail == UsuarioLogueado.Mail)
            {
                MessageBox.Show("Datos sin cambios");
                return;
            }

            BLLUsuario bllUsuario = new BLLUsuario();

            UsuarioLogueado.Nombre = Nombre;
            UsuarioLogueado.Apellido = Apellido;
            UsuarioLogueado.Mail = Mail;
            //UsuarioLogueado.DVV = bllUsuario.ObtenerDVH(UsuarioLogueado);

            bool exitoso = bllUsuario.ModificarUsuario2(UsuarioLogueado);

            MessageBox.Show(exitoso ? "Datos actualizados." : "No se pudieron actualizar sus datos.");
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

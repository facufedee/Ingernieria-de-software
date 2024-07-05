using BE;
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

namespace UI
{
    public partial class FrmPerfiles : Form
    {
        private List<BEUser> Usuarios;
        private List<BEUser> UsuariosVersionados;
        BEUser UsuarioSeleccionado;
        BEUser CambioSeleccionado;
        public FrmPerfiles()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (UsuarioSeleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            BLLUsuario bllUsuario = new BLLUsuario();
            UsuariosVersionados = bllUsuario.ObtenerVersiones(UsuarioSeleccionado);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = UsuariosVersionados;
        }

        private void FrmPerfiles_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            BLLUsuario bllUsuario = new BLLUsuario();
            Usuarios = (List<BEUser>)bllUsuario.ObtenerUsuarios();

            listBox1.Items.Clear();

            foreach (BEUser usuario in Usuarios)
            {
                listBox1.Items.Add(usuario);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (CambioSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cambio");
                return;
            }
            BLLUsuario bllUsuario = new BLLUsuario();

            UsuarioSeleccionado.Nombre = CambioSeleccionado.Nombre;
            UsuarioSeleccionado.Apellido = CambioSeleccionado.Apellido;
            UsuarioSeleccionado.Mail = CambioSeleccionado.Mail;

            bool actualizacionExitosa = bllUsuario.ModificarUsuario2(UsuarioSeleccionado);
            if (!actualizacionExitosa)
            {
                MessageBox.Show("No se puedo volver a una version anterior");
                return;
            }

            bllUsuario.ActualizarUsuario(UsuarioSeleccionado);
            CambioSeleccionado = null;
            UsuarioSeleccionado = null;

            CargarUsuarios();
            UsuariosVersionados = new List<BEUser>();
            dataGridView1.DataSource = null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsuarioSeleccionado = (BEUser)listBox1.SelectedItem;
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CambioSeleccionado = (BEUser)dataGridView1.CurrentRow.DataBoundItem;
        }
    }
}

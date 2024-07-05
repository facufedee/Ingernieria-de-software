using Abstraccion;
using BE;
using BLL;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABSTRACCION;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class frmMDI : Form, ITraducible
    {
        private frmBitacora formBitacora = null;
        private frmGestionUser formGestionUser = null;
        private frmPermisos formPermisos = null;
        private frmPermisosUsuarios formPermisosUsuarios = null;
        private frmCrearIdioma formCrearIdioma = null;
        private FromModificarIdioma formModificarIdioma = null;
        private frmAltaUsuario formAltaUsuario = null;
        private FrmModificarUsuario frmModificarUsuario = null;
        private FrmPerfiles frmPerfiles = null;


        BLLUsuario _bllUsuario;
        BLLBitacora _bllBitacora;
        BEBitacora _beBitacora;
        BLLPermiso _permisos;
        BEPermiso _bePermiso;
        public frmMDI()
        {
            InitializeComponent();
            PermisosUsuario();
            Registrarse();
            CargarIdiomas();
            Actualizar();
        }

        public void Actualizar()
        {
            BLLTraductor bllTraductor = new BLLTraductor();
            List<BEPalabra> Palabras = bllTraductor.ObtenerPalabras();

            if (Tag != null && Tag != "")
            {
                Text = Palabras.Find(pal => pal.Tag.Equals(Tag)).Texto;
            }
            try
            {
                cambioDeContraseñaToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(cambioDeContraseñaToolStripMenuItem.Tag)).Texto;
                listarBitacoraToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(listarBitacoraToolStripMenuItem.Tag)).Texto;
                altaUsuarioToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(altaUsuarioToolStripMenuItem.Tag)).Texto;
                modificarUsuarioToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(modificarUsuarioToolStripMenuItem.Tag)).Texto;
                crearIdiomaToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(crearIdiomaToolStripMenuItem.Tag)).Texto;
                modificarIdiomaToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(modificarIdiomaToolStripMenuItem.Tag)).Texto;
                bitacoraToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(bitacoraToolStripMenuItem.Tag)).Texto;
                cambioDeContraseñaToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(cambioDeContraseñaToolStripMenuItem.Tag)).Texto;
                permisoToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(permisoToolStripMenuItem.Tag)).Texto;
                permisosUsuariosToolStripMenuItem.Text = Palabras.Find(pal => pal.Tag.Equals(permisosUsuariosToolStripMenuItem.Tag)).Texto;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Faltan traducciones");
            }
        }

        private void CargarIdiomas()
        {
            BLLTraductor bllTraductor = new BLLTraductor();
            List<BEIdioma> Idiomas = bllTraductor.ObtenerIdiomasHabilitados();
            comboBox1.DataSource = null;
            comboBox1.DataSource = Idiomas;
        }

        public void Registrarse()
        {
            BLLTraductor BllTraductor = new BLLTraductor();
            BllTraductor.RegistrarForm(this);
        }

        private void PermisosUsuario()
        {

            //obtenemos el usuario logueado 
            BLLUsuario bllUsuario = new BLLUsuario();
            BEUser UsuarioLogueado = bllUsuario.ObtenerUsuarioLogueado();

            
            BLLPadre bllpadre = new BLLPadre();
            //menu usuario : 
            //Cambio de contraseñas=1
            bool resultado;
            resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 1);
            if (resultado == false)
            {
                this.cambioDeContraseñaToolStripMenuItem.Visible = true;
            }
            else
            {
                this.cambioDeContraseñaToolStripMenuItem.Visible = false;
            }

            //Listar bitacora=2
            resultado = true;
            resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 2);
            if (resultado == false)
            {
                this.listarBitacoraToolStripMenuItem.Visible = true;
            }
            else
            {
                this.listarBitacoraToolStripMenuItem.Visible = false;
            }

            //Alta usuario=3
            resultado = true;
            resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 3);
            if (resultado == false)
            {
                this.altaUsuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                this.altaUsuarioToolStripMenuItem.Visible = false;
            }

            //Eliminar Usuario=4
            resultado = true;
            resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 4);
            if (resultado == false)
            {
                this.modificarUsuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                this.modificarUsuarioToolStripMenuItem.Visible = false;
            }


            //Crear Idioma=5
            resultado = true;
            resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 5);
            if (resultado == false)
            {
                this.crearIdiomaToolStripMenuItem.Visible = true;
            }
            else
            {
                this.crearIdiomaToolStripMenuItem.Visible = false;
            }

            //Modificar idioma =6
            resultado = true;
            resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 6);
            if (resultado == false)
            {
                this.modificarIdiomaToolStripMenuItem.Visible = true;
            }
            else
            {
                this.modificarIdiomaToolStripMenuItem.Visible = false;
            }


            //Control de versiones =7  
            resultado = true;
            resultado = bllpadre.ValidarIdPermiso(UsuarioLogueado.LPermisos, 7);
            if (resultado == false)
            {
                this.controlDeVersionesToolStripMenuItem.Visible = true;
            }
            else
            {
                this.controlDeVersionesToolStripMenuItem.Visible = false;
            }


        }
        private void AbrirFormBitacora()
        {
            if (formGestionUser != null && formGestionUser.Visible)
            {
                formGestionUser.Hide();
            }

            if (formBitacora == null || formBitacora.IsDisposed)
            {
                formBitacora = new frmBitacora();
                formBitacora.MdiParent = this;
                formBitacora.FormClosed += (s, e) => formBitacora = null; // Liberar referencia cuando se cierra
                formBitacora.WindowState = FormWindowState.Maximized;
                formBitacora.Show();
            }
            else
            {
                formBitacora.BringToFront();
                formBitacora.WindowState = FormWindowState.Maximized;
                formBitacora.Show(); // Asegurar que se muestre si estaba oculto
            }
        }

        private void AbrirFormGestionUser()
        {
            if (formBitacora != null && formBitacora.Visible)
            {
                formBitacora.Hide();
            }

            if (formGestionUser == null || formGestionUser.IsDisposed)
            {
                formGestionUser = new frmGestionUser();
                formGestionUser.MdiParent = this;
                formGestionUser.FormClosed += (s, e) => formGestionUser = null; 
                formGestionUser.WindowState = FormWindowState.Maximized;
                formGestionUser.Show();
            }
            else
            {
                formGestionUser.BringToFront();
                formGestionUser.WindowState = FormWindowState.Maximized;
                formGestionUser.Show(); // Asegurar que se muestre si estaba oculto
            }
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                _beBitacora = new BEBitacora();
                _bllBitacora = new BLLBitacora();
                _bllUsuario = new BLLUsuario();



                _beBitacora.Tipo = BitacoraTipo.INFO;
                _beBitacora.Usuario = Sesion.ObtenerUsername();
                _beBitacora.Mensaje = "Cierre de sesion.";
                _bllBitacora.Add(_beBitacora);
                _bllUsuario.CerrarSesion();
                Application.Exit();
            }
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormGestionUser();
        }

        private void listarBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormBitacora();
        }

        private void permisoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (formPermisos == null || formPermisos.IsDisposed)
            {
            formPermisos = new frmPermisos();
            formPermisos.MdiParent = this;
            //formPermisos.FormClosed += (s, e) => formPermisos = null; // Liberar referencia cuando se cierra
            formPermisos.WindowState = FormWindowState.Maximized;
            formPermisos.Show();

             }

        }

        private void permisosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formPermisosUsuarios == null || formPermisosUsuarios.IsDisposed)
            {
                formPermisosUsuarios = new frmPermisosUsuarios();
                formPermisosUsuarios.MdiParent = this;
                //formPermisos.FormClosed += (s, e) => formPermisos = null; // Liberar referencia cuando se cierra
                formPermisosUsuarios.WindowState = FormWindowState.Maximized;
                formPermisosUsuarios.Show();

            }

        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formAltaUsuario == null || formAltaUsuario.IsDisposed)
            {
                formAltaUsuario = new frmAltaUsuario();
                formAltaUsuario.MdiParent = this;
                //formPermisos.FormClosed += (s, e) => formPermisos = null; // Liberar referencia cuando se cierra
                formAltaUsuario.WindowState = FormWindowState.Maximized;
                formAltaUsuario.Show();

            }
        }

        

        private void crearIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCrearIdioma == null || formCrearIdioma.IsDisposed)
            {
                formCrearIdioma = new frmCrearIdioma();
                formCrearIdioma.MdiParent = this;
                //formPermisos.FormClosed += (s, e) => formPermisos = null; // Liberar referencia cuando se cierra
                formCrearIdioma.WindowState = FormWindowState.Maximized;
                formCrearIdioma.Show();

            }
        }

        private void modificarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formModificarIdioma == null || formModificarIdioma.IsDisposed)
            {
                formModificarIdioma = new FromModificarIdioma();
                formModificarIdioma.MdiParent = this;
                //formPermisos.FormClosed += (s, e) => formPermisos = null; // Liberar referencia cuando se cierra
                formModificarIdioma.WindowState = FormWindowState.Maximized;
                formModificarIdioma.Show();

            }
        }

        private void controlDeVersionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPerfiles == null || frmPerfiles.IsDisposed)
            {
                frmPerfiles = new FrmPerfiles();
                frmPerfiles.MdiParent = this;
                //formPermisos.FormClosed += (s, e) => formPermisos = null; // Liberar referencia cuando se cierra
                frmPerfiles.WindowState = FormWindowState.Maximized;
                frmPerfiles.Show();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BEIdioma Idioma = (BEIdioma)comboBox1.SelectedItem;
            if (Idioma != null)
            {
                BLLTraductor bllTraductor = new BLLTraductor();
                bllTraductor.CambiarIdioma(Idioma.Id);
            }
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmModificarUsuario == null || frmModificarUsuario.IsDisposed)
            {
                frmModificarUsuario = new FrmModificarUsuario();
                frmModificarUsuario.MdiParent = this;
                //formPermisos.FormClosed += (s, e) => formPermisos = null; // Liberar referencia cuando se cierra
                frmModificarUsuario.WindowState = FormWindowState.Maximized;
                frmModificarUsuario.Show();

            }
        }
    }


}

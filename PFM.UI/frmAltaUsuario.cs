using ABSTRACCION;
using BE;
using BLL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
           
        }

       

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                frmLogin ofrmLogin = new frmLogin();
                ofrmLogin.Show();
            }
        }

        private void MostrarToolTip(string mensaje, Control control)
        {
            toolTip2.Show(mensaje, control, 0, 0, 2200);
        }

        private void OcultarToolTip(Control control)
        {
            toolTip2.Hide(control);
        }

       

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserAlta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUserAlta_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPassAlta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreAlta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoAlta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMailAlta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            //    string username = txtUserAlta.Text.Trim();
            //    if (string.IsNullOrEmpty(username))
            //    {
            //        MostrarToolTip("Por favor ingresar un usuario", txtUserAlta);
            //        return;
            //    }
            //    OcultarToolTip(txtUserAlta);

            //    string password = txtPassAlta.Text;
            //    if (string.IsNullOrEmpty(password))
            //    {
            //        MostrarToolTip("Por favor ingrese una contraseña", txtPassAlta);
            //        return;
            //    }
            //    OcultarToolTip(txtPassAlta);

            //    BLLUsuario _bllUsuario = new BLLUsuario();

            //    BEUser user = new BEUser();
            //    user.Username = username;

            //    if (_bllUsuario.ValidarUser(user))
            //    {
            //        MessageBox.Show("El nombre de usuario ya está en uso, por favor elija otro.", "ERROR USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    if (!_bllUsuario.Validar_pass_regex(password))
            //    {
            //        MessageBox.Show("La contraseña debe contener entre 6 y 15 caracteres alfanuméricos.", "ERROR CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        txtPassAlta.Text = "";
            //        return;
            //    }

            //    string confirmPass = txtConfirm.Text;
            //    if (password != confirmPass)
            //    {
            //        MessageBox.Show("Las contraseñas no coinciden, por favor inténtelo de nuevo.", "ERROR CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    string passwordEncriptada = _bllUsuario.Encriptador(password);
            //    user.Password = passwordEncriptada;
            //    user.Nombre = txtNombreAlta.Text;
            //    user.Apellido = txtApellidoAlta.Text;
            //    user.Mail = txtMailAlta.Text;
            //     user.DVV = _bllUsuario.ObtenerDVH(user);
            //    _bllUsuario.AltaUsuario(user);


            //MessageBox.Show("Usuario creado exitosamente", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    this.Close();
            //    frmLogin ofrmLogin = new frmLogin();
            //    ofrmLogin.Show();
            string username = txtUserAlta.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MostrarToolTip("Por favor ingresar un usuario", txtUserAlta);
                return;
            }
            OcultarToolTip(txtUserAlta);

            string password = txtPassAlta.Text;
            if (string.IsNullOrEmpty(password))
            {
                MostrarToolTip("Por favor ingrese una contraseña", txtPassAlta);
                return;
            }
            OcultarToolTip(txtPassAlta);

            BLLUsuario _bllUsuario = new BLLUsuario();

            BEUser user = new BEUser
            {
                Username = username,
                Nombre = txtNombreAlta.Text,
                Apellido = txtApellidoAlta.Text,
                Mail = txtMailAlta.Text
            };

            if (_bllUsuario.ValidarUser(user))
            {
                MessageBox.Show("El nombre de usuario ya está en uso, por favor elija otro.", "ERROR USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_bllUsuario.Validar_pass_regex(password))
            {
                MessageBox.Show("La contraseña debe contener entre 6 y 15 caracteres alfanuméricos.", "ERROR CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassAlta.Text = "";
                return;
            }

            string confirmPass = txtConfirm.Text;
            if (password != confirmPass)
            {
                MessageBox.Show("Las contraseñas no coinciden, por favor inténtelo de nuevo.", "ERROR CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passwordEncriptada = _bllUsuario.Encriptador(password);
            user.Password = passwordEncriptada;
            user.DVV = _bllUsuario.ObtenerDVH(user);

            _bllUsuario.AltaUsuario(user);

            MessageBox.Show("Usuario creado exitosamente", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            frmLogin ofrmLogin = new frmLogin();
            ofrmLogin.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                    frmLogin ofrmLogin = new frmLogin();
                    ofrmLogin.Show();
                }

            
        }
    }

}

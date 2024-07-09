﻿using Abstraccion;
using BE;
using BLL;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace UI
{
    public partial class frmLogin : Form
    {
        BLLUsuario _bllUsuario;
        BLLBitacora _bllBitacora;
        BEBitacora _beBitacora;
        public frmLogin()
        {
            InitializeComponent();
        }
   
        private void btnLogin_Click(object sender, EventArgs e)
        {
                IniciarSesion();      
        }


        private void IniciarSesion()
        {

            try
            {
                _bllUsuario = new BLLUsuario();
                _bllBitacora = new BLLBitacora();
                _beBitacora = new BEBitacora();

                //IUser user = new BEUser();
                BEUser user = new BEUser();
                user.Username = txtUser.Text;

                // Si el textbox de usuario esta vacio va a mostrar el mensaje de recomendación 
                if (string.IsNullOrEmpty(txtUser.Text))
                {
                    toolTip2.Show("Por favor ingresar un usuario", txtUser, 0, 0, 1200);
                    return;
                }
                else
                {
                    // Ocultar el mensaje de recomendación 
                    toolTip2.Hide(txtUser);
                }



                // Validamos el usuario
                if (!_bllUsuario.ValidarUser(user))
                {
                    MessageBox.Show("El usuario no registrado", "ERROR USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarTxt();
                    return;
                }
            
                
                // Si el textbox de usuario esta vacio va a mostrar el mensaje de recomendación 
                if (string.IsNullOrEmpty(txtPassword.Text))
                    {  
                        // Mostrar el mensaje de recomendación del ToolTip
                        toolTip1.Show("Por favor ingrese una contraseña", txtPassword,0, 0, 1200);
                        return;
                    }
                    else
                    {
                        // Ocultar el mensaje de recomendación del ToolTip
                        toolTip1.Hide(txtPassword);
                    }
      


                string password = txtPassword.Text;
                // Validamos la contraseña con Regex
                if (!_bllUsuario.Validar_pass_regex(password))
                {
                    MessageBox.Show("La contraseña debe contener entre 6 y 15 caracteres alfanuméricos.", "ERROR CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Text = "";
                    return;
                }


                // Encriptamos la contraseña                
                user.Password = _bllUsuario.Encriptador(password);

                // Validamos la contraseña en la base de datos
                if (!_bllUsuario.validarPass(user))
                {
                    MessageBox.Show("Contraseña incorrecta", "ERROR CONTRASEÑA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Text = "";
                    return;
                }
                else
                {   
                    _bllUsuario.ObtenerPermisosUsuario(user);
                }

                // Iniciamos sesión
                Sesion.Login(user);

                // Registramos en la bitácora
                _beBitacora.Tipo = BitacoraTipo.INFO;
                _beBitacora.Usuario = user.Username;
                _beBitacora.Mensaje = "Inicio de sesión";
                _bllBitacora.Add(_beBitacora);

                LimpiarTxt();

                this.Hide();
                frmMDI ofrmContenedor = new frmMDI();
                ofrmContenedor.Show();

            }
            catch (Exception ex)
            {
                _beBitacora.Tipo = BitacoraTipo.ERROR;
                _beBitacora.Usuario = Sesion.ObtenerUsername();
                _beBitacora.Mensaje = ex.Message.ToString();
                _bllBitacora.Add(_beBitacora);
                MessageBox.Show("Se produjo un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void LimpiarTxt()
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IniciarSesion();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IniciarSesion();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaUsuario ofrmAlta = new frmAltaUsuario();
            ofrmAlta.Show();
        }
    }
}

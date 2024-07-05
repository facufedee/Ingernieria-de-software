using AccesoDatos;
using Abstraccion;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Dynamic;
using FRAMEWORK;


namespace BLL
{
    public class BLLUsuario
    {
        DALUsuario _acceso = new DALUsuario();

        public bool ValidarUser(IUser usuario)
        {
            return _acceso.ExisteUsuario(usuario);
        }

        //valido si la password del usuario es valida
        public bool validarPass(IUser usuario)
        {
            return _acceso.validarPass(usuario);
        }

        //Metodo para validar contraseña REGEX
        public bool Validar_pass_regex(string pass)
        {
            ValidarRegex validador = new ValidarRegex();
            return validador.Validar_pass_regex(pass);
        }

        //Metodo para encriptar contraseña
        public string Encriptador(string pass)
        {
            Criptografia encriptador = new Criptografia();

            return encriptador.Encriptador(pass);
        }

        public void CerrarSesion()
        {

            Sesion.Logout();
        }

        public bool AltaUsuario(IUser user)
        {
            bool existoso = _acceso.AltaUsuario(user);
            if (existoso)
            {
                ActualizarDVV();
            }
            return existoso;
        }

        private void ActualizarDVV()
        {
            DalAccesoDatos accesoDatos = new DalAccesoDatos();
            string dvv = CalcularDV();
            accesoDatos.ActualizarDVV(dvv);
        }

        public bool ModificarUsuario(BEUser usuarioLogueado)
        {
           return _acceso.ModificarUsuario(usuarioLogueado);

        }

        public BEUser ObtenerUsuarioLogueado()
        {
            Sesion sesion = Sesion.GetInstance;

            // Recupera el usuario de la sesión
            IUser user = sesion.User;
            return (BEUser)user;
        }

        public object ObtenerUsuarios()
        {
            DalAccesoDatos accesoDatos = new DalAccesoDatos();

            return accesoDatos.ObtenerUsuarios();
        }

        public List<BEPermiso> ObtenerPermisosUsuario(BEUser usuario)
        {
            DalAccesoDatos accesoDatos = new DalAccesoDatos();

            return accesoDatos.ObtenerPermisosUsuario(usuario);

        }

        public string ObtenerDVH(BEUser user)
        {
            CreacionDV Gen = new CreacionDV();
            return Gen.Generar(user);
        }

        public bool EsValidoDV()
        {

            if (!SonValidosDVHs())
            {
                return false;
            }
            DalAccesoDatos accesoDatos = new DalAccesoDatos();
            string DVVCalculado = CalcularDV();

            return DalAccesoDatos.ValidarDV(DVVCalculado);
        }

        private bool SonValidosDVHs()
        {
            List<BEUser> Usuarios = (List<BEUser>)ObtenerUsuarios();
            foreach (BEUser Usuario in Usuarios)
            {
                if (!Usuario.DVV.Equals(ObtenerDVH(Usuario)))
                {
                    return false;
                }
            }

            return true;


           

        }

        private string CalcularDV()
        {
            List<BEUser> Usuarios = (List<BEUser>)ObtenerUsuarios();
            List<string> ListaDv = Usuarios.ConvertAll(user => user.DVV);
            CreacionDV GenDV = new CreacionDV();
            return GenDV.GenerarDVV(ListaDv);


        }

        public bool ModificarUsuario2(BEUser usuarioLogueado)
        {
            return _acceso.ModificarUsuario2(usuarioLogueado);
        }

        public List<BEUser> ObtenerVersiones(BEUser usuarioSeleccionado)
        {
            DalAccesoDatos accesoDatos = new DalAccesoDatos();

            return accesoDatos.ObtenerVersiones(usuarioSeleccionado);
        }

        public void ActualizarUsuario(BEUser usuarioSeleccionado)
        {
            Sesion.Instance().IniciarSesion(usuarioSeleccionado);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABSTRACCION;
using SERVICIOS;
using BE;

namespace FRAMEWORK
{
    public class CreacionDV
    {
        public string Generar(BEUser usuario)
        {
            string cadena = usuario.Nombre + usuario.Apellido + usuario.Username + usuario.Mail;
            Criptografia Enc = new Criptografia();
            return Enc.Encriptador(cadena);
        }

        public string GenerarDVV(List<string> listaDv)
        {
            string cadena = "";
            foreach (string dv in listaDv)
            {
                cadena = cadena + dv;
            }
            Criptografia Enc = new Criptografia();
            return Enc.Encriptador(cadena);
        }
    }
}


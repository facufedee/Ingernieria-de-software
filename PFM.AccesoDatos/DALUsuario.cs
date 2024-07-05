using Abstraccion;
using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Collections;

namespace AccesoDatos
{
    public class DALUsuario
    {
        public bool ExisteUsuario(IUser user)
        {
            bool UserOK = false;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand("SP_USER_VALIDAR_USUARIO", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Usuario", user.Username);
                        int count = (int)command.ExecuteScalar();
                        UserOK = count > 0;
                    }
            }
            return UserOK;
        }
       
        public bool validarPass(IUser user)
        {
            bool PasswordOK = false;
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand("SP_USER_VALIDAR_PASS", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Usuario", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        int count = (int)command.ExecuteScalar();
                        PasswordOK = count > 0;
                    }
                }
                return PasswordOK;
        }

        public bool AltaUsuario(IUser user)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
            {
                cnn.Open();
                SqlTransaction transaction = cnn.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand("SP_USER_ALTA", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@Usuario", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@DW", user.DVV);
                        command.Parameters.AddWithValue("@Nombre", user.Nombre);
                        command.Parameters.AddWithValue("@Apellido", user.Apellido);
                        command.Parameters.AddWithValue("@Mail", user.Mail);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public bool ModificarUsuario(IUser user)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
            {
                cnn.Open();
                    using (SqlCommand command = new SqlCommand("SP_USER_MODIFICAR", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Usuario", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.ExecuteNonQuery();
                    }
                    return true;
            }
        }

        public bool ModificarUsuario2(BEUser usuarioLogueado)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand("SP_USER_MODIFICAR_Datos", cnn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Usuario", usuarioLogueado.Username);
                    command.Parameters.AddWithValue("@Nombre", usuarioLogueado.Nombre);
                    command.Parameters.AddWithValue("@Apellido", usuarioLogueado.Apellido);
                    command.Parameters.AddWithValue("@Mail", usuarioLogueado.Mail);
                    command.ExecuteNonQuery();
                }
                return true;
            }
        }
    }
}

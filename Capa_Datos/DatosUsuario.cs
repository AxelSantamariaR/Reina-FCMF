using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Datos
{
    public class DatosUsuario
    {

        public DataTable LlenasTablas(string transaccion)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_Tablas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Transaccion", transaccion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Validar(string transaccion, string parametro)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_Validaciones", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Transaccion", transaccion);
                cmd.Parameters.AddWithValue("@Parametro", parametro);

                cmd.ExecuteNonQuery();             

                if (cmd.ExecuteScalar() != null) return true;
                else return false;
            }
        }

        public Respuesta AgregarUsuario(string transaccion, Usuario usuario)
        {
            Respuesta respuesta = null;
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Usuario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Identificacion", usuario.Identificacion);
                    cmd.Parameters.AddWithValue("@Email", usuario.Email);
                    cmd.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                    cmd.Parameters.AddWithValue("@Username", usuario.Username);
                    cmd.Parameters.AddWithValue("@Password", usuario.Password);
                    cmd.Parameters.AddWithValue("@PerfilUsuarioId", usuario.PerfilUsuario.Id);
                    cmd.Parameters.AddWithValue("@Transaccion", transaccion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        respuesta = new Respuesta
                        {
                            Titulo  = dt.Rows[0]["Titulo"].ToString(),
                            Mensaje = dt.Rows[0]["Mensaje"].ToString(),
                        };
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la autenticación: " + ex.Message);
                }
            }
            return respuesta;
        }

        public Respuesta AgregarEstudiante(string transaccion, Estudiante estudiante)
        {
            Respuesta respuesta = null;

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Usuario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Identificacion", estudiante.Identificacion);
                    cmd.Parameters.AddWithValue("@Email", estudiante.Email);
                    cmd.Parameters.AddWithValue("@Nombres", estudiante.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", estudiante.Apellidos);
                    cmd.Parameters.AddWithValue("@Username", estudiante.Username);
                    cmd.Parameters.AddWithValue("@Password", estudiante.Password);
                    cmd.Parameters.AddWithValue("@PerfilUsuarioId", estudiante.PerfilUsuario.Id);
                    cmd.Parameters.AddWithValue("@Transaccion", transaccion);
                    cmd.Parameters.AddWithValue("@Matricula", estudiante.Matricula);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        respuesta = new Respuesta
                        {
                            Titulo = dt.Rows[0]["Titulo"].ToString(),
                            Mensaje = dt.Rows[0]["Mensaje"].ToString(),
                        };
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la autenticación: " + ex.Message);
                }
            }
            return respuesta;
        }
    }
}

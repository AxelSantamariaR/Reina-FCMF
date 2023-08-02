using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Datos
{
    public class DatosAuthentication
    {
        public Usuario Authentication(string username, string password)
        {
            Usuario usuario = null;

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Login", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        usuario = new Usuario
                        {
                            Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                            Nombres = dt.Rows[0]["Nombres"].ToString(),
                            Apellidos = dt.Rows[0]["Apellidos"].ToString(),
                            Username = dt.Rows[0]["Username"].ToString(),
                            PerfilUsuario = new PerfilUsuario
                            {
                                Id = Convert.ToInt32(dt.Rows[0]["Id"])
                            }
                        };
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en la autenticación: " + ex.Message);
                }
            }
            return usuario;
        }
    }
}

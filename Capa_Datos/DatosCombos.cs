using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DatosCombos
    {
        public List<Nacionalidad> Nacionalidades(string transaccion)
        {
            List<Nacionalidad> nacionalidades = new List<Nacionalidad>();

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Combos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Transaccion", transaccion);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        Nacionalidad nacionalidad = new Nacionalidad
                        {
                            Id      = Convert.ToInt32(row["Id"]),
                            Pais    = row["Pais"].ToString() 
                        };

                        nacionalidades.Add(nacionalidad);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return nacionalidades;
        }

        public List<Idioma> Idiomas(string transaccion)
        {
            List<Idioma> idiomas = new List<Idioma>();

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Combos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Transaccion", transaccion);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        Idioma idioma = new Idioma
                        {
                            Id          = Convert.ToInt32(row["Id"]),
                            Descripcion = row["Descripcion"].ToString()
                        };

                        idiomas.Add(idioma);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return idiomas;
        }
    }

}

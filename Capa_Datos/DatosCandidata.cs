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
    public class DatosCandidata
    {
        public Respuesta AgregarCandidata(string transaccion, Candidata candidata)
        {
            Respuesta respuesta = null;
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Candidata", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre",          candidata.Nombres);
                    cmd.Parameters.AddWithValue("@FechaNac",        candidata.FechaNac);
                    cmd.Parameters.AddWithValue("@Telefono",        candidata.Telefono);
                    cmd.Parameters.AddWithValue("@Email",           candidata.Email);
                    cmd.Parameters.AddWithValue("@NacionalidadId",  candidata.NacionalidadId.Id);
                    cmd.Parameters.AddWithValue("@FotoNombre",      candidata.FotoNombre);
                    cmd.Parameters.AddWithValue("@TituloAcademico", candidata.TituloAcademico);
                    cmd.Parameters.AddWithValue("@Pasatiempos",     candidata.Pasatiempos);
                    cmd.Parameters.AddWithValue("@Habilidades",     candidata.Habilidades);
                    cmd.Parameters.AddWithValue("@Intereses",       candidata.Intereses);
                    cmd.Parameters.AddWithValue("@Aspiraciones",    candidata.Aspiraciones);
                    cmd.Parameters.AddWithValue("@IdiomaId",        candidata.IdiomaId.Id);
                    cmd.Parameters.AddWithValue("@Transaccion",     transaccion);

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
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return respuesta;
        }

        public int CrearAlbum(string transaccion, Album album)
        {
            int id = 0;
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Album", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CandidataId", album.Candidata.Id);
                    cmd.Parameters.AddWithValue("@NombreAlbum", album.Nombre);
                    cmd.Parameters.AddWithValue("@Transaccion", transaccion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        id = Convert.ToInt32(dt.Rows[0]["Id"]);
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return id;
        }

        public int AgregarFoto(string transaccion, Foto foto)
        {
            int id = 0;
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_Album", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FotoNombre", foto.FotoNombre);
                    cmd.Parameters.AddWithValue("@Titulo", foto.Titulo);
                    cmd.Parameters.AddWithValue("@Descripcion", foto.Descripcion);
                    cmd.Parameters.AddWithValue("@AlbumId", foto.Album.Id);
                    cmd.Parameters.AddWithValue("@Transaccion", transaccion);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        id = Convert.ToInt32(dt.Rows[0]["Id"]);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return id;
        }
    }
}

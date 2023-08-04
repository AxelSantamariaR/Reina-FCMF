using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.VistaGestor
{
    public partial class GestorAlbumes : Form
    {
        NegocioUsuarios negUsu = new NegocioUsuarios();
        NegocioCandidatas negCan = new NegocioCandidatas();
        bool messageShown = false;

        public GestorAlbumes()
        {
            InitializeComponent();
        }

        private void GestorAlbumes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = negUsu.Tablas("TablaCandidata");

            DataGridViewButtonColumn crearAlbum = new DataGridViewButtonColumn();
            crearAlbum.HeaderText = "Crear Álbum";
            crearAlbum.Text = "Crear Álbum";
            crearAlbum.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(crearAlbum);

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Crear Álbum" && !messageShown)
                {
                    int filaSeleccionada = dataGridView1.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dataGridView1.Rows[filaSeleccionada].Cells["Id"].Value);

                    CrearAlbum crearAlbum = new CrearAlbum();
                    if (crearAlbum.ShowDialog() == DialogResult.OK)
                    {
                        string NombreAlbum = crearAlbum.RecogerNombre();

                        AgregarFotosAlbum agregarAlbum = new AgregarFotosAlbum(NombreAlbum);
                        if (agregarAlbum.ShowDialog() == DialogResult.OK)
                        {
                            Album album         = new Album();
                            album.Candidata     =   new Candidata
                            {
                                Id              = id
                            };
                            album.Nombre        = NombreAlbum;
                            int idGenerado      = negCan.CrearAlbum(album);

                            if (idGenerado != 0)
                            {
                                List<Foto> fotosAlbum = agregarAlbum.getFotos();

                                foreach (var Foto in fotosAlbum)
                                {
                                    Foto.Album = new Album
                                    {
                                        Id = idGenerado
                                    };  
                                }
                                int bandera = negCan.AgregarFotos(fotosAlbum);
                                if (bandera != 0)
                                {
                                    MessageBox.Show("Album creado con éxito", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Ha ocurrido un error", "Lo sentimos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    messageShown = true;
                }
                else
                {
                    messageShown = false;
                }
            }
        }
    }
}

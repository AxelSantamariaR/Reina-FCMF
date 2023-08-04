using Capa_Entidad;
using Capa_Presentacion.Shared;
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
    public partial class AgregarFotosAlbum : Form
    {
        SubirImagen subirImagen = new SubirImagen();
        List<string> fileNames = new List<string>();
        List<Foto> listFotos = new List<Foto>();
        string nombreAlbum;        

        public AgregarFotosAlbum(string nombreAlbum)
        {
            InitializeComponent();
            this.nombreAlbum = nombreAlbum;
        }

        private void LlenarTabla()
        {
            dataGridView2.Rows.Clear();
            foreach (string fileName in fileNames)
            {
                dataGridView2.Rows.Add(fileName);
            }
        }

        public List<Foto> getFotos()
        {
            return listFotos;
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.Image = Properties.Resources.Gestor_Album_Fotos_Agregar_Hover;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.Image = Properties.Resources.Gestor_Album_Fotos_Agregar;
        }

        private void btnFotos_Click(object sender, EventArgs e)
        {
            if (fileNames.Count <= 4)
            {
                if (!string.IsNullOrEmpty(txtTitulo.Text) && !string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.Filter = "Imagenes|*.jpg; *.jpeg; *png";
                    openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    openFile.Title = "Seleccionar Imagen";
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        fileNames.Add(openFile.FileName);

                        Foto foto           = new Foto();
                        foto.Titulo         = txtTitulo.Text;
                        foto.Descripcion    = txtDescripcion.Text;
                        foto.FotoNombre     = subirImagen.SaveImageToFile(openFile.FileName, txtTitulo.Text);
                        listFotos.Add(foto);

                        LlenarTabla();
                        txtTitulo.Clear();
                        txtDescripcion.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Primero proporcione un titulo y una descripcion", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Solo se permiten 5 fotos", "Capacidad llena", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void CrearAlbum_Load(object sender, EventArgs e)
        {
            lbNombreAlbum.Text = nombreAlbum;
            DataGridViewTextBoxColumn urlColumn = new DataGridViewTextBoxColumn();
            urlColumn.HeaderText = "URL";
            urlColumn.Name = "urlColumn";
            dataGridView2.Columns.Add(urlColumn);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

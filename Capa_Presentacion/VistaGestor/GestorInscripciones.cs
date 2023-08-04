using Capa_Entidad;
using Capa_Negocio;
using Capa_Presentacion.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.VistaGestor
{
    public partial class GestorInscripciones : Form
    {
        NegocioCombos negCom = new NegocioCombos();
        NegocioCandidatas negCan = new NegocioCandidatas();
        List<Nacionalidad> listaNacionalidades = new List<Nacionalidad>();
        List<Idioma> listIdiomas = new List<Idioma>();
        private string nameFile = "";
        SubirImagen subirImagen = new SubirImagen();

        public GestorInscripciones()
        {
            InitializeComponent();
        }

        private void GestorInscripciones_Load(object sender, EventArgs e)
        {
            LlenarCombos();
        }

        private void LlenarCombos()
        {
            listaNacionalidades             = negCom.getNacionalidades();
            cbNacionalidad.DisplayMember    = "Pais";
            cbNacionalidad.ValueMember      = "Id";
            cbNacionalidad.DataSource       = listaNacionalidades;

            listIdiomas                     = negCom.getIdiomas();
            cbIdiomas.DisplayMember         = "Descripcion";
            cbIdiomas.ValueMember           = "Id";
            cbIdiomas.DataSource            = listIdiomas;
        }

        private void MostrarMensaje(string titulo, string message)
        {
            if (titulo == "Enhorabuena")
            {
                MessageBox.Show(message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.Image = Properties.Resources.Administrador_Boton_Agregar_Hover;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.Image = Properties.Resources.Administrador_Boton_Agregar;
        }

        private void btnFotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Imagenes|*.jpg; *.jpeg; *png";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFile.Title = "Seleccionar Imagen";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                nameFile = openFile.FileName;
            }
        }

        private bool Verificar()
        {
            return !string.IsNullOrEmpty(txtNombres.Text)
                && !string.IsNullOrEmpty(txtEmail.Text)
                && !string.IsNullOrEmpty(txtTelefono.Text)
                && !string.IsNullOrEmpty(txtTitulo.Text)
                && !string.IsNullOrEmpty(nameFile)
                && !string.IsNullOrEmpty(txtPasatiempos.Text)
                && !string.IsNullOrEmpty(txtHabilidades.Text)
                && !string.IsNullOrEmpty(txtIntereses.Text)
                && !string.IsNullOrEmpty(txtAspiraciones.Text);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (txtTelefono.Text.Length >= 10 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtPasatiempos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtHabilidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtIntereses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtAspiraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void Limpiar()
        {
            txtNombres.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            nameFile = "";
            txtTitulo.Clear();
            txtPasatiempos.Clear();
            txtHabilidades.Clear();
            txtIntereses.Clear();
            txtAspiraciones.Clear();  
            cbNacionalidad.SelectedIndex = 0;
            cbIdiomas.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                Candidata candidata         = new Candidata();
                candidata.Nombres           = txtNombres.Text;
                candidata.FechaNac          = dtFechaNac.Value;
                candidata.Telefono          = txtTelefono.Text;
                candidata.Email             = txtEmail.Text;
                candidata.NacionalidadId    = new Nacionalidad {
                    Id                      = listaNacionalidades[cbNacionalidad.SelectedIndex].Id
                };
                candidata.FotoNombre        = subirImagen.SaveImageToFile(nameFile, txtNombres.Text);
                candidata.TituloAcademico   = txtTitulo.Text;
                candidata.Pasatiempos       = txtPasatiempos.Text;
                candidata.Habilidades       = txtHabilidades.Text;
                candidata.Intereses         = txtIntereses.Text;
                candidata.Aspiraciones      = txtAspiraciones.Text;
                candidata.IdiomaId          = new Idioma
                {
                    Id                      = listIdiomas[cbIdiomas.SelectedIndex].Id
                };
                Respuesta respuesta = negCan.AddCandidata(candidata);
                Limpiar();
                MostrarMensaje(respuesta.Titulo, respuesta.Mensaje);
            }
            else
            {
                MessageBox.Show("Campos vacíos", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

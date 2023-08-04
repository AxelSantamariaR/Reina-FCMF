using Capa_Entidad;
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
    public partial class InicioGestor : Form
    {
        Usuario usuarioLogeado;

        public InicioGestor(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogeado = usuario;
        }

        private void InicioGestor_Load(object sender, EventArgs e)
        {
            label1.Text = "     Módulo Gestor - Bienvenido " + usuarioLogeado.Nombres;
            btnInscripciones.Parent     = pictureBox1;
            btnAlbum.Parent             = pictureBox1;
            btnResultados.Parent        = pictureBox1;
            btnCerrar.Parent            = pictureBox1;
        }

        private void AbrirFormHijo(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnInscripciones_MouseEnter(object sender, EventArgs e)
        {
            btnInscripciones.Image = Properties.Resources.GestorInscri_Hover;
        }

        private void btnInscripciones_MouseLeave(object sender, EventArgs e)
        {
            btnInscripciones.Image = Properties.Resources.Gestor_Inscri;
        }

        private void btnAsesores_MouseEnter(object sender, EventArgs e)
        {
            btnAlbum.Image = Properties.Resources.Gestor_Album_Hover;
        }

        private void btnAsesores_MouseLeave(object sender, EventArgs e)
        {
            btnAlbum.Image = Properties.Resources.Gestor_Album;
        }

        private void btnResultados_MouseEnter(object sender, EventArgs e)
        {
            btnResultados.Image = Properties.Resources.Gestor_Resultado_Hover;
        }

        private void btnResultados_MouseLeave(object sender, EventArgs e)
        {
            btnResultados.Image = Properties.Resources.Gestor_Resultado;
        }

        private void InicioGestor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new GestorInscripciones());
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new GestorAlbumes());
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new GestorResultados());
        }
    }
}

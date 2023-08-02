using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.VistaAdministracion
{
    public partial class InicioAdministracion : Form
    {
        NegocioTablas negTab = new NegocioTablas();
        int bandera = 1;

        public InicioAdministracion()
        {
            InitializeComponent();
        }

        private void LlenarTabla(string transaccion)
        {
            dataGridView1.DataSource = negTab.Tablas(transaccion);
        }

        private void MostrarTabla(int bandera, string titulo, string transaccion)
        {
            this.bandera = bandera;
            lbTitle.Text = titulo;
            LlenarTabla(transaccion);
        }

        private void InicioAdministracion_Load(object sender, EventArgs e)
        {
            btnAdministradores.Parent   = pictureBox1;
            btnAsesores.Parent          = pictureBox1;
            btnEstudiantes.Parent       = pictureBox1;
            MostrarTabla(1, "Administradores", "TablaAdministrador");
        }


        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            btnAdministradores.Image = Properties.Resources.Administrador_Admi_Hover;
        }

        private void btnAdministradores_MouseLeave(object sender, EventArgs e)
        {
            btnAdministradores.Image = Properties.Resources.Administrador_Admi;
        }

        private void btnAsesores_MouseEnter(object sender, EventArgs e)
        {
            btnAsesores.Image = Properties.Resources.Administrador_Gestor_Hover;
        }

        private void btnAsesores_MouseLeave(object sender, EventArgs e)
        {
            btnAsesores.Image = Properties.Resources.Administrador_Gestor;
        }

        private void btnEstudiantes_MouseEnter(object sender, EventArgs e)
        {
            btnEstudiantes.Image = Properties.Resources.Administrador_Estudiante_Hover;
        }

        private void btnEstudiantes_MouseLeave(object sender, EventArgs e)
        {
            btnEstudiantes.Image = Properties.Resources.Administrador_Estudiante;
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            MostrarTabla(1, "Administradores", "TablaAdministrador");
        }

        private void btnAsesores_Click(object sender, EventArgs e)
        {
            MostrarTabla(2, "Asesores", "TablaAsesores");
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            MostrarTabla(3, "Estudiantes", "TablaEstudiantes");
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.Image = Properties.Resources.Administrador_Boton_Agregar_Hover;
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.Image = Properties.Resources.Administrador_Boton_Agregar;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregar = new AgregarUsuario(bandera);
            agregar.ShowDialog();
            switch (bandera)
            {
                case 1:
                    MostrarTabla(1, "Administradores", "TablaAdministrador");
                    break;

                case 2:
                    MostrarTabla(2, "Asesores", "TablaAsesores");
                    break;

                case 3:
                    MostrarTabla(3, "Estudiantes", "TablaEstudiantes");
                    break;
            }
        }
    }
}

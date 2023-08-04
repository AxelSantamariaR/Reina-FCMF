using Capa_Entidad;
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
        NegocioUsuarios negUsu = new NegocioUsuarios();
        int bandera = 1;
        Usuario UsuarioLogeado;

        public InicioAdministracion(Usuario usuario)
        {
            InitializeComponent();
            UsuarioLogeado = usuario;
        }

        private void LlenarTabla(string transaccion)
        {
            dataGridView1.DataSource = negUsu.Tablas(transaccion);
        }

        private void MostrarTabla(int bandera, string titulo, string transaccion)
        {
            this.bandera = bandera;
            lbTitle.Text = titulo;
            LlenarTabla(transaccion);
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

        private void InicioAdministracion_Load(object sender, EventArgs e)
        {
            label1.Text                 = "     Módulo Administrador - Bienvenido " + UsuarioLogeado.Nombres;
            btnAdministradores.Parent   = pictureBox1;
            btnAsesores.Parent          = pictureBox1;
            btnEstudiantes.Parent       = pictureBox1;
            btnCerrar.Parent            = pictureBox1;
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
            if (agregar.ShowDialog() == DialogResult.OK)
            {
                Respuesta respuesta = null;

                switch (bandera)
                {
                    case 1:
                        Usuario administrador = agregar.GetUsuario();
                        respuesta = negUsu.AgregarAdmiOrGestor("AGREGAR_ADMINISTRADOR", administrador);
                        MostrarTabla(1, "Administradores", "TablaAdministrador");
                        break;

                    case 2:
                        Usuario gestor = agregar.GetUsuario();
                        respuesta = negUsu.AgregarAdmiOrGestor("AGREGAR_ASESOR", gestor);
                        MostrarTabla(2, "Asesores", "TablaAsesores");
                        break;

                    case 3:
                        Estudiante estudiante = agregar.GetEstudiante();
                        respuesta = negUsu.AgregarEstudiante("AGREGAR_ESTUDIANTE", estudiante);
                        MostrarTabla(3, "Estudiantes", "TablaEstudiantes");
                        break;
                }
                if (respuesta != null)
                {
                    MostrarMensaje(respuesta.Titulo, respuesta.Mensaje);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 login = new Form1();
            login.ShowDialog();
        }

        private void InicioAdministracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

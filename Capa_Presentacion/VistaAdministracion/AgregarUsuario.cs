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

namespace Capa_Presentacion.VistaAdministracion
{
    public partial class AgregarUsuario : Form
    {
        NegocioUsuarios negUsu = new NegocioUsuarios();
        int bandera;

        public AgregarUsuario(int bandera)
        {
            InitializeComponent();
            this.bandera = bandera;
        }

        private string GenerarNumeroMatricula()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100000);
            return $"Soft2023@{numeroAleatorio:D5}";
        }

        private void Setear(int opc)
        {
            lbTitle.Parent = pictureBox1;
            lbNumeroMatricula.Parent = pictureBox1;
            switch (opc)
            {
                case 1:
                    lbTitle.Text = "Agregar \nAdministrador";
                    break;
                case 2:
                    lbTitle.Text = "Agregar \nGestor";
                    break;
                case 3:
                    lbTitle.Text = "Agregar \nEstudiante";
                    break;
            }
        }

        private bool Verificar()
        {
            return !string.IsNullOrEmpty(txtIdentificacion.Text)
                && !string.IsNullOrEmpty(txtEmail.Text)
                && !string.IsNullOrEmpty(txtNombres.Text)
                && !string.IsNullOrEmpty(txtApellidos.Text)
                && !string.IsNullOrEmpty(txtUsername.Text)
                && !string.IsNullOrEmpty(txtPassword.Text);
        }

        private bool ValidarAtributo(string transaccion, string parametro)
        {
            return negUsu.ValidarAtributo(transaccion, parametro);
        }

        public Usuario GetUsuario()
        {
            Usuario usuario             = new Usuario();
            usuario.Identificacion      = txtIdentificacion.Text;
            usuario.Nombres             = txtNombres.Text;
            usuario.Apellidos           = txtApellidos.Text;
            usuario.Email               = txtEmail.Text;
            usuario.Username            = txtUsername.Text;
            usuario.Password            = txtPassword.Text;
            usuario.PerfilUsuario       = new PerfilUsuario()
            {
                Id = bandera
            };
            return usuario;
        }

        public Estudiante GetEstudiante()
        {
            Estudiante estudiante           = new Estudiante();
            estudiante.Identificacion       = txtIdentificacion.Text;
            estudiante.Nombres              = txtNombres.Text;
            estudiante.Apellidos            = txtApellidos.Text;
            estudiante.Email                = txtEmail.Text;
            estudiante.Username             = txtUsername.Text;
            estudiante.Password             = txtPassword.Text;
            estudiante.PerfilUsuario           = new PerfilUsuario()
            {
                Id = bandera
            };
            estudiante.Matricula            = lbNumeroMatricula.Text;
            return estudiante;
        }

        private bool ValidarAtributoYMostrarMensaje(string transaccion, string parametro, string atributo)
        {
            if (ValidarAtributo(transaccion, parametro))
            {
                MessageBox.Show($"{atributo} ya existe", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            Setear(bandera);
            if (bandera == 3)
            {
                lbNumeroMatricula.Text = "Matricula # \n"+ GenerarNumeroMatricula();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                if (!ValidarAtributoYMostrarMensaje("ValidarIdentifiacion", txtIdentificacion.Text, "Identificación"))
                {
                    if (!ValidarAtributoYMostrarMensaje("ValidarEmail", txtEmail.Text, "Email"))
                    {
                        if (!ValidarAtributoYMostrarMensaje("ValidarUsername", txtUsername.Text, "Username"))
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else { txtUsername.Clear(); }
                    }
                    else { txtEmail.Clear(); }
                }
                else { txtIdentificacion.Clear(); }
            }
            else
            {
                MessageBox.Show("Campos vacíos", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (txtIdentificacion.Text.Length >= 10 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}

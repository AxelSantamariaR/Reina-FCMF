using Capa_Entidad;
using Capa_Negocio;
using Capa_Presentacion.Vista404;
using Capa_Presentacion.VistaAdministracion;
using Capa_Presentacion.VistaEstudiante;
using Capa_Presentacion.VistaGestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Form1 : Form
    {
        NegocioAuthentication neg = new NegocioAuthentication();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            btnEntrar.Image = Properties.Resources.Login_Boton_Hover;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            btnEntrar.Image = Properties.Resources.Login_Boton;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                btnEyes.Image = Properties.Resources.Img_Password_Eyes_Hide;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnEyes.Image = Properties.Resources.Img_Password_Eyes;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void AbrirModulo(Usuario usuario)
        {
            Form formulario;

            switch (usuario.PerfilUsuario.Id)
            {
                case 1:
                    formulario = new InicioAdministracion(usuario);
                    Hide();
                    break;

                case 2:
                    formulario = new InicioGestor(usuario);
                    Hide();
                    break;

                case 3:
                    formulario = new InicioEstudiante();
                    Hide();
                    break;

                default:
                    formulario = new Error404();
                    Hide();
                    break;
            }

            formulario.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUser.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                Usuario usuario = neg.Login(txtUser.Text, txtPassword.Text);
                if (usuario != null)
                {
                    AbrirModulo(usuario);
                }
                else
                {
                    txtUser.Clear();
                    txtPassword.Clear();
                    MessageBox.Show("Credenciales incorrectas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campos vacíos", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}

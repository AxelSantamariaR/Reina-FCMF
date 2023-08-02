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

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            Setear(bandera);
            if (bandera == 3)
            {
                lbNumeroMatricula.Text = "Matricula # \n"+ GenerarNumeroMatricula();
            }
        }
    }
}

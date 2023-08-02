using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Vista404
{
    public partial class Error404 : Form
    {
        public Error404()
        {
            InitializeComponent();
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnHome.Image = Properties.Resources.PageError_Boton_Hover;
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnHome.Image = Properties.Resources.PageError_Boton;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.ShowDialog();
            Hide();
        }
    }
}

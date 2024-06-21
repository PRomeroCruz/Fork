using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadochio
{
    public partial class FormularioPersona : Form
    {
        public FormularioPersona()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormularioPersona_Load(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FormIniciarSesionPersona formIniciarSesion = new FormIniciarSesionPersona();
            formIniciarSesion.Show();
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            this.Close();
            FormRegistrarsePersona formRegistrarse = new FormRegistrarsePersona();
            formRegistrarse.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            FormularioInicial form = new FormularioInicial();
            form.Show();
            this.Close();
        }
    }
}

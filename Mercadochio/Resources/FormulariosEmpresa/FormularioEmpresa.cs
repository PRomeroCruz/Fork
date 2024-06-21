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
    public partial class FormularioEmpresa : Form
    {
        public FormularioEmpresa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrarseEmpresa form = new FormRegistrarseEmpresa();
            form.Show();
            this.Close();
        }

        private void FormularioEmpresa_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            FormIniciarSesionEmpresa form = new FormIniciarSesionEmpresa();
            form.Show();
            this.Close();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            FormularioInicial form = new FormularioInicial();
            form.Show();
            this.Close();
        }
    }
}

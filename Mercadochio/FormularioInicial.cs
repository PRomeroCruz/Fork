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
    public partial class FormularioInicial : Form
    {
        FormularioInicial formularioInicial;
        FormularioEmpresa formularioEmpresa = new FormularioEmpresa();
        FormularioPersona formularioPersona = new FormularioPersona();
        public FormularioInicial()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            formularioInicial = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelEslogan_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEmpresa_Click_1(object sender, EventArgs e)
        {
            formularioEmpresa.Show();
            formularioInicial.Hide();
        }

        private void buttonPersona_Click(object sender, EventArgs e)
        {
            formularioPersona.Show();
            formularioInicial.Hide();
        }
    }
}

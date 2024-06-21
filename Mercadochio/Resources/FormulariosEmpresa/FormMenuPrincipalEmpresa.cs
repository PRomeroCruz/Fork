using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadochio.Resources.FormulariosEmpresa
{
    public partial class FormMenuPrincipalEmpresa : Form
    {
        bool mostarMenu = false;
        string correoEmpresa;
        public FormMenuPrincipalEmpresa(string correoEmpresa)
        {
            InitializeComponent();
            this.correoEmpresa = correoEmpresa;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonActualizarOferta_Click(object sender, EventArgs e)
        {
            if (this.panelContenedorMenu.Controls.Count > 0)
                this.panelContenedorMenu.Controls.RemoveAt(0);
            FormActualizarOfertaOchios formularioActualizarOferta = new FormActualizarOfertaOchios(correoEmpresa);
            formularioActualizarOferta.TopLevel = false;
            formularioActualizarOferta.FormBorderStyle = FormBorderStyle.None;
            formularioActualizarOferta.Dock = DockStyle.Fill;
            this.panelContenedorMenu.Controls.Add(formularioActualizarOferta);
            this.panelContenedorMenu.Tag = formularioActualizarOferta;
            formularioActualizarOferta.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (mostarMenu) {
                buttoCuenta.Visible = false;
                buttonActualizarOferta.Visible = false;
                buttonReseniasEmpresa.Visible = false;
                buttonSolicitudesPedidos.Visible = false;
            } else
            {
                buttoCuenta.Visible = true;
                buttonActualizarOferta.Visible = true;
                buttonReseniasEmpresa.Visible = true;
                buttonSolicitudesPedidos.Visible = true;
            }
            mostarMenu = !mostarMenu;
        }

        private void buttoCuenta_Click(object sender, EventArgs e)
        {
            if (this.panelContenedorMenu.Controls.Count > 0)
                this.panelContenedorMenu.Controls.RemoveAt(0);
            FormCuentaEmpresa formulario = new FormCuentaEmpresa(correoEmpresa);
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.panelContenedorMenu.Controls.Add(formulario);
            this.panelContenedorMenu.Tag = formulario;
            formulario.Show();
        }

        private void buttonSolicitudesPedidos_Click(object sender, EventArgs e)
        {
            if (this.panelContenedorMenu.Controls.Count > 0)
                this.panelContenedorMenu.Controls.RemoveAt(0);
            FormSolicitudesPedido formularioActualizarOferta = new FormSolicitudesPedido(correoEmpresa);
            formularioActualizarOferta.TopLevel = false;
            formularioActualizarOferta.FormBorderStyle = FormBorderStyle.None;
            formularioActualizarOferta.Dock = DockStyle.Fill;
            this.panelContenedorMenu.Controls.Add(formularioActualizarOferta);
            this.panelContenedorMenu.Tag = formularioActualizarOferta;
            formularioActualizarOferta.Show();
        }

        private void buttonReseniasEmpresa_Click(object sender, EventArgs e)
        {
            if (this.panelContenedorMenu.Controls.Count > 0)
                this.panelContenedorMenu.Controls.RemoveAt(0);
            FormReseniasDeEmpresa formularioActualizarOferta = new FormReseniasDeEmpresa(correoEmpresa);
            formularioActualizarOferta.TopLevel = false;
            formularioActualizarOferta.FormBorderStyle = FormBorderStyle.None;
            formularioActualizarOferta.Dock = DockStyle.Fill;
            this.panelContenedorMenu.Controls.Add(formularioActualizarOferta);
            this.panelContenedorMenu.Tag = formularioActualizarOferta;
            formularioActualizarOferta.Show();
        }
    }
}

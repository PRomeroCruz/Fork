using Mercadochio.Resources.FomulariosPersona;
using Mercadochio.Resources.FormulariosEmpresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadochio
{
    public partial class FormMenuPrincipalPersona : Form
    {
        private Boolean menuAbierto = false;
        private string correoPersona;
        string cadenaConexion = "Data Source=.;Initial Catalog=InterfacesMercaochio;Integrated Security=True;TrustServerCertificate=True";

        public FormMenuPrincipalPersona(string correoPersona)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.correoPersona = correoPersona;
            cargarNombrePersona();
        }

        private void FormMenuPrincipalPersona_Load(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (menuAbierto)
            {
                buttoCuenta.Visible = false;
                buttonComprarOchios.Visible = false;
                buttonResenias.Visible = false;
                buttonVerMisPedidos.Visible = false;
            }
            else
            {
                buttoCuenta.Visible = true;
                buttonComprarOchios.Visible = true;
                buttonResenias.Visible = true;
                buttonVerMisPedidos.Visible = true;
            }
            menuAbierto = !menuAbierto;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttoCuenta_Click(object sender, EventArgs e)
        {
            if (this.panelContenedorMenuPersona.Controls.Count > 0)
                this.panelContenedorMenuPersona.Controls.RemoveAt(0);
            FormCuentaPersona formulario = new FormCuentaPersona(correoPersona);
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.panelContenedorMenuPersona.Controls.Add(formulario);
            this.panelContenedorMenuPersona.Tag = formulario;
            formulario.Show();
        }
        private void cargarNombrePersona()
        {
            string consultaSQL = "select nombre from Persona where CorreoElectronico = @Correo";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                {
                    cmd.Parameters.AddWithValue("@Correo", correoPersona);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString();

                            labelNombre.Text = nombre;
                        }
                    }
                }
                connection.Close();
            }
        }

        private void buttonComprarOchios_Click(object sender, EventArgs e)
        {
            if (this.panelContenedorMenuPersona.Controls.Count > 0)
                this.panelContenedorMenuPersona.Controls.RemoveAt(0);
            FormComprarOchios formulario = new FormComprarOchios(correoPersona);
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.panelContenedorMenuPersona.Controls.Add(formulario);
            this.panelContenedorMenuPersona.Tag = formulario;
            formulario.Show();
        }

        private void buttonVerMisPedidos_Click(object sender, EventArgs e)
        {
            if (this.panelContenedorMenuPersona.Controls.Count > 0)
                this.panelContenedorMenuPersona.Controls.RemoveAt(0);
            FormVerPedidosSinValorar formulario = new FormVerPedidosSinValorar(correoPersona);
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.panelContenedorMenuPersona.Controls.Add(formulario);
            this.panelContenedorMenuPersona.Tag = formulario;
            formulario.Show();
        }

        private void buttonResenias_Click(object sender, EventArgs e)
        {
            if (this.panelContenedorMenuPersona.Controls.Count > 0)
                this.panelContenedorMenuPersona.Controls.RemoveAt(0);
            FormVerMisValoraciones formulario = new FormVerMisValoraciones(correoPersona);
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            this.panelContenedorMenuPersona.Controls.Add(formulario);
            this.panelContenedorMenuPersona.Tag = formulario;
            formulario.Show();
        }
    }
}

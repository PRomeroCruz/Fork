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
    public partial class FormIniciarSesionEmpresa : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=InterfacesMercaochio;Integrated Security=True;");
        public FormIniciarSesionEmpresa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void buttonInciarSesionEmpresa_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consultaComprobarCorreo = "SELECT COUNT(*) FROM Empresa WHERE CorreoElectronico = @CorreoUsuario and Contraseña = @Contrasenia and CodigoSecreto = @CodigoSecreto";

            using (SqlCommand commandComprobarCorreo = new SqlCommand(consultaComprobarCorreo, conexion))
            {
                commandComprobarCorreo.Parameters.AddWithValue("@CorreoUsuario", textBoxCorreoEmpresa.Text.ToString());
                commandComprobarCorreo.Parameters.AddWithValue("@Contrasenia", textBoxContraseniaEmpresa.Text.ToString());
                commandComprobarCorreo.Parameters.AddWithValue("@CodigoSecreto", textBoxCodigoSecretoEmpresa.Text.ToString());

                int count = (int)commandComprobarCorreo.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Inicio de sesion correcto", "Inicio sesion correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMenuPrincipalEmpresa formulario = new FormMenuPrincipalEmpresa(textBoxCorreoEmpresa.Text);
                    formulario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El correo o las contraseñas son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conexion.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormularioEmpresa formulario = new FormularioEmpresa();
            formulario.Show();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormIniciarSesionEmpresa_Load(object sender, EventArgs e)
        {
            textBoxContraseniaEmpresa.PasswordChar = '*';
            textBoxCodigoSecretoEmpresa.PasswordChar = '*';
        }
    }
}

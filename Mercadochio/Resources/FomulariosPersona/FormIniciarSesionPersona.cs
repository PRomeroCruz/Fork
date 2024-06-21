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
    public partial class FormIniciarSesionPersona : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=InterfacesMercaochio;Integrated Security=True;");
        public FormIniciarSesionPersona()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string consulta = "SELECT COUNT(*) FROM Persona WHERE CorreoElectronico = @CorreoUsuario AND Contraseña = @ContraseñaUsuario;";

            using (SqlCommand command = new SqlCommand(consulta, conexion))
            {
                command.Parameters.AddWithValue("@CorreoUsuario", textBoxCorreoPersona.Text.ToString());
                command.Parameters.AddWithValue("@ContraseñaUsuario", textBoxContraseniaPersona.Text.ToString());

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Has iniciado correctamente", "Registro correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMenuPrincipalPersona formulario = new FormMenuPrincipalPersona(textBoxCorreoPersona.Text);
                    formulario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Correo electrónico o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conexion.Close();
        }
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormIniciarSesion_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormularioPersona formulario = new FormularioPersona();
            formulario.Show();
        }

        private void FormIniciarSesionPersona_Load(object sender, EventArgs e)
        {
            textBoxContraseniaPersona.PasswordChar = '*';
        }
    }
}

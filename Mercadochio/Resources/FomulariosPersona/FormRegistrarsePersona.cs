using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadochio
{
    public partial class FormRegistrarsePersona : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=InterfacesMercaochio;Integrated Security=True;");
        public FormRegistrarsePersona()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormRegistrarsePersona_Load(object sender, EventArgs e)
        {
            textBoxContraseniaPersona.PasswordChar = '*';
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBoxCorreoPersona.Text) || string.IsNullOrEmpty(textBoxContraseniaPersona.Text) || string.IsNullOrEmpty(textBoxNombrePersona.Text) || string.IsNullOrEmpty(textBoxLocalizacionPersona.Text))
            {
                MessageBox.Show("Debes rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxContraseniaPersona.Text.Any(char.IsLetter))
                {
                    MessageBox.Show("La contraseña debe ser numerica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    Regex regex = new Regex("^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$");

                    if(!regex.IsMatch(textBoxCorreoPersona.Text))
                    {
                        MessageBox.Show("Correo electronico invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        conexion.Open();
                        string consultaComprobarCorreo = "SELECT COUNT(*) FROM Persona WHERE CorreoElectronico = @CorreoUsuario";

                        using (SqlCommand commandComprobarCorreo = new SqlCommand(consultaComprobarCorreo, conexion))
                        {
                            commandComprobarCorreo.Parameters.AddWithValue("@CorreoUsuario", textBoxCorreoPersona.Text.ToString());

                            int count = (int)commandComprobarCorreo.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("Ya hay un usuario con este correo electónico, por favor, use otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string consultaInsertarPersona = "insert into Persona values (@nombre, @correoUsuario, @contrasenia, @domicilio)";

                                using (SqlCommand commandInsertarPersona = new SqlCommand(consultaInsertarPersona, conexion))
                                {
                                    commandInsertarPersona.Parameters.AddWithValue("@nombre", textBoxNombrePersona.Text.ToString());
                                    commandInsertarPersona.Parameters.AddWithValue("@correoUsuario", textBoxCorreoPersona.Text.ToString());
                                    commandInsertarPersona.Parameters.AddWithValue("@contrasenia", textBoxContraseniaPersona.Text.ToString());
                                    commandInsertarPersona.Parameters.AddWithValue("@domicilio", textBoxLocalizacionPersona.Text.ToString());

                                    int resultado = commandInsertarPersona.ExecuteNonQuery();

                                    if (resultado == 1)
                                    {
                                        MessageBox.Show("Te has registrado correctamente", "Registro correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                        conexion.Close();
                    }
                }
            }      
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormularioPersona formulario = new FormularioPersona();
            formulario.Show();
        }
    }
}

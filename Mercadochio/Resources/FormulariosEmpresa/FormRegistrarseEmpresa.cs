using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Mercadochio
{
    public partial class FormRegistrarseEmpresa : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=InterfacesMercaochio;Integrated Security=True;");
        public FormRegistrarseEmpresa()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormRegistrarseEmpresa_Load(object sender, EventArgs e)
        {
            textBoxContrasenia.PasswordChar = '*';
            textBoxCodigoSecretoEmpresa.PasswordChar = '*';
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            if (textBoxContrasenia.Text.Any(char.IsLetter) || textBoxCodigoSecretoEmpresa.Text.Any(char.IsLetter))
            {
                MessageBox.Show("La contraseña y el codigo secreto deben ser numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(textBoxNombreempresa.Text) || string.IsNullOrEmpty(textBoxCorreoEmpresa.Text) || string.IsNullOrEmpty(textBoxContrasenia.Text) || string.IsNullOrEmpty(textBoxCodigoSecretoEmpresa.Text) || string.IsNullOrEmpty(textBoxHorarioEmpresa.Text) || string.IsNullOrEmpty(textBoxLocalizacionEmpresa.Text))
                {
                    MessageBox.Show("Debes rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Regex regexCorreo = new Regex("^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$");

                    if (!regexCorreo.IsMatch(textBoxCorreoEmpresa.Text))
                    {
                        MessageBox.Show("Correo electronico invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string nombre = textBoxNombreempresa.Text;
                        string correo = textBoxCorreoEmpresa.Text;
                        string contrasenia = textBoxContrasenia.Text;
                        string codigoSecreto = textBoxCodigoSecretoEmpresa.Text;
                        string localizacion = textBoxLocalizacionEmpresa.Text;

                        Regex regexHorario = new Regex("^([01]\\d|2[0-3]):([0-5]\\d)-([01]\\d|2[0-3]):([0-5]\\d)$");

                        if (!regexHorario.IsMatch(textBoxHorarioEmpresa.Text))
                        {
                            MessageBox.Show("El campo de horario debe tener dormato HH:MM-HH:MM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string[] partes = textBoxHorarioEmpresa.Text.Split('-');
                            conexion.Open();

                            string consultaComprobarCorreo = "SELECT COUNT(*) FROM Empresa WHERE CorreoElectronico = @CorreoUsuario";

                            using (SqlCommand commandComprobarCorreo = new SqlCommand(consultaComprobarCorreo, conexion))
                            {
                                commandComprobarCorreo.Parameters.AddWithValue("@CorreoUsuario", correo);

                                int count = (int)commandComprobarCorreo.ExecuteScalar();

                                if (count > 0)
                                {
                                    MessageBox.Show("Ya hay una Empresa con este correo electónico, por favor, use otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string consultaInsertarEmpresa = "INSERT INTO Empresa (Nombre, CorreoElectronico, Contraseña, CodigoSecreto, HoraApertura, HoraCierre, Domicilio) VALUES (@nombre, @correoEmpresa, @contrasenia, @codigoSecreto, @horaApertura, @horacierre, @domicilio)";


                                    using (SqlCommand commandInsertarPersona = new SqlCommand(consultaInsertarEmpresa, conexion))
                                    {
                                        commandInsertarPersona.Parameters.AddWithValue("@nombre", nombre);
                                        commandInsertarPersona.Parameters.AddWithValue("@correoEmpresa", correo);
                                        commandInsertarPersona.Parameters.AddWithValue("@contrasenia", contrasenia);
                                        commandInsertarPersona.Parameters.AddWithValue("@codigoSecreto", codigoSecreto);
                                        commandInsertarPersona.Parameters.AddWithValue("@horaApertura", partes[0]);
                                        commandInsertarPersona.Parameters.AddWithValue("@horacierre", partes[1]);
                                        commandInsertarPersona.Parameters.AddWithValue("@domicilio", localizacion);

                                        int resultado = commandInsertarPersona.ExecuteNonQuery();

                                        if (resultado == 1)
                                        {
                                            MessageBox.Show("Has registrado correctamente la empresa", "Registro correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.Close();
                                            FormularioEmpresa formulario = new FormularioEmpresa();
                                            formulario.Show();
                                        }
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
            FormularioEmpresa formulario = new FormularioEmpresa();
            formulario.Show();
        }

        private void textBoxContraseniaEmpresa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

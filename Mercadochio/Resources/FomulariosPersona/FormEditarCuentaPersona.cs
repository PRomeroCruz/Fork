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

namespace Mercadochio.Resources.FomulariosPersona
{
    public partial class FormEditarCuentaPersona : Form
    {
        string correoPersona;
        string cadenaConexion = "Data Source=.;Initial Catalog=InterfacesMercaochio;Integrated Security=True;TrustServerCertificate=True";
        public FormEditarCuentaPersona(string correoPersona)
        {
            InitializeComponent();
            this.correoPersona = correoPersona;
            cargarDatosPersona();
        }
        private void cargarDatosPersona()
        {
            string consultaSQL = "SELECT * FROM Persona WHERE CorreoElectronico = @Correo";

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
                            string domicilio = reader["Domicilio"].ToString();

                            textBoxNombre.Text = nombre;
                            textBoxDomicilio.Text = domicilio;
                        }
                    }
                }
                connection.Close();
            }
        }

        private void buttonAceptarEdicion_Click(object sender, EventArgs e)
        {
            string consultaSQL = "update Persona set Nombre = @Nombre, Domicilio = @domicilio;";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", textBoxNombre.Text);
                    cmd.Parameters.AddWithValue("@domicilio", textBoxDomicilio.Text);
                    
                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha Editado correctamete", "Edicion correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                connection.Close();
            }
        }
    }
}

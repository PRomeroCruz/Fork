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

namespace Mercadochio.Resources.FormulariosEmpresa
{
    public partial class FormEditarDatosEmpresa : Form
    {
        string correoEmpresa;
        string cadenaConexion = "Data Source=.;Initial Catalog=InterfacesMercaochio;Integrated Security=True;TrustServerCertificate=True";
        public FormEditarDatosEmpresa(string correoEmpresa)
        {
            InitializeComponent();
            this.correoEmpresa = correoEmpresa;
            cargarDatosEmpresa();
        }

        private void textBoxNombreempresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHorarioEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptarEditar_Click(object sender, EventArgs e)
        {
            string consultaSQL = "update Empresa set Nombre = @Nombre, HoraApertura = @HoraApertura, HoraCierre = @HoraCierre, Domicilio = @Domicilio where CorreoElectronico = @Correo";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                {
                    cmd.Parameters.AddWithValue("@Correo", correoEmpresa);
                    cmd.Parameters.AddWithValue("@Nombre", textBoxNombreempresa.Text);
                    cmd.Parameters.AddWithValue("@HoraApertura", textBoxHorarioAperturaEmpresa.Text);
                    cmd.Parameters.AddWithValue("@HoraCierre", textBoxHorarioCierre.Text);
                    cmd.Parameters.AddWithValue("@Domicilio", textBoxLocalizacionEmpresa.Text);
                    

                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha Editado correctamete la Empresa", "Edicion correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                connection.Close();
            }
        }

        private void cargarDatosEmpresa()
        {
            string consultaSQL = "SELECT * FROM Empresa WHERE CorreoElectronico = @Correo";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                {
                    cmd.Parameters.AddWithValue("@Correo", correoEmpresa);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString();
                            string horaApertura = reader["HoraApertura"].ToString();
                            string horaCierre = reader["HoraCierre"].ToString();
                            string domicilio = reader["Domicilio"].ToString();

                            textBoxNombreempresa.Text = nombre;
                            textBoxHorarioAperturaEmpresa.Text = horaApertura;
                            textBoxHorarioCierre.Text = horaCierre;
                            textBoxLocalizacionEmpresa.Text = domicilio;
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}

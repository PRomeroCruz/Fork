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
    public partial class FormCuentaEmpresa : Form
    {
        string correoEmpresa;
        string cadenaConexion = "Data Source=.;Initial Catalog=InterfacesMercaochio;Integrated Security=True;TrustServerCertificate=True";
        public FormCuentaEmpresa(string correoEmpresa)
        {
            InitializeComponent();
            this.correoEmpresa = correoEmpresa;
            cargarDatosEmpresa();
        }

        private void FormCuentaEmpresa_Load(object sender, EventArgs e)
        {

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
                            string descripcion = reader["Descripcion"].ToString();
                            
                            labelNombreEmpresa.Text = nombre;
                            labelCorreoEmpresa.Text = correoEmpresa;
                            labelHoraApertura.Text = "De " + horaApertura + " a " + horaCierre;
                            labelDomicilio.Text = domicilio;
                            if(!string.IsNullOrEmpty(descripcion))
                            {
                                richTextBoxDescripcion.Text = descripcion;
                            }
                        }
                    }
                }
                connection.Close();
            }
        }

        private void buttonAñadirDescripcion_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(richTextBoxDescripcion.Text))
            {
                MessageBox.Show("Añade una descripcion valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string consultaSQL = "update Empresa set Descripcion = @Descripcion where CorreoElectronico = @Correo";

                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                    {
                        cmd.Parameters.AddWithValue("@Correo", correoEmpresa);
                        cmd.Parameters.AddWithValue("@Descripcion", richTextBoxDescripcion.Text);

                        int resultado = cmd.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("Se ha añadido la descripcion", "Descripcion añadida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarDatosEmpresa();
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            FormEditarDatosEmpresa formulario = new FormEditarDatosEmpresa(correoEmpresa);
            formulario.ShowDialog();
        }
    }
}

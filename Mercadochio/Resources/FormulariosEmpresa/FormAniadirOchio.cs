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
    public partial class FormAniadirOchio : Form
    {
        string correoEmpresa;
        public FormAniadirOchio(string correoEmpresa)
        {
            InitializeComponent();
            this.correoEmpresa = correoEmpresa;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAniadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxAlergenos.Text) || string.IsNullOrEmpty(textBoxTamanio.Text) || string.IsNullOrEmpty(textBoxPrecio.Text))
            {
                MessageBox.Show("Rellena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string cadenaConexion = "Data Source=.;Initial Catalog=InterfacesMercaochio;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    string consultaSQL = "INSERT INTO Ochio (nombre, alergenos, tamano, precio, EmpresaCorreo) VALUES (@Nombre, @Alergenos, @Tamano, @Precio, @EmpresaCorreo)";

                    using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                        cmd.Parameters.AddWithValue("@Alergenos", textBoxAlergenos.Text);
                        cmd.Parameters.AddWithValue("@Tamano", textBoxTamanio.Text);
                        cmd.Parameters.AddWithValue("@Precio", textBoxPrecio.Text);
                        cmd.Parameters.AddWithValue("@EmpresaCorreo", correoEmpresa);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se ha añadido el ochio", "Ochio añadido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connection.Close();
                    this.Close();
                }
            }
        }
    }
}

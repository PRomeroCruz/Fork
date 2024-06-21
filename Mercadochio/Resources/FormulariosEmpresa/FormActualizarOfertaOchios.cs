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
    public partial class FormActualizarOfertaOchios : Form
    {
        string correoEmpresa;
        string cadenaConexion = "Data Source=.;Initial Catalog=InterfacesMercaochio;Integrated Security=True;TrustServerCertificate=True";
        public FormActualizarOfertaOchios(string correoEmpresa)
        {
            InitializeComponent();
            this.correoEmpresa = correoEmpresa;
            CargarDatos();
        }



        private void CargarDatos()
        {
            Console.Write(correoEmpresa);

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string consultaSQL = "SELECT id, nombre, alergenos, tamano, precio FROM Ochio WHERE EmpresaCorreo = @Correo";

                using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                {
                    cmd.Parameters.AddWithValue("@Correo", correoEmpresa);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        System.Data.DataTable dataTable = new System.Data.DataTable();
                        dataTable.Load(reader);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void buttonEliminarOchio_Click(object sender, EventArgs e)
        {
            // Verifico si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string valorClavePrimaria = selectedRow.Cells[0].Value.ToString();

                dataGridView1.Rows.Remove(selectedRow);

                // Eliminar la fila de la base de datos
                EliminarFilaBaseDatos(valorClavePrimaria);
            }
            else
            {
                MessageBox.Show("Seleccione una fila antes de intentar eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void EliminarFilaBaseDatos(string valorClavePrimaria)
        {
            string cadenaConexion = "Data Source=.;Initial Catalog=InterfacesMercaochio;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                string consultaSQL = "DELETE FROM Ochio WHERE ID = @ValorClavePrimaria";

                using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                {
                    cmd.Parameters.AddWithValue("@ValorClavePrimaria", valorClavePrimaria);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se ha borrado el producto satisfactoriamente.", "Borrado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                connection.Close();
            }
        }

        private void buttonAgregarOchio_Click(object sender, EventArgs e)
        {
            FormAniadirOchio formulario = new FormAniadirOchio(correoEmpresa);
            formulario.ShowDialog();
        }

        private void buttonRecargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void FormActualizarOfertaOchios_Load(object sender, EventArgs e)
        {

        }
    }
}

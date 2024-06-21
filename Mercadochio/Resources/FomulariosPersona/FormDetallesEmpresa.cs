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
    public partial class FormDetallesEmpresa : Form
    {
        private string correoEmpresa;
        private string correoPersona;
        string cadenaConexion = "Data Source=.;Initial Catalog=InterfacesMercaochio;Integrated Security=True;TrustServerCertificate=True";
        public FormDetallesEmpresa(string correoEmpresa, string correoPersona)
        {
            InitializeComponent();
            this.correoEmpresa = correoEmpresa;
            this.correoPersona = correoPersona;
            cargarDatosEmpresa();
        }

        private void cargarDatosEmpresa()
        {
            string consultaSQLDatosEmpresa = "SELECT * FROM Empresa WHERE CorreoElectronico = @Correo";
            string consultaSQLDatosOchios = "SELECT * FROM Ochio WHERE EmpresaCorreo = @Correo";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                // Primero cargo los datos de la empresa y luego el datagrid con los datos de los ochios de la empresa
                using (SqlCommand cmd = new SqlCommand(consultaSQLDatosEmpresa, connection))
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
                            if (!string.IsNullOrEmpty(descripcion))
                            {
                                richTextBoxDescripcionEmpresa.Text = descripcion;
                            }
                        }
                    }
                }

                // Obtengo los datos de los ochios y los pongo en el datagrid
                using (SqlCommand cmd = new SqlCommand(consultaSQLDatosOchios, connection))
                {
                    cmd.Parameters.AddWithValue("@Correo", correoEmpresa);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewOchiosDisponibles.DataSource = dataTable;
                    }

                }
                connection.Close();
            }
        }

        private void dataGridViewOchiosDisponibles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFilaSeleccionada = e.RowIndex;

            if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < dataGridViewOchiosDisponibles.Rows.Count)
            {
                if (dataGridViewOchiosDisponibles.Rows[indiceFilaSeleccionada].Cells["ID"].Value != null)
                {
                    string idOchio = dataGridViewOchiosDisponibles.Rows[indiceFilaSeleccionada].Cells["ID"].Value.ToString();
                    string nombreOchio = dataGridViewOchiosDisponibles.Rows[indiceFilaSeleccionada].Cells["Nombre"].Value.ToString();
                    string nombreEmpresa = labelNombreEmpresa.Text.ToString();
                    string precio = dataGridViewOchiosDisponibles.Rows[indiceFilaSeleccionada].Cells["Precio"].Value.ToString();

                    FormConfirmarPedido formDetalles = new FormConfirmarPedido(idOchio, nombreOchio, nombreEmpresa, precio, correoPersona);

                    formDetalles.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecciona un campo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

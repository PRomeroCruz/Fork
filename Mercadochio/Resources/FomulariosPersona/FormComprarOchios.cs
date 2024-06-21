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
    public partial class FormComprarOchios : Form
    {
        string cadenaConexion = "Data Source=localhost;Initial Catalog=InterfacesMercaochio;Integrated Security=True;";
        private string correoPersona;
        private string ordenTabla = "order by Nombre";
        public FormComprarOchios(string correoPersona)
        {
            InitializeComponent();
            this.correoPersona = correoPersona;
            ObtenerDatos();
        }


        private void ObtenerDatos()
        {
            string consultaSQL = "SELECT Nombre, CorreoElectronico, HoraApertura, HoraCierre, Domicilio, Valoracion, Descripcion FROM Empresa " + ordenTabla;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewEmpresas.DataSource = dataTable;
                    }
                }

                connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    ordenTabla = "order by Nombre";
                    break;
                case 1:
                    ordenTabla = "order by Valoracion";
                    break;
                case 2:
                    ordenTabla = "order by CorreoElectronico";
                    break;
            }
            ObtenerDatos();
        }

        private void dataGridViewEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceFilaSeleccionada = e.RowIndex;

            if (indiceFilaSeleccionada >= 0 && indiceFilaSeleccionada < dataGridViewEmpresas.Rows.Count)
            {
                if (dataGridViewEmpresas.Rows[indiceFilaSeleccionada].Cells["CorreoElectronico"].Value != null)
                {
                    string correoEmpresa = dataGridViewEmpresas.Rows[indiceFilaSeleccionada].Cells["CorreoElectronico"].Value.ToString();

                    FormDetallesEmpresa formDetalles = new FormDetallesEmpresa(correoEmpresa, correoPersona);

                    formDetalles.ShowDialog();
                } else MessageBox.Show("Debes seleccionar una fila valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}

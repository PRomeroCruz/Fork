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
    public partial class FormReseniasDeEmpresa : Form
    {
        private string correoEmpresa;
        private string cadenaConexion = "Data Source=localhost;Initial Catalog=InterfacesMercaochio;Integrated Security=True;";
        public FormReseniasDeEmpresa(string correoEmpresa)
        {
            InitializeComponent();
            this.correoEmpresa = correoEmpresa;
            cargarDatos();
        }

        private void cargarDatos() {
            string consultaSQL = "select Pedido.Valoracion, Ochio.Nombre, Ochio.Precio, Pedido.CorreoPersona from Pedido join Ochio on Pedido.OchioID = Ochio.ID and Ochio.EmpresaCorreo = @Correo and Pedido.Valoracion != -1";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                {
                    cmd.Parameters.AddWithValue("@Correo", correoEmpresa);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewValoracionesEmpresa.DataSource = dataTable;
                    }
                }
                connection.Close();
            }
        }

    }
}

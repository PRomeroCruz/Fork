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
    public partial class FormVerMisValoraciones : Form
    {
        private string correoPersona;
        string cadenaConexion = "Data Source=localhost;Initial Catalog=InterfacesMercaochio;Integrated Security=True;";
        public FormVerMisValoraciones(string correoPersona)
        {
            InitializeComponent();
            this.correoPersona = correoPersona;
            cargarDatosEnDatagrid();
        }


        private void cargarDatosEnDatagrid()
        {
            string consultaSQL = "select Pedido.Valoracion, Ochio.Nombre from Pedido join Ochio on Pedido.OchioID = Ochio.ID and Pedido.CorreoPersona = @Correo and Pedido.Valoracion != -1";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                {
                    cmd.Parameters.AddWithValue("@Correo", correoPersona);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewValoracionesPersona.DataSource = dataTable;
                    }
                }
                connection.Close();
            }
        }
    }
}
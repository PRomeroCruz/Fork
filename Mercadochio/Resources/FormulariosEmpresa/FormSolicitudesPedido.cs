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
    public partial class FormSolicitudesPedido : Form
    {
        private string correoEmpresa;
        string cadenaConexion = "Data Source=localhost;Initial Catalog=InterfacesMercaochio;Integrated Security=True;";
        public FormSolicitudesPedido(string correoEmpresa)
        {
            InitializeComponent();
            this.correoEmpresa = correoEmpresa;
            cargarDatosDatagrid();
        }


        private void cargarDatosDatagrid()
        {
            string consultaObtenerPedidos = "select Pedido.PedidoID, Pedido.Recibido, Ochio.Nombre, Ochio.Precio, Pedido.CorreoPersona from Pedido join Ochio on Pedido.OchioID = Ochio.ID where Ochio.EmpresaCorreo = @CorreoEmpresa and Pedido.Recibido = 0";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(consultaObtenerPedidos, connection))
                {
                    cmd.Parameters.AddWithValue("@CorreoEmpresa", correoEmpresa);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }

                connection.Close();
            }
        }

        private void buttonMarcarComoRecibido_Click(object sender, EventArgs e)
        {
            //Verifico si hay una fila seleciconada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Obtengo la fila
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                //Compruebo si selecciona una fila vacia
                if(filaSeleccionada.Cells["PedidoID"].Value == null)
                {
                    MessageBox.Show("Debes seleccionar una fila valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    string pedidoIdObtenido = filaSeleccionada.Cells["PedidoID"].Value.ToString();


                    // Realizo el update que pone recibido en true
                    string consultaSQL = "update Pedido set Recibido = 1 where PedidoId = @IdObtenido";

                    using (SqlConnection connection = new SqlConnection(cadenaConexion))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                        {
                            cmd.Parameters.AddWithValue("IdObtenido", pedidoIdObtenido);

                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Se ha marcado como recibido el pedido, el cliente puede ir a recogerlo", "Recibido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cargarDatosDatagrid();
                            }
                            else MessageBox.Show("Ha ocurrido un error al cambiar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

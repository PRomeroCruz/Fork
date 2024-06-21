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
    public partial class FormVerPedidosSinValorar : Form
    {
        string cadenaConexion = "Data Source=localhost;Initial Catalog=InterfacesMercaochio;Integrated Security=True;";
        string correoPersona;
        public FormVerPedidosSinValorar(string correoPersona)
        {
            InitializeComponent();
            this.correoPersona = correoPersona;
            cargarDatosDatagrid();
        }

        private void cargarDatosDatagrid()
        {
            string consultaSQL = "select Pedido.PedidoID, Ochio.Nombre, Ochio.Precio, Ochio.EmpresaCorreo from Pedido join Ochio on Pedido.OchioID = Ochio.ID where Pedido.CorreoPersona = @CorreoPersona and Pedido.Recibido = 1 and Pedido.Valoracion = -1;";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(consultaSQL, connection))
                {
                    cmd.Parameters.AddWithValue("@CorreoPersona", correoPersona);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewPedidos.DataSource = dataTable;
                    }
                }

                connection.Close();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelNumeroValoracion.Text = trackBarValoracion.Value.ToString();
        }

        private void buttonAniadirValoracion_Click(object sender, EventArgs e)
        {
            //Verifico si hay una fila seleciconada
            if (dataGridViewPedidos.SelectedRows.Count > 0)
            {
                //Obtengo la fila
                DataGridViewRow filaSeleccionada = dataGridViewPedidos.SelectedRows[0];

                //Compruebo si selecciona una fila vacia
                if (filaSeleccionada.Cells["PedidoID"].Value == null)
                {
                    MessageBox.Show("Debes seleccionar una fila valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string pedidoIdObtenido = filaSeleccionada.Cells["PedidoID"].Value.ToString();
                    string correoEmpresaObtenido = filaSeleccionada.Cells["EmpresaCorreo"].Value.ToString();

                    // Realizo el update que pone recibido en true
                    string consultaAniadirValoracion = "update Pedido set Valoracion = @ValoracionElegida where PedidoID = @IdPedido";
                    // con esta consulta actualizo la valoracion de la empresa y pongo su valor medio de valoraciones
                    string colsultaValoracionMedia = "update Empresa set Valoracion = (select avg(Valoracion) from Pedido join Ochio on Pedido.OchioID = Ochio.ID where Ochio.EmpresaCorreo = @CorreoEmpresa and Pedido.Recibido = 1) where CorreoElectronico = @CorreoElectronico";

                    using (SqlConnection connection = new SqlConnection(cadenaConexion))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand(consultaAniadirValoracion, connection))
                        {
                            cmd.Parameters.AddWithValue("ValoracionElegida", trackBarValoracion.Value.ToString());
                            cmd.Parameters.AddWithValue("IdPedido", pedidoIdObtenido);

                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Se ha añadido la valoracion", "Valoracion Añadida", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                using (SqlCommand cmdActualizarValoracionesMedias = new SqlCommand(colsultaValoracionMedia, connection))
                                {
                                    cmdActualizarValoracionesMedias.Parameters.AddWithValue("CorreoEmpresa", correoEmpresaObtenido);
                                    cmdActualizarValoracionesMedias.Parameters.AddWithValue("CorreoElectronico", correoEmpresaObtenido);
                                    cmdActualizarValoracionesMedias.ExecuteNonQuery();
                                }
                            }
                            else MessageBox.Show("Ha ocurrido un error al añadir la valoracion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            cargarDatosDatagrid();
        }
    }
}

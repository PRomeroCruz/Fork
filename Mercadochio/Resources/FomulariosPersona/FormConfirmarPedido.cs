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
    public partial class FormConfirmarPedido : Form
    {
        private string idOchio;
        private string nombreOchio;
        private string nombreEmpresa;
        private string precio;
        private string correoPersona;
        string cadenaConexion = "Data Source=.;Initial Catalog=InterfacesMercaochio;Integrated Security=True;TrustServerCertificate=True";
        public FormConfirmarPedido(string idOchio, string nombreOchio, string nombreEmpresa, string precio, string correoPersona)
        {
            InitializeComponent();
            this.idOchio = idOchio;
            this.nombreOchio = nombreOchio;
            this.nombreEmpresa = nombreEmpresa;
            this.precio = precio;
            this.correoPersona = correoPersona;

           

            labelNombre.Text = "Pedido de " + nombreOchio + " a " + nombreEmpresa + " por " + precio;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string insercionDePedido = "insert into Pedido (OchioId, CorreoPersona) values (@OchioId, @CorreoPersona);";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insercionDePedido, connection))
                {
                    cmd.Parameters.AddWithValue("@OchioId", idOchio);
                    cmd.Parameters.AddWithValue("@CorreoPersona", correoPersona);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Se ha creado un nuevo pedido", "Pedido creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                        this.Close();
                    }
                }
                connection.Close();
            }
        }
    }
}

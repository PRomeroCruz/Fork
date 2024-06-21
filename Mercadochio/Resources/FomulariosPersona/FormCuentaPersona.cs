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
    public partial class FormCuentaPersona : Form
    {
        string correoPersona;
        string cadenaConexion = "Data Source=localhost;Initial Catalog=InterfacesMercaochio;Integrated Security=True;";
        public FormCuentaPersona(string correoPersona)
        {
            InitializeComponent();
            this.correoPersona = correoPersona;
            cargarDatosPersona();
        }

        private void cargarDatosPersona()
        {
            string consultaSQLObtenerDatosPersona = "SELECT * FROM Persona WHERE CorreoElectronico = @Correo";
            string consultaSQLObtenerValoracionesPersona = "SELECT count(*) FROM Pedido WHERE CorreoPersona = @Correo";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(consultaSQLObtenerDatosPersona, connection))
                {
                    cmd.Parameters.AddWithValue("@Correo", correoPersona);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString();
                            string correo = reader["CorreoElectronico"].ToString();
                            string domicilio = reader["Domicilio"].ToString();

                            labelNombre.Text = "Nombre: " + nombre;
                            labelCorreo.Text = "Correo: " + correo;
                            labelDomicilio.Text = "Domicilio: " + domicilio;
                        }
                    }
                }

                using (SqlCommand cmd = new SqlCommand(consultaSQLObtenerValoracionesPersona, connection))
                {
                    cmd.Parameters.AddWithValue("@Correo", correoPersona);
                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                    labelTotalResenias.Text = "He hecho un total de " + resultado + " pedidos";
                }
                connection.Close();
            }
        }

        private void FormCuentaPersona_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            FormEditarCuentaPersona formulario = new FormEditarCuentaPersona(correoPersona);
            formulario.ShowDialog();
        }
    }
}

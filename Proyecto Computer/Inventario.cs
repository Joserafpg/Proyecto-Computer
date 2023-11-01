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

namespace Proyecto_Computer
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private static SqlConnection Conn = new SqlConnection("Server = DESKTOP-NDDA7LS; database=Computer; Integrated Security=True");
        void CargarComboBox()
        {
            Conn.Open();
            string consulta = "SELECT DISTINCT Departamento FROM productos";
            SqlCommand comando = new SqlCommand(consulta, Conn);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                cDepartamento.Items.Add(lector.GetString(0));
            }

            Conn.Close();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }
    }
}

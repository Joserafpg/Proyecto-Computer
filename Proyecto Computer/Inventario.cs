using Proyecto_Computer.Clases.Clases_Clientes;
using Proyecto_Computer.Clases.Clases_Inventario;
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

        public static SqlConnection Conn = new SqlConnection("Server = DESKTOP-NDDA7LS; database=Computer; Integrated Security=True");

        public DatosgetInventario ProductoActual { get; set; }
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

        void Buscar()
        {
            dataGridView1.DataSource = DatosbaseInventario.BuscarAlumnos(txtbuscar.Text, cDepartamento.Text);
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarComboBox();
            Buscar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void cDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea eliminar el producto actual?", "Esta Seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Conn.Open();

                int estudiantesEliminados = 0;

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    SqlCommand cmd = new SqlCommand("DELETE FROM Productos WHERE Id_Producto = @ID", Conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    estudiantesEliminados++;
                }

                Conn.Close();

                Buscar();

                if (estudiantesEliminados > 0)
                {
                    MessageBox.Show("Producto eliminados", "Producto Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }
    }
}
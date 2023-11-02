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

                else
                {
                    MessageBox.Show("Debes seleccionar un productos para ser eliminado", "Eliminacion cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            AgregarProductos formAgregar = new AgregarProductos();
            formAgregar.EditMode = false;
            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                Buscar();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Obtén los datos de la fila seleccionada
                Int64 id = Convert.ToInt64(row.Cells[0].Value);
                string nombre = row.Cells[1].Value.ToString();
                decimal precioCompra = Convert.ToDecimal(row.Cells[2].Value);
                decimal precio = Convert.ToDecimal(row.Cells[3].Value);
                Int64 cantidad = Convert.ToInt64(row.Cells[4].Value);
                string departamento = row.Cells[5].Value.ToString();
                DateTime fecha = Convert.ToDateTime(row.Cells[6].Value);

                // Abre el formulario para editar el producto
                AgregarProductos formEditar = new AgregarProductos();
                formEditar.EditMode = true; // Estás en modo editar
                formEditar.InitializeData(id, nombre, precioCompra, precio, cantidad, departamento, fecha);
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    // Actualiza el DataGridView después de la edición
                    Buscar();
                }
            }
        }
    }
}
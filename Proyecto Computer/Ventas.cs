using Proyecto_Computer.Clases;
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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        void SumarColumna()
        {
            double Total = 0;

            foreach (DataGridViewRow row in dtgv.Rows)
            {
                Total += Convert.ToDouble(row.Cells["Total"].Value);
            }
            txttotal.Text = Total.ToString();

        }

        SqlConnection conn = new SqlConnection("Data source = DESKTOP-NDDA7LS; Initial Catalog = Computer; Integrated Security = True");
        
        private Productos ObtenerProducto(Int64 idProducto)
        {
            Productos producto = null;

            // Cadena de conexión a la base de datos
            string connectionString = "Data source = DESKTOP-NDDA7LS; Initial Catalog=Computer; Integrated Security=True";

            // Consulta SQL para obtener el producto según su ID
            string query = "SELECT Id_Producto, Nombre, Precio FROM Productos WHERE Id_Producto = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", idProducto);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Obtener los valores del producto desde el lector de datos
                            Int32 id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            decimal precio = reader.GetDecimal(2);

                            // Crear un objeto Producto con los valores obtenidos
                            producto = new Productos
                            {
                                Id = id,
                                Nombre_Producto = nombre,
                                Precio = precio
                            };
                        }
                    }
                }
                conn.Close();
            }

            return producto;

        }

        void VerificarAgregarModificarProducto(Productos producto)
        {
            bool encontrado = false;

            // Recorrer las filas del DataGridView para buscar el producto
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                // Obtener el ID del producto en la fila actual
                Int64 id = Convert.ToInt64(row.Cells["codigos"].Value);

                if (id == producto.Id)
                {
                    // El producto ya está en el DataGridView, modificar la cantidad
                    int cantidadExistente = Convert.ToInt32(row.Cells["cantidad"].Value);
                    int cantidadNueva = cantidadExistente + producto.Cantidad;
                    row.Cells["cantidad"].Value = cantidadNueva;

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                // El producto no está en el DataGridView, agregar una nueva fila
                dtgv.Rows.Add(producto.Id, producto.Nombre_Producto, producto.Precio, producto.Cantidad);
            }
        }

        void Limpiar()
        {
            txtcodigo.Clear();
            txttotal.ResetText();
            dtgv.Rows.Clear();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text))
            {
                MessageBox.Show("Debe colocar el ID del producto");
                return;
            }

            Int64 idProducto = Convert.ToInt64(txtcodigo.Text);

            // Llamar a un método para obtener el producto completo según su ID
            Productos producto = ObtenerProducto(idProducto);

            if (producto != null)
            {
                // Verificar si el producto ya está en el DataGridView y realizar la acción correspondiente
                VerificarAgregarModificarProducto(producto);

                foreach (DataGridViewRow row in dtgv.Rows)
                {
                    // Obtener los valores de las columnas "Columna1" y "Columna2"
                    double valor1 = Convert.ToDouble(row.Cells["precios"].Value);
                    int valor2 = Convert.ToInt32(row.Cells["cantidad"].Value);
                    // Realizar la multiplicación
                    double resultado = valor1 * valor2;

                    // Asignar el resultado a la columna "Resultado" de la fila actual
                    row.Cells["Total"].Value = resultado;
                    SumarColumna();
                }
            }
            else
            {
                // No se encontró un producto con el ID especificado, mostrar un mensaje de error o realizar alguna otra acción apropiada
                MessageBox.Show("No se encontró ningún producto con el ID especificado.");
            }

            txtcodigo.Clear();

        }

        private void dtgv_CurrentCellChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                // Obtener los valores de las columnas "Columna1" y "Columna2"
                double valor1 = Convert.ToDouble(row.Cells["precios"].Value);
                int valor2 = Convert.ToInt32(row.Cells["cantidad"].Value);
                // Realizar la multiplicación
                double resultado = valor1 * valor2;

                // Asignar el resultado a la columna "Resultado" de la fila actual
                row.Cells["Total"].Value = resultado;
                SumarColumna();
            }
        }
    }
}
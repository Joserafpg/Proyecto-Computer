using Proyecto_Computer.Clases;
using Proyecto_Computer.Clases.Clases_Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Proyecto_Computer
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private DataGridView _DTProductos;
        public DataGridView DTProductos { get => _DTProductos; set => _DTProductos = value; }

        public void DT_Productos()
        {
            _DTProductos = dtgv;
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

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (decimal.TryParse(textBox.Text, NumberStyles.AllowThousands | NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal value))
                {
                    textBox.Text = value.ToString("N0", CultureInfo.CurrentCulture);
                    textBox.Select(textBox.Text.Length, 0);
                }
            }
        }

        private void dtgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dtgv.Columns[e.ColumnIndex].Name == "Total" && e.RowIndex >= 0)
            {
                if (e.Value is decimal monto)
                {
                    e.Value = monto.ToString("N2");
                    e.FormattingApplied = true;
                }
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (dtgv.Rows.Count > 0)
            {
                conn.Open();
                string connectionString = "Data source = DESKTOP-NDDA7LS; Initial Catalog = Computer; Integrated Security = True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tu consulta SQL
                    string consulta = "SELECT Empleado FROM Usuarios WHERE Usuario = (SELECT TOP 1 Usuario FROM Acceso ORDER BY Fecha DESC)";

                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        // Ejecutar la consulta y recuperar el valor
                        string resultadoConsulta = command.ExecuteScalar() as string;

                        // Asignar el resultado al TextBox
                        txtempleado.Text = resultadoConsulta;
                    }
                }

                Datosgetfactura pFactura = new Datosgetfactura();
                pFactura.Empleado = txtempleado.Text;
                pFactura.Cliente = "Fulanito";
                pFactura.Total = Convert.ToDecimal(txttotal.Text);

                DatosbaseFactura.Agregar(pFactura);

                txtidfactura.Visible = true;

                // Consultar el último registro de Id_Factura en FacturaTittle
                string query = "SELECT TOP 1 No_Factura FROM FacturaTittle ORDER BY No_Factura DESC";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Obtener el resultado de la consulta
                    object result = command.ExecuteScalar();

                    // Verificar si se obtuvo un resultado válido
                    if (result != null && result != DBNull.Value)
                    {
                        // Convertir el resultado en un entero
                        int ultimoIdFactura = Convert.ToInt32(result);

                        // Mostrar el último Id_Factura en un TextBox
                        txtidfactura.Text = ultimoIdFactura.ToString();
                    }
                }

                conn.Close();

                SqlCommand agregar = new SqlCommand("INSERT INTO Factura VALUES (@No_Factura , @Codigo, @Producto, @Precio, @Cantidad, @Total)", conn);
                string verificarQuery = "SELECT Cantidad FROM Productos WHERE Nombre = @Producto";
                string actualizarQuery = "UPDATE Productos SET Cantidad = Cantidad - @Cantidad WHERE Nombre = @Producto";

                conn.Open();

                try
                {
                    foreach (DataGridViewRow row in dtgv.Rows)
                    {
                        // Obtener los valores de la fila actual del DataGridView
                        Int64 idfactura = Convert.ToInt64(txtidfactura.Text);
                        int id_producto = Convert.ToInt32(row.Cells["codigos"].Value);
                        string producto = Convert.ToString(row.Cells["name"].Value);
                        decimal precio = Convert.ToDecimal(row.Cells["precios"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["cantidad"].Value);
                        decimal total = Convert.ToDecimal(row.Cells["Total"].Value);

                        // Verificar si el Stock es menor que la Cantidad
                        using (SqlCommand verificarCmd = new SqlCommand(verificarQuery, conn))
                        {
                            verificarCmd.Parameters.AddWithValue("@Producto", producto);
                            int stock = Convert.ToInt32(verificarCmd.ExecuteScalar());

                            if (stock < cantidad)
                            {
                                MessageBox.Show("No hay suficiente stock para el producto " + producto);
                                return; // Salta a la siguiente iteración del bucle sin ejecutar el código restante
                            }
                        }

                        // Agregar los parámetros al comando
                        agregar.Parameters.Clear();
                        agregar.Parameters.AddWithValue("@No_Factura", idfactura);
                        agregar.Parameters.AddWithValue("@Codigo", id_producto);
                        agregar.Parameters.AddWithValue("@Producto", producto);
                        agregar.Parameters.AddWithValue("@Precio", precio);
                        agregar.Parameters.AddWithValue("@Cantidad", cantidad);
                        agregar.Parameters.AddWithValue("@Total", total);

                        // Ejecutar el comando para agregar la factura
                        agregar.ExecuteNonQuery();

                        // Actualizar los datos de la tabla productos
                        using (SqlCommand actualizarCmd = new SqlCommand(actualizarQuery, conn))
                        {
                            actualizarCmd.Parameters.AddWithValue("@Producto", producto);
                            actualizarCmd.Parameters.AddWithValue("@Cantidad", cantidad);
                            actualizarCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Facturado con exito");
                    dtgv.Rows.Clear();
                    Limpiar();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }

                finally
                {
                    conn.Close();
                }

                PlantillaFactura form = new PlantillaFactura();
                ReportDocument oRep = new ReportDocument();
                ParameterField pf = new ParameterField();
                ParameterFields pfs = new ParameterFields();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                pf.Name = "@numFact";
                pdv.Value = txtidfactura.Text;
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);
                form.crystalReportViewer1.ParameterFieldInfo = pfs;
                oRep.Load(@"C:\Users\Jose\source\repos\Proyecto-Computer\Proyecto Computer\Reportes\Factura.rpt");
                form.crystalReportViewer1.ReportSource = oRep;
                form.Show();
                oRep.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\Jose\source\repos\Proyecto-Computer\Facturas\Factura.pdf");

            }

            else
            {
                MessageBox.Show("Por favor agrega productos al cuadro.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoFacturaNew frm = new ProductoFacturaNew();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            DT_Productos();
        }
    }
}
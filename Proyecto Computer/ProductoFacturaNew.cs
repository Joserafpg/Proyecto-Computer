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
    public partial class ProductoFacturaNew : Form
    {
        public ProductoFacturaNew()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data source = DESKTOP-NDDA7LS; Initial Catalog = Computer; Integrated Security = True");
        private void MostrarDatosInvPantalones()
        {
            String query = "SELECT Id_Producto, Nombre, Precio, Cantidad FROM Productos where ";

            if (btnbuscar.Text != "")
            {
                query = query + "  ( Nombre like '%" + txtbuscar.Text + "%')";
            }

            Conexion.opencon();
            SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Conexion.cerrarcon();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Ventas frm = Owner as Ventas;

            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            int nuevoValor = 1;

            // Verifica si ya existe un registro con los mismos valores en las primeras tres columnas
            bool existeRegistro = false;
            foreach (DataGridViewRow row in frm.DTProductos.Rows)
            {
                string codigoExistente = row.Cells[0].Value.ToString();
                string nombreExistente = row.Cells[1].Value.ToString();
                string precioExistente = row.Cells[2].Value.ToString();

                if (codigo == codigoExistente && nombre == nombreExistente && precio == precioExistente)
                {
                    // El registro ya existe, suma el cuarto valor existente con el nuevo valor
                    int valorExistente = Convert.ToInt32(row.Cells[3].Value);
                    int valorSumado = valorExistente + nuevoValor;
                    row.Cells[3].Value = valorSumado;
                    existeRegistro = true;
                    break;
                }
            }

            if (!existeRegistro)
            {
                // El registro no existe, agrega una nueva fila con los valores
                frm.DTProductos.Rows.Add(codigo, nombre, precio, nuevoValor);
            }

            this.Close();
        }

        private void ProductoFacturaNew_Load(object sender, EventArgs e)
        {
            MostrarDatosInvPantalones();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            MostrarDatosInvPantalones();
        }
    }
}

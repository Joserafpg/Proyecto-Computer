using Proyecto_Computer.Clases.Clases_Clientes;
using Proyecto_Computer.Clases.Clases_Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Computer
{
    public partial class AgregarProductos : Form
    {

        public bool EditMode { get; set; }

        public AgregarProductos()
        {
            InitializeComponent();
        }

        public void InitializeData(Int64 id, string nombre, decimal precioCompra, decimal precio, Int64 cantidad, string departamento, DateTime fecha)
        {
            txtid.Text = id.ToString();
            txtnombre.Text = nombre;
            txtpreciocompra.Text = precioCompra.ToString();
            txtprecio.Text = precio.ToString();
            txtcantidad.Text = cantidad.ToString();
            cdepartamento.Text = departamento;
            dtp.Value = fecha;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                DatosgetInventario pClientes = new DatosgetInventario();
                pClientes.Nombre = txtnombre.Text;
                pClientes.Precio_Compra = Convert.ToDecimal(txtpreciocompra.Text);
                pClientes.Precio = Convert.ToDecimal(txtprecio.Text);
                pClientes.Cantidad = Convert.ToInt64(txtcantidad.Text);
                pClientes.Departamento = cdepartamento.Text;
                pClientes.Fecha_Ingreso = dtp.Value;
                pClientes.Codigo = Convert.ToInt64(txtid.Text);

                int Resultado = DatosbaseInventario.Modificar(pClientes);

                if (Resultado > 0)
                {
                    MessageBox.Show("Alumno Modificado con exito", "Alumno modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo modificar el alumno", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                DatosgetInventario pClientes = new DatosgetInventario();
                pClientes.Nombre = txtnombre.Text;
                pClientes.Precio_Compra = Convert.ToDecimal(txtpreciocompra.Text);
                pClientes.Precio = Convert.ToDecimal(txtprecio.Text);
                pClientes.Cantidad = Convert.ToInt64(txtcantidad.Text);
                pClientes.Departamento = cdepartamento.Text;
                pClientes.Fecha_Ingreso = dtp.Value;

                int Resultado = DatosbaseInventario.Agregar(pClientes);

                if (Resultado > 0)
                {
                    MessageBox.Show("Alumno Agregado con exito", "Alumno agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo agregar el alumno", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            // Indica que la operación fue exitosa
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

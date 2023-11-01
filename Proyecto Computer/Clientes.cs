using Proyecto_Computer.Clases.Clases_Clientes;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        public datosgetclientes ClienteActual { get; set; }
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el cliente actual??", "Esta Seguro?!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Int64 resultado = datosbaseclientes.Eliminar((int)ClienteActual.codigo);
                if (resultado > 0)
                {
                    MessageBox.Show("Cliente eliminado", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                    btneliminar.Enabled = false;
                    btnmodificar.Enabled = false;
                    btnagregar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("No se pudo eliminar al cliente", "Cliente eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            datosgetclientes Clientes = new datosgetclientes();

            Clientes.nombre = txtnombre.Text;
            Clientes.direccion = txtdireccion.Text;
            Clientes.telefono = txttelefono.Text;
            Clientes.correo = txtcorreo.Text;
            Clientes.fecha_ingreso = datetimepicker.Value;

            int resultado = datosbaseclientes.Agregar(Clientes);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No se pudieron guardar los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente pBuscar = new BuscarCliente();
            pBuscar.ShowDialog();
            if (pBuscar.clienteseleccionado != null)
            {
                ClienteActual = pBuscar.clienteseleccionado;
                txtnombre.Text = pBuscar.clienteseleccionado.nombre;
                txtdireccion.Text = pBuscar.clienteseleccionado.direccion;
                txttelefono.Text = pBuscar.clienteseleccionado.telefono;
                txtcorreo.Text = pBuscar.clienteseleccionado.correo;
                datetimepicker.Value = pBuscar.clienteseleccionado.fecha_ingreso;

                btnagregar.Enabled = false;
                btnmodificar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            datosgetclientes pClientes = new datosgetclientes();
            pClientes.nombre = txtnombre.Text;
            pClientes.direccion = txtdireccion.Text;
            pClientes.telefono = txttelefono.Text;
            pClientes.correo = txtcorreo.Text;
            pClientes.fecha_ingreso = datetimepicker.Value;
            pClientes.codigo = ClienteActual.codigo;

            int Resultado = datosbaseclientes.Modificar(pClientes);

            if (Resultado > 0)
            {
                MessageBox.Show("Cliente Modificado con exito", "Cliente modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
                btneliminar.Enabled = false;
                btnmodificar.Enabled = false;
                btnagregar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se pudo modificar el Cliente", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}

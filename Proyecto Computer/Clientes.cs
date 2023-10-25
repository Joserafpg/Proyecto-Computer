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
            
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }
    }
}

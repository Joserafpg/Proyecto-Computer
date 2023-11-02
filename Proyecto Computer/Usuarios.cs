using Proyecto_Computer.Clases.Clases_Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Computer.Clases
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtempleado.Text) && // Verifica que el campo no esté vacío
                !string.IsNullOrEmpty(txtuser.Text) && // Verifica que el campo no esté vacío
                !string.IsNullOrEmpty(txtcontraseña.Text)) // Verifica que el campo no esté vacío
            {
                DatosgetUsuarios Clientes = new DatosgetUsuarios();

                Clientes.Empleado = txtempleado.Text;
                Clientes.Usuario = txtuser.Text;
                Clientes.Contraseña = txtcontraseña.Text;
                Clientes.Empleados = chempleado.Checked;
                Clientes.Caja = chcaja.Checked;
                Clientes.Tecnico = chtecnico.Checked;
                Clientes.Administrador = chadmin.Checked;
                Clientes.Inventario = chinventario.Checked;
                Clientes.Clientes = chclientes.Checked;
                Clientes.Ventas = chventas.Checked;
                Clientes.Configuracion = chconfiguraciones.Checked;
                Clientes.Agregar = chagregar.Checked;
                Clientes.Editar = chmodificar.Checked;
                Clientes.Buscar = chbuscar.Checked;
                Clientes.Eliminar = cheliminar.Checked;

                int resultado = DatosbaseUsuarios.Agregar(Clientes);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("No se pudieron guardar los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Computer.Clases.Clases_Clientes;

namespace Proyecto_Computer
{
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }
        public datosgetclientes clienteseleccionado { get; set; }
        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (datagridview.SelectedRows.Count == 1)
            {
                Int64 codigo = Convert.ToInt64(datagridview.CurrentRow.Cells[0].Value);
                clienteseleccionado = datosbaseclientes.ObtenerClientes(codigo);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado nigun Cliente");
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            datagridview.DataSource = datosbaseclientes.BuscarClientes( txttelefono.Text);
        }
    }
}

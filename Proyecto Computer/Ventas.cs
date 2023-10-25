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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            txtcodigo.Clear();
            txttotal.Clear();
            dtgv.Rows.Clear();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void ExecuteProcedureAndDisplayResult(string procedureName, Label textBox)
        {
            string connectionString = "Data Source=DESKTOP-NDDA7LS;Initial Catalog=Computer;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            using (SqlCommand command = new SqlCommand(procedureName, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                var result = command.ExecuteScalar();
                connection.Close();

                if (result != null)
                {
                    textBox.Text = result.ToString();
                }
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            ExecuteProcedureAndDisplayResult("VALORDELINVENTARIO", valordelinventario);
            //ExecuteProcedureAndDisplayResult("SegundoProcedimiento", txtResult2);
            //ExecuteProcedureAndDisplayResult("TercerProcedimiento", txtResult3);
            //ExecuteProcedureAndDisplayResult("CuartoProcedimiento", txtResult4);
        }
    }
}

using Proyecto_Computer.Clases;
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

        private void MostrarVentas()
        {
            /*String query = "SELECT TOP 3 * FROM FacturaTittle ORDER BY Fecha DESC;";


            Conexion.opencon();
            SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtventas.DataSource = ds.Tables[0];
            Conexion.cerrarcon();*/
        }


        void FormatValueInLabel()
        {
            Label[] labels = { valordelinventario, productoseninventario, ventasmensuales, beneficiobrutomensual };

            foreach (Label label in labels)
            {
                if (decimal.TryParse(label.Text, NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out decimal value))
                {
                    label.Text = value.ToString("N0", CultureInfo.CurrentCulture);
                }
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            ExecuteProcedureAndDisplayResult("VALORDELINVENTARIO", valordelinventario);
            ExecuteProcedureAndDisplayResult("CANTIDADENINVENTARIO", productoseninventario);
            ExecuteProcedureAndDisplayResult("SumarTotalPorMes", ventasmensuales);
            ExecuteProcedureAndDisplayResult("SumarBeneficioMensual", beneficiobrutomensual);

            FormatValueInLabel();
        }
    }
}
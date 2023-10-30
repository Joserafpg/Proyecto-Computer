using Proyecto_Computer.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Computer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        void bordesradius()
        {
            int borderRadius = 20;
            GraphicsPath objDraw = new GraphicsPath();

            objDraw.AddArc(0, 0, borderRadius * 2, borderRadius * 2, 180, 90);
            objDraw.AddArc(this.Width - borderRadius * 2, 0, borderRadius * 2, borderRadius * 2, 270, 90);
            objDraw.AddArc(this.Width - borderRadius * 2, this.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
            objDraw.AddArc(0, this.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
            objDraw.CloseFigure();

            this.Region = new Region(objDraw);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            bordesradius();
        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            string inputText = txtpass.Text;

            bool containsLetterOrDigit = false;
            txtuser.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtuser.BorderColorActive = Color.DodgerBlue;
            txtuser.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtuser.BorderColorIdle = Color.Silver;
            
            txtpass.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtpass.BorderColorActive = Color.DodgerBlue;
            txtpass.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtpass.BorderColorIdle = Color.Silver;

            foreach (char c in inputText)
            {
                if (char.IsLetter(c) || char.IsDigit(c))
                {
                    containsLetterOrDigit = true;
                    break;
                }
            }

            if (containsLetterOrDigit)
            {
                txtpass.PasswordChar = '●';
                btnpassview.Visible = true;
            }

            else
            {
                txtpass.PasswordChar = '\0';
                btnpassview.Visible = false;
            }
        }

        private void bunifuIconButton2_MouseDown(object sender, MouseEventArgs e)
        {
            txtpass.PasswordChar = '\0';
        }

        private void bunifuIconButton2_MouseUp(object sender, MouseEventArgs e)
        {
            txtpass.PasswordChar = '●';
        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '\0';
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Equals(""))
            {
                MessageBox.Show("El usuario no debe estar en blanco!...");
                txtuser.Focus();
                return;
            }

            if (txtpass.Text.Equals(""))
            {
                MessageBox.Show("La contraseña no debe estar en blanco!...");
                txtpass.Focus();
                return;
            }

            DataTable dt = new DataTable();
            string consulta;
            consulta = " select * from Usuarios where Usuario=@usuario AND Contraseña =@contrasena";
            Conexion.opencon();
            SqlDataAdapter da = new SqlDataAdapter(consulta, Conexion.ObtenerConexion());
            Conexion.cerrarcon();

            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 10).Value = txtuser.Text;
            da.SelectCommand.Parameters.Add("@contrasena", SqlDbType.VarChar, 10).Value = txtpass.Text;

             da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                Permisos.Empleados = Convert.ToBoolean(dt.Rows[0][4]);
                Permisos.Caja = Convert.ToBoolean(dt.Rows[0][5]);
                Permisos.Tecnico = Convert.ToBoolean(dt.Rows[0][6]);
                Permisos.Administrador = Convert.ToBoolean(dt.Rows[0][7]);
                Permisos.Inventario = Convert.ToBoolean(dt.Rows[0][8]);
                Permisos.Clientes = Convert.ToBoolean(dt.Rows[0][9]);
                Permisos.Ventas = Convert.ToBoolean(dt.Rows[0][10]);
                Permisos.Configuracion = Convert.ToBoolean(dt.Rows[0][11]);
                Permisos.Agregar = Convert.ToBoolean(dt.Rows[0][12]);
                Permisos.Editar = Convert.ToBoolean(dt.Rows[0][13]);
                Permisos.Buscar = Convert.ToBoolean(dt.Rows[0][14]);
                Permisos.Eliminar = Convert.ToBoolean(dt.Rows[0][15]);

                DatosgetRegistro registro = new DatosgetRegistro();

                registro.Usuario = txtuser.Text;

                int resultado = DatosbaseRegistro.Agregar(registro);

                Form principal = new Form1();
                principal.Show();
                principal.Visible = true;
                Visible = false;
                                
            }

            else
            {
                MessageBox.Show(" Usuario o contraseña Incorrecto");
                txtpass.Focus();
                txtuser.BorderColorActive = Color.Red;
                txtuser.BorderColorDisabled = Color.Red;
                txtuser.BorderColorHover = Color.Red;
                txtuser.BorderColorIdle = Color.Red;
                
                txtpass.BorderColorActive = Color.Red;
                txtpass.BorderColorDisabled = Color.Red;
                txtpass.BorderColorHover = Color.Red;
                txtpass.BorderColorIdle = Color.Red;
            }

            Conexion.cerrarcon();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            txtuser.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtuser.BorderColorActive = Color.DodgerBlue;
            txtuser.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtuser.BorderColorIdle = Color.Silver;

            txtpass.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtpass.BorderColorActive = Color.DodgerBlue;
            txtpass.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtpass.BorderColorIdle = Color.Silver;
        }
    }
}

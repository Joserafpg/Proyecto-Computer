
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Computer.Clases.Clases_Inventario
{
    public class DatosbaseInventario
    {
        public static int Agregar(DatosgetInventario pget)
        {

            int retorno = 0;

            Conexion.opencon();

            SqlCommand Comando = new SqlCommand(string.Format("Insert into Productos (Nombre, Precio_Compra, Precio, Cantidad, Departamento, Fecha_Ingreso) values ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    pget.Nombre, pget.Precio_Compra, pget.Precio, pget.Cantidad, pget.Departamento, pget.Fecha_Ingreso.ToString("yyyy-MM-dd HH:mm:ss")), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;

        }

        public static int Modificar(DatosgetInventario pAlumno)
        {
            int retorno = 0;
            Conexion.opencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("update Productos set Nombre = '{0}', Precio_Compra = '{1}', Precio = '{2}', Cantidad = '{3}', Departamento = '{4}', Fecha_Ingreso = '{5}' where Id_Producto = {6}",
                    pAlumno.Nombre, pAlumno.Precio_Compra, pAlumno.Precio, pAlumno.Cantidad, pAlumno.Departamento, pAlumno.Fecha_Ingreso.ToString("yyyy-MM-dd HH:mm:ss"), pAlumno.Codigo), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            Conexion.cerrarcon();
            return retorno;
        }

        public static int Eliminar(int pID)
        {
            int retorno = 0;
            Conexion.opencon();
            SqlCommand Comando = new SqlCommand(string.Format("Delete from Productos where Id_Producto = {0}", pID), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;
        }

        public static List<DatosgetInventario> BuscarAlumnos(string pCodigo, string pDepartamento)
        {
            List<DatosgetInventario> lista = new List<DatosgetInventario>();
            Conexion.opencon();
            {

                SqlCommand comando = new SqlCommand(String.Format("SELECT Id_Producto, Nombre, Precio_Compra, Precio, Cantidad, Departamento,  Fecha_Ingreso FROM Productos where Id_Producto like '%{0}%' and Departamento like '%{1}%' ", pCodigo, pDepartamento),
                    Conexion.ObtenerConexion());

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DatosgetInventario pAlumnos = new DatosgetInventario();
                    pAlumnos.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pAlumnos.Nombre = reader.GetString(1);
                    pAlumnos.Precio_Compra = reader.GetDecimal(2);
                    pAlumnos.Precio = reader.GetDecimal(3);
                    pAlumnos.Cantidad = Convert.ToInt64(reader.GetValue(4));
                    pAlumnos.Departamento = reader.GetString(5);
                    pAlumnos.Fecha_Ingreso = Convert.ToDateTime(reader.GetValue(6));

                    lista.Add(pAlumnos);
                }
                Conexion.cerrarcon();
                return lista;
            }
        }


        public static DatosgetInventario ObtenerAlumnos(string pId)
        {
            Conexion.opencon();
            {
                DatosgetInventario pAlumno = new DatosgetInventario();
                SqlCommand comando = new SqlCommand(string.Format(
                   "select codigo, Nombre, Cedula, Telefono, Direccion, Fecha_nacimiento From Alumnos where Codigo = {0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pAlumno.Codigo = Convert.ToInt64(reader.GetValue(0));
                    pAlumno.Nombre = reader.GetString(1);
                    pAlumno.Precio_Compra = reader.GetDecimal(2);
                    pAlumno.Precio = reader.GetDecimal(3);
                    pAlumno.Cantidad = reader.GetInt64(4);
                    pAlumno.Departamento = reader.GetString(5);
                    pAlumno.Fecha_Ingreso = Convert.ToDateTime(reader.GetValue(6));
                }
                Conexion.cerrarcon();
                return pAlumno;
            }
        }
    }
}
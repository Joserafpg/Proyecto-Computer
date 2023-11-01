using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Computer.Clases.Clases_Clientes
{
    public class datosbaseclientes
    {
        public static int Agregar(datosgetclientes pget)
        {

            int retorno = 0;

            Conexion.opencon();

            SqlCommand Comando = new SqlCommand(string.Format("Insert into clientes (nombre, telefono, direccion, correo, fecha_ingreso) values ('{0}','{1}','{2}','{3}','{4}')",
              pget.nombre, pget.telefono, pget.direccion, pget.correo, pget.fecha_ingreso.ToString("yyyy-MM-dd HH:mm:ss")), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;

        }

        public static int Modificar(datosgetclientes pClientes)
        {
            int retorno = 0;
            Conexion.opencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("Update clientes set nombre='{0}',direccion='{1}',telefono='{2}',correo='{3}', fecha_ingreso='{4}' where codigo = '{5}'",
                 pClientes.nombre,  pClientes.telefono, pClientes.direccion, pClientes.correo, pClientes.fecha_ingreso.ToString("yyyy-MM-dd HH:mm:ss"), pClientes.codigo), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();

            }

            Conexion.cerrarcon();
            return retorno;

        }

        public static int Eliminar(int pId)
        {
            {
                int retorno = 0;
                Conexion.opencon();
                SqlCommand comando = new SqlCommand(string.Format("Delete From clientes where codigo = {0}", pId), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                Conexion.cerrarcon();
                return retorno;

            }

        }
        public static List<datosgetclientes> BuscarClientes( string pTelefono)
        {
            List<datosgetclientes> lista = new List<datosgetclientes>();
            Conexion.opencon();
            {

                SqlCommand comando = new SqlCommand(String.Format(
               "SELECT codigo, nombre, direccion, telefono, correo, fecha_ingreso FROM clientes where telefono like '%{0}%' ", pTelefono),
                    Conexion.ObtenerConexion());

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    datosgetclientes pClientes = new datosgetclientes();
                    pClientes.codigo = Convert.ToInt64(reader.GetValue(0));
                    pClientes.nombre = reader.GetString(1);
                    pClientes.direccion = reader.GetString(2);
                    pClientes.telefono = reader.GetString(3);
                    pClientes.correo = reader.GetString(4);
                    pClientes.fecha_ingreso = Convert.ToDateTime(reader.GetValue(5));

                    lista.Add(pClientes);
                }
                Conexion.cerrarcon();
                return lista;
            }
        }
        public static datosgetclientes ObtenerClientes(Int64 pId)
        {
            Conexion.opencon();
            {
                datosgetclientes pClientes = new datosgetclientes();
                SqlCommand comando = new SqlCommand(string.Format(
                   "select codigo, nombre, direccion, telefono, correo, fecha_ingreso  From clientes where codigo = {0}", pId), Conexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    pClientes.codigo = Convert.ToInt64(reader.GetValue(0));
                    pClientes.nombre = reader.GetString(1);
                    pClientes.direccion = reader.GetString(2);
                    pClientes.telefono = reader.GetString(3);
                    pClientes.correo = reader.GetString(4);
                    pClientes.fecha_ingreso = reader.GetDateTime(5);

                }


                Conexion.cerrarcon();
                return pClientes;
            }
        }
    }
}

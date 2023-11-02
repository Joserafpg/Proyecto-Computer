using Proyecto_Computer.Clases.Clases_Ventas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Computer.Clases.Clases_Usuarios
{
    public class DatosbaseUsuarios
    {
        public static int Agregar(DatosgetUsuarios pget)
        {

            int retorno = 0;

            Conexion.opencon();

            SqlCommand Comando = new SqlCommand(string.Format("Insert into Usuarios (Empleado, Usuario, Contraseña, Empleados, Caja, Tecnico, Administrador, Inventario, Clientes, Ventas, Configuracion, Agregar, Editar, Buscar, Eliminar) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                    pget.Empleado, pget.Usuario, pget.Contraseña, pget.Empleados, pget.Caja, pget.Tecnico, pget.Administrador, pget.Inventario, pget.Clientes, pget.Ventas, pget.Configuracion, pget.Agregar, pget.Editar, pget.Buscar, pget.Eliminar), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;

        }

       /* public static int Modificar(DatosgetUsuarios pAlumno)
        {
            int retorno = 0;
            Conexion.opencon();
            {
                SqlCommand comando = new SqlCommand(string.Format("update FacturaTittle set Empleado = '{0}', Cliente = '{1}', Fecha = '{2}', Total = '{3}' where Id_Factura = {4}",
                    pAlumno.Empleado, pAlumno.Cliente, pAlumno.Fecha.ToString("yyyy-MM-dd HH:mm:ss"), pAlumno.Total, pAlumno.ID_Factura), Conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            Conexion.cerrarcon();
            return retorno;
        }*/

        public static int Eliminar(int pID)
        {
            int retorno = 0;
            Conexion.opencon();
            SqlCommand Comando = new SqlCommand(string.Format("Delete from Usuarios where Id_Usuario = {0}", pID), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;
        }
    }
}

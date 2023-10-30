using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Computer.Clases
{
    public class Permisos
    {
        public Permisos()
        {
        }

        public static bool Empleados { set; get; }
        public static bool Caja { set; get; }
        public static bool Tecnico { set; get; }
        public static bool Administrador { set; get; }
        public static bool Inventario { set; get; }
        public static bool Clientes { set; get; }
        public static bool Ventas { set; get; }
        public static bool Configuracion { set; get; }
        public static bool Agregar { set; get; }
        public static bool Editar { set; get; }
        public static bool Buscar { set; get; }
        public static bool Eliminar { set; get; }
    }
}

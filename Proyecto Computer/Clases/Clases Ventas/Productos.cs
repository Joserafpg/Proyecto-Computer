using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Computer.Clases
{
    public class Productos
    {
        public Int64 Id { get; set; }
        public string Nombre_Producto { get; set; }
        public decimal Precio { get; set; }

        public int Cantidad = 1;
    }
}

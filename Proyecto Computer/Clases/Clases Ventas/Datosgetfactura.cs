using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Computer.Clases.Clases_Ventas
{
    public class Datosgetfactura
    {
        public Int64 ID_Factura { get; set; }
        public string Empleado { get; set; }
        public string Cliente { get; set; }

        public DateTime Fecha = DateTime.Now;
        public decimal Total { get; set; }

        public Datosgetfactura() { }

        public Datosgetfactura(long iD_Factura, string empleado, string cliente, decimal total)
        {
            ID_Factura = iD_Factura;
            Empleado = empleado;
            Cliente = cliente;
            Total = total;
        }
    }
}

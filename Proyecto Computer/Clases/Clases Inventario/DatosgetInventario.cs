using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Computer.Clases.Clases_Inventario
{
    public class DatosgetInventario
    {
        public Int64 Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal Precio { get; set; }
        public Int64 Cantidad { get; set; }
        public string Departamento { get; set; }
        public DateTime Fecha_Ingreso { get; set; }

        public DatosgetInventario() { }

        public DatosgetInventario(Int64 pCodigo, string pNombre, decimal pPrecio_Compra, decimal pPrecio, Int64 pCantidad, string pDepartamento, DateTime pFecha)
        {
            this.Codigo = pCodigo;
            this.Nombre = pNombre;
            this.Precio_Compra = pPrecio_Compra;
            this.Precio = pPrecio;
            this.Cantidad = pCantidad;
            this.Departamento = pDepartamento;
            this.Fecha_Ingreso = pFecha;
        }
    }
}

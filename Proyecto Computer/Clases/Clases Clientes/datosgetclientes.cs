using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Computer.Clases.Clases_Clientes
{
    public class datosgetclientes
    {
        public Int64 codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public DateTime fecha_ingreso { get; set; }

        public datosgetclientes() { }
        public datosgetclientes(Int64 pcodigo, string pnombre, string pdireccion, string ptelefono, string pcorreo, DateTime pfecha_ingreso)
        {
            this.codigo = pcodigo;
            this.nombre = pnombre;
            this.direccion = pdireccion;
            this.telefono = ptelefono;
            this.correo = pcorreo;
            this.fecha_ingreso = pfecha_ingreso;
        }
    }
}
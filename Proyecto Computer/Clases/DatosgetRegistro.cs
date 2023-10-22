using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Computer.Clases
{
    public class DatosgetRegistro
    {
        public string Usuario { get; set; }

        public DateTime Fecha_de_Ingreso = DateTime.Now;

        public DatosgetRegistro() { }

        public DatosgetRegistro(string pUsuario, DateTime pfecha)
        {
            this.Usuario = pUsuario;
            this.Fecha_de_Ingreso = pfecha;
        }
    }
}

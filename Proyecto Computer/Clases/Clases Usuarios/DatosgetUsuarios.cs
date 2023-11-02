using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Computer.Clases.Clases_Usuarios
{
    public class DatosgetUsuarios
    {
        public Int64 Codigo { get; set; }
        public string Empleado { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public bool Empleados { get; set; }
        public bool Caja { get; set; }
        public bool Tecnico { get; set; }
        public bool Administrador { get; set; }
        public bool Inventario { get; set; }
        public bool Clientes { get; set; }
        public bool Ventas { get; set; }
        public bool Configuracion { get; set; }
        public bool Agregar { get; set; }
        public bool Editar { get; set; }
        public bool Buscar { get; set; }
        public bool Eliminar { get; set; }

        public DatosgetUsuarios() { }

        public DatosgetUsuarios(Int64 pCodigo, string pEmpleado, string pUsuario, string pContraseña, bool oEmpleados, bool pCaja, bool pTecnico, bool pAdministrador, bool pInventario, bool pClientes, bool pVentas, bool pConfiguracion, bool pAgregar, bool pEditar, bool pBuscar, bool pEliminar)
        {
            this.Codigo = pCodigo;
            this.Empleado = pEmpleado;
            this.Usuario = pUsuario;
            this.Contraseña = pContraseña;
            this.Empleados = oEmpleados;
            this.Caja = pCaja;
            this.Tecnico = pTecnico;
            this.Administrador = pAdministrador;
            this.Inventario = pInventario;
            this.Clientes = pClientes;
            this.Ventas = pVentas;
            this.Configuracion = pConfiguracion;
            this.Agregar = pAgregar;
            this.Editar = pEditar;
            this.Buscar = pBuscar;
            this.Eliminar = pEliminar;
        }
    }
}

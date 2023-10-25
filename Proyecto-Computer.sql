create database Computer

use Computer

create table Usuarios(
Id_Usuario int IDENTITY (1,1) NOT NULL,
Empleado varchar (50),
Usuario varchar (10),
Contraseña varchar(30),
Inventario bit,
Clientes bit,
Ventas bit,
Configuracion bit,
Agregar bit,
Editar bit,
Buscar bit,
Eliminar bit,
)

create table Acceso(
Usuario varchar (10),
Fecha datetime,
)


create table Productos (
Id_Producto INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
Nombre varchar (30),
Precio_Compra decimal (38),
Precio decimal (38),
Cantidad int,
Departamento varchar (30),
Fecha_Ingreso date,
)

select * from Usuarios
select * from Acceso ORDER BY Fecha ASC
SELECT TOP 1 * FROM Acceso ORDER BY Fecha DESC
SELECT Empleado FROM Usuarios WHERE Usuario = (SELECT TOP 1 Usuario FROM Acceso ORDER BY Fecha DESC)

drop table Acceso
drop database Computer
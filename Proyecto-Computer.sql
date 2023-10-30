create database Computer

use Computer

create table Usuarios(
Id_Usuario int IDENTITY (1,1) NOT NULL,
Empleado varchar (50),
Usuario varchar (10),
Contraseña varchar(30),
Empleados bit,
Caja bit,
Tecnico bit,
Administrador bit,
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

create table Clientes (
codigo INT IDENTITY (1,1) PRIMARY KEY NOT NULL, 
nombre varchar(50),
telefono varchar (50),
correo varchar (50),
direccion varchar (50),
fecha_ingreso date
)

/*Tabla facturaTitulo*/
create table FacturaTittle(
No_Factura INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
Empleado varchar (50),
Cliente varchar (50),
Fecha datetime,
Total decimal (38),
)

create table Factura (
No_Factura INT NOT NULL,
Codigo INT, 
Producto varchar (50), 
Precio decimal (38), 
Cantidad int,
SubTotal decimal (38),
)


/*Procedures*/
CREATE PROCEDURE VALORDELINVENTARIO
AS
SELECT SUM(Cantidad * Precio) AS ValorTotal FROM Productos;

EXEC VALORDELINVENTARIO
GO


CREATE PROCEDURE CANTIDADENINVENTARIO
AS
SELECT SUM(Cantidad) AS ValorTotal FROM Productos;

EXEC CANTIDADENINVENTARIO
GO


CREATE PROCEDURE SumarTotalPorMes
AS
BEGIN
    DECLARE @MesActual INT;
    SET @MesActual = MONTH(GETDATE());

    -- Filtrar por el mes actual
    SELECT SUM(Total) AS TotalMensual
    FROM FacturaTittle
    WHERE MONTH(Fecha) = @MesActual;
END;

EXEC SumarTotalPorMes;



/*CREATE PROCEDURE SumarBeneficioAdquirido
AS
BEGIN
    SELECT SUM((F.Precio - P.Precio_Compra) * F.Cantidad) AS TotalBeneficio
    FROM Factura F
    JOIN Productos P ON F.Codigo = P.Id_Producto;
END;

EXEC SumarBeneficioAdquirido;*/


CREATE PROCEDURE SumarBeneficioMensual
AS
BEGIN
    DECLARE @FechaInicio DATETIME;
    DECLARE @FechaFin DATETIME;

    -- Obtener la fecha de inicio del mes actual
    SET @FechaInicio = DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0);

    -- Obtener la fecha de fin del mes actual
    SET @FechaFin = DATEADD(MONTH, 1, @FechaInicio);

    SELECT SUM((F.Precio - P.Precio_Compra) * F.Cantidad) AS TotalBeneficio
    FROM Factura F
    JOIN Productos P ON F.Codigo = P.Id_Producto
    JOIN FacturaTittle FT ON F.No_Factura = FT.No_Factura
    WHERE FT.Fecha >= @FechaInicio AND FT.Fecha < @FechaFin;
END;

EXEC SumarBeneficioMensual;




create proc busquedaClienteFacturaPrueba
@numFact varchar(15)
as select No_Factura, Empleado, Cliente, Fecha, Total from FacturaTittle where No_Factura = @numFact
go

CREATE PROC busquedaDetallePrueba
@numFact VARCHAR(15)
AS
SELECT Codigo, Producto, Precio, Cantidad, SubTotal FROM Factura WHERE No_Factura = @numFact


/*Consultas*/
SELECT * FROM Productos
SELECT * FROM Usuarios
SELECT * FROM Factura
SELECT * FROM FacturaTittle
SELECT * FROM Acceso

select Codigo, Producto, Precio,Cantidad,SubTotal from Factura where No_Factura = 1;

SELECT TOP 1 * FROM Acceso ORDER BY Fecha DESC
SELECT Empleado FROM Usuarios WHERE Usuario = (SELECT TOP 1 Usuario FROM Acceso ORDER BY Fecha DESC)
SELECT TOP 3 * FROM FacturaTittle ORDER BY Fecha DESC;


SELECT 
    F.No_Factura,
    F.Producto,
    F.Precio AS Precio_Venta,
    F.Cantidad,
    F.SubTotal AS Ingresos,
    P.Precio_Compra AS Precio_Compra,
    (F.Precio - P.Precio_Compra) * F.Cantidad AS Beneficio_Adquirido
FROM Factura F
JOIN Productos P ON F.Codigo = P.Id_Producto;


/*Limpiar tablas*/
delete Acceso



drop table Acceso
drop table Usuarios
drop table Factura
drop table FacturaTittle
drop database Computer

DROP PROCEDURE SumarBeneficioAdquirido
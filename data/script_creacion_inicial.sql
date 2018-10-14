-- -----------------------------------------------------
-- BD --
-- -----------------------------------------------------

USE [GD2C2018];
GO

-- -----------------------------------------------------
-- Creación de Schema EL_GROUP_BY
-- -----------------------------------------------------

IF (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'EL_GROUP_BY') IS NOT NULL
	DROP SCHEMA EL_GROUP_BY
GO

CREATE SCHEMA [EL_GROUP_BY] AUTHORIZATION [gdEspectaculos2018]
GO

-- -----------------------------------------------------
-- Configuraciones
-- -----------------------------------------------------

SET NOCOUNT ON
GO

-- -----------------------------------------------------
-- Borramos las tablas
-- -----------------------------------------------------

IF OBJECT_ID('EL_GROUP_BY.Rol') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Rol;
GO

IF OBJECT_ID('EL_GROUP_BY.Usuario') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Usuario;
GO

IF OBJECT_ID('EL_GROUP_BY.Funcionalidad') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Funcionalidad;
GO

IF OBJECT_ID('EL_GROUP_BY.Cliente') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Cliente;
GO

IF OBJECT_ID('EL_GROUP_BY.Empresa') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Empresa;
GO

IF OBJECT_ID('EL_GROUP_BY.Rubro') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Rubro;
GO

IF OBJECT_ID('EL_GROUP_BY.Espectaculo') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Espectaculo;
GO

IF OBJECT_ID('EL_GROUP_BY.Ubicacion_Tipo') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Ubicacion_Tipo;
GO

IF OBJECT_ID('EL_GROUP_BY.Ubicacion') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Ubicacion;
GO

IF OBJECT_ID('EL_GROUP_BY.Grado_Publicacion') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Grado_Publicacion;
GO

IF OBJECT_ID('EL_GROUP_BY.Publicacion') IS NOT NULL
	DROP TABLE EL_GROUP_BYPublicacion.;
GO

IF OBJECT_ID('EL_GROUP_BY.Factura') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Factura;
GO

IF OBJECT_ID('EL_GROUP_BY.Forma_Pago') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Forma_Pago;
GO

IF OBJECT_ID('EL_GROUP_BY.Compra') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Compra;
GO

IF OBJECT_ID('EL_GROUP_BY.Item') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Item;
GO

IF OBJECT_ID('EL_GROUP_BY.Puntos') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Puntos;
GO

IF OBJECT_ID('EL_GROUP_BY.Rol_Funcionalidad') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Rol_Funcionalidad;
GO

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Rol
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Rol (
  Rol_ID INT NOT NULL,
  Rol_Nombre NVARCHAR(20) NOT NULL,
  Rol_Habilitado BIT NOT NULL,
  PRIMARY KEY (Rol_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Funcionalidad
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Funcionalidad (
  Funcionalidad_ID INT NOT NULL,
  Rol_Nombre NVARCHAR(20) NOT NULL,
  PRIMARY KEY (Funcionalidad_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Rol_Funcionalidad
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Rol_Funcionalidad (
  Rol_ID INT NOT NULL,
  Funcionalidad_ID INT NOT NULL,
  PRIMARY KEY (Funcionalidad_ID, Rol_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Usuario
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Usuario (
  Usuario_ID INT NOT NULL IDENTITY(1,1),
  Usuario_Username NVARCHAR(50) NOT NULL,
  Usuario_Password NVARCHAR(50) NOT NULL,
  Usuario_Tipo NVARCHAR(20) NOT NULL,
  Usuario_Habilitado BIT NOT NULL,
  Usuario_Intentos SMALLINT NOT NULL,
  Usuario_Mail NVARCHAR(255),
  Usuario_Telefono NVARCHAR(20),
  Usuario_Calle NVARCHAR(255),
  Usuario_Numero_Calle NUMERIC(18,0),
  Usuario_Piso NUMERIC(18,0),
  Usuario_Depto NVARCHAR(255),
  Usuario_Codigo_Postal NVARCHAR(255),
  Rol_ID INT
  PRIMARY KEY (Usuario_ID),
  CONSTRAINT FK_Usuario_Rol_ID FOREIGN KEY (Rol_ID)     
    REFERENCES EL_GROUP_BY.Rol (Rol_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE)
;

CREATE UNIQUE INDEX Usuario_Username_UNIQUE ON EL_GROUP_BY.Usuario (Usuario_Username ASC);

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Cliente
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Cliente (
  Cliente_ID INT NOT NULL IDENTITY(1,1),
  Cliente_Nombre NVARCHAR(255),
  Cliente_Apellido NVARCHAR(255),
  Cliente_Tipo_Documento NVARCHAR(10),
  Cliente_Numero_Documento NUMERIC(18,0),
  Cliente_Cuil NVARCHAR(20),
  Cliente_Fecha_Nacimiento DATETIME,
  Cliente_Tarjeta_Marca NVARCHAR(20),
  Cliente_Tarjeta_Numero NUMERIC(16,0),
  Cliente_Fecha_Creacion DATETIME,
  Usuario_ID INT,
  PRIMARY KEY (Cliente_ID),
  CONSTRAINT FK_Cliente_Usuario_ID FOREIGN KEY (Usuario_ID)     
    REFERENCES EL_GROUP_BY.Usuario (Usuario_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE)
;

CREATE UNIQUE INDEX Cliente_Tipo_Documento_UNIQUE ON EL_GROUP_BY.Cliente (Cliente_Tipo_Documento ASC);

CREATE UNIQUE INDEX Cliente_Numero_Documento_UNIQUE ON EL_GROUP_BY.Cliente (Cliente_Numero_Documento ASC);

CREATE UNIQUE INDEX Cliente_Cuil_UNIQUE ON EL_GROUP_BY.Cliente (Cliente_Cuil ASC);


-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Empresa
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Empresa (
  Empresa_ID INT NOT NULL IDENTITY(1,1),
  Empresa_Razon_Social NVARCHAR(255) NOT NULL,
  Empresa_Cuit NVARCHAR(255) NOT NULL,
  Empresa_Ciudad NVARCHAR(50),
  Empresa_Fecha_Creacion DATETIME,
  Usuario_ID INT,
  PRIMARY KEY (Empresa_ID),
  CONSTRAINT FK_Empresa_Usuario_ID FOREIGN KEY (Usuario_ID)     
    REFERENCES EL_GROUP_BY.Usuario (Usuario_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE)
;

CREATE UNIQUE INDEX Empresa_Razon_Social_UNIQUE ON EL_GROUP_BY.Empresa (Empresa_Razon_Social ASC);

CREATE UNIQUE INDEX Empresa_Cuit_UNIQUE ON EL_GROUP_BY.Empresa (Empresa_Cuit ASC);

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Rubro
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Rubro (
  Rubro_ID INT NOT NULL,
  Rubro_Descripcion NVARCHAR(255) NOT NULL,
  PRIMARY KEY (Rubro_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Espectaculo
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Espectaculo (
  Espectaculo_ID INT NOT NULL,
  Espectaculo_Codigo NUMERIC(18,0) NOT NULL,
  Espectaculo_Descripcion NVARCHAR(255) NOT NULL,
  Espectaculo_Fecha DATETIME NOT NULL,
  Espectaculo_Fecha_Vencimiento DATETIME NOT NULL,
  Espectaculo_Estado NVARCHAR(255) NOT NULL,
  Espectaculo_Ubicaciones_Disponibles NUMERIC(18,0) NOT NULL,
  Espectaculo_Total_Ubicaciones NUMERIC(18,0) NOT NULL,
  Rubro_ID INT NOT NULL,
  PRIMARY KEY (Espectaculo_ID),
  CONSTRAINT FK_Espectaculo_Rubro_ID FOREIGN KEY (Rubro_ID)     
    REFERENCES EL_GROUP_BY.Rubro (Rubro_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Ubicacion_Tipo
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Ubicacion_Tipo (
  Ubicacion_Tipo_ID INT NOT NULL,
  Ubicacion_Tipo_Codigo NUMERIC(18,0) NOT NULL,
  Ubicacion_Tipo_Descripcion NVARCHAR(255) NOT NULL,
  PRIMARY KEY (Ubicacion_Tipo_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Ubicacion
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Ubicacion (
  Ubicacion_ID INT NOT NULL,
  Ubicacion_Fila VARCHAR(3) NULL,
  Ubicacion_Asiento NUMERIC(18,0) NULL,
  Ubicacion_Sin_Numerar BIT NOT NULL,
  Ubicacion_Precio NUMERIC(18,0) NOT NULL,
  Ubicacion_Disponible BIT NOT NULL,
  Ubicacion_Tipo_ID INT NOT NULL,
  Espectaculo_ID INT NOT NULL,
  PRIMARY KEY (Ubicacion_ID),
  CONSTRAINT FK_Ubicacion_Espectaculo_ID FOREIGN KEY (Espectaculo_ID)     
    REFERENCES EL_GROUP_BY.Espectaculo (Espectaculo_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Grado_Publicacion
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Grado_Publicacion (
  Grado_Publicacion_ID INT NOT NULL,
  Grado_Publicacion_Comision NUMERIC(3,3) NOT NULL,
  Grado_Publicacion_Prioridad NVARCHAR(10) NOT NULL,
  PRIMARY KEY (Grado_Publicacion_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Publicacion
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Publicacion (
  Publicacion_ID INT NOT NULL,
  Publicacion_Descripcion_Inicio NVARCHAR(255) NOT NULL,
  Publicacion_Fecha DATETIME NOT NULL,
  Publicacion_Estado NVARCHAR(255) NOT NULL,
  Publicacion_Cantidad_Localidades NUMERIC(7,0) NOT NULL,
  Usuario_ID INT NOT NULL,
  Grado_Publicacion_ID INT NOT NULL,
  Espectaculo_ID INT NOT NULL,
  PRIMARY KEY (Publicacion_ID),
  CONSTRAINT FK_Publicacion_Usuario_ID FOREIGN KEY (Usuario_ID)     
    REFERENCES EL_GROUP_BY.Usuario (Usuario_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,
  CONSTRAINT FK_Publicacion_Grado_Publicacion_ID FOREIGN KEY (Grado_Publicacion_ID)     
    REFERENCES EL_GROUP_BY.Grado_Publicacion (Grado_Publicacion_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,
  CONSTRAINT FK_Publicacion_Espectaculo_ID FOREIGN KEY (Espectaculo_ID)     
    REFERENCES EL_GROUP_BY.Espectaculo (Espectaculo_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Factura
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Factura (
  Factura_ID INT NOT NULL,
  Factura_Nro NUMERIC(18,0) NOT NULL,
  Factura_Fecha DATETIME NOT NULL,
  Factura_Total NUMERIC(18,2) NOT NULL,
  PRIMARY KEY (Factura_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Forma_Pago
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Forma_Pago (
  Forma_Pago_ID INT NOT NULL,
  Forma_Pago_Descripcion NVARCHAR(255) NOT NULL,
  PRIMARY KEY (Forma_Pago_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Compra
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Compra (
  Compra_ID INT NOT NULL,
  Compra_Fecha DATETIME NOT NULL,
  Compra_Cantidad NUMERIC(18,0) NOT NULL,
  Factura_ID INT NOT NULL,
  Usuario_ID INT NOT NULL,
  Forma_Pago_ID INT NOT NULL,
  PRIMARY KEY (Compra_ID),
  CONSTRAINT FK_Compra_Factura_ID FOREIGN KEY (Factura_ID)     
    REFERENCES EL_GROUP_BY.Factura (Factura_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,
  CONSTRAINT FK_Compra_Usuario_ID FOREIGN KEY (Usuario_ID)     
    REFERENCES EL_GROUP_BY.Usuario (Usuario_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE,
  CONSTRAINT FK_Compra_Forma_Pago_ID FOREIGN KEY (Forma_Pago_ID)     
    REFERENCES EL_GROUP_BY.Forma_Pago (Forma_Pago_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Item
-- -----------------------------------------------------


CREATE TABLE EL_GROUP_BY.Item (
  Item_ID INT NOT NULL,
  Item_Monto NUMERIC(18,2) NOT NULL,
  Item_Cantidad NUMERIC(18,0) NOT NULL,
  Item_Descripcion NVARCHAR(60) NOT NULL,
  Factura_ID INT NOT NULL,
  PRIMARY KEY (Item_ID),
  CONSTRAINT FK_Item_Factura_ID FOREIGN KEY (Factura_ID)     
    REFERENCES EL_GROUP_BY.Factura (Factura_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Puntos
-- -----------------------------------------------------


CREATE TABLE EL_GROUP_BY.Puntos (
  Puntos_ID INT NOT NULL,
  Puntos_Cantidad NUMERIC(18,0) NOT NULL,
  Puntos_Fecha_Vencimiento DATETIME NOT NULL,
  Cliente_ID INT NOT NULL,
  PRIMARY KEY (Puntos_ID),
  CONSTRAINT FK_Puntos_Cliente_ID FOREIGN KEY (Cliente_ID)     
    REFERENCES EL_GROUP_BY.Cliente (Cliente_ID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE)
;
GO
-- -----------------------------------------------------
-- Funciones
-- -----------------------------------------------------

-- ME DEVUELVE EL ID_USUARIO
CREATE FUNCTION EL_GROUP_BY.FUNC_COD_USUARIO(@USU NVARCHAR(50))
RETURNS INT
AS
BEGIN
	DECLARE @RESULTADO INT
	SELECT @RESULTADO = Usuario_ID FROM EL_GROUP_BY.USUARIO WHERE Usuario_Username = @USU
	RETURN @RESULTADO
END;
GO

-- -----------------------------------------------------
-- Cargar Usuarios
-- -----------------------------------------------------
GO

CREATE PROC EL_GROUP_BY.CARGAR_USUARIOS
AS
BEGIN TRAN
	INSERT INTO EL_GROUP_BY.USUARIO
	SELECT DISTINCT (Cli_Nombre + CONVERT(NVARCHAR(50),Cli_Dni))
					,HASHBYTES('SHA2_256', CONVERT(NVARCHAR(50),Cli_Dni))
					,'CLIENTE'
					,1
					,0
					,Cli_Mail
					,null
					,Cli_Dom_Calle
					,Cli_Nro_Calle
					,Cli_Piso
					,Cli_Depto
					,Cli_Cod_Postal
					,1
		FROM gd_esquema.Maestra
		WHERE Cli_Dni IS NOT NULL
		UNION
		SELECT DISTINCT CONVERT(NVARCHAR(50),Espec_Empresa_Cuit)
					,HASHBYTES('SHA2_256', CONVERT(NVARCHAR(50),Espec_Empresa_Cuit))
					,'EMPRESA'
					,1
					,0
					,Espec_Empresa_Mail
					,null
					,Espec_Empresa_Dom_Calle
					,Espec_Empresa_Nro_Calle
					,Espec_Empresa_Piso
					,Espec_Empresa_Depto
					,Espec_Empresa_Cod_Postal
					,2
		FROM gd_esquema.Maestra
		WHERE Espec_Empresa_Cuit IS NOT NULL

	INSERT INTO EL_GROUP_BY.USUARIO VALUES
		(CONVERT(NVARCHAR(50),'admin')
		,HASHBYTES('SHA2_256', CONVERT(NVARCHAR(50),'w23e'))
		,'ADMINISTRADOR'
		,1
		,0
		,'admin@frba.com'
		,15123123
		,'Calle Falsa'
		,123
		,null
		,null
		,'1990'
		,3)
COMMIT
GO

-- -----------------------------------------------------
-- Cargar Clientes
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_CLIENTES AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Cliente 
	SELECT DISTINCT Cli_Nombre
		            ,Cli_Apeliido
					,'DNI'
					,Cli_Dni
					,null
					,Cli_Fecha_Nac
					,null
					,null
					,null
					,EL_GROUP_BY.FUNC_COD_USUARIO(Cli_Nombre + CONVERT(NVARCHAR(50),Cli_Dni))
		FROM gd_esquema.Maestra
		WHERE Cli_Dni IS NOT NULL
COMMIT
GO

-- -----------------------------------------------------
-- Cargar Empresas
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_EMPRESAS AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Empresa
	SELECT DISTINCT Espec_Empresa_Razon_Social
		            ,Espec_Empresa_Cuit
					,null
					,null
					,EL_GROUP_BY.FUNC_COD_USUARIO(CONVERT(NVARCHAR(50),Espec_Empresa_Cuit))
		FROM gd_esquema.Maestra
		WHERE Espec_Empresa_Cuit IS NOT NULL
COMMIT
GO
select Cli_Dni from gd_esquema.Maestra where Cli_Dni is not null;
drop table EL_GROUP_BY.Usuario;
drop proc EL_GROUP_BY.CARGAR_USUARIOS;
exec EL_GROUP_BY.CARGAR_USUARIOS;

select * from EL_GROUP_BY.Usuario where Usuario_Id = 780;

exec EL_GROUP_BY.CARGAR_CLIENTES;

drop table EL_GROUP_BY.Cliente;

select * from EL_GROUP_BY.Cliente;

exec EL_GROUP_BY.CARGAR_EMPRESAS;

select * from EL_GROUP_BY.Empresa;
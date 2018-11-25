/****************************************************************
*						BD - GD2C2018							*
****************************************************************/

USE [GD2C2018];
GO

/****************************************************************
*					DROP DE TABLAS - COMIENZO					*
****************************************************************/

IF OBJECT_ID('EL_GROUP_BY.Publicacion') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Publicacion;

IF OBJECT_ID('EL_GROUP_BY.Espectaculo') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Espectaculo;

IF OBJECT_ID('EL_GROUP_BY.Compra') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Compra;

IF OBJECT_ID('EL_GROUP_BY.Puntos') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Puntos;

IF OBJECT_ID('EL_GROUP_BY.Cliente') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Cliente;

IF OBJECT_ID('EL_GROUP_BY.Item') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Item;

IF OBJECT_ID('EL_GROUP_BY.Factura') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Factura;

IF OBJECT_ID('EL_GROUP_BY.Empresa') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Empresa;

IF OBJECT_ID('EL_GROUP_BY.Rol_Usuario') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Rol_Usuario;

IF OBJECT_ID('EL_GROUP_BY.Rol_Funcionalidad') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Rol_Funcionalidad;

IF OBJECT_ID('EL_GROUP_BY.Rol') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Rol;

IF OBJECT_ID('EL_GROUP_BY.Usuario') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Usuario;

IF OBJECT_ID('EL_GROUP_BY.Funcionalidad') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Funcionalidad;

IF OBJECT_ID('EL_GROUP_BY.Rubro') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Rubro;

IF OBJECT_ID('EL_GROUP_BY.Ubicacion') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Ubicacion;

IF OBJECT_ID('EL_GROUP_BY.Ubicacion_Tipo') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Ubicacion_Tipo;

IF OBJECT_ID('EL_GROUP_BY.Grado_Publicacion') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Grado_Publicacion;

IF OBJECT_ID('EL_GROUP_BY.Estado_Publicacion') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Estado_Publicacion;

IF OBJECT_ID('EL_GROUP_BY.Forma_Pago') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Forma_Pago;

IF OBJECT_ID('EL_GROUP_BY.Publicacion_Ubicacion ') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Publicacion_Ubicacion 
GO

/****************************************************************
*					DROP DE TABLAS - FIN						*
****************************************************************/

/****************************************************************
*			DROP DE SPs DE MIGRACIÓN - COMIENZO					*
****************************************************************/

IF OBJECT_ID('EL_GROUP_BY.CARGAR_USUARIOS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_USUARIOS;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_CLIENTES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_CLIENTES;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_EMPRESAS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_EMPRESAS;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_ROLES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_ROLES;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_FUNCIONALIDADES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_FUNCIONALIDADES;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_ROLES_X_USUARIO') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_ROLES_X_USUARIO;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_ROLES_X_FUNCIONALIDAD') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_ROLES_X_FUNCIONALIDAD;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_FORMAS_PAGO') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_FORMAS_PAGO;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_UBICACION_TIPOS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_UBICACION_TIPOS;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_RUBROS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_RUBROS;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_ESTADOS_PUBLICACION') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_ESTADOS_PUBLICACION;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_GRADOS_PUBLICACION') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_GRADOS_PUBLICACION;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_ESPECTACULOS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_ESPECTACULOS;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_PUBLICACIONES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_PUBLICACIONES;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_UBICACIONES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_UBICACIONES;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_PUBLICACION_UBICACION') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_PUBLICACION_UBICACION;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_FACTURAS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_FACTURAS;

IF OBJECT_ID('EL_GROUP_BY.CARGAR_COMPRAS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_COMPRAS;
GO

/****************************************************************
*			DROP DE SPs DE MIGRACIÓN - FIN					*
****************************************************************/

/****************************************************************
*					DROP DE SPs - COMIENZO						*
****************************************************************/

IF OBJECT_ID('EL_GROUP_BY.BUSCAR_USUARIO') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.BUSCAR_USUARIO;

IF OBJECT_ID('EL_GROUP_BY.REG_INTENTO_FALLIDO') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.REG_INTENTO_FALLIDO;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_ID_USUARIO') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_ID_USUARIO;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_CANT_ROLES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_CANT_ROLES;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_ROLES_ACTIVOS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_ROLES_ACTIVOS;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_FUNCIONALIDADES_X_ROL') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_FUNCIONALIDADES_X_ROL;

IF OBJECT_ID('EL_GROUP_BY.GUARDAR_ROL') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.GUARDAR_ROL;

IF OBJECT_ID('EL_GROUP_BY.DAME_ID_X_NOMBRE') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.DAME_ID_X_NOMBRE;

IF OBJECT_ID('EL_GROUP_BY.ELIMINAR_ROL') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.ELIMINAR_ROL;

IF OBJECT_ID('EL_GROUP_BY.AGREGAR_FUNCIONALIDAD_A_ROL') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.AGREGAR_FUNCIONALIDAD_A_ROL;

IF OBJECT_ID('EL_GROUP_BY.ELIMINAR_FUNCIONALIDAD_A_ROL') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.ELIMINAR_FUNCIONALIDAD_A_ROL;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_FUNCIONES_X_ROL') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.LISTAR_FUNCIONES_X_ROL;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_FUNCIONES_X_ROL_NO_ASIGNADAS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.LISTAR_FUNCIONES_X_ROL_NO_ASIGNADAS;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_CLIENTES_EXISTENTES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.LISTAR_CLIENTES_EXISTENTES;

IF OBJECT_ID('EL_GROUP_BY.CREAR_CLIENTE') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CREAR_CLIENTE;

IF OBJECT_ID('EL_GROUP_BY.ACTUALIZAR_CLIENTE') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.ACTUALIZAR_CLIENTE;

IF OBJECT_ID('EL_GROUP_BY.ELIMINAR_CLIENTE') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.ELIMINAR_CLIENTE;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_USER_FOR_MODIFY') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_USER_FOR_MODIFY;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_DATOS_CLIENTE_X_ID') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_DATOS_CLIENTE_X_ID;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_HISTORIAL_CLIENTE_ID') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_HISTORIAL_CLIENTE_ID ;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_EMPRESAS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.LISTAR_EMPRESAS;

IF OBJECT_ID('EL_GROUP_BY.ELIMINAR_EMPRESA') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.ELIMINAR_EMPRESA;

IF OBJECT_ID('EL_GROUP_BY.CREAR_EMPRESA') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CREAR_EMPRESA;

IF OBJECT_ID('EL_GROUP_BY.ACTUALIZAR_EMPRESA') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.ACTUALIZAR_EMPRESA;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_EMPRESA_FOR_MODIFY') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_EMPRESA_FOR_MODIFY;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_GRADOS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.LISTAR_GRADOS;

IF OBJECT_ID('EL_GROUP_BY.ELIMINAR_GRADO') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.ELIMINAR_GRADO;

IF OBJECT_ID('EL_GROUP_BY.CREAR_GRADO') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CREAR_GRADO;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_GRADO_FOR_MODIFY') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_GRADO_FOR_MODIFY;

IF OBJECT_ID('EL_GROUP_BY.ACTUALIZAR_GRADO') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.ACTUALIZAR_GRADO;


/****************************************************************
*					DROP DE SPs - FIN							*
****************************************************************/

/****************************************************************
*				DROP DE FUNCIONES - COMIENZO					*
****************************************************************/
IF OBJECT_ID('EL_GROUP_BY.FUNC_COD_USUARIO') IS NOT NULL
	DROP FUNCTION EL_GROUP_BY.FUNC_COD_USUARIO;

IF OBJECT_ID('EL_GROUP_BY.FUNC_ID_EMPRESA') IS NOT NULL
	DROP FUNCTION EL_GROUP_BY.FUNC_ID_EMPRESA;

IF OBJECT_ID('EL_GROUP_BY.FUNC_ID_RUBRO') IS NOT NULL
	DROP FUNCTION EL_GROUP_BY.FUNC_ID_RUBRO;

IF OBJECT_ID('EL_GROUP_BY.FUNC_ID_UBICACION_TIPO') IS NOT NULL
	DROP FUNCTION EL_GROUP_BY.FUNC_ID_UBICACION_TIPO;

IF OBJECT_ID('EL_GROUP_BY.FUNC_ID_CLIENTE') IS NOT NULL
	DROP FUNCTION EL_GROUP_BY.FUNC_ID_CLIENTE;

GO
/****************************************************************
*					DROP DE FUNCIONES - FIN						*
****************************************************************/

/****************************************************************
*				CREACIÓN DE ESQUEMA - EL_GROUP_BY				*
****************************************************************/

IF (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'EL_GROUP_BY') IS NOT NULL
	DROP SCHEMA EL_GROUP_BY
GO

CREATE SCHEMA [EL_GROUP_BY] AUTHORIZATION [gdEspectaculos2018]
GO 

/****************************************************************
*					CONFIGURACIONES - COMIENZO					*
****************************************************************/

SET NOCOUNT ON
GO


/****************************************************************
*					CONFIGURACIONES - FIN						*
****************************************************************/

/****************************************************************
*				CREACIÓN DE TABLAS - COMIENZO					*
****************************************************************/
-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Rol
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Rol (
		Rol_ID INT IDENTITY(1,1),
		Rol_Nombre NVARCHAR(20) NOT NULL,
		Rol_Habilitado BIT NOT NULL,
	PRIMARY KEY (Rol_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Funcionalidad
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Funcionalidad (
		Funcionalidad_ID INT IDENTITY(1,1),
		Funcionalidad_Nombre NVARCHAR(30) NOT NULL,
		Funcionalidad_visible BIT,
	PRIMARY KEY (Funcionalidad_ID))
;
-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Rol_Funcionalidad
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Rol_Funcionalidad (
		Rol_ID INT NOT NULL,
		Funcionalidad_ID INT NOT NULL,
	PRIMARY KEY (Funcionalidad_ID, Rol_ID),
	CONSTRAINT FK_Rol_Funcionalidad_Rol_ID FOREIGN KEY (Rol_ID)
		REFERENCES EL_GROUP_BY.Rol (Rol_ID)
		ON DELETE CASCADE    
		ON UPDATE CASCADE,
	CONSTRAINT FK_Rol_Funcionalidad_Funcionalidad_ID FOREIGN KEY (Funcionalidad_ID)     
		REFERENCES EL_GROUP_BY.Funcionalidad (Funcionalidad_ID)
		ON DELETE CASCADE    
		ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Usuario
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Usuario (
		Usuario_ID INT NOT NULL IDENTITY(1,1),
		Usuario_Username NVARCHAR(50) NOT NULL,
		Usuario_Password NVARCHAR(256) NOT NULL,
		Usuario_Tipo NVARCHAR(20) NOT NULL,
		Usuario_Habilitado BIT NOT NULL,
		Usuario_Intentos SMALLINT NOT NULL,
		Usuario_Primer_Login BIT,
		Usuario_Telefono NVARCHAR(20),
		Usuario_Calle NVARCHAR(50),
		Usuario_Numero_Calle NUMERIC(18,0),
		Usuario_Piso NUMERIC(18,0),
		Usuario_Depto NVARCHAR(50),
		Usuario_Codigo_Postal NVARCHAR(50),
		Usuario_Localidad NVARCHAR(50),
		Usuario_Mail NVARCHAR(255)
	PRIMARY KEY (Usuario_ID))
;

CREATE UNIQUE INDEX Usuario_Username_UNIQUE ON EL_GROUP_BY.Usuario (Usuario_Username ASC);

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Rol_Usuario
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Rol_Usuario(
		Usuario_ID int,
		Rol_ID int not null,
		Rol_Usuario_Estado BIT NOT NULL,
	PRIMARY KEY (Usuario_ID, Rol_ID),
	CONSTRAINT FK_Rol_Usuario_Rol_ID FOREIGN KEY (Rol_ID)
		REFERENCES EL_GROUP_BY.Rol (Rol_ID)
		ON DELETE CASCADE    
		ON UPDATE CASCADE,
	CONSTRAINT FK_Rol_Usuario_Usuario_ID FOREIGN KEY (Usuario_ID)     
		REFERENCES EL_GROUP_BY.Usuario (Usuario_ID)
		ON DELETE CASCADE    
		ON UPDATE CASCADE)
;

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

CREATE UNIQUE INDEX Cliente_Numero_Documento_UNIQUE ON EL_GROUP_BY.Cliente (Cliente_Numero_Documento ASC);

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

CREATE UNIQUE INDEX Empresa_Cuit_UNIQUE ON EL_GROUP_BY.Empresa (Empresa_Cuit ASC);

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Rubro
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Rubro (
		Rubro_ID INT IDENTITY(1,1),
		Rubro_Descripcion NVARCHAR(255) NOT NULL,
	PRIMARY KEY (Rubro_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Espectaculo
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Espectaculo (
		Espectaculo_ID INT IDENTITY(1,1),
		Espectaculo_Codigo NUMERIC(18,0) NOT NULL,
		Espectaculo_Descripcion NVARCHAR(255) NOT NULL,
		Espectaculo_Direccion NVARCHAR(255),
		Espectaculo_Fecha DATETIME NOT NULL,
		Espectaculo_Fecha_Vencimiento DATETIME NOT NULL,
		Espectaculo_Estado NVARCHAR(255) NOT NULL,
		Rubro_ID INT NOT NULL,
		Empresa_ID INT NOT NULL,
	PRIMARY KEY (Espectaculo_ID),
	CONSTRAINT FK_Espectaculo_Empresa_ID FOREIGN KEY (Empresa_ID)
		REFERENCES EL_GROUP_BY.Empresa (Empresa_ID)
		ON DELETE CASCADE    
		ON UPDATE CASCADE,  
	CONSTRAINT FK_Espectaculo_Rubro_ID FOREIGN KEY (Rubro_ID)
		REFERENCES EL_GROUP_BY.Rubro (Rubro_ID)     
		ON DELETE CASCADE    
		ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Ubicacion_Tipo
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Ubicacion_Tipo (
		Ubicacion_Tipo_ID INT IDENTITY(1,1),
		Ubicacion_Tipo_Codigo NUMERIC(18,0) NOT NULL,
		Ubicacion_Tipo_Descripcion NVARCHAR(255) NOT NULL,
	PRIMARY KEY (Ubicacion_Tipo_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Ubicacion
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Ubicacion (
		Ubicacion_ID INT IDENTITY(1,1),
		Ubicacion_Fila VARCHAR(3) NULL,
		Ubicacion_Asiento NUMERIC(18,0) NULL,
		Ubicacion_Sin_Numerar BIT NOT NULL,
		Ubicacion_Precio NUMERIC(18,0) NOT NULL,
		Ubicacion_Disponible BIT NOT NULL,
		Ubicacion_Tipo_ID INT NOT NULL,
		Ubicacion_Canjeada BIT NOT NULL,
		Ubicacion_Fecha_Canje DATETIME NULL,
		Ubicacion_Cliente_Canje INT NULL
	PRIMARY KEY (Ubicacion_ID),
	CONSTRAINT FK_Ubicacion_Tipo_ID FOREIGN KEY (Ubicacion_Tipo_ID)     
		REFERENCES EL_GROUP_BY.Ubicacion_Tipo (Ubicacion_Tipo_ID)     
	    ON DELETE CASCADE    
		ON UPDATE CASCADE,
	CONSTRAINT FK_Ubicacion_Cliente_Canje_ID FOREIGN KEY (Ubicacion_Cliente_Canje)     
		REFERENCES EL_GROUP_BY.Cliente (Cliente_ID)     
	    ON DELETE CASCADE    
		ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Grado_Publicacion
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Grado_Publicacion (
		Grado_Publicacion_ID INT IDENTITY(1,1),
		Grado_Publicacion_Comision NUMERIC(3,3) NOT NULL,
		Grado_Publicacion_Prioridad NVARCHAR(10) NOT NULL,
		Grado_Publicacion_Habilitado BIT NOT NULL,
	PRIMARY KEY (Grado_Publicacion_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Publicacion
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Publicacion (
		Publicacion_ID INT IDENTITY(1,1),
		Publicacion_Descripcion NVARCHAR(255),
		Publicacion_Fecha DATETIME,
		Publicacion_FechaHora DATETIME,
		Publicacion_Cantidad_Localidades NUMERIC(7,0) NOT NULL,
		Publicacion_Usuario NVARCHAR(50) NOT NULL,
		Espectaculo_ID INT NOT NULL,
		Grado_Publicacion_ID INT NOT NULL,
		Estado_Publicacion_ID INT NOT NULL,
  PRIMARY KEY (Publicacion_ID),
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
-- Creación de Tabla EL_GROUP_BY.Estado_Publicacion
-- -----------------------------------------------------
	       
CREATE TABLE EL_GROUP_BY.Estado_Publicacion (
		Estado_Publicacion_ID INT IDENTITY(1,1),
		Estado_Publicacion_Descripcion NVARCHAR(255) NOT NULL,
		Estado_Publicacion_Modificable BIT NOT NULL,
	PRIMARY KEY (Estado_Publicacion_ID))
;
	
-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Factura
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Factura (
		Factura_ID INT IDENTITY(1,1),
		Factura_Nro NUMERIC(18,0) NOT NULL,
		Factura_Fecha DATETIME NOT NULL,
		Factura_Total NUMERIC(18,2) NOT NULL,
		Factura_Empresa_ID VARCHAR(45) NULL,
  PRIMARY KEY (Factura_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Forma_Pago
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Forma_Pago (
		Forma_Pago_ID INT IDENTITY(1,1),
		Forma_Pago_Descripcion NVARCHAR(255) NOT NULL,
	PRIMARY KEY (Forma_Pago_ID))
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Compra
-- -----------------------------------------------------

CREATE TABLE EL_GROUP_BY.Compra (
		Compra_ID INT IDENTITY(1,1),
		Compra_Fecha DATETIME NOT NULL,
		Compra_Cantidad NUMERIC(18,0) NOT NULL,
		Compra_Monto_Total DECIMAL(18,2) NOT NULL,
		Compra_Rendida BIT NOT NULL,
		Cliente_ID INT NOT NULL,
		Forma_Pago_ID INT NOT NULL,
	PRIMARY KEY (Compra_ID),
	CONSTRAINT FK_Compra_Usuario_ID FOREIGN KEY (Cliente_ID)     
		REFERENCES EL_GROUP_BY.Cliente (Cliente_ID)     
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
		Item_ID INT IDENTITY(1,1),
		Item_Monto NUMERIC(18,2) NOT NULL,
		Item_Cantidad NUMERIC(18,0) NOT NULL,
		Item_Descripcion NVARCHAR(60) NOT NULL,
		Factura_ID INT NOT NULL,
		Compra_ID INT NOT NULL,
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
		Puntos_ID INT IDENTITY(1,1),
		Puntos_Cantidad NUMERIC(18,0) NOT NULL,
		Puntos_Fecha_Vencimiento DATETIME NOT NULL,
		Cliente_ID INT NOT NULL,
	PRIMARY KEY (Puntos_ID),
	CONSTRAINT FK_Puntos_Cliente_ID FOREIGN KEY (Cliente_ID)     
		REFERENCES EL_GROUP_BY.Cliente (Cliente_ID)     
		ON DELETE CASCADE    
		ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Publicacion_Ubicacion
-- -----------------------------------------------------
CREATE TABLE EL_GROUP_BY.Publicacion_Ubicacion (
		Ubicacion_ID INT NOT NULL,
		Publicacion_ID INT NOT NULL,
		Compra_ID INT NULL,
	PRIMARY KEY (Ubicacion_ID, Publicacion_ID))
;
GO

/****************************************************************
*					CREACIÓN DE TABLAS - FIN					*
****************************************************************/
	       

/****************************************************************
*					FUNCIONES - COMIENZO						*
****************************************************************/

-- ---------------------------------------------
-- ME DEVUELVE EL ID_USUARIO
-- ---------------------------------------------
CREATE FUNCTION EL_GROUP_BY.FUNC_COD_USUARIO(@USU NVARCHAR(50))
RETURNS INT
AS
BEGIN
	DECLARE @RESULTADO INT
	SELECT @RESULTADO = Usuario_ID FROM EL_GROUP_BY.USUARIO WHERE Usuario_Username = @USU
	RETURN @RESULTADO
END;
GO

-- ---------------------------------------------
-- ME DEVUELVE EL ID_EMPRESA
-- ---------------------------------------------
CREATE FUNCTION EL_GROUP_BY.FUNC_ID_EMPRESA(@EMPRESA_RAZON NVARCHAR(255),@EMPRESA_CUIT NVARCHAR(255))
RETURNS INT
AS
BEGIN
	DECLARE @RESULTADO INT
	SELECT @RESULTADO = Empresa_ID 
	FROM EL_GROUP_BY.Empresa 
	WHERE Empresa_Razon_Social = @EMPRESA_RAZON AND
		  Empresa_Cuit = @EMPRESA_CUIT
	RETURN @RESULTADO
END;
GO

-- ---------------------------------------------
-- ME DEVUELVE EL ID_RUBRO
-- ---------------------------------------------
CREATE FUNCTION EL_GROUP_BY.FUNC_ID_RUBRO(@RUBRO_DESCRIPCION NVARCHAR(255))
RETURNS INT
AS
BEGIN
	DECLARE @RESULTADO INT
	SELECT @RESULTADO = Rubro_ID 
	FROM EL_GROUP_BY.Rubro 
	WHERE Rubro_Descripcion = @RUBRO_DESCRIPCION
	RETURN @RESULTADO
END;
GO

-- ---------------------------------------------
-- ME DEVUELVE EL ID_Ubicacion_Tipo
-- ---------------------------------------------
CREATE FUNCTION EL_GROUP_BY.FUNC_ID_UBICACION_TIPO(@TIPO_CODIGO NVARCHAR(255))
RETURNS INT
AS
BEGIN
	DECLARE @RESULTADO INT
	SELECT @RESULTADO = Ubicacion_Tipo_ID 
	FROM EL_GROUP_BY.Ubicacion_Tipo 
	WHERE Ubicacion_Tipo_Codigo = @TIPO_CODIGO
	RETURN @RESULTADO
END;
GO

-- ---------------------------------------------
-- ME DEVUELVE EL ID_CLIENTE
-- ---------------------------------------------
CREATE FUNCTION EL_GROUP_BY.FUNC_ID_CLIENTE(@CLIENTE_NOMBRE NVARCHAR(255),@CLIENTE_NUMERO_DOCUMENTO NUMERIC(18,0))
RETURNS INT
AS
BEGIN
	DECLARE @RESULTADO INT
	SELECT @RESULTADO = Cliente_ID 
	FROM EL_GROUP_BY.Cliente 
	WHERE Cliente_Nombre = @CLIENTE_NOMBRE AND
		  Cliente_Numero_Documento = @CLIENTE_NUMERO_DOCUMENTO
	RETURN @RESULTADO
END;
GO


/****************************************************************
*					FUNCIONES - FIN								*
****************************************************************/

/****************************************************************
*			SPs DE MIGRACIÓN (SPMigra) - COMIENZO		        *
****************************************************************/

-- -----------------------------------------------------
-- SPMigra-- Cargar Usuarios
-- -----------------------------------------------------

CREATE PROC EL_GROUP_BY.CARGAR_USUARIOS
AS
BEGIN TRAN
	INSERT INTO EL_GROUP_BY.USUARIO
					 SELECT DISTINCT (Cli_Nombre + CONVERT(NVARCHAR(50),Cli_Dni))
					,HASHBYTES('SHA2_256', CONVERT(NVARCHAR(50),Cli_Dni))
					,'CLIENTE'
					,1
					,0
					,0
					,null
					,Cli_Dom_Calle
					,Cli_Nro_Calle
					,Cli_Piso
					,Cli_Depto
					,Cli_Cod_Postal
					,null
					,Cli_Mail
		FROM gd_esquema.Maestra
		WHERE Cli_Dni IS NOT NULL
		UNION
		SELECT DISTINCT (Espec_Empresa_Razon_Social + CONVERT(NVARCHAR(50),Espec_Empresa_Cuit))
					,HASHBYTES('SHA2_256', CONVERT(NVARCHAR(50),Espec_Empresa_Cuit))
					,'EMPRESA'
					,1
					,0
					,0
					,null
					,Espec_Empresa_Dom_Calle
					,Espec_Empresa_Nro_Calle
					,Espec_Empresa_Piso
					,Espec_Empresa_Depto
					,Espec_Empresa_Cod_Postal
					,null
					,Espec_Empresa_Mail
		FROM gd_esquema.Maestra
		WHERE Espec_Empresa_Cuit IS NOT NULL

	INSERT INTO EL_GROUP_BY.USUARIO VALUES
		(CONVERT(NVARCHAR(50),'admin')
		,HASHBYTES('SHA2_256', CONVERT(NVARCHAR(50),'w23e'))
		,'ADMINISTRADOR'
		,1
		,0
		,0
		,'42612123'
		,'Calle Falsa'
		,123
		,null
		,null
		,'1842'
		,'Echeverria'
		,'admin@frba.com')
COMMIT
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar Clientes
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
					,(select getdate())
					,EL_GROUP_BY.FUNC_COD_USUARIO(Cli_Nombre + CONVERT(NVARCHAR(50),Cli_Dni))
		FROM gd_esquema.Maestra
		WHERE Cli_Dni IS NOT NULL
		ORDER BY Cli_Dni

	-- Acá cargaremos al admin como un cliente más
/*	INSERT INTO EL_GROUP_BY.Cliente
		VALUES ('admin'
			,'admin'
			,'DNI'
			,35123123
			,'20-35123123-4'
			,CONVERT(DATETIME,'1990/02/02 00:00:00',121)
			,'SANTANDER RIO'
			,4242424242424242
			,CONVERT(DATETIME,'2018/02/02 00:00:00',121)
			,783)*/
COMMIT
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar Empresas
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_EMPRESAS AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Empresa
	SELECT DISTINCT Espec_Empresa_Razon_Social
		            ,Espec_Empresa_Cuit
					,null
					,Espec_Empresa_Fecha_Creacion
					,EL_GROUP_BY.FUNC_COD_USUARIO(Espec_Empresa_Razon_Social + CONVERT(NVARCHAR(50),Espec_Empresa_Cuit))
		FROM gd_esquema.Maestra
		WHERE Espec_Empresa_Cuit IS NOT NULL

	-- Acá cargaremos al admin como una empresa más
	INSERT INTO EL_GROUP_BY.Empresa
		VALUES ('RAZON SOCIAL X'
		    ,'30-71031609-7'
			,'Baires'
			,CONVERT(DATETIME,'1980/02/02 00:00:00',121)
			,783)
COMMIT
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar Roles
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_ROLES AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.ROL VALUES ('CLIENTE',1)
	INSERT INTO EL_GROUP_BY.ROL VALUES ('EMPRESA',1)
	INSERT INTO EL_GROUP_BY.ROL VALUES ('ADMINISTRADOR',1)
COMMIT;
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar Funcionalidades
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_FUNCIONALIDADES AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('ABM_ROL',1)
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('ABM_CLIENTE',1)
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('ABM_EMPRESA',1)
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('ABM_RUBRO',1)
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('ABM_GRADO_PUBLICACION',1)
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('GENERAR_PUBLICACION',1)
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('EDITAR_PUBLICACION',1)
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('COMPRAR',1)
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('HISTORIAL_CLIENTE',1)
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('CANJE_ADMINISTRACION_PUNTOS',1)
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('GENERAR_PAGO_COMISIONES',1)
	INSERT INTO EL_GROUP_BY.FUNCIONALIDAD VALUES ('LISTADO_ESTADISTICO',1)
COMMIT;
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar Roles_X_Usuario
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_ROLES_X_USUARIO AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.ROL_USUARIO
			SELECT Usuario_ID,
					1,
					1
			FROM EL_GROUP_BY.USUARIO
			WHERE Usuario_Username = 'admin'
	UNION
			SELECT Usuario_ID,
					2,
					1
		FROM EL_GROUP_BY.USUARIO
		WHERE Usuario_Username = 'admin'
	UNION
			SELECT Usuario_ID,
					3,
					1
		FROM EL_GROUP_BY.USUARIO
		WHERE Usuario_Username = 'admin'
	UNION
		SELECT USUARIO_ID,
				ROL_ID,
				1
			FROM EL_GROUP_BY.Cliente, EL_GROUP_BY.ROL
			WHERE Rol_Nombre = 'CLIENTE'
	UNION
		SELECT USUARIO_ID,
				ROL_ID,
				1
			FROM EL_GROUP_BY.Empresa, EL_GROUP_BY.ROL
			WHERE Rol_Nombre = 'EMPRESA'

COMMIT;
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar Roles_X_Funcionalidad
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_ROLES_X_FUNCIONALIDAD AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.ROL_FUNCIONALIDAD
		SELECT Rol_ID,
				Funcionalidad_ID
			FROM EL_GROUP_BY.ROL R, EL_GROUP_BY.FUNCIONALIDAD F
			WHERE R.Rol_Nombre = 'ADMINISTRADOR' AND
					(F.Funcionalidad_ID = 1 OR
					F.Funcionalidad_ID = 2 OR
					F.Funcionalidad_ID = 3)
	UNION
		SELECT Rol_ID,
				Funcionalidad_ID
			FROM EL_GROUP_BY.ROL R, EL_GROUP_BY.FUNCIONALIDAD F
			WHERE R.Rol_Nombre = 'CLIENTE' AND
					(F.Funcionalidad_ID = 8 OR
					F.Funcionalidad_ID = 9 OR
					F.Funcionalidad_ID = 10 OR
					F.Funcionalidad_ID = 12)
	UNION
		SELECT Rol_ID,
				Funcionalidad_ID
			FROM EL_GROUP_BY.ROL R, EL_GROUP_BY.FUNCIONALIDAD F
			WHERE R.Rol_Nombre = 'EMPRESA' AND
					(F.Funcionalidad_ID = 4 OR
						F.Funcionalidad_ID = 5 OR
						F.Funcionalidad_ID = 6 OR
						F.Funcionalidad_ID = 7 OR
						F.Funcionalidad_ID = 11)
COMMIT TRANSACTION;
GO
									      
-- -----------------------------------------------------
-- SPMigra -- Cargar Formas_Pago
-- -----------------------------------------------------
									      
CREATE PROCEDURE EL_GROUP_BY.CARGAR_FORMAS_PAGO AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Forma_Pago
		SELECT DISTINCT Forma_Pago_Desc
			FROM gd_esquema.Maestra M
			WHERE M.Forma_Pago_Desc IS NOT NULL

	INSERT INTO EL_GROUP_BY.Forma_Pago VALUES ('Tarjeta de Credito') -- Creamos la forma de pago TC mencionada en la Estrategia

COMMIT TRANSACTION;	
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar Ubicacion_Tipo
-- -----------------------------------------------------
									      
CREATE PROCEDURE EL_GROUP_BY.CARGAR_UBICACION_TIPOS AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Ubicacion_Tipo
		SELECT DISTINCT Ubicacion_Tipo_Codigo
					,Ubicacion_Tipo_Descripcion
			FROM gd_esquema.Maestra M
			WHERE Ubicacion_Tipo_Codigo IS NOT NULL
COMMIT TRANSACTION;	
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar Rubros
-- -----------------------------------------------------
									      
CREATE PROCEDURE EL_GROUP_BY.CARGAR_RUBROS AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Rubro
		SELECT DISTINCT Espectaculo_Rubro_Descripcion
			FROM gd_esquema.Maestra M
			WHERE M.Espectaculo_Rubro_Descripcion IS NOT NULL
COMMIT TRANSACTION;	
GO	
									      
-- -----------------------------------------------------
-- SPMigra -- Cargar Estados_Publicacion
-- -----------------------------------------------------
									      
CREATE PROCEDURE EL_GROUP_BY.CARGAR_ESTADOS_PUBLICACION AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Estado_Publicacion VALUES ('BORRADOR',1)
	INSERT INTO EL_GROUP_BY.Estado_Publicacion VALUES ('ACTIVA',0)
	INSERT INTO EL_GROUP_BY.Estado_Publicacion VALUES ('FINALIZADA',0)
COMMIT;
GO	   

-- -----------------------------------------------------
-- SPMigra -- Cargar Grados_Publicacion
-- -----------------------------------------------------
									      														 
CREATE PROCEDURE EL_GROUP_BY.CARGAR_GRADOS_PUBLICACION AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Grado_Publicacion VALUES (0,'BAJA',1)
	INSERT INTO EL_GROUP_BY.Grado_Publicacion VALUES (0,'MEDIA',1)
	INSERT INTO EL_GROUP_BY.Grado_Publicacion VALUES (0,'ALTA',1)
COMMIT;
GO	
-- -----------------------------------------------------
-- SPMigra -- Cargar Espectaculos
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_ESPECTACULOS AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Espectaculo
		SELECT DISTINCT Espectaculo_Cod
		            ,Espectaculo_Descripcion
					,null
					,Espectaculo_Fecha
					,Espectaculo_Fecha_Venc
					,Espectaculo_Estado
					,EL_GROUP_BY.FUNC_ID_RUBRO(Espectaculo_Rubro_Descripcion)
					,EL_GROUP_BY.FUNC_ID_EMPRESA(Espec_Empresa_Razon_Social, Espec_Empresa_Cuit)
		FROM gd_esquema.Maestra 
		WHERE Espec_Empresa_Cuit IS NOT NULL
COMMIT TRANSACTION;
GO
-- -----------------------------------------------------
-- SPMigra -- Cargar Publicaciones
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_PUBLICACIONES AS
BEGIN TRANSACTION
	DECLARE @CANT_ESPEC_ID INT
	DECLARE @ESPEC_ID INT
	SET @CANT_ESPEC_ID = (SELECT COUNT(Espectaculo_ID)
						  FROM EL_GROUP_BY.Espectaculo )
	SET @ESPEC_ID = 1
	WHILE @ESPEC_ID <= @CANT_ESPEC_ID
	BEGIN
		INSERT INTO EL_GROUP_BY.Publicacion VALUES(
						 null
				        ,null
						,null
						,0
						,'MIGRA'
						,@ESPEC_ID
						,1 --Migro directamente Grado_Publicacion_ID = 1
						,1)  -- Migramos como 1 - Borrador en primera instancia
		SET @ESPEC_ID = @ESPEC_ID + 1
	END
COMMIT TRANSACTION;
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar Ubicaciones
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_UBICACIONES AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Ubicacion
		SELECT DISTINCT  Ubicacion_Fila
						,Ubicacion_Asiento
						,Ubicacion_Sin_numerar
						,Ubicacion_Precio
						,0 -- Ubicacion_Disponible Migramos como NO por ahora
						,EL_GROUP_BY.FUNC_ID_UBICACION_TIPO(Ubicacion_Tipo_Codigo)
						,0 -- NO Canjeada dado que el canje de puntos es una funcionalidad nueva
						,NULL -- fecha de canje - idem campo anterior
						,NULL -- Cliente de Canje - idem campo anterior
		FROM gd_esquema.Maestra
COMMIT TRANSACTION;
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar relacion Publicacion_Ubicacion
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_PUBLICACION_UBICACION AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Publicacion_Ubicacion
		SELECT DISTINCT U.Ubicacion_ID
				,P.Publicacion_ID
				,NULL -- La compra la voy a relacionar luego
		FROM EL_GROUP_BY.Ubicacion U,
			 EL_GROUP_BY.Publicacion P,
			 EL_GROUP_BY.Espectaculo E,
			 gd_esquema.Maestra M
		WHERE U.Ubicacion_Fila = M.Ubicacion_Fila AND
			  U.Ubicacion_Asiento = M.Ubicacion_Asiento AND
			  U.Ubicacion_Sin_Numerar = M.Ubicacion_Sin_numerar AND
			  U.Ubicacion_Precio = M.Ubicacion_Precio AND
			  E.Espectaculo_Codigo = M.Espectaculo_Cod AND
			  P.Espectaculo_ID = E.Espectaculo_ID 	
COMMIT TRANSACTION;
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar Facturas
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_FACTURAS AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Factura
		SELECT DISTINCT  Factura_Nro
						,Factura_Fecha
						,Factura_Total
						,EL_GROUP_BY.FUNC_ID_EMPRESA(Espec_Empresa_Razon_Social, Espec_Empresa_Cuit)
		FROM gd_esquema.Maestra
		WHERE Factura_Nro IS NOT NULL
COMMIT TRANSACTION;
GO

-- -----------------------------------------------------
-- SPMigra -- Cargar Compras
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_COMPRAS AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Compra
		SELECT DISTINCT  M.Compra_Fecha
						,M.Compra_Cantidad
						,0 -- POR AHORA 0 LUEGO PODEMOS CALCULAR EL MONTO (0, pq no admite NULL la def de la tabla)
						,RENDIDO = CASE (SELECT COUNT(M2.Factura_Nro)
										 FROM gd_esquema.Maestra M2
										 WHERE M.Cli_Dni = M2.Cli_Dni  AND
											   M.Cli_Nombre = M2.Cli_Nombre AND
											   M.Compra_Fecha = M2.Compra_Fecha   AND
											   M.Compra_Cantidad = M2.Compra_Cantidad)
								   WHEN 0 THEN 0
								   ELSE 1
								   END
						,EL_GROUP_BY.FUNC_ID_CLIENTE(Cli_Nombre, Cli_Dni)
						,1
		FROM gd_esquema.Maestra M 
		GROUP BY M.Cli_Dni, M.Cli_Nombre, M.Compra_Fecha, M.Compra_Cantidad, M.Espectaculo_Cod, 
				 M.Ubicacion_Asiento, M.Ubicacion_Fila, M.Ubicacion_Precio, M.Ubicacion_Sin_numerar
		HAVING M.Cli_Dni IS NOT NULL AND M.Cli_Nombre IS NOT NULL AND M.Compra_Fecha IS NOT NULL AND M.Compra_Cantidad IS NOT NULL
COMMIT TRANSACTION;
GO

/*-- -----------------------------------------------------
-- SPMigra -- Cargar Ubicaciones Compradas
-- -----------------------------------------------------
													 
CREATE PROCEDURE EL_GROUP_BY.CARGAR_UBICACIONES_COMPRADAS AS
BEGIN TRANSACTION
    DECLARE @CLIENTE_NOMBRE NVARCHAR(255)
	DECLARE @CLIENTE_NUMERO_DOCUMENTO NUMERIC(18,0)
	 NVARCHAR(255)
	 
	UPDATE EL_GROUP_BY.Publicacion_Ubicacion
	SET Compra_ID = EL_GROUP_BY.f
	WHERE 
				SELECT DISTINCT 
COMMIT TRANSACTION;
GO*/			----------------------------------------------CONTINUAR MAÑANA ------------------------------

/****************************************************************
*				SPs DE MIGRACIÓN (SPMigra) - FIN				*
****************************************************************/
					      
									      
/****************************************************************
*						SPs (SP) - COMIENZO						*
****************************************************************/


-- -----------------------------------------------------
-- SP - Buscar Usuario
-- -----------------------------------------------------

create procedure EL_GROUP_BY.BUSCAR_USUARIO @Usuario nvarchar(50), @Password nvarchar(50)
as
begin 
	declare @habilitado bit
	declare @cant_int_fallido int

	select @habilitado = Usuario_Habilitado from EL_GROUP_BY.USUARIO where Usuario_Username =  @Usuario and Usuario_Password = HASHBYTES('SHA2_256', @Password)
	select @cant_int_fallido = Usuario_Intentos from EL_GROUP_BY.USUARIO where Usuario_Username = @Usuario

	if not exists(select 1 from EL_GROUP_BY.USUARIO where Usuario_Username = @Usuario)
		select 0 as estado
	if exists(select 1 from EL_GROUP_BY.USUARIO where Usuario_Username = @Usuario and Usuario_Password <> HASHBYTES('SHA2_256', @Password))
		if (@cant_int_fallido = 3) 
			begin
				update EL_GROUP_BY.USUARIO set Usuario_Habilitado = 0 where Usuario_Username = @Usuario
				select 2 as estado
			end
		else select 1 as estado
	if @habilitado = 0
		select 2 as estado
	if @habilitado = 1
		begin
			if @cant_int_fallido = 1 or @cant_int_fallido = 2
				update EL_GROUP_BY.USUARIO set Usuario_Intentos = 0 where Usuario_Username = @Usuario
			select 3 as estado
		end
end
go

-- -----------------------------------------------------
-- SP - Intento Fallido
-- -----------------------------------------------------

create procedure EL_GROUP_BY.REG_INTENTO_FALLIDO @Usuario varchar(50)
as
begin
	declare @cant_int_fallido int
	select @cant_int_fallido = Usuario_Intentos from EL_GROUP_BY.USUARIO where Usuario_Username = @Usuario

	if @cant_int_fallido between 0 and 2
		update EL_GROUP_BY.USUARIO set Usuario_Intentos = Usuario_Intentos + 1 where Usuario_Username = @Usuario
end
go

-- -----------------------------------------------------
-- SP - Obtener ID Usuario
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_ID_USUARIO @USUARIO varchar(50)
as
begin
	select USUARIO_ID from EL_GROUP_BY.USUARIO where Usuario_Username = @USUARIO
end
go

-- -----------------------------------------------------
-- SP - Cantidad de Roles del Usuario
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_CANT_ROLES @USU_ID int
as
begin
	select count(USUARIO_ID) from EL_GROUP_BY.ROL_USUARIO where USUARIO_ID = @USU_ID and ROL_USUARIO_ESTADO = 1  
end
go

-- -----------------------------------------------------
-- SP - Rol Activo
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_ROLES_ACTIVOS @ID int
as
begin
	select R.Rol_Nombre, R.ROL_ID from EL_GROUP_BY.ROL R inner join EL_GROUP_BY.ROL_USUARIO RXU 
		on R.ROL_ID = RXU.ROL_ID where RXU.USUARIO_ID = @ID and R.Rol_Habilitado = 1 
end
go

-- -----------------------------------------------------
-- SP - Funcionalidades del Rol
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_FUNCIONALIDADES_X_ROL @ROL_ID int
as
begin
	select F.Funcionalidad_ID from EL_GROUP_BY.FUNCIONALIDAD F inner join EL_GROUP_BY.ROL_FUNCIONALIDAD RXU 
		on F.Funcionalidad_ID = RXU.Funcionalidad_ID where RXU.Rol_ID = @ROL_ID and F.Funcionalidad_visible = 1 
end
go

-- -----------------------------------------------------
-- SP - Crear Rol
-- -----------------------------------------------------

create procedure EL_GROUP_BY.GUARDAR_ROL @nombre varchar(25), @habilitado bit
as
begin
	insert into EL_GROUP_BY.ROL values (@nombre, @habilitado);
end
go

-- -----------------------------------------------------
-- SP - Rol ID
-- -----------------------------------------------------

create procedure EL_GROUP_BY.DAME_ID_X_NOMBRE @nombre varchar(25)
as
begin
	select Rol_ID from EL_GROUP_BY.ROL where Rol_Nombre = @nombre 
end
go

-- -----------------------------------------------------
-- SP - Eliminar Rol
-- -----------------------------------------------------

create procedure EL_GROUP_BY.ELIMINAR_ROL @ID int
as
begin
	update EL_GROUP_BY.ROL set Rol_Habilitado = 0 where Rol_ID = @ID;
end
go

-- -----------------------------------------------------
-- SP - Agregar Funcionalidad
-- -----------------------------------------------------

create procedure EL_GROUP_BY.AGREGAR_FUNCIONALIDAD_A_ROL @ROL_ID INT, @FUNCIONALIDAD_ID INT

as
begin
	insert into EL_GROUP_BY.ROL_FUNCIONALIDAD values (@ROL_ID,@FUNCIONALIDAD_ID)
end
go

-- -----------------------------------------------------
-- SP - Quitar Funcionalidad a Rol
-- -----------------------------------------------------

create procedure EL_GROUP_BY.ELIMINAR_FUNCIONALIDAD_A_ROL @ROL_ID INT, @FUNCIONALIDAD_ID INT
as
begin
	delete from EL_GROUP_BY.ROL_FUNCIONALIDAD where Rol_ID = @ROL_ID and FUNCIONALIDAD_ID = @FUNCIONALIDAD_ID
end
go

-- -----------------------------------------------------
-- SP - Listar Funcionalidades
-- -----------------------------------------------------

create procedure EL_GROUP_BY.LISTAR_FUNCIONES_X_ROL @ROL_ID int
as
begin
	select f.* from EL_GROUP_BY.ROL_FUNCIONALIDAD as rxf inner join EL_GROUP_BY.FUNCIONALIDAD as f
		   on rxf.Funcionalidad_ID = f.Funcionalidad_ID where rxf.Rol_ID = @ROL_ID;
end
go

-- -----------------------------------------------------
-- SP - Listar Funcionalidades No Asignadas
-- -----------------------------------------------------

create procedure EL_GROUP_BY.LISTAR_FUNCIONES_X_ROL_NO_ASIGNADAS @ROL_ID int
as
begin
	select * from EL_GROUP_BY.FUNCIONALIDAD except 
									     select f.* from EL_GROUP_BY.ROL_FUNCIONALIDAD as rxf inner join EL_GROUP_BY.FUNCIONALIDAD as f
										 on rxf.Funcionalidad_ID = f.Funcionalidad_ID where rxf.Rol_ID = @ROL_ID;
end
go

-- -----------------------------------------------------
-- SP - Listar Clientes
-- -----------------------------------------------------

create procedure EL_GROUP_BY.LISTAR_CLIENTES_EXISTENTES
@NOMBRE VARCHAR(255), 
@APELLIDO VARCHAR(255),
@EMAIL VARCHAR(255),
@NRO_DOC NUMERIC(18,0)
as
begin
	select  U.Usuario_ID,
			C.Cliente_Nombre,
			C.Cliente_Apellido,
			U.Usuario_Mail,
			C.Cliente_Tipo_Documento,
			convert(varchar(50), C.Cliente_Numero_Documento) as NRO_DOC
	from EL_GROUP_BY.Cliente C inner join EL_GROUP_BY.USUARIO U
	on C.Usuario_ID = U.Usuario_ID
		AND C.Cliente_Nombre LIKE ISNULL('%' + @NOMBRE + '%', '%')
              AND C.Cliente_Apellido LIKE ISNULL('%' + @APELLIDO + '%', '%')
              AND U.Usuario_Mail LIKE ISNULL('%' + @EMAIL + '%', '%')
              AND convert(varchar(50), C.Cliente_Numero_Documento) LIKE ISNULL('%' + convert(varchar(50),@NRO_DOC) + '%', '%')
              AND U.Usuario_Habilitado = 1;
end
go

-- -----------------------------------------------------
-- SP - Nuevo Cliente
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CREAR_CLIENTE
@USUARIO VARCHAR(50),
@PASSWORD NVARCHAR(50),
@NOMBRE VARCHAR(255),
@APELLIDO VARCHAR(255),
@TIPO_DOC VARCHAR(10),
@NRO_DOC NUMERIC(18,0),
@CUIL VARCHAR(255),
@TELEFONO VARCHAR(255),
@MAIL VARCHAR(255),
@CALLE VARCHAR(255),
@NRO_CALLE NUMERIC(18,0),
@PISO NUMERIC(18,0),
@DEPARTAMENTO VARCHAR(255),
@LOCALIDAD VARCHAR(255),
@CODIGO_POSTAL VARCHAR(255),
@FECHA_NAC DATETIME,
@TARJETA_NOMBRE VARCHAR(255),
@TARJETA_NRO NUMERIC(16,0)
AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.USUARIO VALUES (@USUARIO
										 ,HASHBYTES('SHA2_256', @PASSWORD)
										 ,'CLIENTE'
										 ,1
										 ,0
										 ,1
										 ,@TELEFONO
										 ,@CALLE
										 ,@NRO_CALLE
										 ,@PISO
										 ,@DEPARTAMENTO
										 ,@CODIGO_POSTAL
										 ,@LOCALIDAD
										 ,@MAIL)

	DECLARE @USER_ID int
	SET @USER_ID = SCOPE_IDENTITY()

	INSERT INTO EL_GROUP_BY.Cliente VALUES (@NOMBRE
										  ,@APELLIDO
										  ,@TIPO_DOC
										  ,@NRO_DOC
										  ,@CUIL
										  ,@FECHA_NAC
										  ,@TARJETA_NOMBRE
										  ,@TARJETA_NRO
										  ,GETDATE()
										  ,@USER_ID) --SCOPE_IDENTITY())

	INSERT INTO EL_GROUP_BY.Rol_Usuario 
		SELECT	@USER_ID,
				Rol_ID,
				1
	    FROM EL_GROUP_BY.Rol 
		WHERE Rol_Nombre = 'CLIENTE'
										
					
	
COMMIT
GO

-- -----------------------------------------------------
-- SP - Actualizar Cliente
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.ACTUALIZAR_CLIENTE
@USUARIO_ID INT,
@NOMBRE VARCHAR(255),
@APELLIDO VARCHAR(255),
@TIPO_DOC VARCHAR(10),
@NRO_DOC NUMERIC(18,0),
@CUIL VARCHAR(255),
@TELEFONO VARCHAR(255),
@MAIL VARCHAR(255),
@CALLE VARCHAR(255),
@NRO_CALLE NUMERIC(18,0),
@PISO NUMERIC(18,0),
@DEPARTAMENTO VARCHAR(255),
@LOCALIDAD VARCHAR(255),
@CODIGO_POSTAL VARCHAR(255),
@FECHA_NAC DATETIME,
@TARJETA_NOMBRE VARCHAR(255),
@TARJETA_NRO NUMERIC(16,0)
AS
BEGIN TRANSACTION
	UPDATE EL_GROUP_BY.Usuario
		SET Usuario_Telefono = @TELEFONO,
			Usuario_Calle = @CALLE,
			Usuario_Numero_Calle = @NRO_CALLE,
			Usuario_Piso = @PISO,
			Usuario_Depto = @DEPARTAMENTO,
			Usuario_Codigo_Postal = @CODIGO_POSTAL,
			Usuario_Localidad = @LOCALIDAD,
			Usuario_Mail = @MAIL
		WHERE Usuario_ID = @USUARIO_ID

	UPDATE EL_GROUP_BY.Cliente
		SET Cliente_Nombre = @NOMBRE,
			Cliente_Apellido = @APELLIDO,
			Cliente_Tipo_Documento = @TIPO_DOC,
			Cliente_Numero_Documento = @NRO_DOC,
			Cliente_Cuil = @CUIL,
			Cliente_Fecha_Nacimiento = @FECHA_NAC,
			Cliente_Tarjeta_Marca = @TARJETA_NOMBRE,
			Cliente_Tarjeta_Numero = @TARJETA_NRO
		WHERE Usuario_ID = @USUARIO_ID
COMMIT
GO

-- -----------------------------------------------------
-- SP - Eliminar Cliente
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.ELIMINAR_CLIENTE
@USUARIO_ID INT
AS
BEGIN TRANSACTION
	UPDATE EL_GROUP_BY.USUARIO
		SET Usuario_Habilitado = 0
		WHERE Usuario_ID = @USUARIO_ID;
COMMIT
GO

-- -----------------------------------------------------
-- SP - Obtener Usuario a Modificar
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_USER_FOR_MODIFY @USER_ID int
as
begin
	SELECT  
		C.Cliente_Nombre,
		C.Cliente_Apellido,
		C.Cliente_Tipo_Documento,
		C.Cliente_Numero_Documento,
		C.Cliente_Fecha_Nacimiento,
		C.Cliente_Cuil,
		U.Usuario_Calle,
		U.Usuario_Numero_Calle,
		U.Usuario_Piso,
		U.Usuario_Depto,
		U.Usuario_Localidad,
		U.Usuario_Codigo_Postal,
		U.Usuario_Telefono,
		U.Usuario_Mail,
		C.Cliente_Tarjeta_Numero,
		C.Cliente_Tarjeta_Marca
	FROM EL_GROUP_BY.USUARIO U INNER JOIN EL_GROUP_BY.Cliente C 
	ON C.Usuario_ID = U.Usuario_ID and U.Usuario_ID = @USER_ID
end
GO

-- -----------------------------------------------------
-- SP - Obtener Datos del cliente para Cabecera
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_DATOS_CLIENTE_X_ID @CLIENT_ID int
as
begin
	SELECT  
		C.Cliente_Nombre,
		C.Cliente_Apellido,
		U.Usuario_Mail,
		C.Cliente_Numero_Documento
	FROM EL_GROUP_BY.USUARIO U INNER JOIN EL_GROUP_BY.Cliente C 
	ON C.Usuario_ID = U.Usuario_ID and C.Cliente_ID = @CLIENT_ID
end
GO

-- -----------------------------------------------------
-- SP - Obtener Datos del historial de Cliente
-- -----------------------------------------------------
create procedure EL_GROUP_BY.OBTENER_HISTORIAL_CLIENTE_ID @CLIENT_ID int
as
begin
select 1 from EL_GROUP_BY.Cliente
/*
	SELECT	C.Compra_ID,
			C.Compra_Fecha,
			F.Forma_Pago_Descripcion,
			P.Publicacion_Descripcion,
			P.Publicacion_Fecha,
			U.Ubicacion_Fila,
			U.Ubicacion_Asiento,
			U.Ubicacion_Sin_Numerar,
			UT.Ubicacion_Tipo_Descripcion,
			U.Ubicacion_Precio
	FROM EL_GROUP_BY.Publicacion_Ubicacion PU
	INNER JOIN EL_GROUP_BY.Ubicacion U on U.Ubicacion_ID = PU.Ubicacion_ID
	INNER JOIN EL_GROUP_BY.Publicacion P on P.Publicacion_ID = PU.Publicacion_ID
	INNER JOIN EL_GROUP_BY.Compra C on C.Compra_ID = PU.Compra_ID
	INNER JOIN EL_GROUP_BY.Forma_Pago F on F.Forma_Pago_ID = C.Forma_Pago_ID
	INNER JOIN EL_GROUP_BY.Ubicacion_Tipo UT on UT.Ubicacion_Tipo_ID = U.Ubicacion_Tipo_ID
	WHERE C.Cliente_ID = @CLIENT_ID
	*/
end
GO



-- -----------------------------------------------------
-- SP - Listar Empresas
-- -----------------------------------------------------

create procedure EL_GROUP_BY.LISTAR_EMPRESAS
@RAZON_SOCIAL VARCHAR(255), 
@CUIT VARCHAR(255),
@EMAIL VARCHAR(255)
as
begin
	select  U.Usuario_ID,
			E.Empresa_ID,
			E.Empresa_Razon_Social,
			E.Empresa_Cuit,
			U.Usuario_Mail,
			E.Empresa_Ciudad
	from EL_GROUP_BY.Empresa E inner join EL_GROUP_BY.USUARIO U
	on E.Usuario_ID = U.Usuario_ID
		AND E.Empresa_Razon_Social LIKE ISNULL('%' + @RAZON_SOCIAL + '%', '%')
              AND E.Empresa_Cuit LIKE ISNULL('%' + @CUIT + '%', '%')
              AND U.Usuario_Mail LIKE ISNULL('%' + @EMAIL + '%', '%')
              --AND U.Usuario_Habilitado = 1; //Se deben poder modificar las eliminadas
end
go

-- -----------------------------------------------------
-- SP - Eliminar Empresa
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.ELIMINAR_EMPRESA
@USUARIO_ID INT
AS
BEGIN TRANSACTION
	UPDATE EL_GROUP_BY.USUARIO
		SET Usuario_Habilitado = 0
		WHERE Usuario_ID = @USUARIO_ID;
COMMIT
GO

-- -----------------------------------------------------
-- SP - Nueva Empresa
-- -----------------------------------------------------


CREATE PROCEDURE EL_GROUP_BY.CREAR_EMPRESA
@USUARIO		VARCHAR(50),
@PASSWORD		NVARCHAR(50),
@RAZON_SOCIAL	VARCHAR(255),
@EMAIL			VARCHAR(255),
@TELEFONO		VARCHAR(20), 
@CALLE			VARCHAR(50), 
@NUMERO			NUMERIC(18,0),
@PISO			NUMERIC(18,0),
@DEPTO			VARCHAR(50), 
@LOCALIDAD		VARCHAR(50),
@CODIGO_POSTAL	VARCHAR(50), 
@CIUDAD			VARCHAR(50), 
@CUIT			VARCHAR(255)
AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Usuario VALUES (@USUARIO
										 ,HASHBYTES('SHA2_256', @PASSWORD)
										 ,'Empresa'		--Tipo
										 ,1				--Habilitado
										 ,0				--Intentos
										 ,1				--Primer login
										 ,@TELEFONO
										 ,@CALLE
										 ,@NUMERO
										 ,@PISO
										 ,@DEPTO
										 ,@CODIGO_POSTAL
										 ,@LOCALIDAD
										 ,@EMAIL)

	DECLARE @USER_ID int
	SET @USER_ID = SCOPE_IDENTITY()

	INSERT INTO EL_GROUP_BY.Empresa VALUES (@RAZON_SOCIAL
										  ,@CUIT
										  ,@CIUDAD
										  ,getDate()
										  , (select Usuario_ID 
												from Usuario u 
												where u.Usuario_Username = @USUARIO 
												and u.Usuario_Password = HASHBYTES('SHA2_256', @PASSWORD) )
										   )
										   										   
	INSERT INTO EL_GROUP_BY.Rol_Usuario 
		SELECT	@USER_ID,
				Rol_ID,
				1
	    FROM EL_GROUP_BY.Rol 
		WHERE Rol_Nombre = 'EMPRESA'

COMMIT
GO

-- -----------------------------------------------------
-- SP - Obtener Empresa a Modificar
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_EMPRESA_FOR_MODIFY @USER_ID int
as
begin
	SELECT  
		E.Empresa_Razon_Social,
		U.Usuario_Mail,
		U.Usuario_Telefono,
		E.Empresa_Cuit,
		U.Usuario_Calle,
		U.Usuario_Numero_Calle,
		U.Usuario_Piso,
		U.Usuario_Depto,
		U.Usuario_Codigo_Postal,
		U.Usuario_Localidad,
		E.Empresa_Ciudad,
		U.Usuario_Habilitado
	FROM EL_GROUP_BY.USUARIO U INNER JOIN EL_GROUP_BY.Empresa E 
	ON E.Usuario_ID = U.Usuario_ID and U.Usuario_ID = @USER_ID
end
GO

-- -----------------------------------------------------
-- SP - Actualizar Empresa
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.ACTUALIZAR_EMPRESA
@USUARIO_ID INT,
@RAZON_SOCIAL	VARCHAR(255),
@EMAIL			VARCHAR(255),
@TELEFONO		VARCHAR(20), 
@CALLE			VARCHAR(50), 
@NUMERO			NUMERIC(18,0),
@PISO			NUMERIC(18,0),
@DEPTO			VARCHAR(50), 
@LOCALIDAD		VARCHAR(50),
@CODIGO_POSTAL	VARCHAR(50), 
@CIUDAD			VARCHAR(50), 
@CUIT			VARCHAR(255),
@HABILITADO     BIT
AS
BEGIN TRANSACTION
	UPDATE EL_GROUP_BY.Usuario
		SET Usuario_Telefono = @TELEFONO,
			Usuario_Calle = @CALLE,
			Usuario_Piso = @PISO,
			Usuario_Depto = @DEPTO,
			Usuario_Codigo_Postal = @CODIGO_POSTAL,
			Usuario_Localidad = @LOCALIDAD,
			Usuario_Mail = @EMAIL,
			Usuario_Habilitado = @HABILITADO
		WHERE Usuario_ID = @USUARIO_ID

	UPDATE EL_GROUP_BY.Empresa 
		SET Empresa_Razon_Social = @RAZON_SOCIAL,
			Empresa_Cuit = @CUIT,
			Empresa_Ciudad = @CIUDAD
		WHERE Usuario_ID = @USUARIO_ID
COMMIT
GO


-- -----------------------------------------------------
-- SP - Listar Grados
-- -----------------------------------------------------

create procedure EL_GROUP_BY.LISTAR_GRADOS
@PRIORIDAD VARCHAR(255)
as
begin
	select  G.Grado_Publicacion_ID,
			G.Grado_Publicacion_Comision,
			G.Grado_Publicacion_Prioridad
	from EL_GROUP_BY.Grado_Publicacion G 
	where G.Grado_Publicacion_Prioridad LIKE ISNULL('%' + @PRIORIDAD + '%', '%')
	  AND G.Grado_Publicacion_Habilitado = 1; 
end
go

-- -----------------------------------------------------
-- SP - Eliminar Grado
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.ELIMINAR_GRADO
@ID INT
AS
BEGIN TRANSACTION
	UPDATE EL_GROUP_BY.Grado_Publicacion
		SET Grado_Publicacion_Habilitado = 0
		WHERE Grado_Publicacion_ID = @ID;
COMMIT
GO

-- -----------------------------------------------------
-- SP - Nuevo Grado
-- -----------------------------------------------------
CREATE PROCEDURE EL_GROUP_BY.CREAR_GRADO
@COMISION		NUMERIC(3,3),
@PRIORIDAD		VARCHAR(10)
AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Grado_Publicacion VALUES (@COMISION
										 ,@PRIORIDAD
										 ,1				
										 )


COMMIT
GO

-- -----------------------------------------------------
-- SP - Obtener Grado a Modificar
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_GRADO_FOR_MODIFY 
@ID int
as
begin
	SELECT  G.Grado_Publicacion_Comision,
			G.Grado_Publicacion_Prioridad
	FROM EL_GROUP_BY.Grado_Publicacion G
	WHERE G.Grado_Publicacion_ID = @ID
end
GO

-- -----------------------------------------------------
-- SP - Actualizar Grado
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.ACTUALIZAR_GRADO
@ID				INT,
@COMISION		NUMERIC(3,3),
@PRIORIDAD		VARCHAR(10)
AS
BEGIN TRANSACTION

	UPDATE EL_GROUP_BY.Grado_Publicacion
		SET Grado_Publicacion_Comision = @COMISION,
			Grado_Publicacion_Prioridad = @PRIORIDAD
		WHERE Grado_Publicacion_ID = @ID

COMMIT
GO


/****************************************************************
*							SPs - FIN							*
****************************************************************/

/****************************************************************
*			EJECUCIÓN DE MIGRACIÓN - COMIENZO					*
****************************************************************/
EXEC EL_GROUP_BY.CARGAR_USUARIOS;
EXEC EL_GROUP_BY.CARGAR_CLIENTES;
EXEC EL_GROUP_BY.CARGAR_EMPRESAS;
EXEC EL_GROUP_BY.CARGAR_ROLES;
EXEC EL_GROUP_BY.CARGAR_FUNCIONALIDADES;
EXEC EL_GROUP_BY.CARGAR_ROLES_X_USUARIO;
EXEC EL_GROUP_BY.CARGAR_ROLES_X_FUNCIONALIDAD;
EXEC EL_GROUP_BY.CARGAR_FORMAS_PAGO;
EXEC EL_GROUP_BY.CARGAR_UBICACION_TIPOS;
EXEC EL_GROUP_BY.CARGAR_RUBROS;
EXEC EL_GROUP_BY.CARGAR_ESTADOS_PUBLICACION;
EXEC EL_GROUP_BY.CARGAR_GRADOS_PUBLICACION;		  
EXEC EL_GROUP_BY.CARGAR_ESPECTACULOS;
EXEC EL_GROUP_BY.CARGAR_PUBLICACIONES;
EXEC EL_GROUP_BY.CARGAR_UBICACIONES;
EXEC EL_GROUP_BY.CARGAR_PUBLICACION_UBICACION;
EXEC EL_GROUP_BY.CARGAR_FACTURAS;
EXEC EL_GROUP_BY.CARGAR_COMPRAS;

/****************************************************************

*			EJECUCIÓN DE MIGRACIÓN - FIN						*
****************************************************************/
/* COMENTE TODO PARA CORRER LA MIGRACION
--------------------------------------------------------
-- Borrador para hacer algunas pruebas
--------------------------------------------------------
select Cli_Dni from gd_esquema.Maestra where Cli_Dni is not null;
drop table EL_GROUP_BY.Usuario;
drop proc EL_GROUP_BY.CARGAR_USUARIOS;

exec EL_GROUP_BY.CARGAR_USUARIOS;

select * from EL_GROUP_BY.Usuario where Usuario_Id = 784;
select * from EL_GROUP_BY.Cliente where Usuario_ID = 523;

exec EL_GROUP_BY.CARGAR_CLIENTES;

drop table EL_GROUP_BY.Cliente;
drop proc EL_GROUP_BY.CARGAR_CLIENTES;

select * from EL_GROUP_BY.Cliente where Cliente_Tipo_Documento is null;

drop table EL_GROUP_BY.Empresa;
drop proc EL_GROUP_BY.CARGAR_EMPRESAS;

exec EL_GROUP_BY.CARGAR_EMPRESAS;

select * from EL_GROUP_BY.Empresa;

exec EL_GROUP_BY.CARGAR_ROLES;

select * from EL_GROUP_BY.Rol;

exec EL_GROUP_BY.CARGAR_FUNCIONALIDADES;
drop table EL_GROUP_BY.Funcionalidad;
drop proc EL_GROUP_BY.CARGAR_FUNCIONALIDADES;

select * from EL_GROUP_BY.Funcionalidad;

exec EL_GROUP_BY.CARGAR_ROLES_X_USUARIO;

select * from EL_GROUP_BY.ROL_USUARIO;

exec EL_GROUP_BY.CARGAR_ROLES_X_FUNCIONALIDAD;
drop table EL_GROUP_BY.Rol_Funcionalidad;


exec EL_GROUP_BY.CARGAR_FORMAS_PAGO;
drop table EL_GROUP_BY.Forma_Pago;


exec EL_GROUP_BY.CARGAR_UBICACION_TIPOS;
drop table EL_GROUP_BY.Ubicacion_Tipo;


exec EL_GROUP_BY.CARGAR_RUBROS;
drop table EL_GROUP_BY.Rubro;


exec EL_GROUP_BY.CARGAR_ESTADOS_PUBLICACION;
drop table EL_GROUP_BY.Estado_Publicacion;

select * from EL_GROUP_BY.Rol_Funcionalidad;

select Espectaculo_Cod, Espectaculo_Descripcion, Ubicacion_Fila, Ubicacion_Asiento from gd_esquema.Maestra where Ubicacion_Fila = 'A';

select Espectaculo_Estado from gd_esquema.Maestra;

select * from gd_esquema.Maestra;

select distinct A.Cli_Nombre, A.Cli_Dni 
from gd_esquema.Maestra A
join gd_esquema.Maestra B ON  a.cli_dni = b.cli_dni
where a.cli_nombre != b.cli_nombre;

select * from El_group_by.Rubro;
*/
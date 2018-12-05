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

IF OBJECT_ID('EL_GROUP_BY.Ubicacion') IS NOT NULL
	DROP TABLE EL_GROUP_BY.Ubicacion;
	
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

IF OBJECT_ID('EL_GROUP_BY.CARGAR_COMPRAS_E_ITEMS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_COMPRAS_E_ITEMS;

IF OBJECT_ID('EL_GROUP_BY.UBICACIONES_MIGRADAS_DISPONIBLES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.UBICACIONES_MIGRADAS_DISPONIBLES;
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
	DROP PROCEDURE EL_GROUP_BY.OBTENER_HISTORIAL_CLIENTE_ID;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_CANJE_DISPONIBLE') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.LISTAR_CANJE_DISPONIBLE;

IF OBJECT_ID('EL_GROUP_BY.CANJEAR_UBICACION') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CANJEAR_UBICACION;

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

IF OBJECT_ID('EL_GROUP_BY.CARGAR_PUBLICACION_UBICACION_COMPRADA') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CARGAR_PUBLICACION_UBICACION_COMPRADA;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_CLIENTES_MAYORES_PUNTOS_VENCIDOS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.LISTAR_CLIENTES_MAYORES_PUNTOS_VENCIDOS;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_CLIENTES_MAYOR_CANTIDAD_COMPRAS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.LISTAR_CLIENTES_MAYOR_CANTIDAD_COMPRAS;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_EMPRESAS_MAYOR_CANTIDAD_LOCALIDADES_NO_VENDIDAS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.LISTAR_EMPRESAS_MAYOR_CANTIDAD_LOCALIDADES_NO_VENDIDAS;

IF OBJECT_ID('EL_GROUP_BY.ACTUALIZAR_PASSWORD') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.ACTUALIZAR_PASSWORD;

IF OBJECT_ID('EL_GROUP_BY.ES_UNICO_USERNAME') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.ES_UNICO_USERNAME;

IF OBJECT_ID('EL_GROUP_BY.CREAR_ESPECTACULO_PUBLICACION') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CREAR_ESPECTACULO_PUBLICACION;

IF OBJECT_ID('EL_GROUP_BY.CREAR_UBICACIONES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CREAR_UBICACIONES;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_PUBLICACIONES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.LISTAR_PUBLICACIONES;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_PUBLICACION_FOR_MODIFY') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_PUBLICACION_FOR_MODIFY;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_UBICACIONES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_UBICACIONES;

IF OBJECT_ID('EL_GROUP_BY.OBTENER_UBICACIONES_PARA_COMPRA') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.OBTENER_UBICACIONES_PARA_COMPRA;

IF OBJECT_ID('EL_GROUP_BY.EDITAR_ESPECTACULO_PUBLICACION') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.EDITAR_ESPECTACULO_PUBLICACION;

IF OBJECT_ID('EL_GROUP_BY.BORRAR_UBICACIONES') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.BORRAR_UBICACIONES;

IF OBJECT_ID('EL_GROUP_BY.EXISTE_ESPECTACULO_PUBLICACION') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.EXISTE_ESPECTACULO_PUBLICACION;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_PUBLICACIONES_DISPONIBLES_COMPRA') IS NOT NULL
	DROP PROC EL_GROUP_BY.LISTAR_PUBLICACIONES_DISPONIBLES_COMPRA;

IF OBJECT_ID('EL_GROUP_BY.LISTAR_COMPRAS_EMPRESA') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.LISTAR_COMPRAS_EMPRESA;

IF OBJECT_ID('EL_GROUP_BY.CREAR_FACTURA') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CREAR_FACTURA;

IF OBJECT_ID('EL_GROUP_BY.CREAR_ITEMS') IS NOT NULL
	DROP PROCEDURE EL_GROUP_BY.CREAR_ITEMS;

IF type_id('EL_GROUP_BY.UBICACION_TIPO_TABLA') IS NOT NULL
	DROP TYPE EL_GROUP_BY.UBICACION_TIPO_TABLA;

IF type_id('EL_GROUP_BY.PUBLICACION_UBICACION_TIPO_TABLA ') IS NOT NULL
	DROP TYPE EL_GROUP_BY.PUBLICACION_UBICACION_TIPO_TABLA ;

IF type_id('EL_GROUP_BY.ITEM_TIPO_TABLA') IS NOT NULL
	DROP TYPE EL_GROUP_BY.ITEM_TIPO_TABLA;

	

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
		ON UPDATE CASCADE,
	CONSTRAINT FK_Rol_Funcionalidad_Funcionalidad_ID FOREIGN KEY (Funcionalidad_ID)     
		REFERENCES EL_GROUP_BY.Funcionalidad (Funcionalidad_ID)
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
		ON UPDATE CASCADE,
	CONSTRAINT FK_Rol_Usuario_Usuario_ID FOREIGN KEY (Usuario_ID)     
		REFERENCES EL_GROUP_BY.Usuario (Usuario_ID)
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
		Cliente_Tarjeta_Numero NVARCHAR(16),
		Cliente_Fecha_Creacion DATETIME,
		Usuario_ID INT,
	PRIMARY KEY (Cliente_ID),
	CONSTRAINT FK_Cliente_Usuario_ID FOREIGN KEY (Usuario_ID)     
		REFERENCES EL_GROUP_BY.Usuario (Usuario_ID)     
		ON UPDATE CASCADE)
;



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
		ON UPDATE CASCADE)
;




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
		Espectaculo_Codigo NUMERIC(18,0),
		Espectaculo_Descripcion NVARCHAR(255) NOT NULL,
		Espectaculo_Direccion NVARCHAR(255),
		Espectaculo_Fecha DATETIME NOT NULL,
		Espectaculo_Fecha_Vencimiento DATETIME NOT NULL,
		Rubro_ID INT NOT NULL,
		Empresa_ID INT NOT NULL,
	PRIMARY KEY (Espectaculo_ID),
	CONSTRAINT FK_Espectaculo_Empresa_ID FOREIGN KEY (Empresa_ID)
		REFERENCES EL_GROUP_BY.Empresa (Empresa_ID)
		ON UPDATE CASCADE,  
	CONSTRAINT FK_Espectaculo_Rubro_ID FOREIGN KEY (Rubro_ID)
		REFERENCES EL_GROUP_BY.Rubro (Rubro_ID)     
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
		Ubicacion_Tipo_ID INT NOT NULL
	PRIMARY KEY (Ubicacion_ID),
	CONSTRAINT FK_Ubicacion_Tipo_ID FOREIGN KEY (Ubicacion_Tipo_ID)     
		REFERENCES EL_GROUP_BY.Ubicacion_Tipo (Ubicacion_Tipo_ID)     
		ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de TIPO Tabla para Ubicación
-- -----------------------------------------------------
CREATE TYPE EL_GROUP_BY.UBICACION_TIPO_TABLA As Table
(
	Ubicacion_Fila VARCHAR(3) NULL,
	Ubicacion_Asiento NUMERIC(18,0) NULL,
	Ubicacion_Sin_Numerar BIT NOT NULL,
	Ubicacion_Precio NUMERIC(18,0) NOT NULL,
	Ubicacion_Disponible BIT NOT NULL,
	Ubicacion_Tipo_ID INT NOT NULL,
	Ubicacion_Canjeada BIT NOT NULL,
	Ubicacion_Fecha_Canje DATETIME NULL,
	Ubicacion_Cliente_Canje INT NULL
)

-- -----------------------------------------------------
-- Creación de TIPO Tabla para Publicacion_Ubicacion
-- -----------------------------------------------------
CREATE TYPE EL_GROUP_BY.PUBLICACION_UBICACION_TIPO_TABLA As Table
(
	Ubicacion_ID INT NULL,
	Publicacion_ID INT NULL
)

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Grado_Publicacion
-- -----------------------------------------------------
 
CREATE TABLE EL_GROUP_BY.Grado_Publicacion (
		Grado_Publicacion_ID INT IDENTITY(1,1),
		Grado_Publicacion_Comision NUMERIC(3,2) NOT NULL,
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
    ON UPDATE CASCADE,
  CONSTRAINT FK_Publicacion_Espectaculo_ID FOREIGN KEY (Espectaculo_ID)     
    REFERENCES EL_GROUP_BY.Espectaculo (Espectaculo_ID)     
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
		ON UPDATE CASCADE,
	CONSTRAINT FK_Compra_Forma_Pago_ID FOREIGN KEY (Forma_Pago_ID)     
		REFERENCES EL_GROUP_BY.Forma_Pago (Forma_Pago_ID)     
		ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Item
-- -----------------------------------------------------


CREATE TABLE EL_GROUP_BY.Item (
		Item_ID INT IDENTITY(1,1),
		Item_Monto NUMERIC(18,2) NOT NULL,
		Item_Cantidad NUMERIC(18,0) NOT NULL,
		Item_Descripcion NVARCHAR(255) NOT NULL,
		Factura_ID INT NOT NULL,
		Compra_ID INT NOT NULL,
	PRIMARY KEY (Item_ID),
	CONSTRAINT FK_Item_Factura_ID FOREIGN KEY (Factura_ID)     
		REFERENCES EL_GROUP_BY.Factura (Factura_ID)     
		ON UPDATE CASCADE)

-- -----------------------------------------------------
-- Creación de TIPO Tabla para ITEMS
-- -----------------------------------------------------
CREATE TYPE EL_GROUP_BY.ITEM_TIPO_TABLA As Table
(
		Item_Monto DECIMAL NOT NULL,
		Item_Cantidad DECIMAL NOT NULL,
		Item_Descripcion NVARCHAR(255) NOT NULL,
		Factura_ID INT NOT NULL,
		Compra_ID INT NOT NULL
)
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
		ON UPDATE CASCADE)
;

-- -----------------------------------------------------
-- Creación de Tabla EL_GROUP_BY.Publicacion_Ubicacion
-- -----------------------------------------------------
CREATE TABLE EL_GROUP_BY.Publicacion_Ubicacion (
		Ubicacion_ID INT NOT NULL,
		Publicacion_ID INT NOT NULL,
		Compra_ID INT NULL,
		Publicacion_Ubicacion_Disponible BIT NOT NULL,
		Publicacion_Ubicacion_Canjeada BIT NOT NULL,
		Publicacion_Ubicacion_Fecha_Canje DATETIME NULL,
		Publicacion_Ubicacion_Cliente_Canje INT NULL
	PRIMARY KEY (Ubicacion_ID, Publicacion_ID),
	CONSTRAINT FK_Ubicacion_Cliente_Canje_ID FOREIGN KEY (Publicacion_Ubicacion_Cliente_Canje)     
		REFERENCES EL_GROUP_BY.Cliente (Cliente_ID)     
		ON UPDATE CASCADE)
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
					,1
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

	/* Acá cargaremos al admin como un cliente más por cuestiones de seguridad
	INSERT INTO EL_GROUP_BY.Cliente
		VALUES ('admin'
				,'admin'
				,'DNI'
				,35123123
				,'20-35123123-4'
				,CONVERT(DATETIME,'1990/02/02 00:00:00',121)
				,'admin'
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

	/* Acá cargaremos al admin como una empresa más por cuestiones de seguridad
	INSERT INTO EL_GROUP_BY.Empresa
		VALUES ('admin'
				,'30-71031609-7'
				,'Baires'
				,CONVERT(DATETIME,'1980/02/02 00:00:00',121)
				,783)*/
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
					F.Funcionalidad_ID = 3 OR
					F.Funcionalidad_ID = 5 OR
					F.Funcionalidad_ID = 11 OR
					F.Funcionalidad_ID = 12)
	UNION
		SELECT Rol_ID,
				Funcionalidad_ID
			FROM EL_GROUP_BY.ROL R, EL_GROUP_BY.FUNCIONALIDAD F
			WHERE R.Rol_Nombre = 'CLIENTE' AND
					(F.Funcionalidad_ID = 8 OR
					F.Funcionalidad_ID = 9 OR
					F.Funcionalidad_ID = 10)
	UNION
		SELECT Rol_ID,
				Funcionalidad_ID
			FROM EL_GROUP_BY.ROL R, EL_GROUP_BY.FUNCIONALIDAD F
			WHERE R.Rol_Nombre = 'EMPRESA' AND
					(F.Funcionalidad_ID = 4 OR
						F.Funcionalidad_ID = 6 OR
						F.Funcionalidad_ID = 7)
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


	--Cargo rubros genéricos para no implementar el ABM
	INSERT EL_GROUP_BY.Rubro VALUES('Musical')
	INSERT EL_GROUP_BY.Rubro VALUES('Teatro')
	INSERT EL_GROUP_BY.Rubro VALUES('Opera')
	INSERT EL_GROUP_BY.Rubro VALUES('Cine')
	
COMMIT TRANSACTION;	
GO	
									      
-- -----------------------------------------------------
-- SPMigra -- Cargar Estados_Publicacion
-- -----------------------------------------------------
									      
CREATE PROCEDURE EL_GROUP_BY.CARGAR_ESTADOS_PUBLICACION AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Estado_Publicacion VALUES ('Borrador',1);
	INSERT INTO EL_GROUP_BY.Estado_Publicacion SELECT DISTINCT ESPECTACULO_ESTADO, 0 FROM gd_esquema.Maestra;
	INSERT INTO EL_GROUP_BY.Estado_Publicacion VALUES ('Finalizada',0);
COMMIT;
GO	   

-- -----------------------------------------------------
-- SPMigra -- Cargar Grados_Publicacion
-- -----------------------------------------------------
									      														 
CREATE PROCEDURE EL_GROUP_BY.CARGAR_GRADOS_PUBLICACION AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Grado_Publicacion VALUES (0.1,'MIGRADA',0)
	INSERT INTO EL_GROUP_BY.Grado_Publicacion VALUES (0.1,'BAJA',1)
	INSERT INTO EL_GROUP_BY.Grado_Publicacion VALUES (0.15,'MEDIA',1)
	INSERT INTO EL_GROUP_BY.Grado_Publicacion VALUES (0.20,'ALTA',1)
COMMIT;
GO	
-- -----------------------------------------------------
-- SPMigra -- Cargar Espectaculos
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CARGAR_ESPECTACULOS AS
BEGIN TRANSACTION
	INSERT INTO EL_GROUP_BY.Espectaculo
		SELECT DISTINCT M.Espectaculo_Cod
		            ,M.Espectaculo_Descripcion
					,null
					,M.Espectaculo_Fecha
					,M.Espectaculo_Fecha_Venc
					,EL_GROUP_BY.FUNC_ID_RUBRO(M.Espectaculo_Rubro_Descripcion)
					,EL_GROUP_BY.FUNC_ID_EMPRESA(M.Espec_Empresa_Razon_Social, M.Espec_Empresa_Cuit)
		FROM gd_esquema.Maestra M
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
						,1 --Migro directamente Grado_Publicacion_ID = 1 - 'MIGRADA'
						,2)  -- Migramos como 2 - Publicada ya que en la Maestra todos los Espectaculo_Estado son 'Publicada'
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
						,EL_GROUP_BY.FUNC_ID_UBICACION_TIPO(Ubicacion_Tipo_Codigo)
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
				,0 -- Ubicacion_Disponible Migramos como NO por ahora
				,0 -- NO Canjeada dado que el canje de puntos es una funcionalidad nueva
				,NULL -- fecha de canje - idem campo anterior
				,NULL -- Cliente de Canje - idem campo anterior
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

-- -------------------------------------------------------
-- SPMigra -- SCRIPT Cargar Compras e Items -- Se decide migrar ambas tablas en un mismo SP por la complejidad de las relaciones
-- -------------------------------------------------------
CREATE PROCEDURE EL_GROUP_BY.CARGAR_COMPRAS_E_ITEMS
AS
BEGIN TRANSACTION  

/*CREACION DE TABLA AUXILIAR #COMPRAS_UBICACIONES_ITEMS*/  
CREATE TABLE EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS (Compras_Ubicaciones_ID INT IDENTITY(1,1)
												   ,Espec_Empresa_Razon_Social NVARCHAR(255)
												   ,Espec_Empresa_Cuit NVARCHAR(255)
												   ,Compra_Fecha DATETIME
												   ,Cli_Dni NUMERIC(18,0)
                                                   ,Cli_Nombre NVARCHAR(255)
                                                   ,Compra_Cantidad NUMERIC(18,0)
                                                   ,Espectaculo_Cod NUMERIC(18,0)
	                                               ,Ubicacion_Fila VARCHAR(3)
												   ,Ubicacion_Asiento NUMERIC(18,0)
                                                   ,Ubicacion_Precio NUMERIC(18,0)
                                                   ,Ubicacion_Sin_numerar BIT
												   ,ACU_COMPRA_CANTIDAD NUMERIC(18,0)
                                                   ,ACU_COMPRA_TOTAL NUMERIC(18,2)
												   ,Item_Monto NUMERIC(18,2)
												   ,Item_Cantidad NUMERIC(18,0)
												   ,Item_Descripcion NVARCHAR(60)
												   ,Factura_Nro NUMERIC(18,0));

/* CARGA DE DATOS TABLA AUXILIAR #COMPRAS_UBICACIONES_ITEMS*/  
INSERT INTO EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS
	SELECT DISTINCT M.Espec_Empresa_Razon_Social
				,M.Espec_Empresa_Cuit
				,M.Compra_Fecha
				,M.Cli_Dni
				,M.Cli_Nombre
				,M.Compra_Cantidad
				,M.Espectaculo_Cod 
				,M.Ubicacion_Fila 
				,M.Ubicacion_Asiento 
				,M.Ubicacion_Precio 
				,M.Ubicacion_Sin_numerar
				,0
				,0
				,M.Item_Factura_Monto
				,M.Item_Factura_Cantidad
				,M.Item_Factura_Descripcion
				,M.Factura_Nro -- Se insertan las Facturas ya que según pudimos observar en la maestra, todas las ubicaciones compradas fueron rendidas --
			FROM gd_esquema.Maestra M
		    GROUP BY  M.Espec_Empresa_Razon_Social, M.Espec_Empresa_Cuit, Compra_Fecha, M.Cli_Dni, M.Cli_Nombre, Compra_Cantidad, M.Espectaculo_Cod, 
					  M.Ubicacion_Asiento, M.Ubicacion_Fila, M.Ubicacion_Precio, M.Ubicacion_Sin_numerar, 
					  M.Ubicacion_Sin_numerar,M.Item_Factura_Monto, M.Item_Factura_Cantidad,
					  M.Item_Factura_Descripcion, M.Factura_Nro
			HAVING M.Cli_Dni IS NOT NULL AND M.Cli_Nombre IS NOT NULL AND M.Compra_Fecha IS NOT NULL AND 
				   M.Compra_Cantidad IS NOT NULL AND M.Factura_Nro IS NOT NULL -- Se indican todos estos campos NOT NULL para que no tome los registros repetidos 
			ORDER BY M.Compra_Fecha, M.Cli_Dni, M.Cli_Nombre, M.Espectaculo_Cod;

/*CREACION DE TABLA AUXILIAR #COMPRAS_UBICACIONES_ITEMS2*/  
CREATE TABLE EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2 (Compras_Ubicaciones_ID INT IDENTITY(1,1)
												   ,Espec_Empresa_Razon_Social NVARCHAR(255)
												   ,Espec_Empresa_Cuit NVARCHAR(255)
												   ,Compra_Fecha DATETIME
												   ,Cli_Dni NUMERIC(18,0)
                                                   ,Cli_Nombre NVARCHAR(255)
                                                   ,Compra_Cantidad NUMERIC(18,0)
                                                   ,Espectaculo_Cod NUMERIC(18,0)
	                                               ,Ubicacion_Fila VARCHAR(3)
												   ,Ubicacion_Asiento NUMERIC(18,0)
                                                   ,Ubicacion_Precio NUMERIC(18,0)
                                                   ,Ubicacion_Sin_numerar BIT
												   ,Item_Monto NUMERIC(18,2)
												   ,Item_Cantidad NUMERIC(18,0)
												   ,Item_Descripcion NVARCHAR(60)
												   ,Factura_Nro NUMERIC(18,0)
												   ,Espec_Empresa_Razon_Social_ANT NVARCHAR(255)
												   ,Espec_Empresa_Cuit_ANT NVARCHAR(255)
												   ,Compra_Fecha_ANT DATETIME
												   ,Cli_Dni_ANT NUMERIC(18,0)
												   ,Cli_Nombre_ANT NVARCHAR(255)
												   ,Compra_Cantidad_ANT NUMERIC(18,0)
												   ,Espectaculo_Cod_ANT NUMERIC(18,0)
												   ,Ubicacion_Fila_ANT VARCHAR(3)
												   ,Ubicacion_Asiento_ANT NUMERIC(18,0)
												   ,Ubicacion_Precio_ANT NUMERIC(18,0)
												   ,Ubicacion_Sin_numerar_ANT BIT
												   ,ACU_COMPRA_CANTIDAD NUMERIC(18,0)
                                                   ,ACU_COMPRA_TOTAL NUMERIC(18,2)
												   ,Cliente_ID INT
												   ,Ubicacion_ID INT
												   ,Publicacion_ID INT
												   ,Factura_ID INT
												   ,Misma_Compra INT
												   ,Compra_ID INT);

/*CARGA DE DATOS TABLA AUXILIAR #COMPRAS_UBICACIONES_ITEMS2*/   
INSERT INTO EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2
        SELECT DISTINCT   A.Espec_Empresa_Razon_Social
				,A.Espec_Empresa_Cuit
				,A.Compra_Fecha
				,A.Cli_Dni
				,A.Cli_Nombre
				,A.Compra_Cantidad
				,A.Espectaculo_Cod 
				,A.Ubicacion_Fila 
				,A.Ubicacion_Asiento 
				,A.Ubicacion_Precio 
				,A.Ubicacion_Sin_numerar
				,A.Item_Monto
				,A.Item_Cantidad
				,A.Item_Descripcion
				,A.Factura_Nro
			    ,B.Espec_Empresa_Razon_Social
				,B.Espec_Empresa_Cuit
				,B.Compra_Fecha
				,B.Cli_Dni
				,B.Cli_Nombre
				,B.Compra_Cantidad
				,B.Espectaculo_Cod 
				,B.Ubicacion_Fila 
				,B.Ubicacion_Asiento 
				,B.Ubicacion_Precio 
				,B.Ubicacion_Sin_numerar
				,A.Compra_Cantidad -- ACU_COMPRA_CANTIDAD
				,A.Ubicacion_Precio -- ACU_COMPRA_TOTAL
				,EL_GROUP_BY.FUNC_ID_CLIENTE(A.Cli_Nombre,A.Cli_Dni)
				,NULL
				,NULL
				,NULL
				,0
				,NULL
			FROM EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS A																			   
			LEFT JOIN EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS B
		    ON A.Compras_Ubicaciones_ID - 1  = B.Compras_Ubicaciones_ID;
		
/* MARCA EN #COMPRAS_UBICACIONES_ITEMS2 DE COMPRAS CON MAS DE UNA UBICACION */  
UPDATE EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2 SET MISMA_COMPRA = 1
WHERE EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Compra_Fecha = EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Compra_Fecha_ANT AND
   EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Cli_Dni = EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Cli_Dni_ANT AND
   EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Cli_Nombre = EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Cli_Nombre_ANT AND
   EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Espectaculo_Cod = EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Espectaculo_Cod_ANT AND
   EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Espec_Empresa_Razon_Social = EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Espec_Empresa_Razon_Social_ANT AND
   EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Espec_Empresa_Cuit = EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2.Espec_Empresa_Cuit_ANT;

/* CARGA DE Ubicacion_ID, Publicacion_ID, Factura_ID EN TABLA #COMPRAS_UBICACIONES_ITEMS2 */ 
UPDATE EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2 SET Ubicacion_ID = U.Ubicacion_ID,
													Publicacion_ID = P.Publicacion_ID,
													Factura_ID = F.Factura_ID
											FROM EL_GROUP_BY.Ubicacion U,
												 EL_GROUP_BY.Publicacion P,
												 EL_GROUP_BY.Espectaculo E,
												 EL_GROUP_BY.Factura F,
												 EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2 M
											WHERE U.Ubicacion_Fila = M.Ubicacion_Fila AND
												  U.Ubicacion_Asiento = M.Ubicacion_Asiento AND
												  U.Ubicacion_Sin_Numerar = M.Ubicacion_Sin_numerar AND
												  U.Ubicacion_Precio = M.Ubicacion_Precio AND
												  E.Espectaculo_Codigo = M.Espectaculo_Cod AND
												  F.Factura_Nro = M.Factura_Nro AND
												  P.Espectaculo_ID = E.Espectaculo_ID;

/*CREACION DE TABLA AUXILIAR DE COMPRAS #Compra*/
CREATE TABLE EL_GROUP_BY.#Compra (
		Compra_ID INT IDENTITY(1,1),
		Compra_Fecha DATETIME  ,
		Compra_Cantidad NUMERIC(18,0)  ,
		Compra_Monto_Total DECIMAL(18,2)  ,
		Compra_Rendida BIT  ,
		Cliente_ID INT  ,
		Forma_Pago_ID INT,
		Compras_Ubicaciones_ID int );

/*CARGA DE DATOS EN DE TABLA AUXILIAR DE COMPRAS #Compra*/
INSERT INTO EL_GROUP_BY.#Compra
	SELECT	 Compra_Fecha
			,Compra_Cantidad
			,Ubicacion_Precio -- Compra_Monto_Total (si la compra tiene mas de una ubicación la actualizaremos luego)
			,1 -- Según los datos de la maestra todas las ubicaciones compradas están rendidas
			,CLiente_ID
			,1 -- Según los datos de la maestra todas las ubicaciones compradas tienen forma de pago 1 - efectivo
			,Compras_Ubicaciones_ID
		FROM #COMPRAS_UBICACIONES_ITEMS2 
		WHERE MISMA_COMPRA = 0 ----cambiar por misma compra
		ORDER BY Compra_Fecha, Cli_Dni, Cli_Nombre, Espectaculo_Cod;

/*ACTUALIZO LA TABLA AUXILIAR #COMPRAS_UBICACIONES_ITEMS2 CON LOS Compra_ID GENERADOS, 
LAS COMPRAS CON MAS DE UNA UBICACION SE TERMINARAN DE CARGAR EN EL CICLO SIGUIENTE A ESTA SENTENCIA*/
UPDATE #COMPRAS_UBICACIONES_ITEMS2 SET Compra_ID = C.Compra_ID
											  FROM #Compra C
											  JOIN #COMPRAS_UBICACIONES_ITEMS2 A ON A.Compras_Ubicaciones_ID = C.Compras_Ubicaciones_ID;

/*SE CARGAN TODOS LOS Compra_ID DE LAS COMPRAS CON MAS DE UNA UBICACION,
SE ACUMULAN LAS CANTIDADES DE LAS COMPRAS,
SE ACUMULAN LOS MONTOS TOTALES DE LAS COMPRAS Y 
SE CARGA TODO EN LA TABLA AUXILIAR #COMPRAS_UBICACIONES_ITEMS2*/
WHILE ((SELECT COUNT(*) FROM #COMPRAS_UBICACIONES_ITEMS2 WHERE Compra_ID IS NULL) > 0)
BEGIN
	SELECT Compras_Ubicaciones_ID, Compra_ID, ACU_COMPRA_CANTIDAD, ACU_COMPRA_TOTAL INTO #TMP FROM #COMPRAS_UBICACIONES_ITEMS2;

		UPDATE #COMPRAS_UBICACIONES_ITEMS2 

		SET #COMPRAS_UBICACIONES_ITEMS2.Compra_ID = (SELECT #TMP.Compra_ID
												FROM #TMP
												WHERE #COMPRAS_UBICACIONES_ITEMS2.Compras_Ubicaciones_ID = #TMP.Compras_Ubicaciones_ID + 1)
		   ,#COMPRAS_UBICACIONES_ITEMS2.ACU_COMPRA_CANTIDAD = #COMPRAS_UBICACIONES_ITEMS2.Compra_Cantidad + 
														 (SELECT #TMP.ACU_COMPRA_CANTIDAD 
														  FROM #TMP
														  WHERE #COMPRAS_UBICACIONES_ITEMS2.Compras_Ubicaciones_ID = #TMP.Compras_Ubicaciones_ID + 1)
		   ,#COMPRAS_UBICACIONES_ITEMS2.ACU_COMPRA_TOTAL = #COMPRAS_UBICACIONES_ITEMS2.Ubicacion_Precio + 
														 (SELECT #TMP.ACU_COMPRA_TOTAL
														  FROM #TMP
														  WHERE #COMPRAS_UBICACIONES_ITEMS2.Compras_Ubicaciones_ID = #TMP.Compras_Ubicaciones_ID + 1)
		WHERE #COMPRAS_UBICACIONES_ITEMS2.Compra_ID IS NULL
	DROP TABLE #TMP
END

/*SE ACTUALIZAN LOS CAMPOS Compra_Cantidad y Compra_Monto_Total EN LA TABLA AUXILIAR # Compra
DE LAS COMPRAS CON MAS DE UNA UBICACION*/
UPDATE #Compra SET #Compra.Compra_Cantidad = (SELECT MAX(#COMPRAS_UBICACIONES_ITEMS2.ACU_COMPRA_CANTIDAD) 
												FROM #COMPRAS_UBICACIONES_ITEMS2 
												WHERE #Compra.Compra_ID = #COMPRAS_UBICACIONES_ITEMS2.Compra_ID
												GROUP BY #COMPRAS_UBICACIONES_ITEMS2.Compra_ID),
					#Compra.Compra_Monto_Total =  (SELECT MAX(#COMPRAS_UBICACIONES_ITEMS2.ACU_COMPRA_TOTAL) 
													FROM #COMPRAS_UBICACIONES_ITEMS2 
													WHERE #Compra.Compra_ID = #COMPRAS_UBICACIONES_ITEMS2.Compra_ID
													GROUP BY #COMPRAS_UBICACIONES_ITEMS2.Compra_ID)
FROM #Compra									  
JOIN #COMPRAS_UBICACIONES_ITEMS2 ON #Compra.Compra_ID = #COMPRAS_UBICACIONES_ITEMS2.Compra_ID
WHERE #COMPRAS_UBICACIONES_ITEMS2.MISMA_COMPRA = 1;

/*CARGA FINAL DE LA TABLA EL_GROUP_BY.COMPRAS*/
INSERT INTO EL_GROUP_BY.Compra
	SELECT Compra_Fecha
		  ,Compra_Cantidad
		  ,Compra_Monto_Total
		  ,Compra_Rendida
		  ,Cliente_ID
		  ,Forma_Pago_ID
	FROM #Compra
	ORDER BY Compras_Ubicaciones_ID ASC;

/*CARGA FINAL DE Compra_ID EN LA TABLA EL_GROUP_BY.Publicacion_Ubicacion*/

UPDATE EL_GROUP_BY.Publicacion_Ubicacion SET EL_GROUP_BY.Publicacion_Ubicacion.Compra_ID = (SELECT A.Compra_ID
														             FROM EL_GROUP_BY.#COMPRAS_UBICACIONES_ITEMS2 A
																	 WHERE EL_GROUP_BY.Publicacion_Ubicacion.Publicacion_ID = A.Publicacion_ID AND
																		   EL_GROUP_BY.Publicacion_Ubicacion.Ubicacion_ID = A.Ubicacion_ID);

/*CARGA FINAL DE LA TABLA EL_GROUP_BY.Item*/

INSERT INTO EL_GROUP_BY.Item
	SELECT DISTINCT  Item_Monto
					,Item_Cantidad
					,Item_Descripcion
					,Factura_ID
					,Compra_ID
	FROM #COMPRAS_UBICACIONES_ITEMS2;

COMMIT TRANSACTION;
GO

-- -----------------------------------------------------
-- SPMigra -- Ubicaciones Migradas Disponibles
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.UBICACIONES_MIGRADAS_DISPONIBLES AS
BEGIN TRANSACTION
	UPDATE EL_GROUP_BY.Publicacion_Ubicacion 
	SET EL_GROUP_BY.Publicacion_Ubicacion.Publicacion_Ubicacion_Disponible = 1
	WHERE EL_GROUP_BY.Publicacion_Ubicacion.Compra_ID IS NULL; 										
COMMIT TRANSACTION;
GO

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
@PRIMER_LOGIN BIT,
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
										 ,@PRIMER_LOGIN
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
-- SP - Actualizar Password
-- -----------------------------------------------------

create proc EL_GROUP_BY.ACTUALIZAR_PASSWORD
@USUARIO_ID INT,
@PASSWORD NVARCHAR(50)
as
begin
	update EL_GROUP_BY.Usuario set Usuario_Password = HASHBYTES('SHA2_256', @PASSWORD),
									Usuario_Primer_Login = 1
		where Usuario_ID = @USUARIO_ID
end
go

-- -----------------------------------------------------
-- SP - Consultar si hay algún usuario con el mismo username
-- -----------------------------------------------------

create proc EL_GROUP_BY.ES_UNICO_USERNAME
@USUARIO_NOMBRE NVARCHAR(50)
as
begin
	if exists(select 1 from EL_GROUP_BY.Usuario where Usuario_Username = @USUARIO_NOMBRE)
		select  1
	else
		select 0
end
go

-- -----------------------------------------------------
-- SP - Obtener Datos del cliente para Cabecera
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_DATOS_CLIENTE_X_ID 
@CLIENT_ID int,
@FECHA datetime
as
begin
	SELECT  
		C.Cliente_Nombre,
		C.Cliente_Apellido,
		U.Usuario_Mail,
		C.Cliente_Numero_Documento,
		isnull(sum(P.Puntos_Cantidad),0)
	FROM EL_GROUP_BY.USUARIO U 
	INNER JOIN EL_GROUP_BY.Cliente C ON C.Usuario_ID = U.Usuario_ID and C.Cliente_ID = @CLIENT_ID
	LEFT JOIN EL_GROUP_BY.Puntos P ON P.Cliente_ID = C.Cliente_ID
	AND convert(date, P.Puntos_Fecha_Vencimiento, 120) > convert(date, @FECHA, 120) 
	GROUP BY C.Cliente_Nombre,
	C.Cliente_Apellido,
	U.Usuario_Mail,
	C.Cliente_Numero_Documento
	
end
GO

-- -----------------------------------------------------
-- SP - Obtener Datos del historial de Cliente
-- -----------------------------------------------------
create procedure EL_GROUP_BY.OBTENER_HISTORIAL_CLIENTE_ID @CLIENT_ID int
as
begin

	SELECT	C.Compra_ID,
			convert(date,C.Compra_Fecha,120) as FechaCompra, 
			F.Forma_Pago_Descripcion,
			E.Espectaculo_Descripcion,
			convert(date,E.Espectaculo_Fecha,120) as FechaEspectaculo,
			U.Ubicacion_Fila,
			U.Ubicacion_Asiento,
			U.Ubicacion_Sin_Numerar,
			UT.Ubicacion_Tipo_Descripcion,
			U.Ubicacion_Precio
		FROM EL_GROUP_BY.Publicacion_Ubicacion PU
		INNER JOIN EL_GROUP_BY.Ubicacion U on U.Ubicacion_ID = PU.Ubicacion_ID
		INNER JOIN EL_GROUP_BY.Publicacion P on P.Publicacion_ID = PU.Publicacion_ID
		INNER JOIN EL_GROUP_BY.Espectaculo E on E.Espectaculo_ID = P.Espectaculo_ID
		INNER JOIN EL_GROUP_BY.Compra C on C.Compra_ID = PU.Compra_ID
		INNER JOIN EL_GROUP_BY.Forma_Pago F on F.Forma_Pago_ID = C.Forma_Pago_ID
		INNER JOIN EL_GROUP_BY.Ubicacion_Tipo UT on UT.Ubicacion_Tipo_ID = U.Ubicacion_Tipo_ID
		WHERE C.Cliente_ID = @CLIENT_ID
		ORDER BY FechaCompra ASC
end
GO

-- -----------------------------------------------------
-- SP - Obtiene el listado de Ubicaciones canjeables para X puntos
-- -----------------------------------------------------
create procedure EL_GROUP_BY.LISTAR_CANJE_DISPONIBLE 
@PUNTOS int,
@FECHA datetime
as
begin

	SELECT	PU.Publicacion_ID, 
			E.Espectaculo_Descripcion,
			convert(date, E.Espectaculo_Fecha,120) as Fecha,
			PU.Ubicacion_ID,
			U.Ubicacion_Fila,
			U.Ubicacion_Asiento,
			U.Ubicacion_Sin_Numerar,
			UT.Ubicacion_Tipo_Descripcion,
			(U.Ubicacion_Precio*5) as Puntos
	FROM EL_GROUP_BY.Publicacion_Ubicacion PU
	INNER JOIN EL_GROUP_BY.Ubicacion U on U.Ubicacion_ID = PU.Ubicacion_ID and U.Ubicacion_Canjeada = 0
	INNER JOIN EL_GROUP_BY.Publicacion P on P.Publicacion_ID = PU.Publicacion_ID
	INNER JOIN EL_GROUP_BY.Espectaculo E on E.Espectaculo_ID = P.Espectaculo_ID
	INNER JOIN EL_GROUP_BY.Ubicacion_Tipo UT on UT.Ubicacion_Tipo_ID = U.Ubicacion_Tipo_ID
	WHERE (U.Ubicacion_Precio*5) < @PUNTOS
	AND convert(date, E.Espectaculo_Fecha,120) > convert(date, @FECHA,120)
	order by Fecha, E.Espectaculo_ID, U.Ubicacion_Fila, U.Ubicacion_asiento asc
	
end
GO

-- -----------------------------------------------------
-- SP - Canjear Ubicacion
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.CANJEAR_UBICACION
@CLIENTE_ID INT,
@PUNTOS INT,
@PUBLICACION_ID INT,
@UBICACION_ID INT,
@FECHA DATETIME
AS
BEGIN TRANSACTION
	UPDATE EL_GROUP_BY.Ubicacion
		SET Ubicacion_Canjeada = 1 
		WHERE Ubicacion_ID = @UBICACION_ID

	DECLARE CU_PUNTOS CURSOR FOR
	SELECT	P.Puntos_ID,
			isnull(P.Puntos_Cantidad,0) 
	FROM EL_GROUP_BY.USUARIO U 
	INNER JOIN EL_GROUP_BY.Cliente C ON C.Usuario_ID = U.Usuario_ID and C.Cliente_ID = @CLIENTE_ID 
	LEFT JOIN EL_GROUP_BY.Puntos P ON P.Cliente_ID = C.Cliente_ID
	AND convert(date, P.Puntos_Fecha_Vencimiento, 120) > convert(date, @FECHA, 120) 
	
	DECLARE @ID INT
	DECLARE @PUNTOS_CU INT
	DECLARE @PUNTOS_RESTANTES INT
	
	SET @PUNTOS_RESTANTES = @PUNTOS

	OPEN CU_PUNTOS
	FETCH CU_PUNTOS INTO @ID, @PUNTOS_CU 
	WHILE @@FETCH_STATUS = 0 OR @PUNTOS_RESTANTES > 0
	BEGIN
		IF @PUNTOS_RESTANTES < @PUNTOS_CU
		BEGIN
			UPDATE EL_GROUP_BY.Puntos
			SET Puntos_Cantidad = Puntos_Cantidad - @PUNTOS_RESTANTES
			WHERE Puntos_ID = @ID
			
			SET @PUNTOS_RESTANTES = 0

		END 
		ELSE
		BEGIN
			UPDATE EL_GROUP_BY.Puntos
			SET Puntos_Cantidad = 0
			WHERE Puntos_ID = @ID
			
			SET @PUNTOS_RESTANTES = @PUNTOS_RESTANTES - @PUNTOS_CU
		END
	
		FETCH CU_PUNTOS INTO @ID, @PUNTOS_CU 
		
	END
	
	CLOSE CU_PUNTOS
	DEALLOCATE CU_PUNTOS

COMMIT
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
@PRIMER_LOGIN   BIT,
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
										 ,@PRIMER_LOGIN --Primer login
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
@COMISION		NUMERIC(3,2),
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
@COMISION		NUMERIC(3,2),
@PRIORIDAD		VARCHAR(10)
AS
BEGIN TRANSACTION

	UPDATE EL_GROUP_BY.Grado_Publicacion
		SET Grado_Publicacion_Comision = @COMISION,
			Grado_Publicacion_Prioridad = @PRIORIDAD
		WHERE Grado_Publicacion_ID = @ID

COMMIT
GO

-- -----------------------------------------------------
-- SP - Crear Espectaculo y Publicacion (1 a 1)
-- -----------------------------------------------------
CREATE PROCEDURE EL_GROUP_BY.CREAR_ESPECTACULO_PUBLICACION
@DESCRIPCION  NVarChar(255),
@DIRECCION NVarChar(255),
@FECHA_ESPEC DateTime,
@FECHA_VENCIMIENTO  DateTime,
@RUBRO_ID Int,
@EMPRESA_ID Int,
@FECHA_PUBLI DateTime,
@CANT_LOC INT,
@USERNAME NVARCHAR(50),
@GRADO_ID INT,
@ESTADO_ID INT,
@PUBLI_ID INT OUTPUT
as
begin transaction

	INSERT EL_GROUP_BY.Espectaculo VALUES(
		NULL, --El codigo es un campo de la migracion
		@DESCRIPCION,
		@DIRECCION,
		@FECHA_ESPEC,
		@FECHA_VENCIMIENTO,
		@RUBRO_ID,
		@EMPRESA_ID)

	INSERT EL_GROUP_BY.Publicacion VALUES(
		@DESCRIPCION,
		@FECHA_PUBLI,
		@FECHA_ESPEC,
		@CANT_LOC,
		@USERNAME,
		SCOPE_IDENTITY(),
		@GRADO_ID,
		@ESTADO_ID)
	
	SET @PUBLI_ID = SCOPE_IDENTITY();
	 

commit transaction
GO

-- -----------------------------------------------------
-- SP - Crear ubicaciones
-- -----------------------------------------------------
CREATE PROCEDURE EL_GROUP_BY.CREAR_UBICACIONES
@UBICACIONES AS UBICACION_TIPO_TABLA READONLY,
@PUBLI_ID INT 
AS
BEGIN TRANSACTION

	DECLARE @output_id TABLE (id int)

	INSERT INTO EL_GROUP_BY.Ubicacion 
	OUTPUT inserted.Ubicacion_ID INTO @output_id
	SELECT * FROM  @UBICACIONES

	INSERT INTO EL_GROUP_BY.Publicacion_Ubicacion
	SELECT id, @PUBLI_ID, null
	FROM @output_id 

COMMIT TRANSACTION
GO

-- -----------------------------------------------------
-- SP - Borrar ubicaciones
-- -----------------------------------------------------
CREATE PROCEDURE EL_GROUP_BY.BORRAR_UBICACIONES
@UBICACIONES AS PUBLICACION_UBICACION_TIPO_TABLA READONLY
AS
BEGIN TRANSACTION

	DELETE EL_GROUP_BY.Publicacion_Ubicacion
	WHERE Ubicacion_ID IN (SELECT Ubicacion_ID FROM  @UBICACIONES)
	AND Publicacion_ID IN (SELECT Publicacion_ID FROM  @UBICACIONES)

	DELETE EL_GROUP_BY.Ubicacion 
	WHERE Ubicacion_ID IN (SELECT Ubicacion_ID FROM  @UBICACIONES)

	
COMMIT TRANSACTION
GO


-- -----------------------------------------------------
-- SP - Listar Publicaciones a editar
-- -----------------------------------------------------

create procedure EL_GROUP_BY.LISTAR_PUBLICACIONES
@DESCRIPCION NVARCHAR(255),
@FECHA_DESDE DATETIME,
@FECHA_HASTA DATETIME,
@USERNAME NVARCHAR(50)
as
begin
	select  p.Publicacion_ID as 'ID',
			p.Publicacion_Descripcion as 'Descripcion',
			p.Publicacion_Fecha as 'Fecha Publicación',
			E.Espectaculo_Direccion as 'Dirección',
			E.Espectaculo_Fecha as 'Fecha Espectáculo',
			g.Grado_Publicacion_Prioridad as 'Prioridad',
			g.Grado_Publicacion_Comision as 'Comision',
			ES.Estado_Publicacion_Descripcion as 'Estado',
			r.Rubro_Descripcion as 'Rubro'
	from EL_GROUP_BY.Publicacion P 
	inner join EL_GROUP_BY.Espectaculo E on p.Espectaculo_ID = e.Espectaculo_ID
	inner join EL_GROUP_BY.Grado_Publicacion G on p.Grado_Publicacion_ID = g.Grado_Publicacion_ID
	inner join EL_GROUP_BY.Estado_Publicacion ES on ES.Estado_Publicacion_ID = p.Estado_Publicacion_ID
	AND ES.Estado_Publicacion_ID != 3 --No debe traer las finalizadas
	inner join EL_GROUP_BY.Rubro R on r.Rubro_ID = e.Rubro_ID
	WHERE P.Publicacion_Descripcion LIKE ISNULL('%' + @DESCRIPCION + '%', '%')
	AND p.Publicacion_Usuario = @USERNAME
    AND convert(date, p.Publicacion_Fecha, 120) between convert(date, @FECHA_DESDE, 120) and convert(date, @FECHA_HASTA, 120) 
	          
end
go

-- -----------------------------------------------------
-- SP - Obtiene Publicacion/Espectaculo para modificar
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_PUBLICACION_FOR_MODIFY
@PUBLI_ID int
as
begin

	SELECT	P.Publicacion_ID,
			p.Publicacion_Descripcion,
			p.Publicacion_Fecha,
			p.Publicacion_FechaHora,
			p.Publicacion_Cantidad_Localidades,
			p.Publicacion_Usuario,
			p.Espectaculo_ID,
			p.Grado_Publicacion_ID,
			p.Estado_Publicacion_ID,
			E.Espectaculo_ID,
			E.Espectaculo_Codigo,
			E.Espectaculo_Descripcion,
			E.Espectaculo_Direccion,
			E.Espectaculo_Fecha,
			E.Espectaculo_Fecha_Vencimiento,
			E.Rubro_ID,
			E.Empresa_ID,
			G.Grado_Publicacion_ID,
			G.Grado_Publicacion_Comision,
			G.Grado_Publicacion_Prioridad,
			ES.Estado_Publicacion_ID,
			ES.Estado_Publicacion_Descripcion,
			ES.Estado_Publicacion_Modificable
	FROM EL_GROUP_BY.Publicacion P
	INNER JOIN EL_GROUP_BY.Espectaculo E ON P.Espectaculo_ID = E.Espectaculo_ID
	INNER JOIN EL_GROUP_BY.Grado_Publicacion G ON G.Grado_Publicacion_ID = P.Grado_Publicacion_ID
	INNER JOIN EL_GROUP_BY.Estado_Publicacion ES ON ES.Estado_Publicacion_ID = P.Estado_Publicacion_ID
	WHERE P.Publicacion_ID = @PUBLI_ID

end
go


-- -----------------------------------------------------
-- SP - Obtiene ubicaciones de la publicacion a modificar
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_UBICACIONES
@PUBLI_ID int
as
begin

	SELECT	PU.Publicacion_ID,
			PU.Ubicacion_ID,
			U.Ubicacion_Fila,
			U.Ubicacion_Asiento,
			u.Ubicacion_Sin_Numerar,
			u.Ubicacion_Precio,
			u.Ubicacion_Tipo_ID,
			T.Ubicacion_Tipo_ID,
			T.Ubicacion_Tipo_Codigo,
			T.Ubicacion_Tipo_Descripcion
	FROM EL_GROUP_BY.Publicacion_Ubicacion PU
	INNER JOIN EL_GROUP_BY.Ubicacion U ON U.Ubicacion_ID = PU.Ubicacion_ID
	INNER JOIN EL_GROUP_BY.Ubicacion_Tipo T ON T.Ubicacion_Tipo_ID = U.Ubicacion_Tipo_ID
	WHERE PU.Publicacion_ID = @PUBLI_ID

end
go

-- -----------------------------------------------------
-- SP - Obtiene ubicaciones de la publicacion que estan 
-- disponibles para la compra
-- -----------------------------------------------------

create procedure EL_GROUP_BY.OBTENER_UBICACIONES_PARA_COMPRA
@PUBLI_ID int
as
begin

SELECT	PU.Publicacion_ID,
			PU.Ubicacion_ID,
			E.Empresa_ID,
			T.Ubicacion_Tipo_Descripcion,
			U.Ubicacion_Fila,
			U.Ubicacion_Asiento,
			u.Ubicacion_Sin_Numerar,
			u.Ubicacion_Precio,
			u.Ubicacion_Tipo_ID,
			T.Ubicacion_Tipo_Codigo
	FROM EL_GROUP_BY.Publicacion_Ubicacion PU
	INNER JOIN EL_GROUP_BY.Ubicacion U ON U.Ubicacion_ID = PU.Ubicacion_ID
	INNER JOIN EL_GROUP_BY.Ubicacion_Tipo T ON T.Ubicacion_Tipo_ID = U.Ubicacion_Tipo_ID
	INNER JOIN EL_GROUP_BY.Publicacion P on P.Publicacion_ID = PU.Publicacion_ID
	INNER JOIN EL_GROUP_BY.Espectaculo E on e.Espectaculo_ID = P.Espectaculo_ID
	WHERE PU.Publicacion_ID = @PUBLI_ID
	AND U.Ubicacion_Canjeada = 0
	AND PU.Compra_ID is null

end
go

-- -----------------------------------------------------
-- SP - Edita publicacion y espectaculo
-- -----------------------------------------------------
CREATE PROCEDURE EL_GROUP_BY.EDITAR_ESPECTACULO_PUBLICACION
@PUBLI_ID INT,
@ESPEC_ID INT,
@DESCRIPCION  NVarChar(255),
@DIRECCION NVarChar(255),
@FECHA_ESPEC DateTime,
@FECHA_VENCIMIENTO  DateTime,
@RUBRO_ID Int,
@FECHA_PUBLI DateTime,
@CANT_LOC INT,
@GRADO_ID INT,
@ESTADO_ID INT
as
begin transaction

	
	UPDATE EL_GROUP_BY.Espectaculo 
		SET Espectaculo_Descripcion = @DESCRIPCION,
			Espectaculo_Direccion = @DIRECCION,
			Espectaculo_Fecha = @FECHA_ESPEC,
			Espectaculo_Fecha_Vencimiento =  @FECHA_VENCIMIENTO,
			Rubro_ID = @RUBRO_ID
		WHERE Espectaculo_ID = @ESPEC_ID
		

	UPDATE EL_GROUP_BY.Publicacion 
		SET Publicacion_Descripcion = @DESCRIPCION,
			Publicacion_Fecha =  @FECHA_PUBLI,
			Publicacion_FechaHora =  @FECHA_ESPEC,
			Publicacion_Cantidad_Localidades =  @CANT_LOC,
			Grado_Publicacion_ID = @GRADO_ID,
			Estado_Publicacion_ID = @ESTADO_ID
		WHERE Publicacion_ID = @PUBLI_ID	


commit transaction
GO

-- -----------------------------------------------------
-- SP - Busca publicacion con los mismos datos
-- -----------------------------------------------------
CREATE PROCEDURE EL_GROUP_BY.EXISTE_ESPECTACULO_PUBLICACION
@PUBLI_ID INT,
@DESCRIPCION  NVarChar(255),
@FECHA_PUBLI DateTime,
@FECHA_ESPEC DateTime,
@DIRECCION NVarChar(255),
@RUBRO_ID Int,
@GRADO_ID INT,
@EXISTE BIT OUTPUT
as
begin

	SET @EXISTE = 0;

	SELECT @EXISTE = 1 
	WHERE exists(
		Select 1 FROM  EL_GROUP_BY.Publicacion P
		INNER JOIN EL_GROUP_BY.Espectaculo E on E.Espectaculo_ID = P.Espectaculo_ID
		WHERE p.Publicacion_Descripcion = @DESCRIPCION 
		AND p.Publicacion_Fecha =  @FECHA_PUBLI 
		AND e.Espectaculo_Fecha = @FECHA_ESPEC
		AND E.Espectaculo_Direccion = @DIRECCION 
		AND E.Rubro_ID = @RUBRO_ID 
		AND P.Grado_Publicacion_ID = @GRADO_ID 
		AND P.Publicacion_ID != @PUBLI_ID)
		
end
GO



-- -----------------------------------------------------
-- SP - Listar Compras de una Empresa para Rendir
-- -----------------------------------------------------

CREATE PROCEDURE EL_GROUP_BY.LISTAR_COMPRAS_EMPRESA
@ID_EMPRESA INT,
@FECHA DATETIME
as
begin

	SELECT	C.Compra_ID AS 'Id Compra',
			C.Compra_Fecha as 'Fecha de Compra',
			PU.Publicacion_ID,
			U.Ubicacion_ID,
			ES.Espectaculo_Descripcion as 'Espectáculo',
			ES.Espectaculo_Fecha as 'Fecha Espectáculo',
			U.Ubicacion_Fila as 'Fila',
			U.Ubicacion_Asiento as 'Asiento',
			U.Ubicacion_Sin_Numerar as 'Sin Numerar',
			UT.Ubicacion_Tipo_Descripcion AS 'Tipo de Ubicación',
			u.Ubicacion_Precio as 'Precio',
			G.Grado_Publicacion_Comision as 'Comision de compra',
			FP.Forma_Pago_Descripcion AS 'Forma de Pago',
			P.Grado_Publicacion_ID
	FROM EL_GROUP_BY.Compra C
	INNER JOIN EL_GROUP_BY.Publicacion_Ubicacion PU on C.Compra_ID = PU.Compra_ID
	INNER JOIN EL_GROUP_BY.Forma_Pago FP ON FP.Forma_Pago_ID = C.Forma_Pago_ID
	INNER JOIN EL_GROUP_BY.Ubicacion U on PU.Ubicacion_ID = U.Ubicacion_ID
	INNER JOIN EL_GROUP_BY.Ubicacion_Tipo UT ON UT.Ubicacion_Tipo_ID = U.Ubicacion_Tipo_ID
	INNER JOIN EL_GROUP_BY.Publicacion p ON P.Publicacion_ID = PU.Publicacion_ID
	INNER JOIN EL_GROUP_BY.Espectaculo ES ON ES.Espectaculo_ID = P.Espectaculo_ID
	INNER JOIN EL_GROUP_BY.Empresa EM ON EM.Empresa_ID = ES.Empresa_ID
	AND EM.Empresa_ID = @ID_EMPRESA
	INNER JOIN EL_GROUP_BY.Grado_Publicacion G on G.Grado_Publicacion_ID = P.Grado_Publicacion_ID
	WHERE C.Compra_Fecha < @FECHA
	AND C.Compra_Rendida = 0
	ORDER BY C.Compra_ID, pu.Publicacion_ID, u.Ubicacion_ID

end
go


-- -----------------------------------------------------
-- SP - Crear Factura
-- -----------------------------------------------------
CREATE PROCEDURE EL_GROUP_BY.CREAR_FACTURA
@FECHA DATETIME,
@TOTAL NUMERIC(18,2),
@EMPRESA_ID INT,
@FACTURA_ID INT OUTPUT
as
begin transaction

	INSERT EL_GROUP_BY.Factura VALUES(
		(SELECT MAX(F.Factura_Nro) FROM EL_GROUP_BY.Factura F)+1,
		@FECHA,
		@TOTAL,
		@EMPRESA_ID)

	SET @FACTURA_ID  = SCOPE_IDENTITY();
	 

commit transaction
GO


-- -----------------------------------------------------
-- SP - Crear ITEMS
-- -----------------------------------------------------
CREATE PROCEDURE EL_GROUP_BY.CREAR_ITEMS
@ITEMS AS ITEM_TIPO_TABLA READONLY
AS
BEGIN TRANSACTION

	INSERT INTO EL_GROUP_BY.Item 
		SELECT * FROM  @ITEMS

	UPDATE EL_GROUP_BY.Compra SET Compra_Rendida = 1
	WHERE Compra_ID in (SELECT Compra_ID FROM @ITEMS)

COMMIT TRANSACTION
GO


-- -----------------------------------------------------
-- SP - Listado Clientes con mayores puntos vencidos
-- -----------------------------------------------------
create procedure EL_GROUP_BY.LISTAR_CLIENTES_MAYORES_PUNTOS_VENCIDOS
@fecha_desde datetime,
@fecha_hasta datetime
as
begin

	SELECT TOP 5 
		C.Cliente_ID as 'ID del Cliente',
		C.Cliente_Nombre as 'Nombre',
		c.Cliente_Apellido as 'Apellido',
		isnull(sum(P.Puntos_Cantidad),0) as 'Puntos Vencidos'
	FROM EL_GROUP_BY.Cliente C
	LEFT JOIN EL_GROUP_BY.Puntos P ON P.Cliente_ID = C.Cliente_ID
	AND convert(date, P.Puntos_Fecha_Vencimiento, 120) > convert(date, @fecha_desde, 120) 
	AND convert(date, P.Puntos_Fecha_Vencimiento, 120) < convert(date, @fecha_hasta, 120) 
	GROUP BY C.Cliente_ID, C.Cliente_Nombre, c.Cliente_Apellido
	ORDER BY 'Puntos Vencidos' DESC

end
GO

-- -----------------------------------------------------
-- SP - Listado Clientes con mayor cantidad de compras
-- -----------------------------------------------------
create procedure EL_GROUP_BY.LISTAR_CLIENTES_MAYOR_CANTIDAD_COMPRAS
@fecha_desde datetime,
@fecha_hasta datetime
as
begin

	SELECT TOP 5 
				 CL.Cliente_ID as 'ID del Cliente',
				 CL.Cliente_Nombre as 'Nombre',
				 CL.Cliente_Apellido as 'Apellido', 
				 EM.Empresa_ID as 'ID de la empresa',
				 EM.Empresa_Razon_Social as 'Razón Social',
				 count(CO.Compra_ID) as 'Cantidad de Compras'  
	FROM EL_GROUP_BY.Publicacion_Ubicacion PU 
	INNER JOIN EL_GROUP_BY.Compra CO on CO.Compra_ID = PU.Compra_ID
	AND convert(date, CO.Compra_Fecha, 120) > convert(date, @fecha_desde, 120) 
	AND convert(date, CO.Compra_Fecha, 120) < convert(date, @fecha_hasta, 120) 
	INNER JOIN EL_GROUP_BY.Cliente CL on CL.Cliente_ID = CO.Cliente_ID
	INNER JOIN EL_GROUP_BY.Publicacion P on P.Publicacion_ID = PU.Publicacion_ID
	INNER JOIN EL_GROUP_BY.Espectaculo ES on ES.Espectaculo_ID = P.Espectaculo_ID
	INNER JOIN EL_GROUP_BY.Empresa EM on EM.Empresa_ID = ES.Empresa_ID
	GROUP BY EM.Empresa_ID, EM.Empresa_Razon_Social, CL.Cliente_ID, CL.Cliente_Nombre, CL.Cliente_Apellido
	ORDER BY 'Cantidad de Compras' desc

end
GO


-- -----------------------------------------------------
-- SP - Listado empresas mayor cant localidades no vendidas
-- -----------------------------------------------------
create procedure EL_GROUP_BY.LISTAR_EMPRESAS_MAYOR_CANTIDAD_LOCALIDADES_NO_VENDIDAS
@fecha_desde datetime,
@fecha_hasta datetime,
@PRIORIDAD int,
@MES int
as
begin

	SELECT TOP 5 
				 EM.Empresa_ID  as 'ID de la Empresa', 
				 EM.Empresa_Razon_Social as 'Razon Social', 
				 COUNT(PU.Publicacion_ID) AS 'Localidades no vendidas', 
				 g.Grado_Publicacion_Prioridad as 'Grado de Prioridad'
	FROM EL_GROUP_BY.Publicacion_Ubicacion PU  
	INNER JOIN EL_GROUP_BY.Publicacion P ON PU.Publicacion_ID = P.Publicacion_ID
	AND P.Grado_Publicacion_ID = @PRIORIDAD
	AND month(P.Publicacion_Fecha) = @MES
	INNER JOIN EL_GROUP_BY.Espectaculo ES ON P.Espectaculo_ID = ES.Espectaculo_ID
	INNER JOIN EL_GROUP_BY.Empresa EM ON ES.Empresa_ID = EM.Empresa_ID
	INNER JOIN EL_GROUP_BY.Grado_Publicacion g on g.Grado_Publicacion_ID = p.Grado_Publicacion_ID
	WHERE PU.Compra_ID IS NULL
	GROUP BY EM.Empresa_ID, EM.Empresa_Razon_Social, g.Grado_Publicacion_Prioridad


end
GO

-- -----------------------------------------------------
-- SP - Listado publicaciones publicadas para comprar
-- -----------------------------------------------------	

create procedure EL_GROUP_BY.LISTAR_PUBLICACIONES_DISPONIBLES_COMPRA
@FECHA_DESDE DATETIME, 
@FECHA_HASTA DATETIME,
@FECHA_SIST DATETIME,
@DESCRIPCION VARCHAR(255),
@RUBRO_UNO INT,
@RUBRO_DOS INT,
@RUBRO_TRES INT
as
begin
	
	select  P.Publicacion_ID,
			G.Grado_Publicacion_Prioridad,
			E.Espectaculo_Descripcion,
			E.Espectaculo_Fecha,
			count(PU.Ubicacion_ID) as 'Localidades disponibles', 
			E.Espectaculo_Direccion,
			R.Rubro_Descripcion
	from EL_GROUP_BY.Publicacion P 
	inner join EL_GROUP_BY.Espectaculo E on P.Espectaculo_ID = E.Espectaculo_ID 
	inner join EL_GROUP_BY.Rubro R on E.Rubro_ID = R.Rubro_ID 
	inner join EL_GROUP_BY.Grado_Publicacion G on P.Grado_Publicacion_ID = G.Grado_Publicacion_ID
	inner join EL_GROUP_BY.Publicacion_Ubicacion PU on PU.Publicacion_ID = P.Publicacion_ID
	and PU.Compra_ID is null --Que no haya sido comprada
	inner join EL_GROUP_BY.Ubicacion U on PU.Ubicacion_ID = U.Ubicacion_ID
	and U.Ubicacion_Canjeada = 0 --Que no haya sido canjeada
	where E.Espectaculo_Fecha between @FECHA_DESDE and @FECHA_HASTA
		and p.Estado_Publicacion_ID = 2	   
		and E.Espectaculo_Fecha_Vencimiento > @FECHA_SIST --Que no este vencida
		and P.Publicacion_Descripcion LIKE ISNULL('%' + @DESCRIPCION + '%', '%')
		and (E.Rubro_ID = @RUBRO_UNO or E.Rubro_ID = @RUBRO_DOS or E.Rubro_ID = @RUBRO_TRES)
	group by P.Publicacion_ID, G.Grado_Publicacion_Prioridad, E.Espectaculo_Descripcion, 
			 E.Espectaculo_Fecha, G.Grado_Publicacion_ID, E.Espectaculo_Direccion, R.Rubro_Descripcion
	--order by G.Grado_Publicacion_ID desc
	--queda pendiente ordenar por grado cuando nos definan como es el peso

end
go

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
EXEC EL_GROUP_BY.CARGAR_COMPRAS_E_ITEMS;
EXEC EL_GROUP_BY.UBICACIONES_MIGRADAS_DISPONIBLES;
/****************************************************************
*			EJECUCIÓN DE MIGRACIÓN - FIN						*
****************************************************************/


/****************************************************************
*			CONSTRAINTS UNIQUE, CHECK - INICIO					*
****************************************************************/
-- VALIDAMOS USERNAME ÚNICO --
ALTER TABLE EL_GROUP_BY.Usuario 
ADD CONSTRAINT UQ_Usuario_Username 
	UNIQUE(Usuario_Username); 

-- VALIDAMOS TIPO Y NUMERO DE DNI ÚNICO --
ALTER TABLE EL_GROUP_BY.Cliente 
ADD CONSTRAINT UQ_Tipo_Num_Doc 
	UNIQUE (Cliente_Tipo_Documento, Cliente_Numero_Documento) 

-- VALIDAMOS CUIT ÚNICO --
ALTER TABLE EL_GROUP_BY.Empresa 
ADD CONSTRAINT UQ_Empresa_Cuit 
	UNIQUE (Empresa_Cuit);

-- VALIDAMOS RAZÓN SOCIAL ÚNICA --	
ALTER TABLE EL_GROUP_BY.Empresa 
ADD CONSTRAINT UQ_Empresa_Razon 
UNIQUE (Empresa_Razon_Social);

-- VALIDAMOS COMISIÓN ENTRE 0 Y 100 % --
ALTER TABLE EL_GROUP_BY.Grado_Publicacion 
ADD CONSTRAINT CHK_Porc_Comision_entre_0y100 
	CHECK ( Grado_Publicacion_Comision >= 0.00 AND Grado_Publicacion_Comision <= 1.00);

-- VALIDAMOS COMPRAS NO NEGATIVAS --
ALTER TABLE EL_GROUP_BY.Compra
ADD CONSTRAINT CHK_Monto_No_Negativo 
	CHECK ( Compra_Monto_Total >= 0.00);
/****************************************************************
*			CONSTRAINTS UNIQUE, CHECK - FIN						*
****************************************************************/

/****************************************************************
*						INDICES - INICIO						*
****************************************************************/

/****************************************************************
*						INDICES - FIN							*
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
drop proc el_group_by.OBTENER_HISTORIAL_CLIENTE_ID
select distinct A.Cli_Nombre, A.Cli_Dni 
from gd_esquema.Maestra A
join gd_esquema.Maestra B ON  a.cli_dni = b.cli_dni
where a.cli_nombre != b.cli_nombre;
select * from El_group_by.Rubro;
SELECT * FROM EL_GROUP_BY.Compra;
SELECT * FROM EL_GROUP_BY.Publicacion_Ubicacion WHERE COMPRA_ID > 90879 ORDER BY COMPRA_ID;
TABLE SELECT * FROM EL_GROUP_BY.#COMPRAS_UBICACIONES2 WHERE compras_ubicaciones_id >90990;
SELECT * FROM EL_GROUP_BY.Publicacion_Ubicacion order by compra_id;
select * from gd_esquema.maestra;
select * from EL_GROUP_BY.Empresa;
select * from EL_GROUP_BY.Compra;
select * from EL_GROUP_BY.Publicacion_Ubicacion order by Compra_ID desc;
select count(*) from  EL_GROUP_BY.Publicacion_Ubicacion where Compra_ID is not NULL;
select * from EL_GROUP_BY.Item
use GD2C2018
select * from gd_esquema.Maestra
*/
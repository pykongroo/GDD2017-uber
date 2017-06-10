USE GD1C2017

/*---CREAR ESQUEMA SI NO EXISTE---*/
IF NOT EXISTS (
	SELECT  schema_name
	FROM    information_schema.SCHEMATA
	WHERE   schema_name = 'LJDG' )
	EXEC sp_executesql N'CREATE SCHEMA LJDG '
GO

/*---BORRO LAS TABLAS SI EXISTEN---*/

--Vistas
IF OBJECT_ID('LJDG.Viaje_Rendicion') IS NOT NULL
	DROP VIEW [LJDG].[Viaje_Rendicion]
GO

IF OBJECT_ID('LJDG.Viaje_Factura') IS NOT NULL
	DROP VIEW [LJDG].[Viaje_Factura]
GO

--Tablas
IF OBJECT_ID('LJDG.Factura') IS NOT NULL
    DROP TABLE LJDG.Factura;
GO

IF OBJECT_ID('LJDG.Funcionalidad_Rol') IS NOT NULL
    DROP TABLE LJDG.Funcionalidad_Rol;
GO

IF OBJECT_ID('LJDG.Funcionalidad') IS NOT NULL
    DROP TABLE LJDG.Funcionalidad;
GO

IF OBJECT_ID('LJDG.Rendicion') IS NOT NULL
    DROP TABLE LJDG.Rendicion;
GO

IF OBJECT_ID('LJDG.Rol_Usuario') IS NOT NULL
    DROP TABLE LJDG.Rol_Usuario;
GO

IF OBJECT_ID('LJDG.Rol') IS NOT NULL
    DROP TABLE LJDG.Rol;
Go

IF OBJECT_ID('LJDG.Viaje') IS NOT NULL
    DROP TABLE LJDG.Viaje;
GO

IF OBJECT_ID('LJDG.Automovil') IS NOT NULL
    DROP TABLE LJDG.Automovil;
GO

IF OBJECT_ID('LJDG.Turno') IS NOT NULL
    DROP TABLE LJDG.Turno;
GO

IF OBJECT_ID('LJDG.Cliente') IS NOT NULL
    DROP TABLE LJDG.Cliente;
GO

IF OBJECT_ID('LJDG.Chofer') IS NOT NULL
    DROP TABLE LJDG.Chofer;
GO

IF OBJECT_ID('LJDG.Usuario') IS NOT NULL
    DROP TABLE LJDG.Usuario;
GO

IF OBJECT_ID('LJDG.Marca') IS NOT NULL
    DROP TABLE LJDG.Marca;
GO

/*---DEFINICION DE TABLAS---*/
CREATE TABLE LJDG.Marca
(
	marc_id             int IDENTITY(1,1) NOT NULL ,
	marc_nombre         varchar(255)  NULL ,
	PRIMARY KEY  NONCLUSTERED (marc_id ASC)
)
GO

CREATE TABLE LJDG.Usuario
(
	user_id              char(30)  NOT NULL ,
	user_password        char(64)  NOT NULL ,
	user_habilitado      bit  NOT NULL ,
	user_intentos		 int NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (user_id ASC)
)
GO

ALTER TABLE LJDG.Usuario ADD  CONSTRAINT DF_Usuario_user_habilitado  DEFAULT ((1)) FOR user_habilitado
GO

ALTER TABLE LJDG.Usuario ADD  CONSTRAINT DF_Usuario_user_intentos  DEFAULT ((3)) FOR user_intentos
GO


CREATE TABLE LJDG.Cliente
(
	clie_id              int IDENTITY(1,1) NOT NULL ,
	clie_nombre          varchar(255) NOT NULL ,
	clie_apellido        varchar(255) NOT NULL ,
	clie_dni             numeric(18,0) NOT NULL ,
	clie_direccion       varchar(255) NOT NULL ,
	clie_cp              varchar(10)  NULL ,
	clie_telefono        numeric(18,0) UNIQUE NOT NULL ,
	clie_mail            varchar(50)  NULL ,
	clie_fecha_nac       datetime NOT NULL ,
	clie_habilitado      bit  NOT NULL ,
	clie_user			 char(30) UNIQUE NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (clie_id ASC) ,
	FOREIGN KEY (clie_user) REFERENCES LJDG.Usuario(user_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

ALTER TABLE LJDG.Cliente ADD  CONSTRAINT DF_Cliente_clie_habilitado  DEFAULT ((1)) FOR clie_habilitado
GO

CREATE TABLE LJDG.Chofer
(
	chof_id              int IDENTITY(1,1) NOT NULL ,
	chof_nombre          varchar(255) NOT NULL ,
	chof_apellido        varchar(255) NOT NULL ,
	chof_dni             numeric(18,0) NOT NULL ,
	chof_direccion       varchar(255) NOT NULL ,
	chof_telefono        numeric(18,0) NOT NULL ,
	chof_mail            varchar(50) NOT NULL ,
	chof_fecha_nac       datetime NOT NULL ,
	chof_habilitado      bit  NOT NULL ,
	chof_user			 char(30) UNIQUE NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (chof_id ASC) ,
	FOREIGN KEY (chof_user) REFERENCES LJDG.Usuario(user_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

ALTER TABLE LJDG.Chofer ADD  CONSTRAINT DF_Chofer_chof_habilitado  DEFAULT ((1)) FOR chof_habilitado
GO

CREATE TABLE LJDG.Turno
(
	turn_id              int IDENTITY(1,1) NOT NULL ,
	turn_hora_inicio     numeric(18,0) NOT NULL ,
	turn_hora_fin        numeric(18,0) NOT NULL ,
	turn_descripcion     varchar(255)  NULL ,
	turn_valor_km        numeric(18,2) NOT NULL ,
	turn_precio_base     numeric(18,2) NOT NULL ,
	turn_habilitado      bit  NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (turn_id ASC)
)
GO

ALTER TABLE LJDG.Turno ADD  CONSTRAINT DF_Turno_turn_habilitado  DEFAULT ((1)) FOR turn_habilitado
GO

/*ALTER TABLE LJDG.Turno  WITH CHECK ADD  CONSTRAINT CK_Turno CHECK  ((turn_hora_inicio>=(0) AND turn_hora_inicio<(24) AND turn_hora_fin>(0) AND turn_hora_fin<=(24)))
GO

ALTER TABLE LJDG.Turno CHECK CONSTRAINT CK_Turno
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hora inicio y hora fin' , @level0type=N'SCHEMA',@level0name=N'LJDG', @level1type=N'TABLE',@level1name=N'Turno', @level2type=N'CONSTRAINT',@level2name=N'CK_Turno'
GO*/
--PARA LIMITAR HORA INICIO Y FIN A QUE SEA ENTRE LAS 0 Y LAS 24


CREATE TABLE LJDG.Automovil
(
	auto_id				 int IDENTITY(1,1) NOT NULL,
	auto_marca           int  NOT NULL ,
	auto_patente         char(10) UNIQUE NOT NULL ,
	auto_modelo          varchar(255)  NULL ,
	auto_licencia        varchar(26)  NULL ,
	auto_rodado          varchar(10)  NULL ,
	auto_chofer          int  NOT NULL ,
	auto_turno			 int NOT NULL,
	auto_habilitado      bit  NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (auto_id ASC),
	FOREIGN KEY (auto_marca) REFERENCES LJDG.Marca(marc_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	FOREIGN KEY (auto_chofer) REFERENCES LJDG.Chofer(chof_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	FOREIGN KEY (auto_turno) REFERENCES LJDG.Turno(turn_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

CREATE TABLE LJDG.Viaje
(
	viaj_id              numeric(18,0) IDENTITY(1,1) NOT NULL ,
	viaj_cant_km         numeric(18,0)  NOT NULL ,
	viaj_fecha_inicio    datetime NOT NULL ,
	viaj_fecha_fin       datetime  NULL ,
	viaj_turno           int  NOT NULL ,
	viaj_auto            int  NOT NULL ,
	viaj_chofer          int  NOT NULL ,
	viaj_cliente         int  NOT NULL ,
	viaj_precio          numeric(18,2) NULL ,
	viaj_importe_rend	 numeric(18,2) NULL ,
	PRIMARY KEY  NONCLUSTERED (viaj_id ASC),
	FOREIGN KEY (viaj_auto) REFERENCES LJDG.Automovil(auto_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (viaj_chofer) REFERENCES LJDG.Chofer(chof_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (viaj_turno) REFERENCES LJDG.Turno(turn_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (viaj_cliente) REFERENCES LJDG.Cliente(clie_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

--se puede agregar un CONSTRAINT CHECK para que fecha inicio sea anterior a fecha fin o algo asi

CREATE TABLE LJDG.Rol
(
	rol_id               int IDENTITY(1,1) NOT NULL ,
	rol_nombre           varchar(255)  NULL ,
	rol_habilitado       bit  NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (rol_id ASC)
)
GO

ALTER TABLE LJDG.Rol ADD  CONSTRAINT DF_Rol_rol_habilitado  DEFAULT ((1)) FOR rol_habilitado
GO


CREATE TABLE LJDG.Rol_Usuario
(
	rxu_rol              int  NOT NULL ,
	rxu_user             char(30)  NOT NULL ,
	PRIMARY KEY  CLUSTERED (rxu_rol ASC,rxu_user ASC),
	 FOREIGN KEY (rxu_rol) REFERENCES LJDG.Rol(rol_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (rxu_user) REFERENCES LJDG.Usuario(user_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

CREATE TABLE LJDG.Funcionalidad
(
	func_id              int IDENTITY(1,1) NOT NULL ,
	func_descripcion     varchar(255)  NULL ,
	PRIMARY KEY  NONCLUSTERED (func_id ASC)
)
GO

CREATE TABLE LJDG.Funcionalidad_Rol
(
	fxr_funcionalidad    int  NOT NULL ,
	fxr_rol              int  NOT NULL ,
	PRIMARY KEY  CLUSTERED (fxr_funcionalidad ASC,fxr_rol ASC),
	 FOREIGN KEY (fxr_funcionalidad) REFERENCES LJDG.Funcionalidad(func_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (fxr_rol) REFERENCES LJDG.Rol(rol_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

CREATE TABLE LJDG.Factura
(
	fact_nro             numeric(18,0) IDENTITY(1,1) NOT NULL ,
	fact_fecha_inicio    datetime  NOT NULL ,
	fact_fecha_fin       datetime  NOT NULL ,
	fact_fecha           datetime  NOT NULL ,
	fact_cliente         int  NOT NULL ,
	fact_importe_total   numeric(18,2) NULL ,
	PRIMARY KEY  NONCLUSTERED (fact_nro ASC),
	FOREIGN KEY (fact_cliente) REFERENCES LJDG.Cliente(clie_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

CREATE TABLE LJDG.Rendicion
(
	rend_nro             numeric(18,0) IDENTITY(1,1) NOT NULL ,
	rend_fecha           datetime  NULL ,
	rend_turno           int  NOT NULL ,
	rend_chofer          int  NOT NULL ,
	rend_importe_total   numeric(18,2) NULL ,
	PRIMARY KEY  NONCLUSTERED (rend_nro ASC),
	 FOREIGN KEY (rend_chofer) REFERENCES LJDG.Chofer(chof_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (rend_turno) REFERENCES LJDG.Turno(turn_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

CREATE VIEW LJDG.Viaje_Factura
AS
SELECT	LJDG.Factura.fact_nro, LJDG.Factura.fact_fecha_inicio, LJDG.Factura.fact_fecha_fin, LJDG.Factura.fact_cliente,
		 LJDG.Viaje.viaj_id, LJDG.Viaje.viaj_fecha_inicio, LJDG.Viaje.viaj_precio
FROM	LJDG.Factura INNER JOIN
		LJDG.Viaje ON LJDG.Factura.fact_cliente = LJDG.Viaje.viaj_cliente
WHERE	(LJDG.viaje_entra_en_factura(LJDG.Viaje.viaj_fecha_inicio, LJDG.Factura.fact_fecha_inicio, LJDG.Factura.fact_fecha_fin) = 1)

GO

CREATE VIEW LJDG.Viaje_Rendicion
AS
SELECT	LJDG.Rendicion.rend_nro, LJDG.Rendicion.rend_fecha, LJDG.Rendicion.rend_chofer, LJDG.Rendicion.rend_turno, LJDG.Viaje.viaj_id, LJDG.Viaje.viaj_importe_rend
FROM	LJDG.Rendicion INNER JOIN
        LJDG.Viaje ON LJDG.Rendicion.rend_chofer = LJDG.Viaje.viaj_chofer and LJDG.Rendicion.rend_turno = LJDG.Viaje.viaj_turno
WHERE	(LJDG.viaje_entra_en_rendicion(LJDG.Viaje.viaj_fecha_inicio,LJDG.Rendicion.rend_fecha) = 1)

GO

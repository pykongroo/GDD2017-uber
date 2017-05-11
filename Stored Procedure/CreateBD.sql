USE GD1C2017

-- ESQUEMA
IF OBJECT_ID('LJDG') IS NOT NULL
	DROP SCHEMA LJDG
GO
CREATE SCHEMA LJDG
GO

-- TIPO DE DATOS
IF OBJECT_ID('LJDG.Habilitado') IS NOT NULL
	DROP TYPE LJDG.Habilitado
GO
CREATE TYPE LJDG.Habilitado
	FROM BIT NOT NULL
GO

IF OBJECT_ID('LJDG.Precio') IS NOT NULL
	DROP TYPE LJDG.Precio
CREATE TYPE LJDG.Precio
	FROM NUMERIC(18,2) NULL
GO


-- TABLAS
CREATE TABLE LJDG.Marca
( 
	marca_id             int  NOT NULL ,
	marca_nombre         varchar(255)  NULL ,
	PRIMARY KEY  NONCLUSTERED (marca_id ASC)
)
go

CREATE TABLE LJDG.Usuario
( 
	user_id              char(30)  NOT NULL ,
	user_password        char(64)  NOT NULL ,
	user_nombre          varchar(255)  NULL ,
	user_apellido        varchar(255)  NULL ,
	user_dni             numeric  NULL ,
	user_direccion       varchar(255)  NULL ,
	user_telefono        numeric  NULL ,
	user_mail            varchar(50)  NULL ,
	user_fecha_nac       datetime  NULL ,
	user_habilitado      LJDG.Habilitado  NOT NULL ,
	user_cp              varchar(10)  NULL ,
	PRIMARY KEY  NONCLUSTERED (user_id ASC)
)
go

CREATE TABLE LJDG.Auto
( 
	auto_patente         char(10)  NOT NULL ,
	auto_modelo          varchar(255)  NULL ,
	auto_licencia        varchar(26)  NULL ,
	auto_rodado          varchar(10)  NULL ,
	auto_habilitado      LJDG.Habilitado  NOT NULL ,
	auto_marca           int  NOT NULL ,
	auto_chofer          char(30)  NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (auto_patente ASC),
	 FOREIGN KEY (auto_marca) REFERENCES LJDG.Marca(marca_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (auto_chofer) REFERENCES LJDG.Usuario(user_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go

CREATE TABLE LJDG.Turno
( 
	turn_id              int  NOT NULL ,
	turn_hora_inicio     numeric(18)  NULL ,
	turn_hora_fin        numeric(18)  NULL ,
	turn_descripcion     varchar(255)  NULL ,
	turn_valor_km        numeric(18,2)  NULL ,
	turn_precio_base     LJDG.Precio ,
	turn_habilitado      LJDG.Habilitado  NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (turn_id ASC)
)
go

CREATE TABLE LJDG.Viaje
( 
	viaj_id              numeric(18)  NOT NULL ,
	viaj_cant_km         numeric(18)  NULL ,
	viaj_fecha           datetime  NULL ,
	viaj_precio          LJDG.Precio ,
	viaj_auto            char(10)  NOT NULL ,
	viaj_chofer          char(30)  NOT NULL ,
	viaj_turno           int  NOT NULL ,
	viaj_cliente         char(30)  NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (viaj_id ASC),
	 FOREIGN KEY (viaj_auto) REFERENCES LJDG.Auto(auto_patente)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (viaj_chofer) REFERENCES LJDG.Usuario(user_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (viaj_turno) REFERENCES LJDG.Turno(turn_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (viaj_cliente) REFERENCES LJDG.Usuario(user_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go

CREATE TABLE LJDG.Rol
( 
	rol_id               int  NOT NULL ,
	rol_nombre           varchar(255)  NULL ,
	rol_habilitado       LJDG.Habilitado  NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (rol_id ASC)
)
go

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
go

CREATE TABLE LJDG.Rendicion
( 
	rend_nro             numeric(18)  NOT NULL ,
	rend_fecha           datetime  NULL ,
	rend_importe_total   LJDG.Precio ,
	rend_chofer          char(30)  NOT NULL ,
	rend_turno           int  NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (rend_nro ASC),
	 FOREIGN KEY (rend_chofer) REFERENCES LJDG.Usuario(user_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (rend_turno) REFERENCES LJDG.Turno(turn_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go

CREATE TABLE LJDG.Funcionalidad
( 
	func_id              int  NOT NULL ,
	func_nombre          varchar(255)  NULL ,
	PRIMARY KEY  NONCLUSTERED (func_id ASC)
)
go

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
go

CREATE TABLE LJDG.Factura
( 
	fact_nro             numeric(18)  NOT NULL ,
	fact_fecha_inicio    datetime  NULL ,
	fact_fecha_fin       datetime  NULL ,
	fact_fecha           datetime  NULL ,
	fact_importe_total   numeric(18,2)  NULL ,
	fact_cliente         char(30)  NOT NULL ,
	PRIMARY KEY  NONCLUSTERED (fact_nro ASC),
	 FOREIGN KEY (fact_cliente) REFERENCES LJDG.Usuario(user_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go

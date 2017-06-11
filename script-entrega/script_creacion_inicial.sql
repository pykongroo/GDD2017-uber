USE GD1C2017
GO

/*---CREACION DE ESQUEMA SI NO EXISTE---*/
IF NOT EXISTS (
	SELECT  schema_name
	FROM    information_schema.SCHEMATA
	WHERE   schema_name = 'LJDG' )
	EXEC sp_executesql N'CREATE SCHEMA LJDG '
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
	viaj_precio          numeric(18,2) NULL
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

CREATE TABLE LJDG.Viaje_Factura
(
	vxf_viaje    numeric(18,0)  NOT NULL ,
	vxf_factura  numeric(18,0) NOT NULL ,
	PRIMARY KEY  CLUSTERED (vxf_viaje ASC, vxf_factura ASC),
	 FOREIGN KEY (vxf_viaje) REFERENCES LJDG.Viaje(viaj_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (vxf_factura) REFERENCES LJDG.Factura(fact_nro)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

CREATE TABLE LJDG.Viaje_Rendicion
(
	vxr_viaje    numeric(18,0)  NOT NULL ,
	vxr_rendicion numeric(18,0) NOT NULL ,
	vxr_importe	 numeric(18,2)  NOT NULL ,
	PRIMARY KEY  CLUSTERED (vxr_viaje ASC, vxr_rendicion ASC),
	 FOREIGN KEY (vxr_viaje) REFERENCES LJDG.Viaje(viaj_id)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	 FOREIGN KEY (vxr_rendicion) REFERENCES LJDG.Rendicion(rend_nro)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
GO

/*--CREACION DE OBJETOS--*/

--FUNCIONES--

CREATE FUNCTION LJDG.easy_username
(
	@nombre varchar(255) , @apellido varchar(255)
)
RETURNS varchar(255)
AS
BEGIN
	RETURN Lower(Substring(@nombre,1,2)+@apellido)
END
GO

CREATE FUNCTION LJDG.viaje_entra_en_rendicion
(
	@viaje_fecha_inicio datetime , @rendicion_fecha datetime
)
RETURNS BIT
AS
BEGIN
	RETURN IIF( convert(date,@viaje_fecha_inicio) = convert(date,@rendicion_fecha) , 1, 0)
END
GO

CREATE FUNCTION LJDG.viaje_entra_en_factura
(
	@viaje_fecha_inicio datetime , @factura_inicio datetime, @factura_fin datetime
)
RETURNS BIT
AS
BEGIN
	RETURN IIF(convert(date,@factura_inicio) <= convert(date,@viaje_fecha_inicio)
				AND convert(date,@viaje_fecha_inicio) <= convert(date,@factura_fin) , 1, 0)
END
GO

--STORE PROCEDURES--

CREATE PROCEDURE LJDG.iniciar_sesion
	@usuario VARCHAR(30),
	@pass CHAR(64), --ya entra encriptada en SHA256
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	IF (NOT EXISTS (SELECT user_id FROM LJDG.Usuario WHERE user_id = @usuario))
		SET @mensaje = 'El usuario no existe en el Sistema.'
	ELSE
	BEGIN
		IF ((SELECT user_habilitado FROM LJDG.Usuario WHERE user_id = @usuario) = 0)
				SET @mensaje = 'El usuario no esta habilitado en el Sistema. Contacte al Administrador.'
		ELSE
		BEGIN
			IF ((SELECT user_password FROM LJDG.Usuario WHERE user_id = @usuario) <> @pass)
			BEGIN
				UPDATE LJDG.Usuario SET user_intentos = user_intentos - 1 WHERE user_id = @usuario
				DECLARE @intentos int = (SELECT user_intentos FROM LJDG.Usuario WHERE user_id = @usuario)
				SET @mensaje = IIF(@intentos > 0, 'La contraseña es incorrecta. Quedan ' + str(@intentos,1,1) + ' intento(s).','Contraseña incorrecta. Usuario deshabilitado.')
				IF ( @intentos = 0)
					UPDATE LJDG.Usuario SET user_habilitado = 0 WHERE user_id = @usuario
			END
			ELSE
			BEGIN
				SET @mensaje = 'OK'
				UPDATE LJDG.Usuario SET user_intentos = 3 WHERE user_id = @usuario
			END
		END
	END
END
GO

CREATE PROCEDURE LJDG.obtener_roles_usuario
	@usuario VARCHAR(30)
AS
BEGIN
	SELECT rol_nombre
	FROM LJDG.Rol_Usuario JOIN LJDG.Rol
	ON @usuario = rxu_user AND rxu_rol = rol_id
END
GO

CREATE PROCEDURE LJDG.obtener_roles
AS
BEGIN
	SELECT rol_id 'ID_Rol'
      ,rol_nombre 'Nombre'
	  ,rol_habilitado 'Habilitado'
	FROM LJDG.Rol
END
GO

CREATE PROCEDURE LJDG.obtener_funcionalidadesxrol
	@rol_id INT
AS
BEGIN
	SELECT F.func_id 'ID_Funcionalidad', F.func_descripcion 'Descripcion'
		FROM LJDG.Funcionalidad_Rol FR
		JOIN LJDG.Funcionalidad F ON (FR.fxr_funcionalidad = F.func_id)
		JOIN LJDG.Rol R ON (FR.fxr_rol = R.rol_id)
	WHERE R.rol_id = @rol_id
END
GO

CREATE PROCEDURE LJDG.obtener_funcionalidades
AS
BEGIN
	SELECT func_id 'ID_Funcionalidad'
      ,func_descripcion 'Descripcion'
	FROM LJDG.Funcionalidad
END
GO

CREATE PROCEDURE LJDG.eliminar_rol
	@rol_id INT
AS
BEGIN
	UPDATE LJDG.Rol
	SET rol_habilitado = 0
	WHERE rol_id = @rol_id;

	DELETE FROM LJDG.Rol_Usuario
	WHERE rxu_rol = @rol_id;
END
GO

CREATE PROCEDURE LJDG.editar_rol
	@rol_id     INT
	,@rol_nombre VARCHAR(255)
	,@rol_habilitado BIT
AS
BEGIN
	UPDATE LJDG.Rol
	SET rol_nombre = @rol_nombre, rol_habilitado = @rol_habilitado
	WHERE rol_id = @rol_id;

	DELETE FROM LJDG.Funcionalidad_Rol
	WHERE fxr_rol = @rol_id;
END
GO

CREATE PROCEDURE LJDG.crear_rol
	@nombre VARCHAR(255),
	@ID     INT OUTPUT
AS
BEGIN
	INSERT INTO LJDG.Rol (rol_nombre) VALUES (@nombre)
	SELECT @ID = rol_id FROM LJDG.Rol WHERE rol_nombre = @nombre
END
GO

CREATE PROCEDURE LJDG.crear_funcxrol
	@rol_id INT
	,@func_id INT
AS
BEGIN
	INSERT INTO LJDG.Funcionalidad_Rol (fxr_funcionalidad, fxr_rol) VALUES (@func_id, @rol_id)
END
GO

CREATE PROCEDURE LJDG.obtener_turnos
AS
BEGIN
	SELECT turn_id 'ID_Turno'
      ,turn_hora_inicio 'HoraInicio'
      ,turn_hora_fin 'HoraFinalizacion'
      ,turn_descripcion 'Descripcion'
      ,turn_valor_km 'ValorKm'
      ,turn_precio_base 'PrecioBase'
      ,turn_habilitado 'Habilitado'
	FROM LJDG.Turno
END
GO

CREATE PROCEDURE LJDG.eliminar_turno
	@turno_id INT
AS
BEGIN
	UPDATE LJDG.Turno
	SET turn_habilitado = 0
	WHERE turn_id = @turno_id;
END
GO

CREATE PROCEDURE LJDG.editar_turno
	@descripcion VARCHAR(255)
	,@horaInicio INT
	,@horaFin INT
	,@valorKm NUMERIC(18,2)
	,@precioBase NUMERIC(18,2)
	,@habilitado BIT
  , @turno_id     INT
AS
BEGIN
	UPDATE LJDG.Turno
	SET turn_descripcion = @descripcion, turn_hora_inicio = @horaInicio, turn_hora_fin = @horaFin, turn_valor_km = @valorKm, turn_precio_base = @precioBase, turn_habilitado = @habilitado
	WHERE turn_id = @turno_id;
END
GO

CREATE PROCEDURE LJDG.crear_turno
	@descripcion VARCHAR(255)
	,@horaInicio INT
	,@horaFin INT
	,@valorKm NUMERIC(18,2)
	,@precioBase NUMERIC(18,2)
  , @ID     INT OUTPUT
AS
BEGIN
	INSERT INTO LJDG.Turno (turn_descripcion, turn_hora_inicio, turn_hora_fin,turn_valor_km, turn_precio_base, turn_habilitado)
	VALUES (@descripcion, @horaInicio, @horaFin, @valorKm, @precioBase, 1)
END
GO

CREATE PROCEDURE LJDG.obtener_marcas
AS
BEGIN
	SELECT marc_nombre
	FROM LJDG.Marca
END
GO

CREATE PROCEDURE LJDG.obtener_descripcion_turnos
AS
BEGIN
	SELECT turn_descripcion
	FROM LJDG.Turno
END
GO

CREATE PROCEDURE LJDG.obtener_auto
	@id INT,
	@marca INT OUT,
	@patente VARCHAR(10) OUT,
	@modelo VARCHAR(255) OUT,
	@chofer INT OUT,
	@turno INT OUT,
	@habilitado BIT OUT
AS
BEGIN
	SELECT  @marca      = auto_marca,
			@patente    = auto_patente,
			@modelo     = auto_modelo,
			@chofer     = auto_chofer,
			@turno      = auto_turno,
			@habilitado = auto_habilitado
	FROM LJDG.Automovil
	WHERE auto_id = @id
END
GO

CREATE PROCEDURE LJDG.modi_auto
	@id INT,
	@marca INT,
	@patente VARCHAR(10),
	@modelo VARCHAR(255),
	@chofer INT,
	@turno INT,
	@habilitado BIT,
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	IF @patente = ''
		SET @mensaje = 'Ingrese la Patente'
	ELSE IF @patente IN ( SELECT auto_patente FROM LJDG.Automovil WHERE auto_id != @id )
		SET @mensaje = 'La Patente Ingresada ya existe'
	ELSE IF @modelo = ''
		SET @mensaje = 'Ingrese el Modelo'
	ELSE
	BEGIN
		UPDATE LJDG.Automovil
		SET auto_marca = @marca,
			auto_patente = @patente,
			auto_modelo = @modelo,
			auto_chofer = @chofer,
			auto_turno = @turno,
			auto_habilitado = @habilitado
		WHERE auto_id = @id
		SET @mensaje = 'Automovil Modificado Exitosamente'
	END
END
GO

CREATE PROCEDURE LJDG.buscar_auto_habilitado
	@marca INT,
	@modelo VARCHAR(255),
	@patente VARCHAR(10),
	@chofer INT
AS
BEGIN
	SELECT auto_id 'ID',
		marc_nombre 'Marca',
		auto_modelo 'Modelo',
		auto_patente 'Patente',
		auto_chofer 'Chofer ID',
		chof_nombre 'Nombre',
		chof_apellido 'Apellido'
	FROM LJDG.Automovil
		JOIN LJDG.Marca ON auto_marca = marc_id
		JOIN LJDG.Chofer ON auto_chofer = chof_id
	WHERE auto_modelo LIKE '%' + @modelo + '%'
		AND auto_patente LIKE '%' + @patente + '%'
		AND ( @marca = 0 OR auto_marca = @marca)
		AND ( @chofer = 0 OR auto_chofer = @chofer)
		AND auto_habilitado = 1
END
GO

CREATE PROCEDURE LJDG.buscar_auto
	@marca INT,
	@modelo VARCHAR(255),
	@patente VARCHAR(10),
	@chofer INT
AS
BEGIN
	SELECT auto_id 'ID',
		marc_nombre 'Marca',
		auto_modelo 'Modelo',
		auto_patente 'Patente',
		auto_chofer 'Chofer ID',
		chof_nombre 'Nombre',
		chof_apellido 'Apellido',
		auto_habilitado 'Habilitado'
	FROM LJDG.Automovil
		JOIN LJDG.Marca ON auto_marca = marc_id
		JOIN LJDG.Chofer ON auto_chofer = chof_id
	WHERE auto_modelo LIKE '%' + @modelo + '%'
		AND auto_patente LIKE '%' + @patente + '%'
		AND ( @marca = 0 OR auto_marca = @marca)
		AND ( @chofer = 0 OR auto_chofer = @chofer)
END
GO

CREATE PROCEDURE LJDG.baja_auto
	@id INT
AS
BEGIN
	UPDATE LJDG.Automovil
	SET auto_habilitado = 0
	WHERE auto_id = @id
END
GO

CREATE PROCEDURE LJDG.alta_auto
	@marca INT,
	@patente VARCHAR(10),
	@modelo VARCHAR(255),
	@chofer INT,
	@turno INT,
	@habilitado BIT,
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	IF @patente = ''
		SET @mensaje = 'Ingrese la Patente'
	ELSE IF @patente IN ( SELECT auto_patente FROM LJDG.Automovil )
		SET @mensaje = 'La Patente Ingresada ya existe'
	ELSE IF @modelo = ''
		SET @mensaje = 'Ingrese el Modelo'
	ELSE
	BEGIN
		INSERT INTO LJDG.Automovil
		( auto_marca, auto_patente, auto_modelo, auto_chofer, auto_turno, auto_habilitado )
		VALUES
		( @marca, @patente, @modelo, @chofer, @turno, @habilitado )
		SET @mensaje = 'Automovil Guardado Exitosamente'
	END
END
GO

CREATE PROCEDURE LJDG.validar_horarios_turno
	@horaInicio INT,
	@horaFin INT,
	@turnoID INT OUT,
	@turnoDescripcion VARCHAR(255) OUT,
	@idAuto INT
AS
BEGIN
	SET @turnoID = 0
	SET @turnoDescripcion = 'Invalido'
	SELECT @turnoID = turn_id, @turnoDescripcion = turn_descripcion
	FROM LJDG.Turno, LJDG.Automovil
	WHERE @horaInicio >= turn_hora_inicio AND @horaFin < turn_hora_fin
		AND @idAuto = auto_id AND turn_id = auto_turno
END
GO

CREATE PROCEDURE LJDG.obtener_precio_viaje
	@turno INT,
	@cantKMs INT,
	@precio NUMERIC(18,2) OUT
AS
BEGIN
	SELECT @precio = @cantKMs * turn_valor_km + turn_precio_base
	FROM LJDG.Turno
	WHERE turn_id = @turno
END
GO

CREATE PROCEDURE LJDG.obtener_auto_habilitado_chofer
	@idChofer INT,
	@idAuto INT OUT,
	@marca VARCHAR(255) OUT,
	@modelo VARCHAR(255) OUT,
	@turno INT OUT
AS
BEGIN
	SELECT TOP 1 @idAuto = ISNULL(auto_id, 0),
	 @marca = ISNULL(marc_nombre, ''),
	 @modelo = ISNULL(auto_modelo, ''),
	 @turno = auto_turno
	FROM LJDG.Automovil	JOIN LJDG.Marca ON auto_marca = marc_id
	WHERE @idChofer = auto_chofer AND auto_habilitado = 1
END
GO

CREATE PROCEDURE LJDG.registrar_viaje
	@cantKMs INT,
	@fechaHoraInicio DATETIME,
	@fechaHoraFin DATETIME,
	@turno INT,
	@idAuto INT,
	@idChofer INT,
	@idCliente INT,
	@precio NUMERIC(18,2),
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	--Validaci�n Cliente sin viajes en esa fecha y horario
	IF @idCliente IN ( SELECT viaj_cliente
						FROM LJDG.Viaje
						WHERE viaj_cliente = @idCliente
							AND
								(( @fechaHoraInicio >= viaj_fecha_inicio AND @fechaHoraInicio < viaj_fecha_fin )
								OR
								( @fechaHoraFin > viaj_fecha_inicio AND @fechaHoraFin <= viaj_fecha_fin )))
		SET @mensaje = 'El cliente ya tiene viajes en esa fecha y horarios.'
	ELSE IF @idChofer IN ( SELECT viaj_chofer
						FROM LJDG.Viaje
						WHERE viaj_chofer = @idChofer
							AND
								(( @fechaHoraInicio >= viaj_fecha_inicio AND @fechaHoraInicio < viaj_fecha_fin )
								OR
								( @fechaHoraFin > viaj_fecha_inicio AND @fechaHoraFin <= viaj_fecha_fin )))
	SET @mensaje = 'El chofer ya tiene viajes en esa fecha y horarios.'
	ELSE IF (select turn_habilitado from LJDG.Turno where turn_id = @turno) = 0
		SET @mensaje = 'El turno esta deshabilitado, no pueden registrarse viajes.'
	ELSE
	BEGIN
		INSERT INTO LJDG.Viaje
		( viaj_cant_km, viaj_fecha_inicio, viaj_fecha_fin, viaj_turno, viaj_auto, viaj_chofer, viaj_cliente, viaj_precio )
		VALUES
		( @cantKMs, @fechaHoraInicio, @fechaHoraFin, @turno, @idAuto, @idChofer, @idCliente, @precio )
		SET @mensaje = 'Viaje Registrado Exitosamente.'
	END
END
GO

CREATE PROCEDURE LJDG.buscar_cliente_habilitado
	@nombre   VARCHAR(255),
	@apellido VARCHAR(255),
	@dni	  NUMERIC(18)
AS
BEGIN
	SELECT clie_id 'ID', clie_nombre 'Nombre', clie_apellido 'Apellido', clie_dni 'DNI'
	FROM LJDG.Cliente
	WHERE clie_nombre LIKE '%' + @nombre + '%'
		AND clie_apellido LIKE '%' + @apellido + '%'
		AND ( @dni = 0 OR clie_dni = @dni)
		AND clie_habilitado = 1
END
GO

CREATE PROCEDURE LJDG.buscar_cliente
	@nombre   VARCHAR(255),
	@apellido VARCHAR(255),
	@dni	  NUMERIC(18)
AS
BEGIN
	SELECT clie_id 'ID', clie_nombre 'Nombre', clie_apellido 'Apellido', clie_dni 'DNI'
	FROM LJDG.Cliente
	WHERE clie_nombre LIKE '%' + @nombre + '%'
		AND clie_apellido LIKE '%' + @apellido + '%'
		AND ( @dni = 0 OR clie_dni = @dni)
END
GO

CREATE PROCEDURE LJDG.buscar_chofer_habilitado
	@nombre   VARCHAR(255),
	@apellido VARCHAR(255),
	@dni	  NUMERIC(18)
AS
BEGIN
	SELECT chof_id 'ID', chof_nombre 'Nombre', chof_apellido 'Apellido', chof_dni 'DNI'
	FROM LJDG.Chofer
	WHERE chof_nombre LIKE '%' + @nombre + '%'
		AND chof_apellido LIKE '%' + @apellido + '%'
		AND ( @dni = 0 OR chof_dni = @dni)
		AND chof_habilitado = 1
END
GO

CREATE PROCEDURE LJDG.buscar_chofer
	@nombre   VARCHAR(255),
	@apellido VARCHAR(255),
	@dni	  NUMERIC(18)
AS
BEGIN
	SELECT chof_id 'ID', chof_nombre 'Nombre', chof_apellido 'Apellido', chof_dni 'DNI'
	FROM LJDG.Chofer
	WHERE chof_nombre LIKE '%' + @nombre + '%'
		AND chof_apellido LIKE '%' + @apellido + '%'
		AND ( @dni = 0 OR chof_dni = @dni)
END
GO

CREATE PROCEDURE LJDG.obtener_cliente
	@id INT,
	@nombre VARCHAR(255) OUT,
	@apellido VARCHAR(255) OUT,
	@DNI NUMERIC(18,0) OUT,
	@direccion VARCHAR(255) OUT,
	@cp VARCHAR(10) OUT,
	@telefono NUMERIC(18,0) OUT,
	@mail VARCHAR(50) OUT,
	@fecha_nac DATETIME OUT,
	@habilitado BIT OUT
AS
BEGIN
	SELECT  @nombre		  = clie_nombre,
			@apellido	  = clie_apellido,
			@DNI			= clie_dni,
			@direccion     = clie_direccion,
			@cp				=	clie_cp,
			@telefono      = clie_telefono,
			@mail		= clie_mail,
			@fecha_nac = clie_fecha_nac,
			@habilitado = clie_habilitado
	FROM LJDG.Cliente
	WHERE clie_id = @id
END
GO

CREATE PROCEDURE LJDG.modi_cliente
	@id INT,
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@dni NUMERIC(18,0),
	@direccion VARCHAR(255),
	@cp VARCHAR(10),
	@telefono NUMERIC(18,0),
	@mail VARCHAR(50),
	@fecha_nac DATETIME,
	@habilitado BIT,
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	IF @telefono IN (SELECT clie_telefono FROM LJDG.Cliente WHERE clie_id <> @id)
		SET @mensaje = 'El Telefono ingresado ya se encuentra registrado'
	ELSE
	BEGIN
	UPDATE LJDG.Cliente
	SET clie_nombre = @nombre,
		clie_apellido = @apellido,
		clie_dni = @dni,
		clie_direccion = @direccion,
		clie_cp = @cp,
		clie_telefono = @telefono,
		clie_mail = @mail,
		clie_fecha_nac = @fecha_nac,
		clie_habilitado = @habilitado
	WHERE clie_id = @id
	SET @mensaje = 'Chofer Modificado Exitosamente'
	END
END
GO

CREATE PROCEDURE LJDG.baja_cliente
	@id INT
AS
BEGIN
	UPDATE LJDG.Cliente
	SET clie_habilitado = 0
	WHERE clie_id = @id
END
GO

CREATE PROCEDURE LJDG.alta_cliente_usuario_nuevo
	@username CHAR(30),
	@password CHAR(64),
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@dni NUMERIC(18,0),
	@direccion VARCHAR(255),
	@cp VARCHAR(10),
	@telefono NUMERIC(18,0),
	@mail VARCHAR(50),
	@fecha_nac DATETIME,
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	 IF @username IN ( SELECT user_id FROM LJDG.Usuario )
		SET @mensaje = 'El Usuario ya existe, ingrese un Username distinto'
	 ELSE IF @telefono IN (SELECT clie_telefono FROM LJDG.Cliente)
		SET @mensaje = 'El Telefono ingresado ya se encuentra registrado'
	 ELSE
	 BEGIN
		INSERT INTO LJDG.Usuario
		(user_id,user_password)
		VALUES ( @username, @password)
		INSERT INTO LJDG.Rol_Usuario
		( rxu_rol, rxu_user)
		VALUES
		( 3 , @username)

		INSERT INTO LJDG.Cliente
		( clie_nombre, clie_apellido, clie_dni, clie_direccion, clie_cp, clie_telefono, clie_mail, clie_fecha_nac, clie_user )
		VALUES
		( @nombre, @apellido, @dni, @direccion, @cp, @telefono, @mail, @fecha_nac, @username )
		SET @mensaje = 'Cliente Guardado Exitosamente'
	 END
END
GO

CREATE PROCEDURE LJDG.alta_cliente_usuario_existente
	@username CHAR(30),
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@dni NUMERIC(18,0),
	@direccion VARCHAR(255),
	@cp VARCHAR(10),
	@telefono NUMERIC(18,0),
	@mail VARCHAR(50),
	@fecha_nac DATETIME,
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	 IF NOT @username IN ( SELECT user_id FROM LJDG.Usuario )
		SET @mensaje = 'El Usuario no existe, ingrese un nuevo Usuario'
	 ELSE IF @username IN (SELECT clie_user FROM LJDG.Cliente)
		SET @mensaje = 'El Usuario ya tiene un Cliente asociado'
	 ELSE IF @telefono IN (SELECT clie_telefono FROM LJDG.Cliente)
		SET @mensaje = 'El Telefono ingresado ya se encuentra registrado'
	 ELSE
	 BEGIN
		INSERT INTO LJDG.Cliente
		( clie_nombre, clie_apellido, clie_dni, clie_direccion, clie_cp, clie_telefono, clie_fecha_nac , clie_mail, clie_user )
		VALUES
		( @nombre, @apellido, @dni, @direccion, @cp, @telefono, @fecha_nac, @mail, @username )
		BEGIN TRY -- INTENTO DARLE ROL CLIENTE, SI YA LO TIENE POR ALGUNA RAZON ATRAPO EL ERROR
		INSERT INTO LJDG.Rol_Usuario
		( rxu_rol, rxu_user)
		VALUES
		( 3 , @username)
		END TRY
		BEGIN CATCH
		END CATCH
		SET @mensaje = 'Cliente Guardado Exitosamente'
	 END
END
GO

CREATE PROCEDURE LJDG.obtener_chofer
	@id INT,
	@nombre VARCHAR(255) OUT,
	@apellido VARCHAR(255) OUT,
	@DNI NUMERIC(18,0) OUT,
	@direccion VARCHAR(255) OUT,
	@telefono NUMERIC(18,0) OUT,
	@mail VARCHAR(50) OUT,
	@fecha_nac DATETIME OUT,
	@habilitado BIT OUT
AS
BEGIN
	SELECT  @nombre     = chof_nombre,
			@apellido    = chof_apellido,
			@DNI		= chof_dni,
			@direccion     = chof_direccion,
			@telefono      = chof_telefono,
			@mail		= chof_mail,
			@fecha_nac = chof_fecha_nac,
			@habilitado = chof_habilitado
	FROM LJDG.Chofer
	WHERE chof_id = @id
END
GO

CREATE PROCEDURE LJDG.modi_chofer
	@id INT,
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@dni NUMERIC(18,0),
	@direccion VARCHAR(255),
	@telefono NUMERIC(18,0),
	@mail VARCHAR(50),
	@fecha_nac DATETIME,
	@habilitado BIT,
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	UPDATE LJDG.Chofer
	SET chof_nombre = @nombre,
		chof_apellido = @apellido,
		chof_dni = @dni,
		chof_direccion = @direccion,
		chof_telefono = @telefono,
		chof_mail = @mail,
		chof_fecha_nac = @fecha_nac,
		chof_habilitado = @habilitado
	WHERE chof_id = @id
	SET @mensaje = 'Chofer Modificado Exitosamente'
END
GO

CREATE PROCEDURE LJDG.baja_chofer
	@id INT
AS
BEGIN
	UPDATE LJDG.Chofer
	SET chof_habilitado = 0
	WHERE chof_id = @id
END
GO

CREATE PROCEDURE LJDG.alta_chofer_usuario_nuevo
	@username CHAR(30),
	@password CHAR(64),
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@dni NUMERIC(18,0),
	@direccion VARCHAR(255),
	@telefono NUMERIC(18,0),
	@mail VARCHAR(50),
	@fecha_nac DATETIME,
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	 IF @username IN ( SELECT user_id FROM LJDG.Usuario )
		SET @mensaje = 'El Usuario ya existe, ingrese un Username distinto'
	 ELSE
	 BEGIN
		INSERT INTO LJDG.Usuario
		(user_id,user_password)
		VALUES ( @username, @password)
		INSERT INTO LJDG.Rol_Usuario
		( rxu_rol, rxu_user)
		VALUES
		( 2 , @username)

		INSERT INTO LJDG.Chofer
		( chof_nombre, chof_apellido, chof_dni, chof_direccion, chof_telefono, chof_fecha_nac, chof_mail, chof_user )
		VALUES
		( @nombre, @apellido, @dni, @direccion, @telefono, @fecha_nac, @mail, @username )
		SET @mensaje = 'Chofer Guardado Exitosamente'
	 END
END
GO

CREATE PROCEDURE LJDG.alta_chofer_usuario_existente
	@username CHAR(30),
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@dni NUMERIC(18,0),
	@direccion VARCHAR(255),
	@telefono NUMERIC(18,0),
	@mail VARCHAR(50),
	@fecha_nac DATETIME,
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	 IF NOT @username IN ( SELECT user_id FROM LJDG.Usuario )
		SET @mensaje = 'El Usuario no existe, ingrese un nuevo Usuario'
	 ELSE IF @username IN (SELECT chof_user FROM LJDG.Chofer)
		SET @mensaje = 'El Usuario ya tiene un Chofer asociado'
	 ELSE
	 BEGIN
		INSERT INTO LJDG.Chofer
		( chof_nombre, chof_apellido, chof_dni, chof_direccion, chof_telefono, chof_fecha_nac , chof_mail, chof_user )
		VALUES
		( @nombre, @apellido, @dni, @direccion, @telefono, @fecha_nac, @mail, @username )
		BEGIN TRY -- INTENTO DARLE ROL CHOFER, SI YA LO TIENE POR ALGUNA RAZON ATRAPO EL ERROR
		INSERT INTO LJDG.Rol_Usuario
		( rxu_rol, rxu_user)
		VALUES
		( 2 , @username)
		END TRY
		BEGIN CATCH
		END CATCH
		SET @mensaje = 'Chofer Guardado Exitosamente'
	 END
END
GO

CREATE PROCEDURE LJDG.alta_Usuario (@userId char(30), @pass char(64), @rol_id int)
AS
BEGIN
	INSERT INTO LJDG.Usuario (user_id, user_password) VALUES (@userId, @pass)
	INSERT INTO LJDG.Rol_Usuario (rxu_rol, rxu_user) VALUES (@rol_id, @userId)
END
GO

CREATE PROCEDURE LJDG.viajes_chofer
	@fecha DATETIME,
	@idTurno INT,
	@idChofer INT,
	@pcj DECIMAL(3,2)
AS
BEGIN
	SELECT viaj_fecha_inicio 'Fecha Inicio',
			viaj_fecha_fin 'Fecha Fin',
			(SELECT turn_descripcion FROM LJDG.Turno WHERE turn_id = viaj_turno) 'Turno',
			(SELECT clie_apellido FROM LJDG.Cliente WHERE clie_id = viaj_cliente) 'Apellido Cliente',
			(SELECT auto_patente FROM LJDG.Automovil WHERE auto_id = viaj_auto) 'Patente Auto',
			viaj_cant_km 'Cant. Kms',
			viaj_precio 'Precio',
			CONVERT(decimal(18,2),viaj_precio * @pcj) 'Importe a rendir'
	FROM LJDG.Viaje
	WHERE LJDG.viaje_entra_en_rendicion(viaj_fecha_inicio,@fecha) = 1 AND viaj_chofer = @idChofer AND viaj_turno = @idTurno
	ORDER BY 1
END
GO

CREATE PROCEDURE LJDG.crear_rendicion
	@rend_chofer INT,
	@rend_turno INT,
	@rend_fecha DATETIME,
	@rend_total NUMERIC(18,2),
	@pcj DECIMAL(3,2),
	@mensaje VARCHAR(200) OUTPUT
AS
BEGIN
	--Rendicion sin viajes
	IF NOT EXISTS (SELECT * FROM LJDG.Viaje WHERE viaj_chofer = @rend_chofer AND viaj_turno = @rend_turno
												AND LJDG.viaje_entra_en_rendicion(viaj_fecha_inicio,@rend_fecha) = 1)
	SET @mensaje = 'La Rendicion no incluye Viajes que Rendir'
	--Validaci�n Rendicion existente en la fecha dada (sea en el turno especificado o en otro)
	ELSE IF EXISTS (SELECT * FROM LJDG.Rendicion WHERE rend_chofer = @rend_chofer AND rend_fecha = @rend_fecha)
		SET @mensaje = 'Ya existe una Rendicion en esta Fecha para este Chofer'
	ELSE
	BEGIN

		INSERT INTO LJDG.Rendicion(rend_chofer, rend_turno, rend_fecha, rend_importe_total)
		VALUES (@rend_chofer, @rend_turno, @rend_fecha, @rend_total)

		INSERT INTO LJDG.Viaje_Rendicion
			(vxr_viaje
			,vxr_rendicion
			,vxr_importe)
		SELECT viaj_id , rend_nro, CONVERT(decimal(18,2),viaj_precio * @pcj)
		FROM LJDG.Viaje, LJDG.Rendicion
		WHERE viaj_chofer = rend_chofer AND LJDG.viaje_entra_en_rendicion(viaj_fecha_inicio, rend_fecha) = 1 AND viaj_turno = rend_turno
				AND rend_chofer = @rend_chofer AND rend_turno = @rend_turno AND rend_fecha = @rend_fecha
		SET @mensaje = 'Rendicion Registrada Exitosamente'
	END
END
GO

CREATE PROCEDURE LJDG.viajes_cliente
	@fechaInicio DATETIME,
	@fechaFin DATETIME,
	@idCliente INT
AS
BEGIN
	SELECT viaj_fecha_inicio 'Fecha Inicio',
			viaj_fecha_fin 'Fecha Fin',
			(SELECT turn_descripcion FROM LJDG.Turno WHERE turn_id = viaj_turno) 'Turno',
			(SELECT chof_apellido FROM LJDG.Chofer WHERE chof_id = viaj_chofer) 'Apellido Chofer',
			(SELECT auto_patente FROM LJDG.Automovil WHERE auto_id = viaj_auto) 'Patente Auto',
			viaj_cant_km 'Cant. Kms',
			viaj_precio 'Precio'
	FROM LJDG.Viaje
	WHERE LJDG.viaje_entra_en_factura(viaj_fecha_inicio,@fechaInicio,@fechaFin) = 1 AND viaj_cliente = @idCliente
	ORDER BY 1
END
GO

CREATE PROCEDURE LJDG.crear_factura
	@fact_cliente INT
	,@fact_total NUMERIC(18,2)
	,@fact_fecha DATETIME
	,@fact_fecha_inicio DATETIME
	,@fact_fecha_fin DATETIME
	,@mensaje VARCHAR(200) OUTPUT
AS
BEGIN
	--Factura sin viajes
	IF NOT EXISTS (SELECT * FROM LJDG.Viaje WHERE viaj_cliente = @fact_cliente
												AND LJDG.viaje_entra_en_factura(viaj_fecha_inicio,@fact_fecha_inicio,@fact_fecha_fin) = 1)
	SET @mensaje = 'La Factura no incluye Viajes que Facturar'
	--Validaci�n Factura existente
	ELSE IF EXISTS (SELECT * FROM LJDG.Factura WHERE fact_cliente = @fact_cliente
											AND ((@fact_fecha_inicio >= fact_fecha_inicio AND @fact_fecha_inicio <= fact_fecha_fin)
																		OR
												  (@fact_fecha_fin >= fact_fecha_inicio AND @fact_fecha_fin <= fact_fecha_fin))
				 )
		SET @mensaje = 'La Factura ya fue realizada'
	ELSE
	BEGIN

		INSERT INTO LJDG.Factura(fact_cliente, fact_importe_total, fact_fecha,fact_fecha_inicio, fact_fecha_fin)
		VALUES (@fact_cliente, @fact_total, @fact_fecha, @fact_fecha_inicio, @fact_fecha_fin)

		INSERT INTO LJDG.Viaje_Factura
			(vxf_viaje
			,vxf_factura)
		SELECT viaj_id , fact_nro
		FROM LJDG.Viaje, LJDG.Factura
		WHERE viaj_cliente = fact_cliente AND LJDG.viaje_entra_en_factura(viaj_fecha_inicio, fact_fecha_inicio, fact_fecha_fin) = 1
				AND fact_cliente = @fact_cliente AND fact_fecha_inicio = @fact_fecha_inicio AND fact_fecha_fin = @fact_fecha_fin

		SET @mensaje = 'Factura Registrada Exitosamente'
	END
END
GO

CREATE PROCEDURE LJDG.clientes_mayor_consumo
	@anio INT,
	@trimestre INT
AS
BEGIN
	SELECT TOP 5 clie_id 'ID',
				clie_dni 'DNI',
				clie_nombre 'Nombre',
				clie_apellido 'Apellido',
				clie_direccion 'Direccion',
				SUM(viaj_precio) 'Total $'
	FROM LJDG.Viaje	JOIN LJDG.Cliente ON viaj_cliente = clie_id
	WHERE YEAR(viaj_fecha_inicio) = @anio
		AND DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
	GROUP BY clie_id, clie_dni, clie_nombre, clie_apellido, clie_direccion
	ORDER BY SUM(viaj_precio) DESC, clie_id ASC
END
GO

CREATE PROCEDURE LJDG.choferes_viaje_mas_largo
	@anio INT,
	@trimestre INT
AS
BEGIN
	SELECT TOP 5 chof_id 'ID',
				chof_dni 'DNI',
				chof_nombre 'Nombre',
				chof_apellido 'Apellido',
				chof_direccion 'Direccion',
				MAX(viaj_cant_km) 'KMs'
	FROM LJDG.Viaje	JOIN LJDG.Chofer ON viaj_chofer = chof_id
	WHERE YEAR(viaj_fecha_inicio) = @anio
		AND DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
	GROUP BY chof_id, chof_dni, chof_nombre, chof_apellido, chof_direccion
	ORDER BY MAX(viaj_cant_km) DESC, chof_id ASC
END
GO

CREATE PROCEDURE LJDG.choferes_mayor_recaudacion
	@anio INT,
	@trimestre INT
AS
BEGIN
	SELECT TOP 5 chof_id 'ID',
				chof_dni 'DNI',
				chof_nombre 'Nombre',
				chof_apellido 'Apellido',
				chof_direccion 'Direccion',
				SUM(rend_importe_total) 'Total $'
	FROM LJDG.Rendicion	JOIN LJDG.Chofer ON rend_chofer = chof_id
	WHERE YEAR(rend_fecha) = @anio
		AND DATEPART(QUARTER, rend_fecha) = @trimestre
	GROUP BY chof_id, chof_dni, chof_nombre, chof_apellido, chof_direccion
	ORDER BY SUM(rend_importe_total) DESC, chof_id ASC
END
GO

CREATE PROCEDURE LJDG.cliente_auto
	@anio INT,
	@trimestre INT
AS
BEGIN
	SELECT TOP 5 clie_id 'ID Cliente',
				clie_nombre 'Nombre',
				clie_apellido 'Apellido',
				clie_dni 'DNI',
				(select top 1 viaj_auto from LJDG.Viaje
					 where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
												and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
						group by viaj_auto order by count(*) desc)  'ID Auto',
				(select top 1 marc_nombre from LJDG.Marca join LJDG.Automovil on marc_id = auto_marca join LJDG.Viaje on viaj_auto = auto_id
					where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
												and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
									group by viaj_auto,marc_nombre order by count(*) desc
				) 'Marca',
				(select top 1 auto_modelo from LJDG.Automovil join LJDG.Viaje on auto_id = viaj_auto
					where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
												and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
						group by viaj_auto,auto_modelo order by count(*) desc
				) 'Modelo',
				(select top 1 auto_patente from LJDG.Automovil join LJDG.Viaje on auto_id = viaj_auto
					where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
												and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
									group by viaj_auto,auto_patente order by count(*) desc
				) 'Patente',
				(select top 1 count(*) from LJDG.Viaje
					where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
												and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
						group by viaj_auto order by count(*) desc)  'Veces'
	FROM LJDG.Cliente
	ORDER BY 9 DESC, 1 ASC
END
GO

/* --MIGRACION-- */

--CREACION ROLES Y FUNCIONALIDADES--

INSERT INTO LJDG.Rol
           (rol_nombre)
	VALUES ('Administrador'),
			 ('Chofer'),
			 ('Cliente')
GO

INSERT INTO LJDG.Funcionalidad
           (func_descripcion)
	VALUES	('ABM de Rol'),
			 ('Registro de Usuario'),
			 ('ABM de Cliente'),
			 ('ABM de Automovil'),
			 ('ABM de Chofer'),
			 ('ABM de Turno'),
			 ('Registro de Viajes'),
			 ('Rendicion de cuenta de Chofer'),
			 ('Facturacion a Cliente'),
			 ('Listado Estadistico')
GO

--Todas las funcionalidades al Administrador, nada al resto
INSERT INTO LJDG.Funcionalidad_Rol
			(fxr_funcionalidad,
			 fxr_rol)
	SELECT func_id, 1
	FROM LJDG.Funcionalidad
GO

--CREACION ADMIN--

INSERT INTO LJDG.Usuario
           (user_id
           ,user_password
           )
VALUES (
'admin',
CONVERT(CHAR(64),HASHBYTES('SHA2_256', 'w23e'),2)
)
GO

INSERT LJDG.Rol_Usuario
VALUES (1, 'admin')
GO

--USUARIOS (CLIENTES Y CHOFERES)--

INSERT INTO LJDG.Usuario
           (user_id
           ,user_password)
SELECT LJDG.easy_username(Cliente_Nombre,Cliente_Apellido),CONVERT(char(64),HASHBYTES('SHA2_256',LJDG.easy_username(Cliente_Nombre,Cliente_Apellido)),2)
FROM gd_esquema.Maestra
GROUP BY Cliente_nombre,Cliente_apellido,Cliente_dni,Cliente_direccion,Cliente_telefono,Cliente_Mail,Cliente_Fecha_Nac
UNION
SELECT LJDG.easy_username(Chofer_Nombre,Chofer_Apellido),CONVERT(char(64),HASHBYTES('SHA2_256',LJDG.easy_username(Chofer_Nombre,Chofer_Apellido)),2)
FROM gd_esquema.Maestra
GROUP BY Chofer_Nombre,Chofer_apellido,Chofer_dni,Chofer_direccion,Chofer_telefono,Chofer_Mail,Chofer_Fecha_Nac
GO

INSERT INTO LJDG.Cliente
           (clie_nombre
           ,clie_apellido
           ,clie_dni
           ,clie_direccion
           ,clie_telefono
           ,clie_mail
           ,clie_fecha_nac
		   ,clie_user)
SELECT Cliente_nombre,Cliente_apellido,Cliente_dni,Cliente_direccion,Cliente_telefono,Cliente_Mail,Cliente_Fecha_Nac,LJDG.easy_username(Cliente_Nombre,Cliente_Apellido)
FROM gd_esquema.Maestra
GROUP BY Cliente_nombre,Cliente_apellido,Cliente_dni,Cliente_direccion,Cliente_telefono,Cliente_Mail,Cliente_Fecha_Nac
GO


INSERT INTO LJDG.Chofer
           (chof_nombre
           ,chof_apellido
           ,chof_dni
           ,chof_direccion
           ,chof_telefono
           ,chof_mail
           ,chof_fecha_nac
		   ,chof_user)
SELECT Chofer_Nombre,Chofer_apellido,Chofer_dni,Chofer_direccion,Chofer_telefono,Chofer_Mail,Chofer_Fecha_Nac,LJDG.easy_username(Chofer_Nombre,Chofer_Apellido)
FROM gd_esquema.Maestra
GROUP BY Chofer_Nombre,Chofer_apellido,Chofer_dni,Chofer_direccion,Chofer_telefono,Chofer_Mail,Chofer_Fecha_Nac
GO

INSERT INTO LJDG.Rol_Usuario
           (rxu_rol,
		   rxu_user)
SELECT 3,clie_user
FROM LJDG.Cliente
UNION
SELECT 2,chof_user
FROM LJDG.Chofer
GO

--MARCAS--

INSERT INTO LJDG.Marca
           (marc_nombre)
     SELECT distinct Auto_Marca
	 FROM gd_esquema.Maestra
GO

--TURNOS--

INSERT INTO LJDG.Turno
           (turn_hora_inicio
           ,turn_hora_fin
           ,turn_descripcion
           ,turn_valor_km
           ,turn_precio_base)
SELECT distinct Turno_Hora_Inicio, Turno_Hora_Fin, Turno_Descripcion, Turno_Valor_Kilometro, Turno_Precio_Base
FROM gd_esquema.Maestra
ORDER BY Turno_Hora_Inicio
GO

--AUTOMOVILES--

INSERT INTO LJDG.Automovil
           (
		    auto_marca
           ,auto_patente
           ,auto_modelo
           ,auto_licencia
           ,auto_rodado
           ,auto_chofer
		   ,auto_turno
           ,auto_habilitado)
SELECT distinct (select marc_id from LJDG.Marca where auto_marca = marc_nombre),
		Auto_Patente,
	 Auto_Modelo,Auto_Licencia,Auto_Rodado,
	 (select chof_id from LJDG.Chofer where chof_dni = chofer_dni),
	 (select turn_id from LJDG.Turno where turn_descripcion =
		(select top 1 turno_descripcion from gd_esquema.Maestra aux where main.Auto_patente = aux.Auto_patente order by Viaje_Fecha DESC)
	 ), --turno actual: ultimo turno que trabajo el chofer asignado a este auto en los viajes registrados en la tabla maestra
	 1 --todos los autos habilitados
FROM gd_esquema.Maestra main
ORDER BY Auto_Patente
GO

--VIAJES--

INSERT INTO LJDG.Viaje
           (viaj_cant_km
           ,viaj_fecha_inicio
           ,viaj_fecha_fin
           ,viaj_turno
           ,viaj_auto
           ,viaj_chofer
           ,viaj_cliente
           ,viaj_precio)
SELECT distinct m.Viaje_Cant_Kilometros,m.Viaje_Fecha,NULL, --Fecha fin: null, al no existir el dato
		(select turn_id from LJDG.Turno where turn_descripcion = m.Turno_Descripcion),
		(select auto_id from LJDG.Automovil where auto_patente = m.Auto_patente),
		(select chof_id from LJDG.Chofer where chof_dni = m.Chofer_Dni),
		(select clie_id from LJDG.Cliente where clie_dni = m.Cliente_Dni),
		 m.Turno_Precio_Base + m.Turno_Valor_Kilometro * m.Viaje_Cant_Kilometros
FROM gd_esquema.Maestra m
ORDER BY m.Viaje_Fecha
GO

--FACTURAS--

SET IDENTITY_INSERT LJDG.Factura ON
GO --Se permite insertar a mano el numero identificador, luego se incrementara de 1 a 1

INSERT INTO LJDG.Factura
           (fact_nro
           ,fact_fecha_inicio
           ,fact_fecha_fin
           ,fact_fecha
           ,fact_cliente)
SELECT   m.Factura_Nro,m.Factura_Fecha_Inicio,m.Factura_Fecha_Fin,m.Factura_Fecha,
		 (select clie_id from LJDG.Cliente where clie_dni = m.Cliente_Dni)
FROM gd_esquema.Maestra m
WHERE Factura_Nro is not null
GROUP BY m.Factura_Nro,m.Factura_Fecha_Inicio,m.Factura_Fecha_Fin,m.Factura_Fecha,m.Cliente_Dni
ORDER BY m.Factura_Nro
GO

SET IDENTITY_INSERT LJDG.Factura OFF
GO

INSERT INTO LJDG.Viaje_Factura --Se registran los viajes de cada factura
			(vxf_viaje
			,vxf_factura)
SELECT viaj_id , fact_nro
FROM LJDG.Viaje, LJDG.Factura
WHERE viaj_cliente = fact_cliente AND LJDG.viaje_entra_en_factura(viaj_fecha_inicio, fact_fecha_inicio, fact_fecha_fin) = 1
ORDER BY fact_nro
GO

UPDATE LJDG.Factura --Se calcula el importe total
SET fact_importe_total = (select sum(viaj_precio) from LJDG.Viaje join LJDG.Viaje_Factura on viaj_id = vxf_viaje
						  where fact_nro = vxf_factura)
GO

--RENDICIONES--

SET IDENTITY_INSERT LJDG.Rendicion ON --Idem Facturas
GO

INSERT INTO LJDG.Rendicion
           (rend_nro
           ,rend_fecha
           ,rend_turno
           ,rend_chofer)
SELECT  m.Rendicion_Nro,m.Rendicion_Fecha,
		(select turn_id from LJDG.Turno where turn_descripcion = m.Turno_Descripcion),
		 (select chof_id from LJDG.Chofer where chof_dni = m.Chofer_Dni)
FROM gd_esquema.Maestra m
WHERE Rendicion_Nro is not null
GROUP BY m.Rendicion_Nro,m.Rendicion_Fecha,m.Turno_Descripcion,m.Chofer_Dni
ORDER BY m.Rendicion_Nro
GO

SET IDENTITY_INSERT LJDG.Rendicion OFF
GO

/*INSERT INTO LJDG.Viaje_Rendicion --solucion calculando el importe en lugar de migrandolo
			(vxr_viaje
			,vxr_rendicion
			,vxr_importe)
SELECT viaj_id , rend_nro, viaj_precio * 0.3
FROM LJDG.Viaje, LJDG.Rendicion
WHERE viaj_chofer = rend_chofer AND viaj_turno = rend_turno AND LJDG.viaje_entra_en_rendicion(viaj_fecha_inicio,rend_fecha) = 1
ORDER BY rend_nro
GO*/

INSERT INTO LJDG.Viaje_Rendicion --Se registran los viajes de cada rendicion y se migra el importe de rendici�n correspondiente a cada uno
			(vxr_viaje
			,vxr_rendicion
			,vxr_importe)
SELECT viaj_id , rend_nro, (select Rendicion_Importe from gd_esquema.Maestra
							where rend_nro = Rendicion_Nro
							AND Chofer_Dni = (select chof_dni from LJDG.Chofer where viaj_chofer = chof_id)
							AND Cliente_Dni = (select clie_dni from LJDG.Cliente where viaj_cliente = clie_id)
							AND Viaje_Fecha = viaj_fecha_inicio
							AND Viaje_Cant_Kilometros = viaj_cant_km
							group by Rendicion_Importe)

FROM LJDG.Viaje, LJDG.Rendicion
WHERE viaj_chofer = rend_chofer AND viaj_turno = rend_turno AND LJDG.viaje_entra_en_rendicion(viaj_fecha_inicio,rend_fecha) = 1
ORDER BY rend_nro
GO

UPDATE LJDG.Rendicion --Se calcula el importe total
SET rend_importe_total = (select sum(vxr_importe) from LJDG.Viaje_Rendicion
						  where rend_nro = vxr_rendicion)
GO


/* --TRIGGERS-- */

CREATE TRIGGER LJDG.trigger_abm_automovil
   ON  LJDG.Automovil
   AFTER INSERT,UPDATE
AS
BEGIN
	DECLARE @id INT
	DECLARE @hab BIT
	DECLARE @chof INT

	DECLARE c1 CURSOR FOR SELECT inserted.auto_id, inserted.auto_habilitado, inserted.auto_chofer
						FROM inserted
						ORDER BY inserted.auto_id

	OPEN c1
	FETCH NEXT FROM c1 INTO @id, @hab, @chof
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @hab = 1
		BEGIN

		UPDATE LJDG.Automovil
		SET auto_habilitado = 0  --deshabilito todos los otros automoviles del mismo chofer que no sean este
		WHERE auto_chofer = @chof and auto_id <> @id

		UPDATE LJDG.Automovil
		SET auto_habilitado = 1 --habilito este automovil (ya deberia estar habilitado, pero puede ser deshabilitado en una iteracion anterior,
		WHERE auto_id = @id		-- si varios autos activos del mismo chofer son insertados o actualizados a la vez.
								--Con esto se deja el ultimo activo)
		END
		FETCH NEXT FROM c1 INTO @id, @hab, @chof
	END

	CLOSE c1
	DEALLOCATE c1
END
GO

USE GD1C2017
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='alta_cliente_usuario_nuevo' AND type='p')
DROP PROCEDURE LJDG.alta_cliente_usuario_nuevo
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
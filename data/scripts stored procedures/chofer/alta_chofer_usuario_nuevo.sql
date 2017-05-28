USE GD1C2017
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='alta_chofer_usuario_nuevo' AND type='p')
DROP PROCEDURE LJDG.alta_chofer_usuario_nuevo
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
		SET @mensaje = 'Alta Exitosa'
	 END
END
GO
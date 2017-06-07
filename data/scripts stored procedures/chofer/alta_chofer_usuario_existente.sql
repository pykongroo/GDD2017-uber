USE GD1C2017
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='alta_chofer_usuario_existente' AND type='p')
DROP PROCEDURE LJDG.alta_chofer_usuario_existente
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
USE GD1C2017
IF OBJECT_ID('LJDG.IniciarSesion') IS NOT NULL
	DROP PROCEDURE LJDG.IniciarSesion
GO
CREATE PROCEDURE LJDG.IniciarSesion
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
				SET @mensaje = 'El usuario no está habilitado en el Sistema. Contacte al Administrador.'
		ELSE
		BEGIN
			IF ((SELECT user_password FROM LJDG.Usuario WHERE user_id = @usuario) <> @pass)
				SET @mensaje = 'La contraseña es incorrecta.'
			ELSE
				SET @mensaje = 'OK'
		END
	END
END
GO
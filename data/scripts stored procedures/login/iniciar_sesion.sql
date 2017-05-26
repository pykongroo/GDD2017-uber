USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='iniciar_sesion' AND type='p')
DROP PROCEDURE LJDG.iniciar_sesion
GO

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
				SET @mensaje = 'El usuario no está habilitado en el Sistema. Contacte al Administrador.'
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
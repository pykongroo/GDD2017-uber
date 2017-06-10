USE GD1C2017
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='alta_cliente_usuario_existente' AND type='p')
DROP PROCEDURE LJDG.alta_cliente_usuario_existente
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
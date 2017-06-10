USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='modi_cliente' AND type='p')
DROP PROCEDURE LJDG.modi_cliente
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
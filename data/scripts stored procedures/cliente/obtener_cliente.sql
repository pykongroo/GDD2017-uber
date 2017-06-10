USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_cliente' AND type='p')
DROP PROCEDURE LJDG.obtener_cliente
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
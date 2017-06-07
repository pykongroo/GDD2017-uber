USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_chofer' AND type='p')
DROP PROCEDURE LJDG.obtener_chofer
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
USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='modi_chofer' AND type='p')
DROP PROCEDURE LJDG.modi_chofer
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
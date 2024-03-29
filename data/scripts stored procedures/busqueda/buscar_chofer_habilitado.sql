USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='buscar_chofer_habilitado' AND type='p')
DROP PROCEDURE LJDG.buscar_chofer_habilitado
GO

CREATE PROCEDURE LJDG.buscar_chofer_habilitado
	@nombre   VARCHAR(255),
	@apellido VARCHAR(255),
	@dni	  NUMERIC(18)
AS
BEGIN
	SELECT chof_id 'ID', chof_nombre 'Nombre', chof_apellido 'Apellido', chof_dni 'DNI'
	FROM LJDG.Chofer
	WHERE chof_nombre LIKE '%' + @nombre + '%'
		AND chof_apellido LIKE '%' + @apellido + '%'
		AND ( @dni = 0 OR chof_dni = @dni)
		AND chof_habilitado = 1
END
GO
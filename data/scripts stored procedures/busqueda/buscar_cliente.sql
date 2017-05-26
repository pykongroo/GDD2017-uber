USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='buscar_cliente' AND type='p')
DROP PROCEDURE LJDG.buscar_cliente
GO

CREATE PROCEDURE LJDG.buscar_cliente
	@nombre   VARCHAR(255),
	@apellido VARCHAR(255),
	@dni	  NUMERIC(18)
AS
BEGIN
	SELECT clie_id 'ID', clie_nombre 'Nombre', clie_apellido 'Apellido', clie_dni 'DNI'
	FROM LJDG.Cliente
	WHERE clie_nombre LIKE '%' + @nombre + '%'
		AND clie_apellido LIKE '%' + @apellido + '%'
		AND ( @dni = 0 OR clie_dni = @dni)
END
GO
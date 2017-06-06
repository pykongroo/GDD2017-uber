USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='cliente_auto' AND type='p')
DROP PROCEDURE LJDG.cliente_auto
GO

CREATE PROCEDURE LJDG.cliente_auto
	@anio INT,
	@trimestre INT
AS
BEGIN
	SELECT TOP 1 clie_id 'ID',
				clie_nombre 'Nombre',
				clie_apellido 'Apellido',
				clie_dni 'DNI',
				(SELECT marc_nombre FROM LJDG.Marca WHERE marc_id = auto_marca) 'Marca Auto',
				auto_modelo 'Modelo',
				auto_patente 'Patente',
				COUNT(*) 'Cant.'
	FROM LJDG.Viaje	JOIN LJDG.Cliente ON viaj_cliente = clie_id
		JOIN LJDG.Automovil ON viaj_auto = auto_id
	WHERE YEAR(viaj_fecha_inicio) = @anio
		AND DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
	GROUP BY clie_id, clie_nombre, clie_apellido, clie_dni, auto_marca, auto_modelo, auto_patente
	ORDER BY COUNT(*) DESC
END
GO
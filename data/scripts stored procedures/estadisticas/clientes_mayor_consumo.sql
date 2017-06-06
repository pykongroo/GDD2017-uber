USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='clientes_mayor_consumo' AND type='p')
DROP PROCEDURE LJDG.clientes_mayor_consumo
GO

CREATE PROCEDURE LJDG.clientes_mayor_consumo
	@anio INT,
	@trimestre INT
AS
BEGIN
	SELECT TOP 5 clie_id 'ID',
				clie_dni 'DNI',
				clie_nombre 'Nombre',
				clie_apellido 'Apellido',
				clie_direccion 'Dirección',
				SUM(viaj_precio) 'Total $'
	FROM LJDG.Viaje	JOIN LJDG.Cliente ON viaj_cliente = clie_id
	WHERE YEAR(viaj_fecha_inicio) = @anio
		AND DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
	GROUP BY clie_id, clie_dni, clie_nombre, clie_apellido, clie_direccion
	ORDER BY SUM(viaj_precio) DESC
END
GO
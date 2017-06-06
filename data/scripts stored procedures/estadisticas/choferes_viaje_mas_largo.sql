USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='choferes_viaje_mas_largo' AND type='p')
DROP PROCEDURE LJDG.choferes_viaje_mas_largo
GO

CREATE PROCEDURE LJDG.choferes_viaje_mas_largo
	@anio INT,
	@trimestre INT
AS
BEGIN
	SELECT TOP 5 chof_id 'ID',
				chof_dni 'DNI',
				chof_nombre 'Nombre',
				chof_apellido 'Apellido',
				chof_direccion 'Dirección',	
				MAX(viaj_cant_km) 'KMs'
	FROM LJDG.Viaje	JOIN LJDG.Chofer ON viaj_chofer = chof_id
	WHERE YEAR(viaj_fecha_inicio) = @anio
		AND DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
	GROUP BY chof_id, chof_dni, chof_nombre, chof_apellido, chof_direccion
	ORDER BY MAX(viaj_cant_km) DESC
END
GO
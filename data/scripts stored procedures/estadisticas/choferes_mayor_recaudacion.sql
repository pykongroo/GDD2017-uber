USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='choferes_mayor_recaudacion' AND type='p')
DROP PROCEDURE LJDG.choferes_mayor_recaudacion
GO

CREATE PROCEDURE LJDG.choferes_mayor_recaudacion
	@anio INT,
	@trimestre INT
AS
BEGIN
	SELECT TOP 5 chof_id 'ID',
				chof_dni 'DNI',
				chof_nombre 'Nombre',
				chof_apellido 'Apellido',
				chof_direccion 'Dirección',				
				SUM(rend_importe_total) 'Total $'
	FROM LJDG.Rendicion	JOIN LJDG.Chofer ON rend_chofer = chof_id
	WHERE YEAR(rend_fecha) = @anio
		AND DATEPART(QUARTER, rend_fecha) = @trimestre
	GROUP BY chof_id, chof_dni, chof_nombre, chof_apellido, chof_direccion
	ORDER BY SUM(rend_importe_total) DESC, chof_id ASC
END
GO
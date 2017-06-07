USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='cliente_auto' AND type='p')
DROP PROCEDURE LJDG.cliente_auto
GO

CREATE PROCEDURE LJDG.cliente_auto
	@anio INT,
	@trimestre INT
AS
BEGIN
	SELECT TOP 5 clie_id 'ID Cliente',
				clie_nombre 'Nombre',
				clie_apellido 'Apellido',
				clie_dni 'DNI',
				(select top 1 viaj_auto from LJDG.Viaje where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
																					and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
						group by viaj_auto order by count(*) desc)  'ID Auto',
				(select marc_nombre from LJDG.Marca join LJDG.Automovil on marc_id = auto_marca 
					where auto_id = (select top 1 viaj_auto from LJDG.Viaje where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
																					and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
									group by viaj_auto order by count(*) desc)
				) 'Marca',
				(select auto_modelo from LJDG.Automovil
					where auto_id = (select top 1 viaj_auto from LJDG.Viaje where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
																					and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
									group by viaj_auto order by count(*) desc)
				) 'Modelo',
				(select auto_patente from LJDG.Automovil
					where auto_id = (select top 1 viaj_auto from LJDG.Viaje where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
																					and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
									group by viaj_auto order by count(*) desc)
				) 'Patente', 
				(select top 1 count(*) from LJDG.Viaje where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
																					and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
						group by viaj_auto order by count(*) desc)  'Veces'
	FROM LJDG.Cliente
	GROUP BY clie_id, clie_nombre, clie_apellido, clie_dni
	ORDER BY 9 DESC, 1 ASC
END
GO
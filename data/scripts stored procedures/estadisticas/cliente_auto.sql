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
				(select top 1 viaj_auto from LJDG.Viaje
					 where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
												and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
						group by viaj_auto order by count(*) desc)  'ID Auto',
				(select top 1 marc_nombre from LJDG.Marca join LJDG.Automovil on marc_id = auto_marca join LJDG.Viaje on viaj_auto = auto_id
					where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
												and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
									group by viaj_auto,marc_nombre order by count(*) desc
				) 'Marca',
				(select top 1 auto_modelo from LJDG.Automovil join LJDG.Viaje on auto_id = viaj_auto
					where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
												and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
						group by viaj_auto,auto_modelo order by count(*) desc
				) 'Modelo',
				(select top 1 auto_patente from LJDG.Automovil join LJDG.Viaje on auto_id = viaj_auto
					where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
												and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
									group by viaj_auto,auto_patente order by count(*) desc
				) 'Patente', 
				ISNULL((select top 1 count(*) from LJDG.Viaje 
					where viaj_cliente = clie_id and YEAR(viaj_fecha_inicio) = @anio
												and DATEPART(QUARTER, viaj_fecha_inicio) = @trimestre
						group by viaj_auto order by count(*) desc),0)  'Veces'
	FROM LJDG.Cliente
	ORDER BY 9 DESC, 1 ASC
END
GO
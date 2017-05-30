USE [GD1C2017]
GO

/*DELETE FROM LJDG.Factura
GO*/

SET IDENTITY_INSERT LJDG.Factura ON
GO

INSERT INTO [LJDG].[Factura]
           ([fact_nro]
           ,[fact_fecha_inicio]
           ,[fact_fecha_fin]
           ,[fact_fecha]
           ,[fact_cliente])
SELECT   m.Factura_Nro,m.Factura_Fecha_Inicio,m.Factura_Fecha_Fin,m.Factura_Fecha,
		 (select clie_id from LJDG.Cliente where clie_dni = m.Cliente_Dni)
FROM gd_esquema.Maestra m
WHERE Factura_Nro is not null
GROUP BY m.Factura_Nro,m.Factura_Fecha_Inicio,m.Factura_Fecha_Fin,m.Factura_Fecha,m.Cliente_Dni
ORDER BY m.Factura_Nro
GO

SET IDENTITY_INSERT LJDG.Factura OFF
GO

UPDATE LJDG.Factura
SET fact_importe_total = (select sum(viaj_precio) from LJDG.Viaje
						where LJDG.viaje_entra_en_factura(viaj_fecha_inicio,fact_fecha_inicio,fact_fecha_fin) = 1 AND
								viaj_cliente = fact_cliente)
GO

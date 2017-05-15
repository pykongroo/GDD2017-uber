USE [GD1C2017]
GO

/*DELETE FROM LJDG.Factura
GO*/

INSERT INTO [LJDG].[Factura]
           ([fact_nro]
           ,[fact_fecha_inicio]
           ,[fact_fecha_fin]
           ,[fact_fecha]
           ,[fact_cliente]
           ,[fact_importe_total])
SELECT   m.Factura_Nro,m.Factura_Fecha_Inicio,m.Factura_Fecha_Fin,m.Factura_Fecha,
		 (select user_id from LJDG.Usuario where user_dni = m.Cliente_Dni),
		 --sum(Viaje_Cant_Kilometros * Turno_Valor_Kilometro + Turno_Precio_Base), -- incluye viajes duplicados que se facturan dos veces
		 (select sum(viaj_precio) from LJDG.Viaje  
			 where LJDG.viaje_entra_en_factura(viaj_fecha_inicio,m.Factura_Fecha_Inicio,m.Factura_Fecha_Fin) = 1 
							and viaj_cliente = (select user_id from LJDG.Usuario where m.Cliente_Dni = user_dni))
FROM gd_esquema.Maestra m
WHERE Factura_Nro is not null
GROUP BY m.Factura_Nro,m.Factura_Fecha_Inicio,m.Factura_Fecha_Fin,m.Factura_Fecha,m.Cliente_Dni
ORDER BY m.Factura_Nro
GO

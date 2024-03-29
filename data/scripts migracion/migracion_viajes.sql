USE [GD1C2017]
GO

/*DELETE FROM LJDG.Viaje
GO
DBCC CHECKIDENT ('LJDG.Viaje', RESEED, 0)
GO*/

INSERT INTO [LJDG].[Viaje]
           ([viaj_cant_km]
           ,[viaj_fecha_inicio]
           ,[viaj_fecha_fin]
           ,[viaj_turno]
           ,[viaj_auto]
           ,[viaj_chofer]
           ,[viaj_cliente]
           ,[viaj_precio])
SELECT distinct m.Viaje_Cant_Kilometros,m.Viaje_Fecha,NULL,
		(select turn_id from LJDG.Turno where turn_descripcion = m.Turno_Descripcion),
		(select auto_id from LJDG.Automovil where auto_patente = m.Auto_patente),
		(select chof_id from LJDG.Chofer where chof_dni = m.Chofer_Dni),
		(select clie_id from LJDG.Cliente where clie_dni = m.Cliente_Dni),
		 m.Turno_Precio_Base + m.Turno_Valor_Kilometro * m.Viaje_Cant_Kilometros
FROM gd_esquema.Maestra m
ORDER BY m.Viaje_Fecha
GO




USE [GD1C2017]
GO

/*DELETE FROM LJDG.Automovil
GO
DBCC CHECKIDENT ('LJDG.Automovil', RESEED, 0)
GO*/

INSERT INTO [LJDG].[Automovil]
           (
		    [auto_marca]
           ,[auto_patente]
           ,[auto_modelo]
           ,[auto_licencia]
           ,[auto_rodado]
           ,[auto_chofer]
		   ,[auto_turno]
           ,[auto_habilitado])
SELECT distinct (select marc_id from LJDG.Marca where auto_marca = marc_nombre),
		Auto_Patente,
	 Auto_Modelo,Auto_Licencia,Auto_Rodado,
	 (select user_id from LJDG.Usuario where user_dni = chofer_dni),
	 (select turn_id from LJDG.Turno where turn_descripcion = 
		(select top 1 turno_descripcion from gd_esquema.Maestra aux where main.Auto_patente = aux.Auto_patente order by Viaje_Fecha DESC)
	 ), --ultimo turno que trabajo el chofer asignado a este auto en los viajes registrados en la tabla maestra
	 1
FROM gd_esquema.Maestra main
ORDER BY Auto_Patente
GO


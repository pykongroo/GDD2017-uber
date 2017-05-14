USE [GD1C2017]
GO

/*DELETE FROM LJDG.Turno
GO
DBCC CHECKIDENT ('LJDG.Turno', RESEED, 0)
GO*/

INSERT INTO [LJDG].[Turno]
           ([turn_hora_inicio]
           ,[turn_hora_fin]
           ,[turn_descripcion]
           ,[turn_valor_km]
           ,[turn_precio_base])
SELECT distinct Turno_Hora_Inicio, Turno_Hora_Fin, Turno_Descripcion, Turno_Valor_Kilometro, Turno_Precio_Base
FROM gd_esquema.Maestra
ORDER BY Turno_Hora_Inicio
GO
USE [GD1C2017]
GO

/*DELETE FROM LJDG.Marca
GO
DBCC CHECKIDENT ('LJDG.Marca', RESEED, 0)
GO*/

INSERT INTO [LJDG].[Marca]
           ([marc_nombre])
     SELECT distinct Auto_Marca
	 FROM gd_esquema.Maestra       
GO



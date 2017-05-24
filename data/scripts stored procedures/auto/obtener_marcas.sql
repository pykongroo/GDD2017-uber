USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_marcas' AND type='p')
DROP PROCEDURE LJDG.obtener_marcas
GO

CREATE PROCEDURE LJDG.obtener_marcas
AS
BEGIN
	SELECT marc_nombre
	FROM LJDG.Marca
END

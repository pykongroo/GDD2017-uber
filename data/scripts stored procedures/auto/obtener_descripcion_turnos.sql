USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_descripcion_turnos' AND type='p')
DROP PROCEDURE LJDG.obtener_descripcion_turnos
GO

CREATE PROCEDURE LJDG.obtener_descripcion_turnos
AS
BEGIN
	SELECT turn_descripcion
	FROM LJDG.Turno
END

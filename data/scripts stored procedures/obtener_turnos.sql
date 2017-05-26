USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_turnos' AND type='p')
DROP PROCEDURE LJDG.obtener_turnos
GO

CREATE PROCEDURE LJDG.obtener_turnos
AS
BEGIN
	SELECT turn_descripcion
	FROM LJDG.Turno
	WHERE turn_habilitado = 1
END

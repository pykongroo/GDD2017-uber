USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='eliminar_turno' AND type='p')
DROP PROCEDURE LJDG.eliminar_turno
GO

CREATE PROCEDURE [LJDG].[eliminar_turno]
	@turno_id INT
AS
BEGIN
	UPDATE LJDG.Turno
	SET turn_habilitado = 0
	WHERE turn_id = @turno_id;

	--DEBERIA HACER ALGO EN LA TABLA AUTO? O SE PREGUNTA AL MOMENTO DE ELEGIR ALGO SI EL TURNO ESTA HABILITADO?
END

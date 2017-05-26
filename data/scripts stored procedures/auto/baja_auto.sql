USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='baja_auto' AND type='p')
DROP PROCEDURE LJDG.baja_auto
GO

CREATE PROCEDURE LJDG.baja_auto
	@id INT
AS
BEGIN
	UPDATE LJDG.Automovil
	SET auto_habilitado = 0
	WHERE auto_id = @id
END
GO
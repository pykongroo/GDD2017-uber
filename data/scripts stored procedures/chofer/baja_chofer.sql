USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='baja_chofer' AND type='p')
DROP PROCEDURE LJDG.baja_chofer
GO

CREATE PROCEDURE LJDG.baja_chofer
	@id INT
AS
BEGIN
	UPDATE LJDG.Chofer
	SET chof_habilitado = 0
	WHERE chof_id = @id
END
GO
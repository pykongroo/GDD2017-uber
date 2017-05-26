USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='baja_cliente' AND type='p')
DROP PROCEDURE LJDG.baja_cliente
GO

CREATE PROCEDURE LJDG.baja_cliente
	@id INT
AS
BEGIN
	UPDATE LJDG.Cliente
	SET clie_habilitado = 0
	WHERE clie_id = @id
END
GO
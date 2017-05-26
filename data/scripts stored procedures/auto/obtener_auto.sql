USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_auto' AND type='p')
DROP PROCEDURE LJDG.obtener_auto
GO

CREATE PROCEDURE LJDG.obtener_auto
	@id INT,
	@marca INT OUT,
	@patente VARCHAR(10) OUT,
	@modelo VARCHAR(255) OUT,
	@chofer INT OUT,
	@turno INT OUT,
	@habilitado BIT OUT,
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	SELECT  @marca      = auto_marca,
			@patente    = auto_patente,
			@modelo     = auto_modelo,
			@chofer     = auto_chofer,
			@turno      = auto_turno,
			@habilitado = auto_habilitado
	FROM LJDG.Automovil
	WHERE auto_id = @id	
END
GO
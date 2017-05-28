USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_auto_habilitado_chofer' AND type='p')
DROP PROCEDURE LJDG.obtener_auto_habilitado_chofer
GO

CREATE PROCEDURE LJDG.obtener_auto_habilitado_chofer
	@idChofer INT,
	@idAuto INT OUT,
	@marca VARCHAR(255) OUT,
	@modelo VARCHAR(255) OUT,
	@turno INT OUT
AS
BEGIN
	SELECT TOP 1 @idAuto = ISNULL(auto_id, 0),
	 @marca = ISNULL(marc_nombre, ''),
	 @modelo = ISNULL(auto_modelo, ''),
	 @turno = auto_turno
	FROM LJDG.Automovil	JOIN LJDG.Marca ON auto_marca = marc_id
	WHERE @idChofer = auto_chofer AND auto_habilitado = 1
END
GO
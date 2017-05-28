USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_precio_viaje' AND type='p')
DROP PROCEDURE LJDG.obtener_precio_viaje
GO

CREATE PROCEDURE LJDG.obtener_precio_viaje
	@turno INT,
	@cantKMs INT,
	@precio NUMERIC(18,2) OUT
AS
BEGIN
	SELECT @precio = @cantKMs*turn_valor_km + turn_precio_base
	FROM LJDG.Turno
	WHERE turn_id = @turno
END
GO
USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='crear_turno' AND type='p')
DROP PROCEDURE LJDG.crear_turno
GO

CREATE PROCEDURE [LJDG].[crear_turno]
	@descripcion VARCHAR(255)
	,@horaInicio INT
	,@horaFin INT
	,@valorKm NUMERIC(18,2)
	,@precioBase NUMERIC(18,2)
  , @ID     INT OUTPUT
AS
BEGIN
	INSERT INTO LJDG.Turno (turn_descripcion, turn_hora_inicio, turn_hora_fin,turn_valor_km, turn_precio_base, turn_habilitado) 
	VALUES (@descripcion, @horaInicio, @horaFin, @valorKm, @precioBase, 1)
END

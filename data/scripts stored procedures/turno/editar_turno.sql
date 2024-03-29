USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='editar_turno' AND type='p')
DROP PROCEDURE LJDG.editar_turno
GO

CREATE PROCEDURE [LJDG].[editar_turno]
	@descripcion VARCHAR(255)
	,@horaInicio INT
	,@horaFin INT
	,@valorKm NUMERIC(18,2)
	,@precioBase NUMERIC(18,2)
	,@habilitado BIT
  , @turno_id     INT
AS
BEGIN
	UPDATE LJDG.Turno 
	SET turn_descripcion = @descripcion, turn_hora_inicio = @horaInicio, turn_hora_fin = @horaFin, turn_valor_km = @valorKm, turn_precio_base = @precioBase, turn_habilitado = @habilitado
	WHERE turn_id = @turno_id;
END
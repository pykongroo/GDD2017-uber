USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_turnos' AND type='p')
DROP PROCEDURE LJDG.obtener_turnos
GO

CREATE PROCEDURE [LJDG].[obtener_turnos]
AS
BEGIN
	SELECT turn_id "ID_Turno"
      ,turn_hora_inicio "HoraInicio"
      ,turn_hora_fin "HoraFinalizacion"
      ,turn_descripcion "Descripcion"
      ,turn_valor_km "ValorKm"
      ,turn_precio_base "PrecioBase"
      ,turn_habilitado "Habilitado"
	FROM LJDG.Turno
END

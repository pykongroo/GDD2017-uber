USE [GD1C2017]
GO
/****** Object:  StoredProcedure [LJDG].[obtener_funcionalidades]    Script Date: 25-May-17 4:10:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
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

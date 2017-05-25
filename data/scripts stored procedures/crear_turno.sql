USE [GD1C2017]
GO
/****** Object:  StoredProcedure [LJDG].[crear_rol]    Script Date: 25-May-17 3:49:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
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
	INSERT INTO LJDG.Turno (turn_descripcion, turn_hora_inicio, turn_hora_fin,turn_valor_km, turn_precio_base, turn_habilitado) VALUES (@descripcion, @horaInicio, @horaFin, @valorKm, @precioBase, 1)

END

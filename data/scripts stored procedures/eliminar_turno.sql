USE [GD1C2017]
GO
/****** Object:  StoredProcedure [LJDG].[eliminar_rol]    Script Date: 25-May-17 4:07:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [LJDG].[eliminar_turno]
	@turno_id INT
AS
BEGIN
	UPDATE LJDG.Turno
	SET turn_habilitado = 0
	WHERE turn_id = @turno_id;

	--DEBERIA HACER ALGO EN LA TABLA AUTO? O SE PREGUNTA AL MOMENTO DE ELEGIR ALGO SI EL TURNO ESTA HABILITADO?
END

USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='validar_horarios_turno' AND type='p')
DROP PROCEDURE LJDG.validar_horarios_turno
GO

CREATE PROCEDURE LJDG.validar_horarios_turno
	@horaInicio INT,
	@horaFin INT,
	@turnoID INT OUT,
	@turnoDescripcion VARCHAR(255) OUT,
	@idAuto INT
AS
BEGIN
	SET @turnoID = 0
	SET @turnoDescripcion = 'Inválido'
	SELECT @turnoID = turn_id, @turnoDescripcion = turn_descripcion
	FROM LJDG.Turno, LJDG.Automovil
	WHERE @horaInicio >= turn_hora_inicio AND @horaFin < turn_hora_fin
		AND @idAuto = auto_id AND turn_id = auto_turno
END
GO
USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='registrar_viaje' AND type='p')
DROP PROCEDURE LJDG.registrar_viaje
GO

CREATE PROCEDURE LJDG.registrar_viaje
	@cantKMs INT,
	@fechaHoraInicio DATETIME,
	@fechaHoraFin DATETIME,
	@turno INT,
	@idAuto INT,
	@idChofer INT,
	@idCliente INT,
	@precio NUMERIC(18,2),
	@importeRendicion NUMERIC(18,2),
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	--Validación Cliente sin viajes en esa fecha y horario
	IF @idCliente IN ( SELECT viaj_cliente
						FROM LJDG.Viaje
						WHERE viaj_cliente = @idCliente -- AND viaj_fecha_fin !> NULL
							AND 
								(( @fechaHoraInicio >= viaj_fecha_inicio AND @fechaHoraInicio < viaj_fecha_fin )	
								OR
								( @fechaHoraFin >= viaj_fecha_inicio AND @fechaHoraFin < viaj_fecha_fin )))
		SET @mensaje = 'El cliente ya tiene viajes en esa fecha y horarios.'
	ELSE
	BEGIN
		INSERT INTO LJDG.Viaje
		( viaj_cant_km, viaj_fecha_inicio, viaj_fecha_fin, viaj_turno, viaj_auto, viaj_chofer, viaj_cliente, viaj_precio, viaj_importe_rend )
		VALUES
		( @cantKMs, @fechaHoraInicio, @fechaHoraFin, @turno, @idAuto, @idChofer, @idCliente, @precio, @importeRendicion )
		SET @mensaje = 'Viaje Registrado Exitosamente.'
	END
END
GO
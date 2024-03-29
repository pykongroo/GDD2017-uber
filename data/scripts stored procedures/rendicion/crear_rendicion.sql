USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='crear_rendicion' AND type='p')
DROP PROCEDURE LJDG.crear_rendicion
GO

CREATE PROCEDURE LJDG.crear_rendicion
	@rend_chofer INT,
	@rend_turno INT,
	@rend_fecha DATETIME,
	@rend_total NUMERIC(18,2),
	@pcj DECIMAL(3,2),
	@mensaje VARCHAR(200) OUTPUT
AS
BEGIN
	--Rendicion sin viajes
	IF NOT EXISTS (SELECT * FROM LJDG.Viaje WHERE viaj_chofer = @rend_chofer AND viaj_turno = @rend_turno
												AND LJDG.viaje_entra_en_rendicion(viaj_fecha_inicio,@rend_fecha) = 1)
	SET @mensaje = 'La Rendición no incluye Viajes que Rendir'
	--Validación Rendicion existente en la fecha dada (sea en el turno especificado o en otro)
	ELSE IF EXISTS (SELECT * FROM LJDG.Rendicion WHERE rend_chofer = @rend_chofer AND rend_fecha = @rend_fecha)
		SET @mensaje = 'Ya existe una Rendición en esta Fecha para este Chofer'
	ELSE
	BEGIN

		INSERT INTO LJDG.Rendicion(rend_chofer, rend_turno, rend_fecha, rend_importe_total)
		VALUES (@rend_chofer, @rend_turno, @rend_fecha, @rend_total)

		INSERT INTO LJDG.Viaje_Rendicion
			(vxr_viaje
			,vxr_rendicion
			,vxr_importe)
		SELECT viaj_id , rend_nro, CONVERT(decimal(18,2),viaj_precio * @pcj)
		FROM LJDG.Viaje, LJDG.Rendicion
		WHERE viaj_chofer = rend_chofer AND LJDG.viaje_entra_en_rendicion(viaj_fecha_inicio, rend_fecha) = 1 AND viaj_turno = rend_turno
				AND rend_chofer = @rend_chofer AND rend_turno = @rend_turno AND rend_fecha = @rend_fecha
		SET @mensaje = 'Rendición Registrada Exitosamente'
	END
END

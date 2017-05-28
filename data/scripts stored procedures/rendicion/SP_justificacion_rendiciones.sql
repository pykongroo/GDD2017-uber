USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='rendiciones_justif' AND type='p')
DROP PROCEDURE LJDG.rendiciones_justif
GO

CREATE PROCEDURE LJDG.rendiciones_justif
	@fecha DATETIME,
	@turno INT,
	@chofer INT,
	@i_total NUMERIC(18,2) OUT,
	@mensaje CHAR(255) OUT
AS
BEGIN
	 SET @i_total = ISNULL((SELECT rend_importe_total from LJDG.Rendicion where rend_chofer=@chofer AND CAST(rend_fecha AS DATE)=CAST(@fecha AS DATE) AND rend_turno=@turno),0)
	 IF (@i_total<>0)
	 BEGIN
		SET @mensaje = 'EXISTENTE'
	 END
	 ELSE
	 BEGIN
		SET @mensaje = 'No almacenado'
		SET @i_total = ISNULL((select sum(viaj_importe_rend) from LJDG.Viaje where viaj_chofer = @chofer AND CAST(viaj_fecha_inicio AS DATE)=CAST(@fecha AS DATE) AND viaj_turno=@turno),0)
		IF (@i_total=0)
			SET @mensaje = 'No existen viajes realizados con los datos ingresados'
		ELSE
		BEGIN
			SET @mensaje = 'Nueva rendicion agregada'
			--INSERT EN TABLA DE RENDICIONES--
		END
	 END
	 select viaj_importe_rend from LJDG.Viaje where viaj_chofer = @chofer AND CAST(viaj_fecha_inicio AS DATE)=CAST(@fecha AS DATE) AND viaj_turno=@turno
END
GO

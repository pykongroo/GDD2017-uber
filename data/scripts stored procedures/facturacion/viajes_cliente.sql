USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='viajes_cliente' AND type='p')
DROP PROCEDURE LJDG.viajes_cliente
GO

CREATE PROCEDURE LJDG.viajes_cliente
	@fechaInicio DATETIME,
	@fechaFin DATETIME,
	@idCliente INT
AS
BEGIN
	SELECT viaj_fecha_inicio 'Fecha Inicio',
			viaj_fecha_fin 'Fecha Fin',
			(SELECT turn_descripcion FROM LJDG.Turno WHERE turn_id = viaj_turno) 'Turno',
			(SELECT chof_apellido FROM LJDG.Chofer WHERE chof_id = viaj_chofer) 'Apellido Chofer',
			(SELECT auto_patente FROM LJDG.Automovil WHERE auto_id = viaj_auto) 'Patente Auto',
			viaj_cant_km 'Cant. Kms',
			viaj_precio 'Precio'
	FROM LJDG.Viaje
	WHERE LJDG.viaje_entra_en_factura(viaj_fecha_inicio,@fechaInicio,@fechaFin) = 1 AND viaj_cliente = @idCliente
	ORDER BY 1
END
GO
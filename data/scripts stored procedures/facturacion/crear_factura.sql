USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='crear_factura' AND type='p')
DROP PROCEDURE LJDG.crear_factura
GO

CREATE PROCEDURE LJDG.crear_factura
	@fact_cliente INT
	,@fact_total NUMERIC(18,2)
	,@fact_fecha DATETIME
	,@fact_fecha_inicio DATETIME
	,@fact_fecha_fin DATETIME
	,@mensaje VARCHAR(200) OUTPUT
AS
BEGIN
	--Factura sin viajes
	IF NOT EXISTS (SELECT * FROM LJDG.Viaje WHERE viaj_cliente = @fact_cliente 
												AND LJDG.viaje_entra_en_factura(viaj_fecha_inicio,@fact_fecha_inicio,@fact_fecha_fin) = 1)
	SET @mensaje = 'La Factura no incluye Viajes que Facturar'
	--Validación Factura existente
	ELSE IF EXISTS (SELECT * FROM LJDG.Factura WHERE fact_cliente = @fact_cliente 
											AND ((@fact_fecha_inicio >= fact_fecha_inicio AND @fact_fecha_inicio <= fact_fecha_fin) 
																		OR
												  (@fact_fecha_fin >= fact_fecha_inicio AND @fact_fecha_fin <= fact_fecha_fin))
				 )
		SET @mensaje = 'La Factura ya fue realizada'
	ELSE
	BEGIN

		INSERT INTO LJDG.Factura(fact_cliente, fact_importe_total, fact_fecha,fact_fecha_inicio, fact_fecha_fin)
		VALUES (@fact_cliente, @fact_total, @fact_fecha, @fact_fecha_inicio, @fact_fecha_fin)

		INSERT INTO LJDG.Viaje_Factura
			(vxf_viaje
			,vxf_factura)
		SELECT viaj_id , fact_nro
		FROM LJDG.Viaje, LJDG.Factura
		WHERE viaj_cliente = fact_cliente AND LJDG.viaje_entra_en_factura(viaj_fecha_inicio, fact_fecha_inicio, fact_fecha_fin) = 1
				AND fact_cliente = @fact_cliente AND fact_fecha_inicio = @fact_fecha_inicio AND fact_fecha_fin = @fact_fecha_fin

		SET @mensaje = 'Factura Registrada Exitosamente'
	END
END

USE [GD1C2017]
GO
/****** Object:  StoredProcedure [LJDG].[crear_factura]    Script Date: 09-Jun-17 7:00:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [LJDG].[crear_factura]
	@fact_cliente INT
	,@fact_total NUMERIC(18,2)
	,@fact_fecha DATETIME
	,@fact_fecha_inicio DATETIME
	,@fact_fecha_fin DATETIME

AS
BEGIN
	INSERT INTO LJDG.Factura(fact_cliente, fact_importe_total, fact_fecha,fact_fecha_inicio, fact_fecha_fin) VALUES (@fact_cliente, @fact_total, @fact_fecha, @fact_fecha_inicio, @fact_fecha_fin)
END

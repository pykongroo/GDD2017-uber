USE GD1C2017
GO
IF EXISTS (SELECT name FROM sysobjects WHERE name='viaje_entra_en_factura' AND type in ( N'FN', N'IF', N'TF', N'FS', N'FT' ))
DROP FUNCTION LJDG.viaje_entra_en_factura
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [LJDG].[viaje_entra_en_factura] 
(
	@viaje_fecha datetime , @factura_inicio datetime, @factura_fin datetime
)
RETURNS BIT
AS
BEGIN
	RETURN IIF((datediff(day,@factura_inicio,@viaje_fecha) >= 0 AND datediff(day,@viaje_fecha,@factura_fin) >= 0),1,0)
END
GO

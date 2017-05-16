USE GD1C2017
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='viaje_entra_en_rendicion' AND type in ( N'FN', N'IF', N'TF', N'FS', N'FT' ))
	DROP FUNCTION LJDG.viaje_entra_en_rendicion
GO

CREATE FUNCTION LJDG.viaje_entra_en_rendicion
(
	@viaje_fecha_inicio datetime , @rendicion_fecha datetime
)
RETURNS BIT
AS
BEGIN
	RETURN IIF( datediff(day,@viaje_fecha_inicio,@rendicion_fecha) = 0 , 1, 0)
END
GO




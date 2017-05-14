USE [GD1C2017]
GO

/*DELETE FROM LJDG.Rendicion
GO*/

INSERT INTO [LJDG].[Rendicion]
           ([rend_nro]
           ,[rend_fecha]
           ,[rend_turno]
           ,[rend_chofer]
           ,[rend_importe_total])
SELECT  m.Rendicion_Nro,m.Rendicion_Fecha,
		(select turn_id from LJDG.Turno where turn_descripcion = m.Turno_Descripcion),
		 (select user_id from LJDG.Usuario where user_dni = m.Chofer_Dni),
		 sum(m.Rendicion_Importe)
FROM gd_esquema.Maestra m
WHERE Rendicion_Nro is not null
GROUP BY m.Rendicion_Nro,m.Rendicion_Fecha,m.Turno_Descripcion,m.Chofer_Dni
ORDER BY m.Rendicion_Nro
GO



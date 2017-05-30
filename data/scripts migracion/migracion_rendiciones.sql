USE [GD1C2017]
GO

/*DELETE FROM LJDG.Rendicion
GO*/

SET IDENTITY_INSERT LJDG.Rendicion ON
GO

INSERT INTO [LJDG].[Rendicion]
           ([rend_nro]
           ,[rend_fecha]
           ,[rend_turno]
           ,[rend_chofer])
SELECT  m.Rendicion_Nro,m.Rendicion_Fecha,
		(select turn_id from LJDG.Turno where turn_descripcion = m.Turno_Descripcion),
		 (select chof_id from LJDG.Chofer where chof_dni = m.Chofer_Dni)
FROM gd_esquema.Maestra m
WHERE Rendicion_Nro is not null
GROUP BY m.Rendicion_Nro,m.Rendicion_Fecha,m.Turno_Descripcion,m.Chofer_Dni
ORDER BY m.Rendicion_Nro
GO

SET IDENTITY_INSERT LJDG.Rendicion OFF
GO

UPDATE LJDG.Rendicion
SET rend_importe_total = (select sum(viaj_importe_rend) from LJDG.Viaje
						where LJDG.viaje_entra_en_rendicion(viaj_fecha_inicio,rend_fecha) = 1 AND
								viaj_chofer = rend_chofer AND viaj_turno = rend_turno)
GO



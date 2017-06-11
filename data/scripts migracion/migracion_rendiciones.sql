USE [GD1C2017]
GO

/*
DELETE FROM LJDG.Viaje_Rendicion
GO
DELETE FROM LJDG.Rendicion
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

INSERT INTO LJDG.Viaje_Rendicion
			(vxr_viaje
			,vxr_rendicion
			,vxr_importe)
SELECT viaj_id , rend_nro, (select Rendicion_Importe from gd_esquema.Maestra 
							where rend_nro = Rendicion_Nro 
							AND Chofer_Dni = (select chof_dni from LJDG.Chofer where viaj_chofer = chof_id)
							AND Cliente_Dni = (select clie_dni from LJDG.Cliente where viaj_cliente = clie_id)
							AND Viaje_Fecha = viaj_fecha_inicio
							AND Viaje_Cant_Kilometros = viaj_cant_km
							group by Rendicion_Importe) --tarda unos 30 segundos

FROM LJDG.Viaje, LJDG.Rendicion
WHERE viaj_chofer = rend_chofer AND viaj_turno = rend_turno AND LJDG.viaje_entra_en_rendicion(viaj_fecha_inicio,rend_fecha) = 1
ORDER BY rend_nro
GO

UPDATE LJDG.Rendicion
SET rend_importe_total = (select sum(vxr_importe) from LJDG.Viaje_Rendicion
						  where rend_nro = vxr_rendicion)
GO



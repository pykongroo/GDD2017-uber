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

INSERT INTO LJDG.Viaje_Rendicion
			(vxr_viaje
			,vxr_rendicion
			,vxr_importe)
SELECT viaj_id , rend_nro, viaj_precio * 0.3
FROM LJDG.Viaje, LJDG.Rendicion
WHERE viaj_chofer = rend_chofer AND viaj_turno = rend_turno AND LJDG.viaje_entra_en_rendicion(viaj_fecha_inicio,rend_fecha) = 1
ORDER BY rend_nro
GO

/*UPDATE LJDG.Viaje_Rendicion
SET vxr_importe = (select Viaje_Fecha,Rendicion_Importe from gd_esquema.Maestra where Rendicion_Importe is not null 
					group by Chofer_DNI, Cliente_DNI, Viaje_Fecha, Viaje_Cant_Kilometros, Rendicion_Importe
					 order by Viaje_Fecha)
GO*/ --IMPOSIBLE MIGRAR RENDICION_IMPORTE, USO VIAJ_PRECIO * 0.3

UPDATE LJDG.Rendicion
SET rend_importe_total = (select sum(vxr_importe) from LJDG.Viaje_Rendicion
						  where rend_nro = vxr_rendicion)
GO



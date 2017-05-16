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
		 sum(m.Rendicion_Importe) --suma duplicados
		 /* --evita sumar dos veces el importe de los viajes con rendicion duplicada pero tarda 5 minutos
		 (select sum(viaj_importe_rend) from LJDG.Viaje  
			 where LJDG.viaje_entra_en_rendicion(viaj_fecha_inicio,m.Rendicion_Fecha) = 1  --mismo dia ignorando hora
							and viaj_chofer = (select user_id from LJDG.Usuario where m.Chofer_Dni = user_dni)
							and viaj_turno = (select turn_id from LJDG.Turno where m.Turno_Descripcion = turn_descripcion))*/
FROM gd_esquema.Maestra m
WHERE Rendicion_Nro is not null
GROUP BY m.Rendicion_Nro,m.Rendicion_Fecha,m.Turno_Descripcion,m.Chofer_Dni
ORDER BY m.Rendicion_Nro
GO



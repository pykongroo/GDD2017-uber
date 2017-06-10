select *
from LJDG.Viaje
where year(viaj_fecha_inicio) = 2017

select *
from LJDG.Viaje_Rendicion
where vxr_viaje IN (select viaj_id from LJDG.Viaje where year(viaj_fecha_inicio) = 2017) 

select *
from LJDG.Rendicion
where rend_nro > 46409

delete from LJDG.Viaje_Rendicion where vxr_viaje IN (select viaj_id from LJDG.Viaje where year(viaj_fecha_inicio) = 2017) 
delete from LJDG.Viaje where year(viaj_fecha_inicio) = 2017
delete from LJDG.Rendicion where rend_nro > 46409

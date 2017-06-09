select *
from LJDG.Viaje
where year(viaj_fecha_inicio) = 2017

delete from LJDG.Viaje where year(viaj_fecha_inicio) = 2017

select *
from LJDG.Turno

select *
from LJDG.Viaje_Factura
where fact_nro = 10610

select *
from LJDG.Factura
where fact_nro > 10609

delete from LJDG.Factura where fact_nro > 10609

use GD1C2017

/*DAR DE ALTA Y MODIFICAR ROLES ARRIBA DEL 4 DESDE LA APP, LUEGO EJECUTAR ESTE SCRIPT PARA VOLVER AL ESTADO POR DEFECTO*/

select *
from LJDG.Rol left join LJDG.Funcionalidad_Rol on rol_id = fxr_rol left join LJDG.Funcionalidad on func_id = fxr_funcionalidad
go

delete from LJDG.Funcionalidad_Rol
where fxr_rol > 3
go 

delete from LJDG.Rol
where rol_id > 3
go

DBCC CHECKIDENT ('LJDG.Rol', RESEED, 3); 
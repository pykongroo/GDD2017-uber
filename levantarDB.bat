sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i data/limpiar_SP.sql
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i data/limpiar_funciones.sql

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i data/script_creacion_inicial.sql

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts funciones/easy_username.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts funciones/viaje_entra_en_factura.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts funciones/viaje_entra_en_rendicion.sql"


sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/crear_funcxrol.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/crear_rol.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/editar_rol.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/eliminar_rol.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/crear_turno.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/editar_turno.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/eliminar_turno.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/iniciar_sesion.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/obtener_funcionalidades.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/obtener_funcionalidadesxrol.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/obtener_roles_usuario.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/obtener_roles.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/obtener_turnos.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/ABM_Usuario.sql"
sqlcmd -S LOCALHOST\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/SP_justificacion_rendiciones.sql"


sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/insercion_roles_y_funcionalidades.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/creacion_admin.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_usuarios.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_marcas.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_turnos.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_autos.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_viajes.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_rendiciones.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_facturas.sql"

<<<<<<< HEAD
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts triggers/trigger_abm_automovil.sql"
=======
sqlcmd -S LOCALHOST\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts triggers/trigger_abm_automovil.sql"
>>>>>>> 2bbfa93b35ed5aed371a22ec53696dcd8cf3a6fb

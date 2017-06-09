sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i data/script_creacion_inicial.sql

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts funciones/easy_username.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts funciones/viaje_entra_en_factura.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts funciones/viaje_entra_en_rendicion.sql"

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/login/iniciar_sesion.sql"

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/roles_y_func/crear_funcxrol.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/roles_y_func/crear_rol.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/roles_y_func/editar_rol.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/roles_y_func/eliminar_rol.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/roles_y_func/obtener_funcionalidades.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/roles_y_func/obtener_funcionalidadesxrol.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/roles_y_func/obtener_roles_usuario.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/roles_y_func/obtener_roles.sql"

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/turno/crear_turno.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/turno/editar_turno.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/turno/eliminar_turno.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/turno/obtener_turnos.sql"

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/auto/obtener_marcas.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/auto/obtener_descripcion_turnos.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/auto/alta_auto.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/auto/baja_auto.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/auto/modi_auto.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/auto/obtener_auto.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/auto/buscar_auto.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/auto/buscar_auto_habilitado.sql"

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/viaje/obtener_auto_habilitado_chofer.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/viaje/validar_horarios_turno.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/viaje/obtener_precio_viaje.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/viaje/registrar_viaje.sql"

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/busqueda/buscar_cliente_habilitado.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/busqueda/buscar_cliente.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/busqueda/buscar_chofer_habilitado.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/busqueda/buscar_chofer.sql"

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/usuario/ABM_Usuario.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/chofer/alta_chofer_usuario_existente.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/chofer/alta_chofer_usuario_nuevo.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/chofer/modi_chofer.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/chofer/baja_chofer.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/chofer/obtener_chofer.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/cliente/baja_cliente.sql"

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/rendicion/SP_justificacion_rendiciones.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/facturacion/viajes_cliente.sql"

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/estadisticas/choferes_mayor_recaudacion.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/estadisticas/choferes_viaje_mas_largo.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/estadisticas/cliente_auto.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts stored procedures/estadisticas/clientes_mayor_consumo.sql"

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/insercion_roles_y_funcionalidades.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/creacion_admin.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_usuarios.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_marcas.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_turnos.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_autos.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_viajes.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_rendiciones.sql"
sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts migracion/migracion_facturas.sql"

sqlcmd -S localhost\SQLSERVER2012 -U gd -P gd2017 -i "data/scripts triggers/trigger_abm_automovil.sql"


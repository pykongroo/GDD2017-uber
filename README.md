# GDD2017-uber
Repositorio para TP de Gestion de Datos

# Para levantar la BD correctamente:

1. 'script_creacion_inicial' -> Crea esquema 'LJDG' y todas las tablas (con relaciones, PKs, restricciones, etc)
2.  Todos los scripts en carpetas 'triggers','funciones' y 'stored procedures' (sin incluir los de test) -> crea los objetos necesarios
3. 'insersion_roles_y_funcionalidades' -> Inserta roles y funcionalidades, asigna todas las funcionalidades al rol 'Administrador'
4. 'creacion_admin' -> Inserta el usuario 'admin' y le asigna el rol 'Administrador'
5. 'migracion_usuarios' -> Migra todos los usuarios de la tabla maestra y les asigna los roles correspondientes
6. 'migracion_marcas' -> Migra las marcas de la tabla maestra
7. 'migracion_turnos' -> Migra los turnos de la tabla maestra
8. 'migracion_autos' -> Migra los autos de la tabla maestra, asignados a un turno, una marca y un usuario (chofer)
9. 'migracion_viajes' -- no realizado --
10. 'migracion_rendiciones' -- no realizado --
11. 'migracion_facturas' -- no realizado --

# Para borrar:

1. 'limpiar_tablas' -> Borra todos los  registros de  todas las tablas en el orden correcto
2. 'borrar_tablas' -> Borra las tablas en el orden correcto

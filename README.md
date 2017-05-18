# GDD2017-uber
Repositorio para TP de Gestion de Datos

GRUPO Nº 17 - LJDG

# Para levantar la BD correctamente:

1. 'script_creacion_inicial' -> Crea esquema 'LJDG' y todas las tablas (con relaciones, PKs, restricciones, etc)
2.  Todos los scripts en carpetas 'triggers','funciones' y 'stored procedures' (sin incluir los de test) -> crea los objetos necesarios
3. 'insersion_roles_y_funcionalidades' -> Inserta roles y funcionalidades, asigna todas las funcionalidades al rol 'Administrador'
4. 'creacion_admin' -> Inserta el usuario 'admin' y le asigna el rol 'Administrador'
5. 'migracion_usuarios' -> Migra todos los usuarios de la tabla maestra y les asigna los roles correspondientes
6. 'migracion_marcas' -> Migra las marcas de la tabla maestra
7. 'migracion_turnos' -> Migra los turnos de la tabla maestra
8. 'migracion_autos' -> Migra los autos de la tabla maestra, asignados a un turno, una marca y un usuario (chofer)
9. 'migracion_viajes' -> Migra los viajes de la  tabla maestra (sin duplicados)
10. 'migracion_rendiciones' -> Migra las rendiciones de la tabla maestra, una por dia, chofer y turno
11. 'migracion_facturas' -> Migra las facturas de la tabla maestra, una por mes y cliente

# Con archivos batch:

1. Ejecutar 'levantarBD.bat' -> Borra todo lo que existe salvo el esquema, crea las tablas, SPs, funciones, hace la migracion y crea los triggers

# Para borrar:

1. 'limpiar_tablas' o ejecutar batch correspondiente -> Borra todos los  registros de  todas las tablas en el orden correcto
2. 'borrar_tablas' o ejecutar batch correspondiente -> Borra las tablas en el orden correcto

USE GD1C2017
GO

IF OBJECT_ID('LJDG.crear_funcxrol') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.crear_funcxrol
END;
GO

IF OBJECT_ID('LJDG.crear_rol') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.crear_rol
END;
GO

IF OBJECT_ID('LJDG.editar_rol') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.editar_rol
END;
GO

IF OBJECT_ID('LJDG.eliminar_rol') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.eliminar_rol
END;
GO

IF OBJECT_ID('LJDG.crear_turno') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.crear_turno
END;
GO

IF OBJECT_ID('LJDG.editar_turno') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.editar_turno
END;
GO

IF OBJECT_ID('LJDG.eliminar_turno') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.eliminar_turno
END;
GO

IF OBJECT_ID('LJDG.iniciar_sesion') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.iniciar_sesion
END;
GO

IF OBJECT_ID('LJDG.obtener_funcionalidades') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.obtener_funcionalidades
END;
GO

IF OBJECT_ID('LJDG.obtener_funcionalidadesxrol') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.obtener_funcionalidadesxrol
END;
GO

IF OBJECT_ID('LJDG.obtener_roles') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.obtener_roles
END;
GO

IF OBJECT_ID('LJDG.obtener_turnos') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.obtener_turnos
END;
GO

IF OBJECT_ID('LJDG.obtener_roles_usuario') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.obtener_roles_usuario
END;
GO

IF OBJECT_ID('LJDG.SP_Alta_Usuario') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.SP_Alta_Usuario
END;
GO

IF OBJECT_ID('LJDG.SP_Baja_Usuario') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.SP_Baja_Usuario
END;
GO

IF OBJECT_ID('LJDG.obtener_marcas') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.obtener_marcas
END;
GO

IF OBJECT_ID('LJDG.alta_auto') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.alta_auto
END;
GO

IF OBJECT_ID('LJDG.rendiciones_justif') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.rendiciones_justif
END;
GO

IF OBJECT_ID('LJDG.buscar_cliente_habilitado') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.buscar_cliente_habilitado
END;
GO

IF OBJECT_ID('LJDG.buscar_cliente') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.buscar_cliente
END;
GO

IF OBJECT_ID('LJDG.buscar_chofer_habilitado') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.buscar_chofer_habilitado
END;
GO

IF OBJECT_ID('LJDG.buscar_chofer') IS NOT NULL
BEGIN
    DROP PROCEDURE LJDG.buscar_chofer
END;
GO

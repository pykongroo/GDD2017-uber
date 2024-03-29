USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='editar_rol' AND type='p')
DROP PROCEDURE  LJDG.editar_rol
GO

CREATE PROCEDURE LJDG.editar_rol
	@rol_id     INT
	,@rol_nombre VARCHAR(255)
	,@rol_habilitado BIT
AS
BEGIN
	UPDATE LJDG.Rol 
	SET rol_nombre = @rol_nombre, rol_habilitado = @rol_habilitado
	WHERE rol_id = @rol_id;

	DELETE FROM LJDG.Funcionalidad_Rol
	WHERE fxr_rol = @rol_id;
END

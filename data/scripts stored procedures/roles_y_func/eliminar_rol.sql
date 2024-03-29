USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='eliminar_rol' AND type='p')
DROP PROCEDURE  LJDG.eliminar_rol
GO

CREATE PROCEDURE LJDG.eliminar_rol
	@rol_id INT
AS
BEGIN
	UPDATE LJDG.Rol
	SET rol_habilitado = 0
	WHERE rol_id = @rol_id;

	DELETE FROM LJDG.Rol_Usuario 
	WHERE rxu_rol = @rol_id;
END

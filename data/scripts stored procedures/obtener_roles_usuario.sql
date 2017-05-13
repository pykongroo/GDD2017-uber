USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_roles_usuario' AND type='p')
DROP PROCEDURE LJDG.obtener_roles_usuario
GO

CREATE PROCEDURE LJDG.obtener_roles_usuario
	@usuario VARCHAR(30)
AS
BEGIN
	SELECT rol_nombre
	FROM LJDG.Rol_Usuario JOIN LJDG.Rol
	ON @usuario = rxu_user AND rxu_rol = rol_id
END
GO
USE GD1C2017
IF OBJECT_ID('LJDG.ObtenerRolesUsuario') IS NOT NULL
	DROP PROCEDURE LJDG.ObtenerRolesUsuario
GO
CREATE PROCEDURE LJDG.ObtenerRolesUsuario
	@usuario VARCHAR(30)
AS
BEGIN
SELECT rol_nombre
FROM LJDG.Rol_Usuario JOIN LJDG.Rol
	ON @usuario = rxu_user AND rxu_rol = rol_id
END
GO
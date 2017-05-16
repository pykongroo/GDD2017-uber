USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_roles' AND type='p')
DROP PROCEDURE LJDG.obtener_roles
GO

CREATE PROCEDURE LJDG.obtener_roles
AS
BEGIN
	SELECT rol_id 'ID_Rol'
      ,rol_nombre 'Nombre'
	  ,rol_habilitado 'Habilitado'
	FROM LJDG.Rol
END

USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_funcionalidadesxrol' AND type='p')
DROP PROCEDURE LJDG.obtener_funcionalidadesxrol
GO

CREATE PROCEDURE LJDG.obtener_funcionalidadesxrol
	@rol_id INT
AS
BEGIN
	SELECT F.func_id 'ID_Funcionalidad', F.func_descripcion 'Descripcion'
		FROM LJDG.Funcionalidad_Rol FR
		JOIN LJDG.Funcionalidad F ON (FR.fxr_funcionalidad = F.func_id)
		JOIN LJDG.Rol R ON (FR.fxr_rol = R.rol_id)
	WHERE R.rol_id = @rol_id
END

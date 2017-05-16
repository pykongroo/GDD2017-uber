USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='obtener_funcionalidades' AND type='p')
DROP PROCEDURE  LJDG.obtener_funcionalidades
GO

CREATE PROCEDURE LJDG.obtener_funcionalidades
AS
BEGIN
	SELECT func_id 'ID_Funcionalidad'
      ,func_descripcion 'Descripcion'
	FROM LJDG.Funcionalidad
END

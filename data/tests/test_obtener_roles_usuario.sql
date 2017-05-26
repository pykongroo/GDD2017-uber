USE [GD1C2017]
GO

DECLARE @usuario CHAR(30) = 'admin'
EXEC LJDG.obtener_roles_usuario @usuario

GO
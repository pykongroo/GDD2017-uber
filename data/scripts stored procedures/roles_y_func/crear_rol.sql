USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='crear_rol' AND type='p')
DROP PROCEDURE  LJDG.crear_rol
GO

CREATE PROCEDURE LJDG.crear_rol
	@nombre VARCHAR(255),
	@ID     INT OUTPUT
AS
BEGIN
	INSERT INTO LJDG.Rol (rol_nombre) VALUES (@nombre)
	SELECT @ID = rol_id FROM LJDG.Rol WHERE rol_nombre = @nombre
END

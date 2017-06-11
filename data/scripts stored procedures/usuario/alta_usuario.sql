USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='alta_usuario' AND type='p')
DROP PROCEDURE  LJDG.alta_Usuario
GO

CREATE PROCEDURE LJDG.alta_Usuario (@userId char(30), @pass char(64), @rol_id int)
AS
BEGIN
	INSERT INTO LJDG.Usuario (user_id, user_password) VALUES (@userId, @pass)
	INSERT INTO LJDG.Rol_Usuario (rxu_rol, rxu_user) VALUES (@rol_id, @userId)
END
GO

USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='SP_Baja_Usuario' AND type='p')
DROP PROCEDURE  LJDG.SP_Baja_Usuario
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='SP_Alta_Usuario' AND type='p')
DROP PROCEDURE  LJDG.SP_Alta_Usuario
GO

CREATE PROCEDURE LJDG.SP_Baja_Usuario (@userId varchar(30))
AS
BEGIN
	UPDATE LJDG.Usuario SET user_habilitado=0 WHERE user_id=@userId
END
GO

CREATE PROCEDURE LJDG.SP_Alta_Usuario (@userId varchar(30), @pass varchar(255), @rol_id int)
AS
BEGIN
	INSERT INTO LJDG.Usuario (user_id, user_password) VALUES (@userId, CONVERT(char(64),HASHBYTES('SHA2_256',@pass), 2))
	INSERT INTO LJDG.Rol_Usuario (rxu_rol, rxu_user) VALUES (@rol_id, @userId)
END
GO

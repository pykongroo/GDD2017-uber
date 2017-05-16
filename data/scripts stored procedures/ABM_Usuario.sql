USE [GD1C2017]
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='SP_Baja_Usuario' AND type='p')
DROP PROCEDURE  LJDG.SP_Baja_Usuario
GO

CREATE PROCEDURE LJDG.SP_Baja_Usuario (@userId varchar(30))
AS
BEGIN
	UPDATE LJDG.Usuario SET user_habilitado=0 WHERE user_id=@userId
END
GO

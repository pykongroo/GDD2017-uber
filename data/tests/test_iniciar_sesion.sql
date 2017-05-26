USE [GD1C2017]
GO

DECLARE @usuario CHAR(30) = 'admin'
DECLARE @mensaje VARCHAR(200) = NULL
DECLARE @pass CHAR(64) = CONVERT(char(64),HASHBYTES('SHA2_256', 'w23e'),2)
EXEC LJDG.iniciar_sesion @usuario, @pass, @mensaje = @mensaje OUTPUT
SELECT @Mensaje

SELECT *
FROM LJDG.Usuario
WHERE user_id = @usuario
GO

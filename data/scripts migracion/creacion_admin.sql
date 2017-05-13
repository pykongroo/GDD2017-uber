USE GD1C2017

DELETE LJDG.Rol_Usuario WHERE rxu_user = 'admin'
GO
DELETE FROM LJDG.Usuario WHERE user_id = 'admin'
GO

INSERT INTO [LJDG].[Usuario]
           ([user_id]
           ,[user_password]
           ,[user_nombre])
VALUES (
'admin',
CONVERT(CHAR(64),HASHBYTES('SHA2_256', 'w23e'),2),
'Administrador General'
)
GO

INSERT LJDG.Rol_Usuario
VALUES (1, 'admin')
GO
USE [GD1C2017]
GO

/*DELETE FROM LJDG.Cliente
DBCC CHECKIDENT ('LJDG.Cliente', RESEED, 0)
GO

DELETE FROM LJDG.Chofer
DBCC CHECKIDENT ('LJDG.Chofer', RESEED, 0)
GO

DELETE FROM LJDG.Rol_Usuario
WHERE rxu_user <> 'admin'
GO
DELETE FROM LJDG.Usuario
WHERE user_id <> 'admin'
GO*/

INSERT INTO [LJDG].[Usuario]
           ([user_id]
           ,[user_password])
SELECT LJDG.easy_username(Cliente_Nombre,Cliente_Apellido),CONVERT(char(64),HASHBYTES('SHA2_256',LJDG.easy_username(Cliente_Nombre,Cliente_Apellido)),2)
FROM gd_esquema.Maestra
GROUP BY Cliente_nombre,Cliente_apellido,Cliente_dni,Cliente_direccion,Cliente_telefono,Cliente_Mail,Cliente_Fecha_Nac
UNION
SELECT LJDG.easy_username(Chofer_Nombre,Chofer_Apellido),CONVERT(char(64),HASHBYTES('SHA2_256',LJDG.easy_username(Chofer_Nombre,Chofer_Apellido)),2)
FROM gd_esquema.Maestra
GROUP BY Chofer_Nombre,Chofer_apellido,Chofer_dni,Chofer_direccion,Chofer_telefono,Chofer_Mail,Chofer_Fecha_Nac
GO

INSERT INTO LJDG.Cliente
           (clie_nombre
           ,clie_apellido
           ,clie_dni
           ,clie_direccion
           ,clie_telefono
           ,clie_mail
           ,clie_fecha_nac
		   ,clie_user)
SELECT Cliente_nombre,Cliente_apellido,Cliente_dni,Cliente_direccion,Cliente_telefono,Cliente_Mail,Cliente_Fecha_Nac,LJDG.easy_username(Cliente_Nombre,Cliente_Apellido)
FROM gd_esquema.Maestra
GROUP BY Cliente_nombre,Cliente_apellido,Cliente_dni,Cliente_direccion,Cliente_telefono,Cliente_Mail,Cliente_Fecha_Nac
GO


INSERT INTO LJDG.Chofer
           (chof_nombre
           ,chof_apellido
           ,chof_dni
           ,chof_direccion
           ,chof_telefono
           ,chof_mail
           ,chof_fecha_nac
		   ,chof_user)
SELECT Chofer_Nombre,Chofer_apellido,Chofer_dni,Chofer_direccion,Chofer_telefono,Chofer_Mail,Chofer_Fecha_Nac,LJDG.easy_username(Chofer_Nombre,Chofer_Apellido)
FROM gd_esquema.Maestra
GROUP BY Chofer_Nombre,Chofer_apellido,Chofer_dni,Chofer_direccion,Chofer_telefono,Chofer_Mail,Chofer_Fecha_Nac
GO

INSERT INTO [LJDG].[Rol_Usuario]
           ([rxu_rol],
		   [rxu_user])
SELECT 3,clie_user
FROM LJDG.Cliente
UNION
SELECT 2,chof_user
FROM LJDG.Chofer
GO



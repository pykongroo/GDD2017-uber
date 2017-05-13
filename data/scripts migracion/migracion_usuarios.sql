USE [GD1C2017]
GO

/*DELETE FROM LJDG.Rol_Usuario
WHERE rxu_user <> 'admin'
GO
DELETE FROM LJDG.Usuario
WHERE user_id <> 'admin'
GO*/

INSERT INTO [LJDG].[Usuario]
           ([user_id]
           ,[user_password]
           ,[user_nombre]
           ,[user_apellido]
           ,[user_dni]
           ,[user_direccion]
           ,[user_telefono]
           ,[user_mail]
           ,[user_fecha_nac])
SELECT LJDG.easy_username(Cliente_nombre,Cliente_Apellido),CONVERT(char(64),HASHBYTES('SHA2_256',LJDG.easy_username(Cliente_nombre,Cliente_Apellido)),2),Cliente_nombre,Cliente_apellido,Cliente_dni,Cliente_direccion,Cliente_telefono,Cliente_Mail,Cliente_Fecha_Nac
FROM gd_esquema.Maestra
group by Cliente_nombre,Cliente_apellido,Cliente_dni,Cliente_direccion,Cliente_telefono,Cliente_Mail,Cliente_Fecha_Nac
UNION
SELECT LJDG.easy_username(Chofer_nombre,Chofer_Apellido),CONVERT(char(64),HASHBYTES('SHA2_256',LJDG.easy_username(Chofer_Nombre,Chofer_Apellido)),2),Chofer_Nombre,Chofer_apellido,Chofer_dni,Chofer_direccion,Chofer_telefono,Chofer_Mail,Chofer_Fecha_Nac
FROM gd_esquema.Maestra
group by Chofer_Nombre,Chofer_apellido,Chofer_dni,Chofer_direccion,Chofer_telefono,Chofer_Mail,Chofer_Fecha_Nac
GO


INSERT INTO [LJDG].[Rol_Usuario]
           ([rxu_rol],
		   [rxu_user])
SELECT 3,LJDG.easy_username(Cliente_nombre,Cliente_Apellido)
FROM gd_esquema.Maestra
group by Cliente_nombre,Cliente_apellido,Cliente_dni,Cliente_direccion,Cliente_telefono,Cliente_Mail,Cliente_Fecha_Nac
UNION
SELECT 2,LJDG.easy_username(Chofer_nombre,Chofer_Apellido)
FROM gd_esquema.Maestra
group by Chofer_Nombre,Chofer_apellido,Chofer_dni,Chofer_direccion,Chofer_telefono,Chofer_Mail,Chofer_Fecha_Nac
GO



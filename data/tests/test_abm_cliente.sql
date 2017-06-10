USE GD1C2017
GO

/*DAR DE ALTA Y MODIFICAR CHOFERES ARRIBA DEL 48 DESDE LA APP, LUEGO EJECUTAR LO NECESARIO PARA VOLVER AL ESTADO POR DEFECTO*/

SELECT *
FROM LJDG.Cliente join LJDG.Usuario on clie_user = user_id join LJDG.Rol_Usuario on user_id = rxu_user join LJDG.Rol on rol_id = rxu_rol
WHERE rol_nombre = 'Cliente'
ORDER BY clie_id
GO

DELETE FROM LJDG.Chofer
WHERE chof_id > 47
GO

DBCC CHECKIDENT ('LJDG.Cliente', RESEED, 47);
GO

/*PARA BORRAR USUARIOS NUEVOS Y ROLES CLIENTE*/

DECLARE @test_user CHAR(30)
SET @test_user = 'damianc31'
DELETE FROM LJDG.Rol_Usuario
WHERE rxu_user = @test_user AND rxu_rol = 3
DELETE FROM LJDG.Usuario 
WHERE user_id = @test_user
GO

SELECT * 
FROM LJDG.Usuario join LJDG.Rol_Usuario on user_id = rxu_user
GO 

--DATOS ORIGINALES 89 usuarios, 1 rol admin 41 rol chofer, 47 rol cliente = 89 filas
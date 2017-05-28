USE GD1C2017
GO

/*DAR DE ALTA Y MODIFICAR CHOFERES ARRIBA DEL 42 DESDE LA APP, LUEGO EJECUTAR ESTE SCRIPT PARA VOLVER AL ESTADO POR DEFECTO*/

SELECT *
FROM LJDG.Chofer join LJDG.Usuario on chof_user = user_id join LJDG.Rol_Usuario on user_id = rxu_user join LJDG.Rol on rol_id = rxu_rol
WHERE rol_nombre = 'Chofer'
ORDER BY chof_id
GO

DELETE FROM LJDG.Chofer
WHERE chof_id > 41
GO

DBCC CHECKIDENT ('LJDG.Chofer', RESEED, 41);
GO

/*PARA BORRAR USUARIOS NUEVOS*/

DECLARE @test_user CHAR(30)
SET @test_user = 'damianc'
DELETE FROM LJDG.Rol_Usuario
WHERE rxu_user = @test_user
DELETE FROM LJDG.Usuario 
WHERE user_id = @test_user
GO

SELECT * 
FROM LJDG.Usuario
GO
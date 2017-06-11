USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='buscar_auto' AND type='p')
DROP PROCEDURE LJDG.buscar_auto
GO

CREATE PROCEDURE LJDG.buscar_auto
	@marca INT,
	@modelo VARCHAR(255),
	@patente VARCHAR(10),
	@chofer INT
AS
BEGIN
	SELECT auto_id 'ID',
		marc_nombre 'Marca',
		auto_modelo 'Modelo',
		auto_patente 'Patente',
		auto_chofer 'Chofer ID',
		chof_nombre 'Nombre',
		chof_apellido 'Apellido',
		auto_habilitado 'Habilitado'
	FROM LJDG.Automovil
		JOIN LJDG.Marca ON auto_marca = marc_id
		JOIN LJDG.Chofer ON auto_chofer = chof_id
	WHERE auto_modelo LIKE '%' + @modelo + '%'
		AND auto_patente LIKE '%' + @patente + '%'
		AND ( @marca = 0 OR auto_marca = @marca)
		AND ( @chofer = 0 OR auto_chofer = @chofer)
END
GO
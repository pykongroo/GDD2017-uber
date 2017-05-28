USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='modi_auto' AND type='p')
DROP PROCEDURE LJDG.modi_auto
GO

CREATE PROCEDURE LJDG.modi_auto
	@id INT,
	@marca INT,
	@patente VARCHAR(10),
	@modelo VARCHAR(255),
	@chofer INT,
	@turno INT,
	@habilitado BIT,
	@mensaje VARCHAR(200) OUT
AS
BEGIN
	IF @patente = ''
		SET @mensaje = 'Ingrese la Patente'
	ELSE IF @patente IN ( SELECT auto_patente FROM LJDG.Automovil WHERE auto_id != @id )
		SET @mensaje = 'La Patente Ingresada ya existe'
	ELSE IF @modelo = ''
		SET @mensaje = 'Ingrese el Modelo'
	ELSE
	BEGIN
		UPDATE LJDG.Automovil
		SET auto_marca = @marca,
			auto_patente = @patente,
			auto_modelo = @modelo,
			auto_chofer = @chofer,
			auto_turno = @turno,
			auto_habilitado = @habilitado
		WHERE auto_id = @id
		SET @mensaje = 'Automóvil Modificado Exitosamente'
	END
END
GO
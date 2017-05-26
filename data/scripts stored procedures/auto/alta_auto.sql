USE GD1C2017

IF EXISTS (SELECT name FROM sysobjects WHERE name='alta_auto' AND type='p')
DROP PROCEDURE LJDG.alta_auto
GO

CREATE PROCEDURE LJDG.alta_auto
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
	ELSE IF @patente IN ( SELECT auto_patente FROM LJDG.Automovil )
		SET @mensaje = 'La Patente Ingresada ya existe'
	ELSE IF @modelo = ''
		SET @mensaje = 'Ingrese el Modelo'
	ELSE IF @chofer IN ( SELECT auto_chofer FROM LJDG.Automovil
						WHERE auto_chofer = @chofer AND auto_habilitado = 1 ) AND @habilitado = 1
		SET @mensaje = 'El Chofer ya posee un Automóvil Habilitado'
	ELSE
	BEGIN
		INSERT INTO LJDG.Automovil
		( auto_marca, auto_patente, auto_modelo, auto_chofer, auto_turno, auto_habilitado )
		VALUES
		( @marca, @patente, @modelo, @chofer, @turno, @habilitado )
		SET @mensaje = 'Carga Exitosa'
	END
END
GO
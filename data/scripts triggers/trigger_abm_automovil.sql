USE GD1C2017
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name='trigger_abm_automovil')
	DROP TRIGGER LJDG.trigger_abm_automovil
GO

CREATE TRIGGER LJDG.trigger_abm_automovil
   ON  LJDG.Automovil
   AFTER INSERT,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here

	DECLARE @id INT
	DECLARE @hab BIT
	DECLARE @chof INT

	DECLARE c1 CURSOR FOR SELECT inserted.auto_id, inserted.auto_habilitado, inserted.auto_chofer
						FROM inserted
						ORDER BY inserted.auto_id

	OPEN c1
	FETCH NEXT FROM c1 INTO @id, @hab, @chof
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @hab = 1
		BEGIN

		UPDATE LJDG.Automovil
		SET auto_habilitado = 0  --deshabilito todos los otros automoviles del mismo chofer que no sean este
		WHERE auto_chofer = @chof and auto_id <> @id
		
		UPDATE LJDG.Automovil
		SET auto_habilitado = 1 --habilito este automovil (ya deberia estar habilitado, pero puede ser deshabilitado en una iteracion anterior,
		WHERE auto_id = @id		-- si varios autos activos del mismo chofer son insertados o actualizados a la vez. 
								--Con esto se deja el ultimo activo)
		END
		FETCH NEXT FROM c1 INTO @id, @hab, @chof
	END

	CLOSE c1
	DEALLOCATE c1
	---------------------
	SET NOCOUNT OFF;
END
GO

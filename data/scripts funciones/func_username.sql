USE GD1C2017
GO
IF EXISTS (SELECT name FROM sysobjects WHERE name='easy_username' AND type in ( N'FN', N'IF', N'TF', N'FS', N'FT' ))
DROP FUNCTION LJDG.easy_username
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [LJDG].[easy_username] 
(
	@nombre varchar(255) , @apellido varchar(255)
)
RETURNS varchar(255)
AS
BEGIN
	RETURN Lower(Substring(@nombre,1,2)+@apellido)
END
GO

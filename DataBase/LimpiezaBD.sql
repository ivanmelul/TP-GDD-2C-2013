DECLARE @Sql VARCHAR(MAX)
DECLARE @Schema VARCHAR(20)

WHILE (EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'))
	BEGIN
	SELECT TOP 1 @Sql = ('ALTER TABLE ' + TABLE_SCHEMA + '.[' + TABLE_NAME + '] DROP CONSTRAINT [' + CONSTRAINT_NAME + ']')
	FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
	WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
	EXEC (@Sql)
END

SET @Schema = 'SQUELA' 

SELECT @Sql = COALESCE(@Sql,'') + 'DROP TABLE ' + @Schema + '.' + QUOTENAME(TABLE_NAME) + ';' + CHAR(13)
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = @Schema
    AND TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME

SELECT @Sql = COALESCE(@Sql,'') + 'DROP VIEW ' + @Schema + '.' + QUOTENAME(TABLE_NAME) + ';' + CHAR(13)
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = @Schema
    AND TABLE_TYPE = 'VIEW'
ORDER BY TABLE_NAME

SELECT @Sql = COALESCE(@Sql,'') + 'DROP PROCEDURE ' + @Schema + '.' + QUOTENAME(ROUTINE_NAME) + ';' + CHAR(13)
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_SCHEMA = @Schema
    AND ROUTINE_TYPE = 'PROCEDURE'
ORDER BY ROUTINE_NAME

SELECT @Sql = COALESCE(@Sql,'') + 'DROP FUNCTION ' + @Schema + '.' + QUOTENAME(ROUTINE_NAME) + ';' + CHAR(13)
FROM INFORMATION_SCHEMA.ROUTINES
WHERE ROUTINE_SCHEMA = @Schema
    AND ROUTINE_TYPE = 'FUNCTION'
ORDER BY ROUTINE_NAME

EXEC (@Sql)

DROP SCHEMA [SQUELA]
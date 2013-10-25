--
-- Creacion Store Procedures
--

CREATE PROCEDURE [SQUELA].[GetAllRolByUser]
	@userId int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT 
		Rol.[ID_Rol] AS [Rol_ID],
		Rol.Nombre AS [Rol_Nombre],
		Rol.Habilitado AS [Rol_Habilitado]
	FROM 
		[SQUELA].[Rol] Rol
		JOIN [SQUELA].[RolXUsuario] RolxUsuario ON RolxUsuario.ID_Rol = Rol.ID_Rol
	WHERE 
		RolxUsuario.ID_Usuario = @userId AND [Rol].[Habilitado] = 1
	
END 
GO

CREATE PROCEDURE [SQUELA].[GetRolByName] 
	@rolName varchar(25),
	@rolHabilitados bit
AS
BEGIN
	
	SET NOCOUNT ON;
 
	IF @rolHabilitados = 1 
		BEGIN
		SELECT TOP 1
			[ID_Rol] AS [Rol_ID],
			[Nombre] AS [Rol_Nombre],
			[Habilitado] AS [Rol_Habilitado]
		
		FROM [SQUELA].[Rol]
		WHERE
			[Nombre] = @rolName AND [Habilitado] = 1
		END
	ELSE
		BEGIN 
		SELECT TOP 1
			[ID_Rol] AS [Rol_ID],
			[Nombre] AS [Rol_Nombre],
			[Habilitado] AS [Rol_Habilitado]
		
		FROM [SQUELA].[Rol]
		WHERE
			[Nombre] = @rolName
		END
END
GO

CREATE PROCEDURE [SQUELA].[GetAllRolByNameLike] 
	@rolName varchar(50),
	@rolHabilitados bit
AS
BEGIN
	
	SET NOCOUNT ON;
 
	IF @rolHabilitados = 1 
		BEGIN
		SELECT
			[ID_Rol] AS [Rol_ID],
			[Nombre] AS [Rol_Nombre],
			[Habilitado] AS [Rol_Habilitado]
		
		FROM [SQUELA].[Rol]
		WHERE
			[Nombre] LIKE '%' + @rolName + '%' AND [Habilitado] = 1
		END
	ELSE
		BEGIN 
		SELECT
			[ID_Rol] AS [Rol_ID],
			[Nombre] AS [Rol_Nombre],
			[Habilitado] AS [Rol_Habilitado]
		
		FROM [SQUELA].[Rol]
		WHERE
			[Nombre] LIKE '%' + @rolName + '%'
		END
END
GO

CREATE PROCEDURE [SQUELA].[InsertRol] 
	@rolName varchar(25),
	@rolHabilitado bit
AS
BEGIN
	
	SET NOCOUNT ON;
 
    -- Insert statements for procedure here
	INSERT INTO [SQUELA].[Rol](
		[Nombre],
		[Habilitado]
	)
	VALUES (
		@rolName,
		@rolHabilitado
	)
	SELECT SCOPE_IDENTITY()
END
GO

CREATE PROCEDURE [SQUELA].[UpdateRolById] 
	@rolId int,
	@rolName varchar(25),
	@rolHabilitado bit
AS
BEGIN
	
	SET NOCOUNT ON;
 
    -- Insert statements for procedure here
	UPDATE [SQUELA].[Rol]
	SET 
		[Nombre] = @rolName,
		[Habilitado] = @rolHabilitado
	WHERE
		[ID_Rol] = @rolId
END
GO

CREATE PROCEDURE [SQUELA].[GetAllFuncionalidad] 
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT 
		[ID_Func] AS [Func_ID], 
		[Nombre] AS [Func_Nombre]
	FROM [SQUELA].[Funcionalidad]
END
GO

CREATE PROCEDURE [SQUELA].[GetAllFuncionalidadByRol] 
	@rolId int
AS
BEGIN
	
	SET NOCOUNT ON;
 
    -- Insert statements for procedure here
	SELECT  
		[Funcionalidad].[ID_Func] AS [Func_ID],
		[Funcionalidad].[Nombre] AS [Func_Nombre]
	FROM [SQUELA].[Funcionalidad] AS [Funcionalidad]
		JOIN [SQUELA].[RolXFuncionalidad] AS [RolXFuncionalidad] ON [Funcionalidad].ID_Func = [RolXFuncionalidad].[ID_Func]
	WHERE
		[RolXFuncionalidad].[ID_Rol] = @rolId 
END
GO

CREATE PROCEDURE [SQUELA].[InsertFuncionalidadXRol] 
	@funcId int,
	@rolId int
AS
BEGIN
	
	SET NOCOUNT ON;
 
    -- Insert statements for procedure here
	INSERT INTO [SQUELA].[RolXFuncionalidad](
		[ID_Func],
		[ID_Rol] 
	)
	VALUES (
		@funcId,
		@rolId 
	)
END
GO

CREATE PROCEDURE [SQUELA].[DeleteFuncionalidadXRol] 
	@rolId int,
	@funcId int
AS
BEGIN
	
	SET NOCOUNT ON;
		
    -- Insert statements for procedure here
	DELETE FROM [SQUELA].[RolXFuncionalidad] 
	WHERE
		[ID_Func] = @funcId AND [ID_Rol] = @rolId 
			
END
GO


CREATE PROCEDURE [SQUELA].[GetUserByUsername]
	@userUsername varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		[ID_Usuario] AS [Usuario_ID],
		[Usuario] AS [Usuario_Nombre],
		[Password] AS [Usuario_Password],
		[Habilitado] AS [Usuario_Habilitado],
		[LoginFails] AS [Usuario_LoginFails]
    FROM [SQUELA].[Usuario]
    WHERE [Usuario] = @userUsername
    	
END
GO

CREATE PROCEDURE [SQUELA].[UpdateUser]
	@userId int,
	@userLoginFails int,
	@userHabilitado bit
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE [SQUELA].[Usuario] 
    SET 
		LoginFails = @userLoginFails,
		Habilitado = @userHabilitado 
    WHERE ID_Usuario = @userId
    	
END
GO



CREATE PROCEDURE [SQUELA].[DeleteAllFuncionalidadXRol]
	@rolId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM [SQUELA].[RolXFuncionalidad] WHERE [ID_Rol] = @rolId
END
GO


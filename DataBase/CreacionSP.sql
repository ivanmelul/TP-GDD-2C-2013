--
-- Creacion Store Procedures
--

CREATE PROCEDURE [SQUELA].[GetRoleByName] 
	@roleName varchar(25),
	@habilitados bit
AS
BEGIN
	
	SET NOCOUNT ON;
 
	IF @habilitados = 1 
		BEGIN
		SELECT TOP 1
			[ID_Rol] AS [Rol_ID],
			[Nombre] AS [Rol_Nombre],
			[Habilitado] AS [Rol_Habilitado]
		
		FROM [SQUELA].[Rol]
		WHERE
			[Nombre] = @roleName AND [Habilitado] = 1
		END
	ELSE
		BEGIN 
		SELECT TOP 1
			[ID_Rol] AS [Rol_ID],
			[Nombre] AS [Rol_Nombre],
			[Habilitado] AS [Rol_Habilitado]
		
		FROM [SQUELA].[Rol]
		WHERE
			[Nombre] = @roleName
		END
END
GO

CREATE PROCEDURE [SQUELA].[GetRoleByNameLike] 
	@roleName varchar(50),
	@habilitados bit
AS
BEGIN
	
	SET NOCOUNT ON;
 
	IF @habilitados = 1 
		BEGIN
		SELECT
			[ID_Rol] AS [Rol_ID],
			[Nombre] AS [Rol_Nombre],
			[Habilitado] AS [Rol_Habilitado]
		
		FROM [SQUELA].[Rol]
		WHERE
			[Nombre] LIKE '%' + @roleName + '%' AND [Habilitado] = 1
		END
	ELSE
		BEGIN 
		SELECT
			[ID_Rol] AS [Rol_ID],
			[Nombre] AS [Rol_Nombre],
			[Habilitado] AS [Rol_Habilitado]
		
		FROM [SQUELA].[Rol]
		WHERE
			[Nombre] LIKE '%' + @roleName + '%'
		END
END
GO

CREATE PROCEDURE [SQUELA].[InsertRole] 
	@roleName varchar(25),
	@habilitado bit
AS
BEGIN
	
	SET NOCOUNT ON;
 
    -- Insert statements for procedure here
	INSERT INTO [SQUELA].[Rol](
		[Nombre],
		[Habilitado]
	)
	VALUES (
		@roleName,
		@habilitado
	)
	SELECT SCOPE_IDENTITY ()
END
GO

CREATE PROCEDURE [SQUELA].[UpdateRoleById] 
	@id int,
	@roleName varchar(25),
	@habilitado bit
AS
BEGIN
	
	SET NOCOUNT ON;
 
    -- Insert statements for procedure here
	UPDATE [SQUELA].[Rol]
	SET 
		[Nombre] = @roleName,
		[Habilitado] = @habilitado
	WHERE
		[ID_Rol] = @id
END
GO

CREATE PROCEDURE [SQUELA].[GetFuncionalidadesByRol] 
	@id int
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
		[RolXFuncionalidad].[ID_Rol] = @id 
END
GO

CREATE PROCEDURE [SQUELA].[InsertFuncionalidadXRol] 
	@idFunc int,
	@idRol int
AS
BEGIN
	
	SET NOCOUNT ON;
 
    -- Insert statements for procedure here
	INSERT INTO [SQUELA].[RolXFuncionalidad](
		[ID_Func],
		[ID_Rol] 
	)
	VALUES (
		@idFunc,
		@idRol 
	)
END
GO

CREATE PROCEDURE [SQUELA].[DeleteFuncionalidadXRol] 
	@idRol int,
	@idFunc int
AS
BEGIN
	
	SET NOCOUNT ON;
		
    -- Insert statements for procedure here
	DELETE FROM [SQUELA].[RolXFuncionalidad] 
	WHERE
		[ID_Func] = @idFunc AND [ID_Rol] = @idRol 
			
END
GO


CREATE PROCEDURE [SQUELA].[GetUserByUsername]
	@username varchar(50)
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
    WHERE [Usuario] = @username
    	
END
GO

CREATE PROCEDURE [SQUELA].[UpdateUser]
	@userId int,
	@loginFails int,
	@habilitado bit
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE [SQUELA].[Usuario] 
    SET 
		LoginFails = @loginFails,
		Habilitado = @habilitado 
    WHERE ID_Usuario = @userId
    	
END
GO

CREATE PROCEDURE [SQUELA].[GetRolesByUser]
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

CREATE PROCEDURE [SQUELA].[DeleteAllFuncionalidadXRol]
	@idRol int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM [SQUELA].[RolXFuncionalidad] WHERE [ID_Rol] = @idRol
END
GO


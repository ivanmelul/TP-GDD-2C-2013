--			 --
-- Migracion --
--			 --

--
-- Migracion Tabla PlanMedico
--
SET IDENTITY_INSERT [SQUELA].[PlanMedico] ON

INSERT INTO [SQUELA].[PlanMedico]
(
	[ID_PlanMedico],
	[Nombre],
	[PrecioConsulta],
	[PrecioBono]
)
SELECT DISTINCT 
	[Plan_Med_Codigo] AS ID_PlanMedico,
	[Plan_Med_Descripcion] AS Nombre,
	[Plan_Med_Precio_Bono_Consulta] AS PrecioConsulta,
	[Plan_Med_Precio_Bono_Farmacia] AS PrecioBono
		
FROM gd_esquema.Maestra

SET IDENTITY_INSERT [SQUELA].[PlanMedico] OFF

--
-- Migracion Tabla Afiliados
--
INSERT INTO [SQUELA].[Afiliado]
(	
	[Nombre],
	[Apellido],
	[Numero],
	[Direccion],
	[Telefono],
	[Mail],
	[FechaNacimiento],
	-- [Sexo],
	-- [ID_EstadoCivil],
	[ID_PlanMedico]
	-- [NumeroAfiliadoBase], IDENTITY
	-- [NumeroAfiliadoFamiliar], DEFAULT
)
SELECT DISTINCT 
		
		[Paciente_Nombre] AS Nombre,
		[Paciente_Apellido] AS Apellido,	
		[Paciente_Dni] AS Numero,	
		[Paciente_Direccion] AS Direccion,
		[Paciente_Telefono] AS Telefono,
		[Paciente_Mail] AS Mail,
		[Paciente_Fecha_Nac] AS FechaNacimiento,
		-- [Sexo] NULL
		-- [ID_EstadoCivil] NULL
		[Plan_Med_Codigo] AS ID_PlanMedico
		
FROM gd_esquema.Maestra

--							   --
-- Migracion Tabla Profesional --
--							   --

INSERT INTO [SQUELA].[Profesional]
(	
	[ID_Profesional],
	[Nombre],
	[Apellido],
	[Direccion],
	[Telefono],
	[Mail],
	[FechaNacimiento]
	-- [Matricula] NULL
	-- [Baja] DEFAULT
	-- [Sexo] NULL
)
SELECT DISTINCT 
	[Medico_Dni] AS ID_Profesional,
	[Medico_Nombre] AS Nombre,
	[Medico_Apellido] AS Apellido,
	[Medico_Direccion] AS Direccion,
	[Medico_Telefono] AS Telefono,
	[Medico_Mail] AS Mail,
	[Medico_Fecha_Nac] AS FechaNacimiento
		
FROM gd_esquema.Maestra
WHERE Medico_Nombre IS NOT NULL

--									--
-- Migracion Tabla TipoEspecialidad --
--									--

SET IDENTITY_INSERT [SQUELA].[TipoEspecialidad] ON

INSERT INTO [SQUELA].[TipoEspecialidad]
(
	[ID_TipoEspecialidad],
	[Descripcion]
)
SELECT DISTINCT 
    [Tipo_Especialidad_Codigo] AS ID_TipoEspecialidad,
    [Tipo_Especialidad_Descripcion] AS Descripcion
	FROM gd_esquema.Maestra
	WHERE [Tipo_Especialidad_Codigo] IS NOT NULL
	
SET IDENTITY_INSERT [SQUELA].[TipoEspecialidad] OFF

--								--
-- Migracion Tabla Especialidad --
--								--

SET IDENTITY_INSERT [SQUELA].[Especialidad] ON

INSERT INTO [SQUELA].[Especialidad]
(
	[ID_Especialidad],
	[Descripcion],
	[ID_TipoEspecialidad]
)
SELECT DISTINCT 
    [Especialidad_Codigo] AS ID_Especialidad,
    [Especialidad_Descripcion] AS Descripcion,
    [Tipo_Especialidad_Codigo] AS ID_TipoEspecialidad
	FROM gd_esquema.Maestra
	WHERE [Especialidad_Codigo] IS NOT NULL
	
SET IDENTITY_INSERT [SQUELA].[Especialidad] OFF


--								--
-- Migracion Tabla Compra       --
--								--

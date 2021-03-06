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
	[ID_PlanMedico],
	[NumeroAfiliadoBase]
	--[NumeroAfiliadoFamiliar], DEFAULT
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
		[Plan_Med_Codigo] AS ID_PlanMedico,
		1 AS NumeroAfiliadoBase
		
FROM gd_esquema.Maestra

UPDATE [SQUELA].[Afiliado] SET [NumeroAfiliadoBase] = [ID_Afiliado]

--							   --
-- Migracion Tabla Profesional --
--							   --

INSERT INTO [SQUELA].[Profesional]
(	
	[Nombre],
	[Apellido],
	[Numero],
	[Direccion],
	[Telefono],
	[Mail],
	[FechaNacimiento],
	[Matricula]
	-- [Baja] DEFAULT
	-- [Sexo] NULL
)
SELECT DISTINCT 
	[Medico_Nombre] AS Nombre,
	[Medico_Apellido] AS Apellido,
	[Medico_Dni] AS Numero,
	[Medico_Direccion] AS Direccion,
	[Medico_Telefono] AS Telefono,
	[Medico_Mail] AS Mail,
	[Medico_Fecha_Nac] AS FechaNacimiento,
	1 AS Matricula
		
FROM gd_esquema.Maestra
WHERE Medico_Nombre IS NOT NULL

UPDATE [SQUELA].[Profesional] SET [Matricula] = [ID_Profesional]

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
INSERT INTO [SQUELA].[Compra]
(	
	[ID_Afiliado], [Fecha]
)
SELECT DISTINCT [Afiliado].ID_Afiliado, [Compra_Bono_Fecha]
	FROM gd_esquema.Maestra
	JOIN [SQUELA].[Afiliado] ON [Afiliado].ID_TipoDocumento = 1 AND [Afiliado].Numero = [Paciente_Dni]
	WHERE [Compra_Bono_Fecha] IS NOT NULL
	GROUP BY [Afiliado].ID_Afiliado, [Compra_Bono_Fecha]
	ORDER BY [Afiliado].ID_Afiliado, [Compra_Bono_Fecha]
	
	

--								--
-- Migracion Tabla BonoConsulta --
--								--

SET IDENTITY_INSERT [SQUELA].[BonoConsulta] ON

INSERT INTO [SQUELA].[BonoConsulta]
(
	[ID_BonoConsulta],
	[ID_Compra],
	[ID_PlanMedico],
	[ID_Comprador]
)
SELECT DISTINCT [Bono_Consulta_Numero] AS BonoConsulta
	, [Compra].[ID_Compra] AS ID_Compra
	, [Afiliado].[ID_PlanMedico] AS ID_PlanMedico
	, [Afiliado].[ID_Afiliado] AS ID_Comprador
	FROM gd_esquema.Maestra
	JOIN [SQUELA].[Afiliado] ON [Afiliado].[ID_TipoDocumento] = 1 AND [Afiliado].[Numero] = [Paciente_Dni]
	JOIN [SQUELA].[Compra] ON [Compra].[ID_Afiliado] = [Afiliado].ID_Afiliado AND [Compra].[Fecha] = [Compra_Bono_Fecha]
	WHERE [Compra_Bono_Fecha] IS NOT NULL
	AND [Bono_Consulta_Numero] IS NOT NULL
	
SET IDENTITY_INSERT [SQUELA].[BonoConsulta] OFF
--								--
-- Migracion Tabla BonoFarmacia --
--								--

SET IDENTITY_INSERT [SQUELA].[BonoFarmacia] ON

INSERT INTO [SQUELA].[BonoFarmacia]
(
	[ID_BonoFarmacia],
	[ID_Compra],
	[ID_PlanMedico],
	[ID_Comprador]
)
SELECT DISTINCT [Bono_Farmacia_Numero] AS BonoFarmacia
	, [Compra].[ID_Compra] AS ID_Compra
	, [Afiliado].[ID_PlanMedico] AS ID_PlanMedico
	, [Afiliado].[ID_Afiliado] AS ID_Comprador
	FROM gd_esquema.Maestra
	JOIN [SQUELA].[Afiliado] ON [Afiliado].[ID_TipoDocumento] = 1 AND [Afiliado].[Numero] = [Paciente_Dni]
	JOIN [SQUELA].[Compra] ON [Compra].[ID_Afiliado] = [Afiliado].ID_Afiliado AND [Compra].[Fecha] = [Compra_Bono_Fecha]
	WHERE [Compra_Bono_Fecha] IS NOT NULL
	AND [Bono_Farmacia_Numero] IS NOT NULL
	
SET IDENTITY_INSERT [SQUELA].[BonoFarmacia] OFF

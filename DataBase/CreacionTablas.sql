USE [GD2C2013]

--					  --
-- Creacion de Schema --
--					  --

IF NOT EXISTS (SELECT 1 FROM sys.schemas WHERE name = 'SQUELA')
BEGIN
  EXECUTE( 'CREATE SCHEMA SQUELA AUTHORIZATION [gd]' );
END

--					  --
-- Creacion de Tablas --
--					  --

--
-- Creacion Tabla Usuario
--
CREATE TABLE [SQUELA].Usuario(
	ID_Usuario numeric(18,0) identity(1,1) primary key,
	Usuario varchar(50) NOT NULL,
	[Password] varchar(100) NOT NULL,
	Habilitado bit NOT NULL DEFAULT 1,
	LoginFails integer NOT NULL DEFAULT 0,
	UNIQUE(Usuario)
) 

--
-- Creacion Tabla Rol
--
CREATE TABLE [SQUELA].Rol(
	ID_Rol numeric(18,0) identity(1,1) primary key,
	Nombre varchar(50) NOT NULL,
	Habilitado bit NOT NULL DEFAULT 1
) 

--
-- Creacion Tabla RolXUsuario
--
CREATE TABLE [SQUELA].RolXUsuario(
	ID_Usuario numeric(18,0) NOT NULL,
	ID_Rol numeric(18,0) NOT NULL
)

--
-- Creacion Tabla Funcionalidad
--
CREATE TABLE [SQUELA].Funcionalidad(
	ID_Func numeric(18,0) identity(1,1) primary key,
	Nombre varchar(50) NOT NULL
) 

--
-- Creacion Tabla RolXFuncionalidad
--
CREATE TABLE [SQUELA].RolXFuncionalidad(
	ID_Rol numeric(18,0) NOT NULL,
	ID_Func numeric(18,0) NOT NULL
)

--
-- Creacion Tabla Afiliado
--
CREATE TABLE [SQUELA].[Afiliado]
(
	[Nombre] [nvarchar](255) NOT NULL,
	[Apellido] [nvarchar](255) NOT NULL,
	[DNI] [numeric](18, 0) NOT NULL PRIMARY KEY,
	[Direccion] [nvarchar](255) NOT NULL,
	[Telefono] [nvarchar](255) NOT NULL,
	[Mail] [nvarchar](255) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Sexo] [char](1) NULL,
	[ID_EstadoCivil] [numeric](18, 0) NULL,
	[ID_PlanMedico] [numeric](18, 0) NOT NULL,
	[NumeroAfiliadoBase] [numeric](18, 0) NOT NULL IDENTITY(1,1),
	[NumeroAfiliadoFamiliar] [numeric](2, 0) NOT NULL DEFAULT 1,
	[FechaBaja] [datetime] NULL,
	UNIQUE ([NumeroAfiliadoBase], [NumeroAfiliadoFamiliar])
)

--
-- Creacion Tabla Profesional
--
CREATE TABLE [SQUELA].[Profesional]
(
	[Nombre] [nvarchar](255) NOT NULL,
	[Apellido] [nvarchar](255) NOT NULL,
	[DNI] [numeric](18, 0) NOT NULL PRIMARY KEY,
	[Direccion] [nvarchar](255) NOT NULL,
	[Telefono] [nvarchar](255) NOT NULL,
	[Mail] [varchar](255) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Matricula] [varchar](255) NULL UNIQUE,
	[FechaBaja] [datetime] NULL,
	[Sexo] [char](1) NULL
)

--
-- Creacion Tabla Plan Medico
--
CREATE TABLE [SQUELA].[PlanMedico]
(
	[ID_PlanMedico] [numeric](18, 0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Nombre] [nvarchar](255) NOT NULL,
	[PrecioConsulta] [numeric](18, 0) NOT NULL,
	[PrecioBono] [numeric](18, 0) NOT NULL
)

--
-- Creacion Tabla TipoEspecialidad
--
CREATE TABLE [SQUELA].[TipoEspecialidad]
(
	[ID_TipoEspecialidad] [numeric](18, 0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Descripcion] [varchar](255) NOT NULL
)

--
-- Creacion Tabla Especialidad
--
CREATE TABLE [SQUELA].[Especialidad]
(
	[ID_Especialidad] [numeric](18, 0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Descripcion] [varchar](255) NOT NULL,
	[ID_TipoEspecialidad] [numeric](18, 0) NOT NULL
)

--
-- Creacion Tabla EstadoCivil
--
CREATE TABLE [SQUELA].[EstadoCivil]
(
	[ID_EstadoCivil] [numeric](18, 0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Nombre] [nvarchar](255) NOT NULL
)

--
-- Creacion Tabla ProfesionalXEspecialidad
--
CREATE TABLE [SQUELA].[ProfesionalXEspecialidad]
(
	[ID_Profesional] [numeric](18, 0) NOT NULL,
	[ID_Especialidad] [numeric](18, 0) NOT NULL
)

--
-- Creacion Tabla Agenda
--
CREATE TABLE [SQUELA].[Agenda]
(
	[ID_Agenda] [numeric](18, 0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[ID_Profesional] [numeric](18, 0) NOT NULL,
	[Desde] [datetime] NOT NULL,
	[Hasta] [datetime] NOT NULL
)

--
-- Creacion Tabla HorarioXAgenda
--
CREATE TABLE [SQUELA].[HorarioXAgenda]
(
	[ID_Agenda] [numeric](18, 0) NOT NULL,
	[ID_Dia] [numeric](18, 0) NOT NULL,
	[ID_Horario] [numeric](18, 0) NOT NULL
)

--
-- Creacion Tabla Dia
--
CREATE TABLE [SQUELA].[Dia]
(
	[ID_Dia] [numeric](18, 0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Dia] [varchar](50) NOT NULL
)

--
-- Creacion Tabla BonoConsulta
--
CREATE TABLE [SQUELA].[BonoConsulta]
(
	[ID_BonoConsulta] [numeric](18, 0) NOT NULL PRIMARY KEY, -- TODO: IDENTITY(1,1) -> Prenderlo despues de la migracion
	[ID_Compra] [numeric](18, 0) NOT NULL,
	[ID_PlanMedico] [numeric](18, 0) NOT NULL,
	[ID_Comprador] [numeric](18, 0) NOT NULL,
	[ID_Consumidor] [numeric](18, 0) NOT NULL,
	[NumeroConsulta] [numeric](18, 0) NULL
)

--
-- Creacion Tabla BonoFarmacia
--
CREATE TABLE [SQUELA].[BonoFarmacia]
(
	[ID_BonoFarmacia] [numeric](18, 0) NOT NULL PRIMARY KEY, -- TODO: IDENTITY(1,1) -> Prenderlo despues de la migracion
	[ID_Compra] [numeric](18, 0) NOT NULL,
	[ID_PlanMedico] [numeric](18, 0) NOT NULL,
	[ID_Comprador] [numeric](18, 0) NOT NULL,
	[ID_Consumidor] [numeric](18, 0) NOT NULL
)

--
-- Creacion Tabla Compra
--
CREATE TABLE [SQUELA].[Compra]
(
	[ID_Compra] [numeric](18, 0) NOT NULL IDENTITY (1,1) PRIMARY KEY,
	[Fecha] [datetime] NOT NULL
)

--
-- Creacion Tabla Turno
--
CREATE TABLE [SQUELA].[Turno]
(
	[ID_Turno] [numeric](18, 0) NOT NULL PRIMARY KEY,  -- TODO: IDENTITY(1,1) -> Prenderlo despues de la migracion
	[ID_Profesional] [numeric](18, 0) NOT NULL,
	[ID_Afiliado] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[ID_Horario] [numeric](18,0) NOT NULL
)

--
-- Creacion Tabla Horario
--
CREATE TABLE [SQUELA].[Horario]
(
	[ID_Horario] [numeric](18, 0) NOT NULL PRIMARY KEY,
	[Hora] [time] NOT NULL
)

--
-- Creacion Tabla Consulta
--
CREATE TABLE [SQUELA].[Consulta]
(
	[ID_Consulta] [numeric](18, 0) NOT NULL IDENTITY(1,1) PRIMARY KEY, -- Ya hay ID's de consultas en la maestra?
	[ID_Turno] [numeric](18, 0) NOT NULL,
	[ID_BonoConsulta] [numeric](18, 0) NOT NULL,
	[Llegada] [datetime] NOT NULL,
	[Diagnostico] [nvarchar](255) NULL,
	[Sintomas] [nvarchar](255) NULL
)

--
-- Creacion Tabla Cancelacion
--
CREATE TABLE [SQUELA].[Cancelacion]
(
	[ID_Cancelacion] [numeric](18, 0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[ID_TipoCancelacion] [numeric](18, 0) NOT NULL,
	[Motivo] [nvarchar](255) NOT NULL,
	[CanceladoPor] [char](1) NOT NULL,
	[ID_Turno] [numeric](18, 0) NOT NULL,
	[FechaCancelacion] [datetime] NOT NULL
)

--
-- Creacion Tabla TipoCancelacion
--
CREATE TABLE [SQUELA].[TipoCancelacion]
(
	[ID_TipoCancelacion] [numeric](18, 0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Nombre] [nvarchar](255) NOT NULL
)

--
-- Creacion Tabla Receta
--
CREATE TABLE [SQUELA].[Receta]
(
	[ID_Receta] [numeric](18, 0) NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[ID_Consulta] [numeric](18, 0) NOT NULL
)

--
-- Creacion Tabla RecetaXBonoFarmacia
--
CREATE TABLE [SQUELA].[RecetaXBonoFarmacia]
(
	[ID_Receta] [numeric](18, 0) NOT NULL,
	[ID_BonoFarmacia] [numeric](18, 0) NOT NULL
)

--
-- Creacion Tabla RecetaXMedicamento
--
CREATE TABLE [SQUELA].[RecetaXMedicamento]
(
	[ID_Receta] [numeric](18, 0) NOT NULL,
	[Medicamento] [nvarchar](255) NOT NULL,
	[Cantidad] [numeric](18, 0) NOT NULL
)

--							 --
-- Creacion de Foreign Key's --
--							 --

--
-- Foreign Key's Afiliados
--
ALTER TABLE [SQUELA].Afiliado
	ADD FOREIGN KEY (ID_EstadoCivil) REFERENCES [SQUELA].EstadoCivil(ID_EstadoCivil)
ALTER TABLE [SQUELA].Afiliado
	ADD FOREIGN KEY (ID_PlanMedico) REFERENCES [SQUELA].PlanMedico(ID_PlanMedico)

--
-- Foreign Key's ProfesionalXEspecialidad
--
ALTER TABLE [SQUELA].ProfesionalXEspecialidad
	ADD FOREIGN KEY (ID_Profesional) REFERENCES [SQUELA].Profesional(DNI)
ALTER TABLE [SQUELA].ProfesionalXEspecialidad
	ADD FOREIGN KEY (ID_Especialidad) REFERENCES [SQUELA].Especialidad(ID_Especialidad)

--
-- Foreign Key's Especialidad
--
ALTER TABLE [SQUELA].Especialidad
	ADD FOREIGN KEY (ID_TipoEspecialidad) REFERENCES [SQUELA].TipoEspecialidad(ID_TipoEspecialidad)

--
-- Foreign Key's Agenda
--
ALTER TABLE [SQUELA].Agenda
	ADD FOREIGN KEY (ID_Profesional) REFERENCES [SQUELA].Profesional(DNI)
	
--
-- Foreign Key's HorarioXAgenda
--
ALTER TABLE [SQUELA].HorarioXAgenda
	ADD FOREIGN KEY (ID_Agenda) REFERENCES [SQUELA].Agenda(ID_Agenda)
ALTER TABLE [SQUELA].HorarioXAgenda
	ADD FOREIGN KEY (ID_Dia) REFERENCES [SQUELA].Dia(ID_Dia)
ALTER TABLE [SQUELA].HorarioXAgenda
	ADD FOREIGN KEY (ID_Horario) REFERENCES [SQUELA].Horario(ID_Horario)
	
--
-- Foreign Key's BonoConsulta
--
ALTER TABLE [SQUELA].BonoConsulta
	ADD FOREIGN KEY (ID_Compra) REFERENCES [SQUELA].Compra(ID_Compra)
ALTER TABLE [SQUELA].BonoConsulta
	ADD FOREIGN KEY (ID_PlanMedico) REFERENCES [SQUELA].PlanMedico(ID_PlanMedico)
ALTER TABLE [SQUELA].BonoConsulta
	ADD FOREIGN KEY (ID_Comprador) REFERENCES [SQUELA].Afiliado(DNI)
ALTER TABLE [SQUELA].BonoConsulta
	ADD FOREIGN KEY (ID_Consumidor) REFERENCES [SQUELA].Afiliado(DNI)	

--
-- Foreign Key's BonoFarmacia
--
ALTER TABLE [SQUELA].BonoFarmacia
	ADD FOREIGN KEY (ID_Compra) REFERENCES [SQUELA].Compra(ID_Compra)
ALTER TABLE [SQUELA].BonoFarmacia
	ADD FOREIGN KEY (ID_PlanMedico) REFERENCES [SQUELA].PlanMedico(ID_PlanMedico)
ALTER TABLE [SQUELA].BonoFarmacia
	ADD FOREIGN KEY (ID_Comprador) REFERENCES [SQUELA].Afiliado(DNI)
ALTER TABLE [SQUELA].BonoFarmacia
	ADD FOREIGN KEY (ID_Consumidor) REFERENCES [SQUELA].Afiliado(DNI)
	
--
-- Foreign Key's Turno
--
ALTER TABLE [SQUELA].Turno
	ADD FOREIGN KEY (ID_Profesional) REFERENCES [SQUELA].Profesional(DNI)
ALTER TABLE [SQUELA].Turno
	ADD FOREIGN KEY (ID_Afiliado) REFERENCES [SQUELA].Afiliado(DNI)
ALTER TABLE [SQUELA].Turno
	ADD FOREIGN KEY (ID_Horario) REFERENCES [SQUELA].Horario(ID_Horario)

--
-- Foreign Key's Consulta
--
ALTER TABLE [SQUELA].Consulta
	ADD FOREIGN KEY (ID_Turno) REFERENCES [SQUELA].Turno(ID_Turno)
ALTER TABLE [SQUELA].Consulta
	ADD FOREIGN KEY (ID_BonoConsulta) REFERENCES [SQUELA].BonoConsulta(ID_BonoConsulta)

--
-- Foreign Key's Cancelacion
--
ALTER TABLE [SQUELA].Cancelacion
	ADD FOREIGN KEY (ID_TipoCancelacion) REFERENCES [SQUELA].TipoCancelacion(ID_TipoCancelacion)
ALTER TABLE [SQUELA].Cancelacion
	ADD FOREIGN KEY (ID_Turno) REFERENCES [SQUELA].Turno(ID_Turno)

--
-- Foreign Key's Receta
--
ALTER TABLE [SQUELA].Receta
	ADD FOREIGN KEY (ID_Consulta) REFERENCES [SQUELA].Consulta(ID_Consulta)

--
-- Foreign Key's RecetaXBonoFarmacia
--
ALTER TABLE [SQUELA].RecetaXBonoFarmacia
	ADD FOREIGN KEY (ID_Receta) REFERENCES [SQUELA].Receta(ID_Receta)
ALTER TABLE [SQUELA].RecetaXBonoFarmacia
	ADD FOREIGN KEY (ID_BonoFarmacia) REFERENCES [SQUELA].BonoFarmacia(ID_BonoFarmacia)

--
-- Foreign Key's RecetaXMedicamento
--
ALTER TABLE [SQUELA].RecetaXMedicamento
	ADD FOREIGN KEY (ID_Receta) REFERENCES [SQUELA].Receta(ID_Receta)
	
--
-- Foreign Key's RolXUsuario
--
ALTER TABLE [SQUELA].RolXUsuario
	ADD FOREIGN KEY (ID_Usuario) REFERENCES [SQUELA].Usuario(ID_Usuario)
ALTER TABLE [SQUELA].RolXUsuario
	ADD FOREIGN KEY (ID_Rol) REFERENCES [SQUELA].Rol(ID_Rol)
	
--
-- Foreign Key's RolXFuncionalidad
--
ALTER TABLE [SQUELA].RolXFuncionalidad
	ADD FOREIGN KEY (ID_Rol) REFERENCES [SQUELA].Rol(ID_Rol)
ALTER TABLE [SQUELA].RolXFuncionalidad 
	ADD FOREIGN KEY (ID_Func) REFERENCES [SQUELA].Funcionalidad(ID_Func)
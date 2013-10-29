--Creacion Funcionalidades
INSERT INTO [SQUELA].[Funcionalidad]([Nombre]) VALUES('ABM Roles')
INSERT INTO [SQUELA].[Funcionalidad]([Nombre]) VALUES('ABM Afiliados')
INSERT INTO [SQUELA].[Funcionalidad]([Nombre]) VALUES('ABM Profesionales')
INSERT INTO [SQUELA].[Funcionalidad]([Nombre]) VALUES('Registrar Agenda')
INSERT INTO [SQUELA].[Funcionalidad]([Nombre]) VALUES('Comprar Bono')
INSERT INTO [SQUELA].[Funcionalidad]([Nombre]) VALUES('Pedir Turno')
INSERT INTO [SQUELA].[Funcionalidad]([Nombre]) VALUES('Registrar Llegada')
INSERT INTO [SQUELA].[Funcionalidad]([Nombre]) VALUES('Registrar Resultados')
INSERT INTO [SQUELA].[Funcionalidad]([Nombre]) VALUES('Cancelar Atencion')
INSERT INTO [SQUELA].[Funcionalidad]([Nombre]) VALUES('Emitir Receta')
INSERT INTO [SQUELA].[Funcionalidad]([Nombre]) VALUES('Estadisticas')

--Creacion roles
INSERT INTO [SQUELA].Rol([Nombre]) VALUES('Afiliado')
INSERT INTO [SQUELA].Rol([Nombre]) VALUES('Administrativo')
INSERT INTO [SQUELA].Rol([Nombre]) VALUES('Profesional')

--Asignacion de funcionalidades a los roles TODO
DECLARE @funcId int
DECLARE @roleId int

SELECT @roleId = [ID_Rol] FROM [SQUELA].Rol WHERE [Nombre] = 'Afiliado'

SELECT @funcId = [ID_Func] FROM [SQUELA].Funcionalidad WHERE [Nombre] = 'ABM Roles'
INSERT INTO [SQUELA].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)


--Creacion usuarios administradores
INSERT INTO [SQUELA].Usuario([Usuario], [Password])
VALUES ('Admin', 'E6-B8-70-50-BF-CB-81-43-FC-B8-DB-01-70-A4-DC-9E-D0-0D-90-4D-DD-3E-2A-4A-D1-B1-E8-DC-0F-DC-9B-E7')

--Asignacion rol Administrador a usuarios
DECLARE @userId int

SELECT @roleId = [ID_Rol] FROM [SQUELA].Rol WHERE [Nombre] = 'Administrativo'

SELECT @userId = [ID_Usuario] FROM [SQUELA].Usuario WHERE [Usuario] = 'Admin'
INSERT INTO [SQUELA].RolXUsuario([ID_Usuario], [ID_Rol]) VALUES (@userId,@roleId)

--Creacion horarios de turnos
INSERT INTO [SQUELA].Horario(Hora) VALUES ('7:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('7:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('8:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('8:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('9:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('9:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('10:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('10:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('11:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('11:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('12:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('12:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('13:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('13:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('14:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('14:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('15:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('15:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('16:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('16:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('17:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('17:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('18:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('18:30')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('19:00')
INSERT INTO [SQUELA].Horario(Hora) VALUES ('19:30')

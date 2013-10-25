--Creacion Funcionalidades
INSERT INTO [GESTIONAMESQLO].[Funcionalidad]([Nombre]) VALUES('ABM Roles')
INSERT INTO [GESTIONAMESQLO].[Funcionalidad]([Nombre]) VALUES('ABM Recorridos')
INSERT INTO [GESTIONAMESQLO].[Funcionalidad]([Nombre]) VALUES('ABM Micros')
INSERT INTO [GESTIONAMESQLO].[Funcionalidad]([Nombre]) VALUES('Generar Viaje')
INSERT INTO [GESTIONAMESQLO].[Funcionalidad]([Nombre]) VALUES('Registro Llegada')
INSERT INTO [GESTIONAMESQLO].[Funcionalidad]([Nombre]) VALUES('Comprar Pasaje')
INSERT INTO [GESTIONAMESQLO].[Funcionalidad]([Nombre]) VALUES('Cancelar Pasaje')
INSERT INTO [GESTIONAMESQLO].[Funcionalidad]([Nombre]) VALUES('Consultar Puntos')
INSERT INTO [GESTIONAMESQLO].[Funcionalidad]([Nombre]) VALUES('Canjear Puntos')
INSERT INTO [GESTIONAMESQLO].[Funcionalidad]([Nombre]) VALUES('Estadisticas')

--Creacion roles
INSERT INTO [GESTIONAMESQLO].Rol([Nombre]) VALUES('Administrador')
INSERT INTO [GESTIONAMESQLO].Rol([Nombre]) VALUES('Cliente')

--Asignacion de funcionalidades a los roles
DECLARE @funcId int
DECLARE @roleId int

SELECT @roleId = [ID_Rol] FROM [GESTIONAMESQLO].Rol WHERE [Nombre] = 'Administrador'

SELECT @funcId = [ID_Func] FROM [GESTIONAMESQLO].Funcionalidad WHERE [Nombre] = 'ABM Roles'
INSERT INTO [GESTIONAMESQLO].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)

SELECT @funcId = [ID_Func] FROM [GESTIONAMESQLO].Funcionalidad WHERE [Nombre] = 'ABM Recorridos'
INSERT INTO [GESTIONAMESQLO].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)

SELECT @funcId = [ID_Func] FROM [GESTIONAMESQLO].Funcionalidad WHERE [Nombre] = 'ABM Micros'
INSERT INTO [GESTIONAMESQLO].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)

SELECT @funcId = [ID_Func] FROM [GESTIONAMESQLO].Funcionalidad WHERE [Nombre] = 'Generar Viaje'
INSERT INTO [GESTIONAMESQLO].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)

SELECT @funcId = [ID_Func] FROM [GESTIONAMESQLO].Funcionalidad WHERE [Nombre] = 'Registro Llegada'
INSERT INTO [GESTIONAMESQLO].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)

SELECT @funcId = [ID_Func] FROM [GESTIONAMESQLO].Funcionalidad WHERE [Nombre] = 'Comprar Pasaje'
INSERT INTO [GESTIONAMESQLO].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)

SELECT @funcId = [ID_Func] FROM [GESTIONAMESQLO].Funcionalidad WHERE [Nombre] = 'Cancelar Pasaje'
INSERT INTO [GESTIONAMESQLO].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)

SELECT @funcId = [ID_Func] FROM [GESTIONAMESQLO].Funcionalidad WHERE [Nombre] = 'Estadisticas'
INSERT INTO [GESTIONAMESQLO].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)

SELECT @roleId = [ID_Rol] FROM [GESTIONAMESQLO].Rol WHERE [Nombre] = 'Cliente'

SELECT @funcId = [ID_Func] FROM [GESTIONAMESQLO].Funcionalidad WHERE [Nombre] = 'Comprar Pasaje'
INSERT INTO [GESTIONAMESQLO].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)

SELECT @funcId = [ID_Func] FROM [GESTIONAMESQLO].Funcionalidad WHERE [Nombre] = 'Consultar Puntos'
INSERT INTO [GESTIONAMESQLO].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)

SELECT @funcId = [ID_Func] FROM [GESTIONAMESQLO].Funcionalidad WHERE [Nombre] = 'Canjear Puntos'
INSERT INTO [GESTIONAMESQLO].RolXFuncionalidad([ID_Func], [ID_Rol]) VALUES (@funcId, @roleId)

--Creacion usuarios administradores
INSERT INTO [GESTIONAMESQLO].Usuario([Usuario], [Password])
VALUES ('Admin', 'E6-B8-70-50-BF-CB-81-43-FC-B8-DB-01-70-A4-DC-9E-D0-0D-90-4D-DD-3E-2A-4A-D1-B1-E8-DC-0F-DC-9B-E7')

INSERT INTO [GESTIONAMESQLO].Usuario([Usuario], [Password])
VALUES ('Javi', 'E6-B8-70-50-BF-CB-81-43-FC-B8-DB-01-70-A4-DC-9E-D0-0D-90-4D-DD-3E-2A-4A-D1-B1-E8-DC-0F-DC-9B-E7')

INSERT INTO [GESTIONAMESQLO].Usuario([Usuario], [Password])
VALUES ('Maxi', 'E6-B8-70-50-BF-CB-81-43-FC-B8-DB-01-70-A4-DC-9E-D0-0D-90-4D-DD-3E-2A-4A-D1-B1-E8-DC-0F-DC-9B-E7')

INSERT INTO [GESTIONAMESQLO].Usuario([Usuario], [Password])
VALUES ('Ivo', 'E6-B8-70-50-BF-CB-81-43-FC-B8-DB-01-70-A4-DC-9E-D0-0D-90-4D-DD-3E-2A-4A-D1-B1-E8-DC-0F-DC-9B-E7')

INSERT INTO [GESTIONAMESQLO].Usuario([Usuario], [Password])
VALUES ('Pato', 'E6-B8-70-50-BF-CB-81-43-FC-B8-DB-01-70-A4-DC-9E-D0-0D-90-4D-DD-3E-2A-4A-D1-B1-E8-DC-0F-DC-9B-E7')

INSERT INTO [GESTIONAMESQLO].Usuario([Usuario], [Password])
VALUES ('Profe', 'E6-B8-70-50-BF-CB-81-43-FC-B8-DB-01-70-A4-DC-9E-D0-0D-90-4D-DD-3E-2A-4A-D1-B1-E8-DC-0F-DC-9B-E7')

INSERT INTO [GESTIONAMESQLO].Usuario([Usuario], [Password])
VALUES ('Cliente','A6-0B-85-D4-09-A0-1D-46-02-3F-90-74-1E-01-B7-95-43-A3-CB-1B-A0-48-EA-EF-BE-5D-7A-63-63-80-43-BF')


--Asignacion rol Administrador a usuarios
DECLARE @userId int

SELECT @roleId = [ID_Rol] FROM [GESTIONAMESQLO].Rol WHERE [Nombre] = 'Administrador'

SELECT @userId = [ID_Usuario] FROM [GESTIONAMESQLO].Usuario WHERE [Usuario] = 'Admin'
INSERT INTO [GESTIONAMESQLO].RolXUsuario([ID_Usuario], [ID_Rol]) VALUES (@userId,@roleId)

SELECT @userId = [ID_Usuario] FROM [GESTIONAMESQLO].Usuario WHERE [Usuario] = 'Javi'
INSERT INTO [GESTIONAMESQLO].RolXUsuario([ID_Usuario], [ID_Rol]) VALUES (@userId,@roleId)

SELECT @userId = [ID_Usuario] FROM [GESTIONAMESQLO].Usuario WHERE [Usuario] = 'Maxi'
INSERT INTO [GESTIONAMESQLO].RolXUsuario([ID_Usuario], [ID_Rol]) VALUES (@userId,@roleId)

SELECT @userId = [ID_Usuario] FROM [GESTIONAMESQLO].Usuario WHERE [Usuario] = 'Ivo'
INSERT INTO [GESTIONAMESQLO].RolXUsuario([ID_Usuario], [ID_Rol]) VALUES (@userId,@roleId)

SELECT @userId = [ID_Usuario] FROM [GESTIONAMESQLO].Usuario WHERE [Usuario] = 'Pato'
INSERT INTO [GESTIONAMESQLO].RolXUsuario([ID_Usuario], [ID_Rol]) VALUES (@userId,@roleId)

SELECT @userId = [ID_Usuario] FROM [GESTIONAMESQLO].Usuario WHERE [Usuario] = 'Profe'
INSERT INTO [GESTIONAMESQLO].RolXUsuario([ID_Usuario], [ID_Rol]) VALUES (@userId,@roleId)

SELECT @roleId = [ID_Rol] FROM [GESTIONAMESQLO].Rol WHERE [Nombre] = 'Cliente'

SELECT @userId = [ID_Usuario] FROM [GESTIONAMESQLO].Usuario WHERE [Usuario] = 'Cliente'
INSERT INTO [GESTIONAMESQLO].RolXUsuario([ID_Usuario], [ID_Rol]) VALUES (@userId,@roleId)
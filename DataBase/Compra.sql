-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Compra
AS
BEGIN
DECLARE @Paciente_Dni numeric(18, 0)
	DECLARE @Compra_Bono_Fecha datetime
	DECLARE @Bono_Consulta_Numero numeric(18, 0)
	DECLARE @Bono_Farmacia_Numero numeric(18, 0)
	DECLARE @ID_Plan_Medico numeric(18, 0)
	DECLARE @ID_Compra numeric(18, 0)
	
	
	DECLARE cur CURSOR FOR 
		SELECT TOP 10000 [Paciente_Dni]
		, [Compra_Bono_Fecha]
		,[Bono_Consulta_Numero]
		,[Bono_Farmacia_Numero]
		,[Plan_Med_Codigo]
		FROM gd_esquema.Maestra
		WHERE [Compra_Bono_Fecha] IS NOT NULL
		ORDER BY [Compra_Bono_Fecha], [Paciente_Dni]
	OPEN cur
	FETCH cur INTO @Paciente_Dni, @Compra_Bono_Fecha, @Bono_Consulta_Numero, @Bono_Farmacia_Numero, @ID_Plan_Medico
	
	WHILE @@FETCH_STATUS = 0	
	BEGIN 
	SET @ID_Compra = NULL
		------------------------------------------------------------------------------------------------------------------------
		--Controlo que el ID_Compra haya sido dado de ALTA (para cualquie Bono):
		-------------------------------------------------------------------------------------------------------------------------
			SELECT @ID_Compra = [Compra].[ID_Compra] FROM [SQUELA].[BonoConsulta]
				JOIN [SQUELA].[Compra] ON [BonoConsulta].[ID_Compra] = [Compra].[ID_Compra]
				JOIN [SQUELA].Afiliado ON BonoConsulta.ID_Comprador = Afiliado.ID_Afiliado
				WHERE [Afiliado].[Numero] = @Paciente_Dni
				AND [Compra].[Fecha] = @Compra_Bono_Fecha
			
			IF @ID_Compra IS NULL
			BEGIN
				SELECT @ID_Compra = [Compra].[ID_Compra] FROM [SQUELA].[BonoFarmacia]
				JOIN [SQUELA].[Compra] ON [BonoFarmacia].[ID_Compra] = [Compra].[ID_Compra]
				JOIN [SQUELA].Afiliado ON BonoFarmacia.ID_Comprador = Afiliado.ID_Afiliado
				WHERE [Afiliado].[Numero] = @Paciente_Dni
				AND [Compra].[Fecha] = @Compra_Bono_Fecha
			END			
		-------------------------------------------------------------------------------------------------------------------------
		-------------------------------------------------------------------------------------------------------------------------
		-------------------------------------------------------------------------------------------------------------------------
		
		IF @ID_Compra IS NULL
		BEGIN			
		-------------------------------------------------------------------------------------------------------------------------
		-- Insertar Compra
		-------------------------------------------------------------------------------------------------------------------------
		
			INSERT INTO [SQUELA].[Compra] ([Fecha])
				VALUES (@Compra_Bono_Fecha)	
			
			SELECT @ID_Compra = SCOPE_IDENTITY()
		-------------------------------------------------------------------------------------------------------------------------
		-------------------------------------------------------------------------------------------------------------------------
		-------------------------------------------------------------------------------------------------------------------------
		END
				
				
		--								CONSULTA								--
		--------------------------------------------------------------------------------------------------------------------------------
		--Si es compra de Bono Consulta:
		--------------------------------------------------------------------------------------------------------------------------------
			IF @Bono_Consulta_Numero IS NOT NULL
			BEGIN	
				-- Insertar Bono
					SET IDENTITY_INSERT [SQUELA].[BonoConsulta] ON

					INSERT INTO [SQUELA].[BonoConsulta]
					(
						[ID_BonoConsulta],
						[ID_Compra],
						[ID_PlanMedico],
						[ID_Comprador]			
					)
					VALUES (@Bono_Consulta_Numero, @ID_Compra, @ID_Plan_Medico, @Paciente_Dni)
						
					SET IDENTITY_INSERT [SQUELA].[BonoConsulta] OFF	
			END			
		--------------------------------------------------------------------------------------------------------------------------------
		--------------------------------------------------------------------------------------------------------------------------------
		--------------------------------------------------------------------------------------------------------------------------------
		
		
		
		--								FARMACIA								--
		--------------------------------------------------------------------------------------------------------------------------------
		--Si es compra de Bono Farmacia:
		--------------------------------------------------------------------------------------------------------------------------------
			IF @Bono_Farmacia_Numero IS NOT NULL
			BEGIN	
				-- Insertar Bono
					SET IDENTITY_INSERT [SQUELA].[BonoFarmacia] ON

					INSERT INTO [SQUELA].[BonoFarmacia]
					(
						[ID_BonoFarmacia],
						[ID_Compra],
						[ID_PlanMedico],
						[ID_Comprador]			
					)
					VALUES (@Bono_Farmacia_Numero, @ID_Compra, @ID_Plan_Medico, @Paciente_Dni)
						
					SET IDENTITY_INSERT [SQUELA].[BonoFarmacia] OFF	
			END			
		--------------------------------------------------------------------------------------------------------------------------------
		--------------------------------------------------------------------------------------------------------------------------------
		--------------------------------------------------------------------------------------------------------------------------------
		
		FETCH cur INTO @Paciente_Dni, @Compra_Bono_Fecha, @Bono_Consulta_Numero, @Bono_Farmacia_Numero, @ID_Plan_Medico
	END
	CLOSE cur
END
GO
/*
   lunes, 13 de enero de 202013:53:49
   Usuario: sa
   Servidor: DESKTOP-SQU6PUC\SQLEXPRESS
   Base de datos: MakUpCoffe
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Vehiculo
	DROP CONSTRAINT DF_Vehiculo_Activo
GO
CREATE TABLE dbo.Tmp_Vehiculo
	(
	IdVehiculo int NOT NULL IDENTITY (1, 1),
	Placa varchar(20) NULL,
	Marca nvarchar(50) NULL,
	Modelo nvarchar(50) NULL,
	Color nvarchar(50) NULL,
	TipoVehiculo nvarchar(50) NOT NULL,
	Activo bit NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Vehiculo SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Tmp_Vehiculo ADD CONSTRAINT
	DF_Vehiculo_Activo DEFAULT ((1)) FOR Activo
GO
SET IDENTITY_INSERT dbo.Tmp_Vehiculo ON
GO
IF EXISTS(SELECT * FROM dbo.Vehiculo)
	 EXEC('INSERT INTO dbo.Tmp_Vehiculo (IdVehiculo, Placa, Marca, TipoVehiculo, Activo)
		SELECT IdVehiculo, Placa, Marca, TipoVehiculo, Activo FROM dbo.Vehiculo WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Vehiculo OFF
GO
DROP TABLE dbo.Vehiculo
GO
EXECUTE sp_rename N'dbo.Tmp_Vehiculo', N'Vehiculo', 'OBJECT' 
GO
ALTER TABLE dbo.Vehiculo ADD CONSTRAINT
	PK_Vehiculo_1 PRIMARY KEY CLUSTERED 
	(
	IdVehiculo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Vehiculo', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Vehiculo', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Vehiculo', 'Object', 'CONTROL') as Contr_Per 
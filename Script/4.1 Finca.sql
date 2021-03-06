/*
   lunes, 6 de enero de 202020:25:06
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
ALTER TABLE dbo.Finca
	DROP CONSTRAINT DF_Finca_FechaActualizacion
GO
CREATE TABLE dbo.Tmp_Finca
	(
	IdFinca int NOT NULL IDENTITY (1, 1),
	IdProductor int NULL,
	NomFinca varchar(50) NULL,
	IdComarca int NULL,
	Altitud varchar(50) NULL,
	[Notas de Cata] varchar(MAX) NULL,
	Emblaje float(53) NULL,
	FechaActualizacion datetime NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Finca SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Tmp_Finca ADD CONSTRAINT
	DF_Finca_FechaActualizacion DEFAULT (getdate()) FOR FechaActualizacion
GO
SET IDENTITY_INSERT dbo.Tmp_Finca ON
GO
IF EXISTS(SELECT * FROM dbo.Finca)
	 EXEC('INSERT INTO dbo.Tmp_Finca (IdFinca, IdProductor, NomFinca, IdComarca, Altitud, [Notas de Cata], Emblaje, FechaActualizacion)
		SELECT IdFinca, IdProductor, NomFinca, IdComarca, Altitud, [Notas de Cata], Emblaje, FechaActualizacion FROM dbo.Finca WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Finca OFF
GO
DROP TABLE dbo.Finca
GO
EXECUTE sp_rename N'dbo.Tmp_Finca', N'Finca', 'OBJECT' 
GO
ALTER TABLE dbo.Finca ADD CONSTRAINT
	PK_Finca_1 PRIMARY KEY CLUSTERED 
	(
	IdFinca
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Finca', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Finca', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Finca', 'Object', 'CONTROL') as Contr_Per 
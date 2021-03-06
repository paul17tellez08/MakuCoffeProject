/*
   jueves, 2 de enero de 202021:23:52
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
CREATE TABLE dbo.Tmp_Comarca
	(
	IdComarca int NOT NULL IDENTITY (1, 1),
	Comarca nvarchar(MAX) NOT NULL,
	IdMunicipio int NULL,
	Activo bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Comarca SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Comarca ON
GO
IF EXISTS(SELECT * FROM dbo.Comarca)
	 EXEC('INSERT INTO dbo.Tmp_Comarca (IdComarca, Comarca, IdMunicipio, Activo)
		SELECT IdComarca, Comarca, IdMunicipio, Activo FROM dbo.Comarca WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Comarca OFF
GO
DROP TABLE dbo.Comarca
GO
EXECUTE sp_rename N'dbo.Tmp_Comarca', N'Comarca', 'OBJECT' 
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Comarca', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Comarca', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Comarca', 'Object', 'CONTROL') as Contr_Per 
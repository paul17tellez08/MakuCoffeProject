/*
   martes, 14 de enero de 202009:32:24
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
CREATE TABLE dbo.Tmp_Conductor
	(
	Codigo int NOT NULL IDENTITY (1, 1),
	Nombre varchar(500) NULL,
	Cedula varchar(20) NULL,
	Licencia varchar(20) NULL,
	Activo bit NULL,
	ListaNegra bit NULL,
	RazonListaNegra varchar(2000) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Conductor SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Conductor ON
GO
IF EXISTS(SELECT * FROM dbo.Conductor)
	 EXEC('INSERT INTO dbo.Tmp_Conductor (Codigo, Nombre, Cedula, Licencia, Activo, ListaNegra, RazonListaNegra)
		SELECT CONVERT(int, Codigo), Nombre, Cedula, Licencia, Activo, ListaNegra, RazonListaNegra FROM dbo.Conductor WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Conductor OFF
GO
DROP TABLE dbo.Conductor
GO
EXECUTE sp_rename N'dbo.Tmp_Conductor', N'Conductor', 'OBJECT' 
GO
ALTER TABLE dbo.Conductor ADD CONSTRAINT
	PK_Conductor PRIMARY KEY CLUSTERED 
	(
	Codigo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Conductor', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Conductor', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Conductor', 'Object', 'CONTROL') as Contr_Per 
/*
   martes, 7 de enero de 202014:59:52
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
CREATE TABLE dbo.Variedad
	(
	IdVariedad int NOT NULL,
	Variedad nvarchar(150) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Variedad SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Variedad', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Variedad', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Variedad', 'Object', 'CONTROL') as Contr_Per 
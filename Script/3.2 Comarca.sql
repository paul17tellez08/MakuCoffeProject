/*
   martes, 28 de enero de 202009:23:25
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
ALTER TABLE dbo.Comarca ADD CONSTRAINT
	PK_Comarca PRIMARY KEY CLUSTERED 
	(
	IdComarca
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Comarca SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Comarca', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Comarca', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Comarca', 'Object', 'CONTROL') as Contr_Per 
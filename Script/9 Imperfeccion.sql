/*
   viernes, 10 de enero de 202015:16:00
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
CREATE TABLE dbo.Imperfeccion
	(
	IdImperfeccion int NOT NULL IDENTITY (1, 1),
	Imperfeccion nvarchar(50) NULL,
	activa bit NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Imperfeccion ADD CONSTRAINT
	DF_Imperfeccion_activa DEFAULT 1 FOR activa
GO
ALTER TABLE dbo.Imperfeccion SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Imperfeccion', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Imperfeccion', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Imperfeccion', 'Object', 'CONTROL') as Contr_Per 
/*
   martes, 7 de enero de 202011:13:51
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
EXECUTE sp_rename N'dbo.Finca.[Notas de Cata]', N'Tmp_NotasdeCata', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.Finca.Tmp_NotasdeCata', N'NotasdeCata', 'COLUMN' 
GO
ALTER TABLE dbo.Finca SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Finca', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Finca', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Finca', 'Object', 'CONTROL') as Contr_Per 
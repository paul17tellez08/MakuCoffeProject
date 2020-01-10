/*
   sábado, 08 de diciembre de 201802:06:56 p.m.
   Usuario: 
   Servidor: JUANBERMUDEZ\SQL2014
   Base de datos: TRANSPORTE
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
ALTER TABLE dbo.ReciboCafePergamino ADD
	IdTipoIngreso int NULL
GO
ALTER TABLE dbo.ReciboCafePergamino SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ReciboCafePergamino', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ReciboCafePergamino', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ReciboCafePergamino', 'Object', 'CONTROL') as Contr_Per 
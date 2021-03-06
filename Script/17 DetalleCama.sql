/*
   martes, 28 de enero de 202009:33:33
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
CREATE TABLE dbo.DetalleCama
	(
	IdDetalleCama int NOT NULL IDENTITY (1, 1),
	NumeroRecepcion nvarchar(50) NOT NULL,
	IdCama int NOT NULL,
	FechaHora datetime NULL,
	CodProveedor nvarchar(50) NULL,
	NumeroTraza nvarchar(MAX) NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.DetalleCama ADD CONSTRAINT
	PK_DetalleCama PRIMARY KEY CLUSTERED 
	(
	IdDetalleCama
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.DetalleCama SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetalleCama', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetalleCama', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetalleCama', 'Object', 'CONTROL') as Contr_Per 
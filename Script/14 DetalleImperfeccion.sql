/*
   martes, 14 de enero de 202014:45:07
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
CREATE TABLE dbo.DetalleImperfeccion
	(
	IdDetalleImperfeccion int NOT NULL IDENTITY (1, 1),
	NumeroRecepcion nvarchar(50) NULL,
	Imperfeccion nchar(10) NULL,
	Porcentaje nchar(10) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.DetalleImperfeccion ADD CONSTRAINT
	PK_DetalleImperfeccion PRIMARY KEY CLUSTERED 
	(
	IdDetalleImperfeccion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.DetalleImperfeccion SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetalleImperfeccion', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetalleImperfeccion', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetalleImperfeccion', 'Object', 'CONTROL') as Contr_Per 
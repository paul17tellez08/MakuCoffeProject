/*
   viernes, 31 de enero de 202015:37:34
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
CREATE TABLE dbo.Tmp_DetalleCama
	(
	IdDetalleCama int NOT NULL IDENTITY (1, 1),
	NumeroRecepcion nvarchar(50) NOT NULL,
	IdCama int NOT NULL,
	FechaHora datetime NOT NULL,
	CodProveedor nvarchar(50) NOT NULL,
	NumeroTraza nvarchar(MAX) NOT NULL,
	Nivel nvarchar(50) NOT NULL,
	PesoEnviado float(53) NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_DetalleCama SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_DetalleCama ON
GO
IF EXISTS(SELECT * FROM dbo.DetalleCama)
	 EXEC('INSERT INTO dbo.Tmp_DetalleCama (IdDetalleCama, NumeroRecepcion, IdCama, FechaHora, CodProveedor, NumeroTraza, Nivel, PesoEnviado)
		SELECT IdDetalleCama, NumeroRecepcion, IdCama, FechaHora, CodProveedor, NumeroTraza, CONVERT(nvarchar(50), Nivel), PesoEnviado FROM dbo.DetalleCama WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_DetalleCama OFF
GO
DROP TABLE dbo.DetalleCama
GO
EXECUTE sp_rename N'dbo.Tmp_DetalleCama', N'DetalleCama', 'OBJECT' 
GO
ALTER TABLE dbo.DetalleCama ADD CONSTRAINT
	PK_DetalleCama PRIMARY KEY CLUSTERED 
	(
	IdDetalleCama
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.DetalleCama', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DetalleCama', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DetalleCama', 'Object', 'CONTROL') as Contr_Per 
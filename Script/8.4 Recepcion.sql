/*
   jueves, 16 de enero de 202017:00:09
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
ALTER TABLE dbo.Recepcion
	DROP CONSTRAINT DF_Recepcion_Cancelar
GO
ALTER TABLE dbo.Recepcion
	DROP CONSTRAINT DF_Recepcion_Contabilizado
GO
ALTER TABLE dbo.Recepcion
	DROP CONSTRAINT DF_Recepcion_Seleccion
GO
ALTER TABLE dbo.Recepcion
	DROP CONSTRAINT DF_Recepcion_Activo
GO
CREATE TABLE dbo.Tmp_Recepcion
	(
	NumeroRecepcion nvarchar(50) NOT NULL,
	TipoRecepcion nvarchar(50) NOT NULL,
	Fecha date NULL,
	Cod_Proveedor nvarchar(50) NULL,
	Cod_SubProveedor nvarchar(50) NULL,
	Conductor nvarchar(50) NULL,
	Id_identificacion nvarchar(50) NULL,
	Id_Placa nvarchar(50) NULL,
	Cod_Bodega nvarchar(50) NULL,
	Observaciones nvarchar(MAX) NULL,
	SubTotal float(53) NULL,
	Telefono nvarchar(50) NULL,
	Cancelar bit NULL,
	Peso float(53) NULL,
	Lote nvarchar(50) NULL,
	Contabilizado bit NULL,
	FechaHora datetime NULL,
	RecibimosDe nvarchar(200) NULL,
	IdFinca int NULL,
	Calidad nvarchar(50) NULL,
	Fermentado bit NULL,
	Moho bit NULL,
	Estado nvarchar(50) NULL,
	Idvariedad int NULL,
	IdPlantillo int NULL,
	TipoPesada nvarchar(51) NULL,
	Seleccion bit NULL,
	Activo bit NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Recepcion SET (LOCK_ESCALATION = TABLE)
GO
ALTER TABLE dbo.Tmp_Recepcion ADD CONSTRAINT
	DF_Recepcion_Cancelar DEFAULT ((0)) FOR Cancelar
GO
ALTER TABLE dbo.Tmp_Recepcion ADD CONSTRAINT
	DF_Recepcion_Contabilizado DEFAULT ((0)) FOR Contabilizado
GO
ALTER TABLE dbo.Tmp_Recepcion ADD CONSTRAINT
	DF_Recepcion_Seleccion DEFAULT ((0)) FOR Seleccion
GO
ALTER TABLE dbo.Tmp_Recepcion ADD CONSTRAINT
	DF_Recepcion_Activo DEFAULT ((1)) FOR Activo
GO
IF EXISTS(SELECT * FROM dbo.Recepcion)
	 EXEC('INSERT INTO dbo.Tmp_Recepcion (NumeroRecepcion, TipoRecepcion, Fecha, Cod_Proveedor, Cod_SubProveedor, Conductor, Id_identificacion, Id_Placa, Cod_Bodega, Observaciones, SubTotal, Telefono, Cancelar, Peso, Lote, Contabilizado, FechaHora, RecibimosDe, IdFinca, Calidad, Fermentado, Moho, Estado, Idvariedad, IdPlantillo, TipoPesada, Seleccion, Activo)
		SELECT NumeroRecepcion, TipoRecepcion, Fecha, Cod_Proveedor, Cod_SubProveedor, Conductor, Id_identificacion, Id_Placa, Cod_Bodega, Observaciones, SubTotal, Telefono, Cancelar, Peso, Lote, Contabilizado, FechaHora, RecibimosDe, IdFinca, Calidad, Fermentado, Moho, Estado, Idvariedad, IdPlantillo, TipoPesada, Seleccion, Activo FROM dbo.Recepcion WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.Recepcion
GO
EXECUTE sp_rename N'dbo.Tmp_Recepcion', N'Recepcion', 'OBJECT' 
GO
ALTER TABLE dbo.Recepcion ADD CONSTRAINT
	PK_Recepcion PRIMARY KEY CLUSTERED 
	(
	NumeroRecepcion,
	TipoRecepcion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.Recepcion', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Recepcion', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Recepcion', 'Object', 'CONTROL') as Contr_Per 
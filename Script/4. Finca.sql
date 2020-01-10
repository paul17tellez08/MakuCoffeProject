use MakUpCoffe
CREATE TABLE [dbo].[Finca](
	[IdFinca] [int] NOT NULL,
	[IdProductor] [int] NULL,
	[NomFinca] [varchar](50) NULL,
	[IdComarca] [int] NULL,
	[Altitud] [varchar](50) NULL,
	[Notas de Cata] [varchar](Max) NULL,
	[Emblaje] [float]NULL,
	[FechaActualizacion] [datetime] NOT NULL CONSTRAINT [DF_Finca_FechaActualizacion]  DEFAULT (getdate()),
 CONSTRAINT [PK_Finca_1] PRIMARY KEY CLUSTERED 
(
	[IdFinca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
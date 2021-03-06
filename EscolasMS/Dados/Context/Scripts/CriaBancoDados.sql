USE [master]
GO
/****** Object:  Database [BDEscolaMS]    Script Date: 31/05/2021 08:14:20 ******/
CREATE DATABASE [BDEscolaMS] 
GO

USE [BDEscolaMS]
GO

/****** Object:  Table [dbo].[ALUNOS]    Script Date: 31/05/2021 08:14:20 ******/
CREATE TABLE [dbo].[ALUNOS](
	[AlunoId] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NULL,
	[DataNascimento] [datetime2](7) NOT NULL,
	[NumeroCertidaoNova] [varchar](50) NULL,
	[CPF] [varchar](11) NULL,
	[ResponsavelId] [int] NULL,
 CONSTRAINT [PK_Alunos] PRIMARY KEY CLUSTERED 
(
	[AlunoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[RESPONSAVEL]    Script Date: 31/05/2021 08:14:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RESPONSAVEL](
	[ResponsavelId] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NULL,
	[DataNascimento] [datetime2](7) NOT NULL,
	[CPF] [varchar](11) NULL,
 CONSTRAINT [PK_Responsavel] PRIMARY KEY CLUSTERED 
(
	[ResponsavelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Index [IX_ALUNOS_ResponsavelId]    Script Date: 31/05/2021 08:14:20 ******/
CREATE NONCLUSTERED INDEX [IX_ALUNOS_ResponsavelId] ON [dbo].[ALUNOS]
(
	[ResponsavelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ALUNOS]  WITH CHECK ADD  CONSTRAINT [FK_ALUNOS_RESPONSAVEL_ResponsavelId] FOREIGN KEY([ResponsavelId])
REFERENCES [dbo].[RESPONSAVEL] ([ResponsavelId])
GO
ALTER TABLE [dbo].[ALUNOS] CHECK CONSTRAINT [FK_ALUNOS_RESPONSAVEL_ResponsavelId]
GO

USE [master]
GO

ALTER DATABASE [BDEscolaMS] SET  READ_WRITE 
GO

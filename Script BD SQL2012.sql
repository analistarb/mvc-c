USE [BDSQL2012]
GO
/****** Object:  Table [dbo].[Aluno]    Script Date: 04/02/2016 21:24:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aluno](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](75) NULL,
	[Mae] [varchar](75) NULL,
	[DataNascimento] [date] NULL,
	[nr_cpf] [varchar](15) NULL,
	[ci_sexo] [int] NULL,
	[ci_Cadeirante] [int] NULL,
	[ci_Fala] [int] NULL,
	[p172] [varchar](255) NULL,
	[p15] [varchar](255) NULL,
	[nr_idade] [int] NULL,
	[nm_email] [varchar](255) NULL,
	[nr_dinheiro] [decimal](18, 2) NULL,
	[dc_obs] [varchar](255) NULL,
	[nm_usuario] [varchar](50) NULL,
	[nm_senha] [varchar](50) NULL,
	[ci_raca] [int] NULL,
 CONSTRAINT [PK_Aluno] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Raca]    Script Date: 04/02/2016 21:24:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Raca](
	[ci_raca] [int] IDENTITY(1,1) NOT NULL,
	[dc_raca] [varchar](30) NULL,
 CONSTRAINT [PK_raca] PRIMARY KEY CLUSTERED 
(
	[ci_raca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 04/02/2016 21:24:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sexo](
	[ci_sexo] [int] IDENTITY(1,1) NOT NULL,
	[dc_sexo] [varchar](30) NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[ci_sexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Aluno] ON 

INSERT [dbo].[Aluno] ([ID], [Nome], [Mae], [DataNascimento], [nr_cpf], [ci_sexo], [ci_Cadeirante], [ci_Fala], [p172], [p15], [nr_idade], [nm_email], [nr_dinheiro], [dc_obs], [nm_usuario], [nm_senha], [ci_raca]) VALUES (1, N'MARIA ESTEFANIA DE CASTRO', N'ANDREIA CRISTINA DOS SANTOS', CAST(N'1970-07-28' AS Date), N'72776682514', 1, 1, 2, N'2', N'2', 18, N'a@a.com.br', CAST(3.99 AS Decimal(18, 2)), N'sadsad1121127311222', N'sadsad', N'1', NULL)
INSERT [dbo].[Aluno] ([ID], [Nome], [Mae], [DataNascimento], [nr_cpf], [ci_sexo], [ci_Cadeirante], [ci_Fala], [p172], [p15], [nr_idade], [nm_email], [nr_dinheiro], [dc_obs], [nm_usuario], [nm_senha], [ci_raca]) VALUES (2, N'CARLOS ROSA DOS SANTOS', N'ISAURA DOS SANTOS RAMOS', CAST(N'2001-07-22' AS Date), N'32197345532', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Aluno] ([ID], [Nome], [Mae], [DataNascimento], [nr_cpf], [ci_sexo], [ci_Cadeirante], [ci_Fala], [p172], [p15], [nr_idade], [nm_email], [nr_dinheiro], [dc_obs], [nm_usuario], [nm_senha], [ci_raca]) VALUES (3, N'ANDREIA CRISTINA NERIS', N'MARIA ESTEFANIA', CAST(N'2003-08-04' AS Date), N'45288821402', 0, 2, 2, N'', N'', 0, N'', CAST(3.99 AS Decimal(18, 2)), N'', N'fdgdfg', N'1', NULL)
INSERT [dbo].[Aluno] ([ID], [Nome], [Mae], [DataNascimento], [nr_cpf], [ci_sexo], [ci_Cadeirante], [ci_Fala], [p172], [p15], [nr_idade], [nm_email], [nr_dinheiro], [dc_obs], [nm_usuario], [nm_senha], [ci_raca]) VALUES (4, N'CARLOS ROSA DOS SANTOS', N'CLARICE MARIA DOS SANTOS', CAST(N'1976-02-27' AS Date), N'05082161253', 2, 1, 1, N'1', N'123', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Aluno] ([ID], [Nome], [Mae], [DataNascimento], [nr_cpf], [ci_sexo], [ci_Cadeirante], [ci_Fala], [p172], [p15], [nr_idade], [nm_email], [nr_dinheiro], [dc_obs], [nm_usuario], [nm_senha], [ci_raca]) VALUES (5, N'ROBERT NERIS DOS SANTOS', N'ANDREIA CRISTINA NERIS', CAST(N'1991-11-16' AS Date), N'48414381065', 2, 1, 1, N'1', N'a@a.com.br', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Aluno] ([ID], [Nome], [Mae], [DataNascimento], [nr_cpf], [ci_sexo], [ci_Cadeirante], [ci_Fala], [p172], [p15], [nr_idade], [nm_email], [nr_dinheiro], [dc_obs], [nm_usuario], [nm_senha], [ci_raca]) VALUES (6, N'ELIANA DOS SANTOS', N'NARCISA DE JESUS CAMPOS', CAST(N'1970-05-25' AS Date), N'51552693007', 2, 1, 1, N'1', N'a@a.com.br', 18, N'', CAST(0.00 AS Decimal(18, 2)), N'', N'asdasd', N'1', NULL)
SET IDENTITY_INSERT [dbo].[Aluno] OFF
SET IDENTITY_INSERT [dbo].[Raca] ON 

INSERT [dbo].[Raca] ([ci_raca], [dc_raca]) VALUES (1, N'Branca')
INSERT [dbo].[Raca] ([ci_raca], [dc_raca]) VALUES (2, N'Negra')
INSERT [dbo].[Raca] ([ci_raca], [dc_raca]) VALUES (3, N'Parda')
INSERT [dbo].[Raca] ([ci_raca], [dc_raca]) VALUES (4, N'Amarela')
INSERT [dbo].[Raca] ([ci_raca], [dc_raca]) VALUES (5, N'Indígena')
SET IDENTITY_INSERT [dbo].[Raca] OFF
SET IDENTITY_INSERT [dbo].[Sexo] ON 

INSERT [dbo].[Sexo] ([ci_sexo], [dc_sexo]) VALUES (1, N'Masculino')
INSERT [dbo].[Sexo] ([ci_sexo], [dc_sexo]) VALUES (2, N'Feminino')
SET IDENTITY_INSERT [dbo].[Sexo] OFF
ALTER TABLE [dbo].[Aluno]  WITH NOCHECK ADD  CONSTRAINT [FK_Aluno_Raca] FOREIGN KEY([ci_raca])
REFERENCES [dbo].[Raca] ([ci_raca])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Aluno] NOCHECK CONSTRAINT [FK_Aluno_Raca]
GO
ALTER TABLE [dbo].[Aluno]  WITH NOCHECK ADD  CONSTRAINT [FK_Aluno_Sexo] FOREIGN KEY([ci_sexo])
REFERENCES [dbo].[Sexo] ([ci_sexo])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Aluno] NOCHECK CONSTRAINT [FK_Aluno_Sexo]
GO

USE [control]
GO
/****** Object:  Table [dbo].[alumnos]    Script Date: 08/06/2020 03:13:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[alumnos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[num_ctrl] [varchar](50) NOT NULL CONSTRAINT [DF_alumnos_num_ctrl]  DEFAULT (''),
	[nombre] [varchar](250) NOT NULL CONSTRAINT [DF_alumnos_nombre]  DEFAULT (''),
	[Carrera] [varchar](250) NOT NULL CONSTRAINT [DF_alumnos_Carrera]  DEFAULT (''),
	[fecha_nac] [date] NULL,
	[num_tel] [varchar](50) NOT NULL CONSTRAINT [DF_alumnos_num_tel]  DEFAULT (''),
	[email] [varchar](50) NOT NULL CONSTRAINT [DF_alumnos_email]  DEFAULT (''),
 CONSTRAINT [PK_alumnos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[registro_ent]    Script Date: 08/06/2020 03:13:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[registro_ent](
	[id_reg] [int] IDENTITY(1,1) NOT NULL,
	[num_ctrl] [varchar](50) NOT NULL CONSTRAINT [DF_registro_ent_num_ctrl]  DEFAULT (''),
	[nombre] [varchar](250) NOT NULL CONSTRAINT [DF_registro_ent_nombre]  DEFAULT (''),
	[fecha_reg] [datetime] NULL,
	[fecha_sal] [datetime] NULL,
	[Carrera] [varchar](250) NOT NULL CONSTRAINT [DF_registro_ent_Carrera]  DEFAULT (''),
 CONSTRAINT [PK_registro_ent] PRIMARY KEY CLUSTERED 
(
	[id_reg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

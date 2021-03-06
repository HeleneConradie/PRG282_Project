USE [dbdDataSmart]
GO
/****** Object:  Table [dbo].[ModuleInformation]    Script Date: 2021/10/13 20:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModuleInformation](
	[ModuleCode] [varchar](6) NOT NULL,
	[ModuleName] [varchar](30) NOT NULL,
	[ModuleDescription] [varchar](150) NOT NULL,
	[OnlineResources] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ModuleInformation] PRIMARY KEY CLUSTERED 
(
	[ModuleCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentInformation]    Script Date: 2021/10/13 20:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentInformation](
	[StudentNumber] [varchar](7) NOT NULL,
	[StudentFirstName] [varchar](50) NOT NULL,
	[StudentMiddleName] [varchar](50) NULL,
	[StudentLastName] [varchar](50) NOT NULL,
	[StudentImage] [varbinary](max) NOT NULL,
	[StudentDateOfBirth] [varchar](10) NOT NULL,
	[StudentGender] [varchar](6) NOT NULL,
	[StudentPhone] [varchar](10) NOT NULL,
	[StudentAddress] [varchar](50) NOT NULL,
 CONSTRAINT [PK_StudentInformation] PRIMARY KEY CLUSTERED 
(
	[StudentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentModule]    Script Date: 2021/10/13 20:05:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentModule](
	[StudentNumber] [varchar](7) NOT NULL,
	[ModuleCode] [varchar](6) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[StudentModule]  WITH CHECK ADD  CONSTRAINT [FK_StudentModule_ModuleInformation] FOREIGN KEY([ModuleCode])
REFERENCES [dbo].[ModuleInformation] ([ModuleCode])
GO
ALTER TABLE [dbo].[StudentModule] CHECK CONSTRAINT [FK_StudentModule_ModuleInformation]
GO
ALTER TABLE [dbo].[StudentModule]  WITH CHECK ADD  CONSTRAINT [FK_StudentModule_StudentInformation] FOREIGN KEY([StudentNumber])
REFERENCES [dbo].[StudentInformation] ([StudentNumber])
GO
ALTER TABLE [dbo].[StudentModule] CHECK CONSTRAINT [FK_StudentModule_StudentInformation]
GO

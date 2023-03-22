USE [Library]
GO
/****** Object:  Table [dbo].[AccountingBook]    Script Date: 22.03.2023 21:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountingBook](
	[AccountingBook] [int] NOT NULL,
	[idBook] [int] NULL,
	[idUser] [int] NOT NULL,
	[NumberBook] [int] NOT NULL,
	[NumberBookGiven] [int] NOT NULL,
 CONSTRAINT [PK_AccountingBook] PRIMARY KEY CLUSTERED 
(
	[AccountingBook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 22.03.2023 21:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[idAuthor] [int] NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[YearBirth] [date] NOT NULL,
	[YearDeath] [date] NULL,
 CONSTRAINT [PK_Autor] PRIMARY KEY CLUSTERED 
(
	[idAuthor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 22.03.2023 21:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[idBook] [int] NOT NULL,
	[NameBook] [nvarchar](50) NOT NULL,
	[idGenre] [int] NOT NULL,
	[idAuthor] [int] NOT NULL,
	[PublishingHouse] [nvarchar](50) NOT NULL,
	[PlacePublication] [nvarchar](50) NOT NULL,
	[YearPublication] [nvarchar](50) NOT NULL,
	[NumberPages] [int] NOT NULL,
	[ISBN] [int] NOT NULL,
	[BBK] [int] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[idBook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 22.03.2023 21:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[idGenre] [int] NOT NULL,
	[NameGenre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED 
(
	[idGenre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NumberBookGiven]    Script Date: 22.03.2023 21:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NumberBookGiven](
	[IdBookGiven] [int] NOT NULL,
	[AccountingBook] [int] NOT NULL,
	[idUser] [int] NOT NULL,
 CONSTRAINT [PK_NumberBookGiven] PRIMARY KEY CLUSTERED 
(
	[IdBookGiven] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 22.03.2023 21:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[idUser] [int] NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[idViewUser] [int] NOT NULL,
	[YearBirth] [date] NOT NULL,
	[ResidentialAddress] [nvarchar](50) NOT NULL,
	[PlaceWork] [nvarchar](50) NOT NULL,
	[NumbrePhone] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViewUser]    Script Date: 22.03.2023 21:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViewUser](
	[idViewUser] [int] NOT NULL,
	[NameViewUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ViewUser] PRIMARY KEY CLUSTERED 
(
	[idViewUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ViewUser] ([idViewUser], [NameViewUser]) VALUES (1, N'Читатель')
INSERT [dbo].[ViewUser] ([idViewUser], [NameViewUser]) VALUES (2, N'Библиотекарь')
INSERT [dbo].[ViewUser] ([idViewUser], [NameViewUser]) VALUES (3, N'Администратор')
GO
ALTER TABLE [dbo].[AccountingBook]  WITH CHECK ADD  CONSTRAINT [FK_AccountingBook_Book] FOREIGN KEY([idBook])
REFERENCES [dbo].[Book] ([idBook])
GO
ALTER TABLE [dbo].[AccountingBook] CHECK CONSTRAINT [FK_AccountingBook_Book]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author] FOREIGN KEY([idAuthor])
REFERENCES [dbo].[Author] ([idAuthor])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Author]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Genre] FOREIGN KEY([idGenre])
REFERENCES [dbo].[Genre] ([idGenre])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Genre]
GO
ALTER TABLE [dbo].[NumberBookGiven]  WITH CHECK ADD  CONSTRAINT [FK_NumberBookGiven_AccountingBook] FOREIGN KEY([AccountingBook])
REFERENCES [dbo].[AccountingBook] ([AccountingBook])
GO
ALTER TABLE [dbo].[NumberBookGiven] CHECK CONSTRAINT [FK_NumberBookGiven_AccountingBook]
GO
ALTER TABLE [dbo].[NumberBookGiven]  WITH CHECK ADD  CONSTRAINT [FK_NumberBookGiven_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[NumberBookGiven] CHECK CONSTRAINT [FK_NumberBookGiven_User]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_ViewUser] FOREIGN KEY([idViewUser])
REFERENCES [dbo].[ViewUser] ([idViewUser])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_ViewUser]
GO

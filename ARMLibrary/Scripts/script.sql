USE [Library]
GO
/****** Object:  Table [dbo].[AccountingBook]    Script Date: 29.03.2023 15:13:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountingBook](
	[AccountingBook] [int] NOT NULL,
	[idBook] [int] NOT NULL,
	[NumberBook] [int] NOT NULL,
	[NumberBookGiven] [int] NOT NULL,
 CONSTRAINT [PK_AccountingBook] PRIMARY KEY CLUSTERED 
(
	[AccountingBook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 29.03.2023 15:13:18 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 29.03.2023 15:13:18 ******/
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
	[ISBN] [varchar](50) NOT NULL,
	[BBK] [varchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[idBook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 29.03.2023 15:13:19 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NumberBookGiven]    Script Date: 29.03.2023 15:13:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NumberBookGiven](
	[IdBookGiven] [int] NOT NULL,
	[AccountingBook] [int] NOT NULL,
	[idUser] [int] NOT NULL,
	[DateIssue] [date] NOT NULL,
	[ReturnDate] [date] NOT NULL,
 CONSTRAINT [PK_NumberBookGiven] PRIMARY KEY CLUSTERED 
(
	[IdBookGiven] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TemporaryUsers]    Script Date: 29.03.2023 15:13:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TemporaryUsers](
	[idTemporaryUser] [int] NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TemporaryUsers] PRIMARY KEY CLUSTERED 
(
	[idTemporaryUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 29.03.2023 15:13:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[idUser] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[idViewUser] [int] NOT NULL,
	[YearBirth] [date] NOT NULL,
	[ResidentialAddress] [nvarchar](50) NOT NULL,
	[PlaceWork] [nvarchar](50) NOT NULL,
	[NumbrePhone] [varchar](20) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViewUser]    Script Date: 29.03.2023 15:13:19 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (1, 1, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (2, 2, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (3, 3, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (4, 4, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (5, 5, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (6, 6, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (7, 7, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (8, 8, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (9, 9, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (10, 10, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (11, 11, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (12, 12, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (13, 13, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (14, 14, 10, 0)
INSERT [dbo].[AccountingBook] ([AccountingBook], [idBook], [NumberBook], [NumberBookGiven]) VALUES (15, 15, 10, 0)
INSERT [dbo].[Author] ([idAuthor], [LastName], [FirstName], [Patronymic], [YearBirth], [YearDeath]) VALUES (1, N'Терри', N'Россио', N'Россио', CAST(N'2004-01-01' AS Date), NULL)
INSERT [dbo].[Author] ([idAuthor], [LastName], [FirstName], [Patronymic], [YearBirth], [YearDeath]) VALUES (2, N'Терри', N'Россио', N'Россио', CAST(N'2004-01-01' AS Date), NULL)
INSERT [dbo].[Author] ([idAuthor], [LastName], [FirstName], [Patronymic], [YearBirth], [YearDeath]) VALUES (3, N'Терри', N'Россио', N'Россио', CAST(N'2004-11-01' AS Date), NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (1, N'Пираты карибского моря', 1, 2, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-10', 50, N'1000000000000', N'26.31c+26.342a', N'Жизнь харизматичного авантюриста, капитана Джека Воробья, полная увлекательных приключений, резко меняется, когда его заклятый враг — капитан Барбосса — похищает корабль Джека, Черную Жемчужину, а затем нападает на Порт Ройал и крадет прекрасную дочь губернатора, Элизабет Свонн.')
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (2, N'Гари Потер', 2, 3, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-01', 60, N'2111111111111', N'26.31c+26.342b', N'«Harry Potter» — серия романов, написанная британской писательницей Дж. К. Роулинг. Книги представляют собой хронику приключений юного волшебника Гарри Поттера, а также его друзей Рона Уизли и Гермионы Грейнджер, обучающихся в школе чародейства и волшебства Хогвартс.')
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (3, N'Пираты карибского моря', 3, 1, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-10', 50, N'3111111111111', N'26.31c+26.342c', NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (4, N'Алиса в стране чудес', 1, 2, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-01', 60, N'4111111111111', N'26.31c+26.342d', N'В ней рассказывается о девочке по имени Алиса, которая попадает сквозь кроличью нору в воображаемый мир, населённый странными антропоморфными существами. Сказка пользуется устойчивой популярностью как у детей, так и у взрослых.')
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (5, N'Пираты карибского моря', 2, 3, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-10', 50, N'5111111111111', N'26.31c+26.342e', NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (6, N'Пираты карибского моря', 3, 1, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-01', 60, N'6111111111111', N'26.31c+26.342f', NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (7, N'Пираты карибского моря', 1, 2, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-10', 50, N'7111111111111', N'26.31c+26.342g', NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (8, N'Пираты карибского моря', 2, 3, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-01', 60, N'8111111111111', N'26.31c+26.342h', NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (9, N'Пираты карибского моря', 3, 1, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-10', 50, N'9111111111111', N'26.31c+26.342y', NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (10, N'Пираты карибского моря', 1, 2, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-01', 60, N'1011111111111', N'26.31c+26.342q', NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (11, N'Пираты карибского моря', 2, 3, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-10', 50, N'1111111111111', N'26.31c+26.342w', NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (12, N'Пираты карибского моря', 3, 1, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-01', 60, N'1211111111111', N'26.31c+26.342t', NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (13, N'Пираты карибского моря', 1, 2, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-10', 50, N'1311111111111', N'26.31c+26.342u', NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (14, N'Пираты карибского моря', 2, 3, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-01', 60, N'1411111111111', N'26.31c+26.342i', NULL)
INSERT [dbo].[Book] ([idBook], [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description]) VALUES (15, N'Пираты карибского моря', 3, 1, N'Эгмонт Россия Лтд', N'г.Кант', N'2001-01-10', 50, N'1511111111111', N'26.31c+26.342o', NULL)
INSERT [dbo].[Genre] ([idGenre], [NameGenre]) VALUES (0, N'Все типы')
INSERT [dbo].[Genre] ([idGenre], [NameGenre]) VALUES (1, N'Любовь')
INSERT [dbo].[Genre] ([idGenre], [NameGenre]) VALUES (2, N'Сёнен')
INSERT [dbo].[Genre] ([idGenre], [NameGenre]) VALUES (3, N'Фентези')
INSERT [dbo].[NumberBookGiven] ([IdBookGiven], [AccountingBook], [idUser], [DateIssue], [ReturnDate]) VALUES (1, 1, 1, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-31' AS Date))
INSERT [dbo].[NumberBookGiven] ([IdBookGiven], [AccountingBook], [idUser], [DateIssue], [ReturnDate]) VALUES (2, 2, 2, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-31' AS Date))
INSERT [dbo].[NumberBookGiven] ([IdBookGiven], [AccountingBook], [idUser], [DateIssue], [ReturnDate]) VALUES (3, 3, 3, CAST(N'2023-03-21' AS Date), CAST(N'2023-06-01' AS Date))
INSERT [dbo].[User] ([idUser], [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES (1, N'1', N'1', N'Шмидт', N'Максим', N'Лео', 1, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ([idUser], [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES (2, N'2', N'2', N'Шмидт', N'Максим', N'Лео', 2, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663375')
INSERT [dbo].[User] ([idUser], [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES (3, N'3', N'3', N'Шмидт', N'Максим', N'Лео', 2, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[ViewUser] ([idViewUser], [NameViewUser]) VALUES (1, N'Читатель')
INSERT [dbo].[ViewUser] ([idViewUser], [NameViewUser]) VALUES (2, N'Библиотекарь')
INSERT [dbo].[ViewUser] ([idViewUser], [NameViewUser]) VALUES (3, N'Администратор')
INSERT [dbo].[ViewUser] ([idViewUser], [NameViewUser]) VALUES (4, N'Временный пользователь')
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

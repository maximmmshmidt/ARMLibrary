USE [Library]
GO
/****** Object:  Table [dbo].[AccountingBook]    Script Date: 04.05.2023 20:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountingBook](
	[AccountingBook] [int] IDENTITY(1,1) NOT NULL,
	[idBook] [int] NOT NULL,
	[NumberBook] [int] NOT NULL,
	[NumberBookGiven] [int] NOT NULL,
 CONSTRAINT [PK_AccountingBook] PRIMARY KEY CLUSTERED 
(
	[AccountingBook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 04.05.2023 20:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[idAuthor] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Book]    Script Date: 04.05.2023 20:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[idBook] [int] IDENTITY(1,1) NOT NULL,
	[NameBook] [nvarchar](50) NOT NULL,
	[idGenre] [int] NOT NULL,
	[idAuthor] [int] NOT NULL,
	[PublishingHouse] [nvarchar](50) NOT NULL,
	[PlacePublication] [nvarchar](50) NOT NULL,
	[YearPublication] [date] NOT NULL,
	[NumberPages] [int] NOT NULL,
	[ISBN] [varchar](50) NOT NULL,
	[BBK] [varchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ImageBook] [image] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[idBook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 04.05.2023 20:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[idGenre] [int] IDENTITY(1,1) NOT NULL,
	[NameGenre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED 
(
	[idGenre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NumberBookGiven]    Script Date: 04.05.2023 20:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NumberBookGiven](
	[IdBookGiven] [int] IDENTITY(1,1) NOT NULL,
	[AccountingBook] [int] NOT NULL,
	[idUser] [int] NOT NULL,
	[DateIssue] [date] NOT NULL,
	[ReturnDate] [date] NULL,
	[ReturnedBook] [bit] NULL,
	[BuyBook] [bit] NULL,
 CONSTRAINT [PK_NumberBookGiven] PRIMARY KEY CLUSTERED 
(
	[IdBookGiven] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TemporaryUsers]    Script Date: 04.05.2023 20:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TemporaryUsers](
	[idTemporaryUser] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TemporaryUsers] PRIMARY KEY CLUSTERED 
(
	[idTemporaryUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 04.05.2023 20:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViewUser]    Script Date: 04.05.2023 20:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViewUser](
	[idViewUser] [int] IDENTITY(1,1) NOT NULL,
	[NameViewUser] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ViewUser] PRIMARY KEY CLUSTERED 
(
	[idViewUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 1, 7, 3)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 2, 9, 1)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 3, 9, 1)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 4, 9, 1)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 5, 9, 1)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 6, 9, 1)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 7, 10, 0)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 8, 10, 0)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 9, 10, 0)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 10, 10, 0)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 11, 10, 0)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 12, 10, 0)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 13, 10, 0)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 14, 10, 0)
INSERT [dbo].[AccountingBook] ( [idBook], [NumberBook], [NumberBookGiven]) VALUES ( 15, 10, 0)
GO
INSERT [dbo].[Author] ( [LastName], [FirstName], [Patronymic], [YearBirth], [YearDeath]) VALUES ( N'Терри', N'Россио', N'Россио', CAST(N'2004-01-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[Author] ( [LastName], [FirstName], [Patronymic], [YearBirth], [YearDeath]) VALUES ( N'Терри', N'Россио', N'Россио', CAST(N'2004-01-01' AS Date), NULL)
INSERT [dbo].[Author] ( [LastName], [FirstName], [Patronymic], [YearBirth], [YearDeath]) VALUES ( N'Терри', N'Россио', N'Россио', CAST(N'2004-11-01' AS Date), CAST(N'2023-01-02' AS Date))
GO
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 1, 2, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-10' AS Date), 50, N'1000000000000', N'26.31c+26.342a', N'Жизнь харизматичного авантюриста, капитана Джека Воробья, полная увлекательных приключений, резко меняется, когда его заклятый враг — капитан Барбосса — похищает корабль Джека, Черную Жемчужину, а затем нападает на Порт Ройал и крадет прекрасную дочь губернатора, Элизабет Свонн.', NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Гари Потер', 2, 3, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-01' AS Date), 60, N'2111111111111', N'26.31c+26.342b', N'«Harry Potter» — серия романов, написанная британской писательницей Дж. К. Роулинг. Книги представляют собой хронику приключений юного волшебника Гарри Поттера, а также его друзей Рона Уизли и Гермионы Грейнджер, обучающихся в школе чародейства и волшебства Хогвартс.', NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 3, 1, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-10' AS Date), 50, N'3111111111111', N'26.31c+26.342c', NULL, NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Алиса в стране чудес', 1, 2, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-01' AS Date), 60, N'4111111111111', N'26.31c+26.342d', N'В ней рассказывается о девочке по имени Алиса, которая попадает сквозь кроличью нору в воображаемый мир, населённый странными антропоморфными существами. Сказка пользуется устойчивой популярностью как у детей, так и у взрослых.', NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 2, 3, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-10' AS Date), 50, N'5111111111111', N'26.31c+26.342e', NULL, NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 3, 1, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-01' AS Date), 60, N'6111111111111', N'26.31c+26.342f', NULL, NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 1, 2, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-10' AS Date), 50, N'7111111111111', N'26.31c+26.342g', NULL, NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 2, 3, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-01' AS Date), 60, N'8111111111111', N'26.31c+26.342h', NULL, NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 3, 1, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-10' AS Date), 50, N'9111111111111', N'26.31c+26.342y', NULL, NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 1, 2, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-01' AS Date), 60, N'1011111111111', N'26.31c+26.342q', NULL, NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 2, 3, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-10' AS Date), 50, N'1111111111111', N'26.31c+26.342w', NULL, NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 3, 1, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-01' AS Date), 60, N'1211111111111', N'26.31c+26.342t', NULL, NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 1, 2, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-10' AS Date), 50, N'1311111111111', N'26.31c+26.342u', NULL, NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 2, 3, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-01' AS Date), 60, N'1411111111111', N'26.31c+26.342i', NULL, NULL)
INSERT [dbo].[Book] ( [NameBook], [idGenre], [idAuthor], [PublishingHouse], [PlacePublication], [YearPublication], [NumberPages], [ISBN], [BBK], [Description], [ImageBook]) VALUES ( N'Пираты карибского моря', 3, 1, N'Эгмонт Россия Лтд', N'г.Кант', CAST(N'2001-01-10' AS Date), 50, N'1511111111111', N'26.31c+26.342o', NULL, NULL)
GO
INSERT [dbo].[Genre] ( [NameGenre]) VALUES ( N'Все типы')
INSERT [dbo].[Genre] ( [NameGenre]) VALUES ( N'Любовь')
INSERT [dbo].[Genre] ( [NameGenre]) VALUES ( N'Сёнен')
INSERT [dbo].[Genre] ( [NameGenre]) VALUES ( N'Фентези')
GO
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 1, 1, CAST(N'2023-04-20' AS Date), CAST(N'2023-03-31' AS Date), 1, 1)
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 1, 1, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-31' AS Date), 1, 0)
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 2, 2, CAST(N'2023-03-21' AS Date), CAST(N'2023-04-30' AS Date), 0, 0)
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 3, 3, CAST(N'2023-03-21' AS Date), CAST(N'2023-06-01' AS Date), 1, 0)
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 4, 4, CAST(N'2023-03-21' AS Date), CAST(N'2023-06-01' AS Date), 1, 0)
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 5, 5, CAST(N'2023-03-21' AS Date), CAST(N'2023-06-01' AS Date), 1, 0)
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 6, 6, CAST(N'2023-03-21' AS Date), CAST(N'2023-06-01' AS Date), 0, 0)
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 1, 2, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-31' AS Date), 0, 0)
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 1, 2, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-31' AS Date), 0, 1)
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 1, 2, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-31' AS Date), 0, 1)
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 1, 2, CAST(N'2023-03-21' AS Date), CAST(N'2023-03-31' AS Date), 0, 1)
INSERT [dbo].[NumberBookGiven] ( [AccountingBook], [idUser], [DateIssue], [ReturnDate], [ReturnedBook], [BuyBook]) VALUES ( 1, 1, CAST(N'2023-05-04' AS Date), CAST(N'2023-05-18' AS Date), 0, 0)
GO
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'1', N'1', N'Шмидт', N'Максим', N'Лео', 1, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'2', N'2', N'Казанцев', N'Даниил', N'Максимович', 2, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663375')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'3', N'3', N'Шмидт', N'Максим', N'Лео', 3, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'4', N'4', N'Шмидт', N'Максим', N'Максимович', 3, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'5', N'5', N'Шмидт', N'Максим', N'Лео', 3, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'6', N'6', N'Шмидт', N'Максим', N'Максимович', 3, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'7', N'7', N'Шмидт', N'Максим', N'Лео', 3, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'8', N'8', N'Шмидт', N'Максим', N'Максимович', 3, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'9', N'9', N'Шмидт', N'Максим', N'Лео', 3, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'10', N'10', N'Шмидт', N'Максим', N'Максимович', 3, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'11', N'11', N'Шмидт', N'Максим', N'Лео', 3, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'12', N'12', N'Шмидт', N'Максим', N'Максимович', 3, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'13', N'13', N'Шмидт', N'Максим', N'Лео', 3, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
INSERT [dbo].[User] ( [Login], [Password], [LastName], [FirstName], [Patronymic], [idViewUser], [YearBirth], [ResidentialAddress], [PlaceWork], [NumbrePhone]) VALUES ( N'14', N'14', N'Шмидт', N'Максим', N'Лео', 1, CAST(N'2004-01-01' AS Date), N'Декабристов 83', N'ЕМК', N'89826663374')
GO
INSERT [dbo].[ViewUser] ( [NameViewUser]) VALUES ( N'Администратор')
INSERT [dbo].[ViewUser] ( [NameViewUser]) VALUES ( N'Библиотекарь')
INSERT [dbo].[ViewUser] ( [NameViewUser]) VALUES ( N'Читатель')
INSERT [dbo].[ViewUser] ( [NameViewUser]) VALUES ( N'Временный пользователь')
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

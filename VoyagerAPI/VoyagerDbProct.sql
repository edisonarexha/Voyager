USE [Voyager]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[appLogs]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appLogs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[LogsNumber] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[FormaId] [int] NOT NULL,
	[ModuliId] [int] NOT NULL,
	[InsertedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_appLogs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[destination]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[destination](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DestinationName] [nvarchar](max) NOT NULL,
	[State] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_destination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FlightsDatas]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FlightsDatas](
	[FlightNumber] [int] IDENTITY(1,1) NOT NULL,
	[FlightName] [nvarchar](max) NOT NULL,
	[FlightDate] [datetime2](7) NOT NULL,
	[CompanyName] [nvarchar](max) NOT NULL,
	[AirCraftName] [nvarchar](max) NOT NULL,
	[TailNumber] [int] NOT NULL,
 CONSTRAINT [PK_FlightsDatas] PRIMARY KEY CLUSTERED 
(
	[FlightNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hotels]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hotels](
	[HotelId] [int] IDENTITY(1,1) NOT NULL,
	[HotelName] [nvarchar](max) NOT NULL,
	[HotelStatus] [int] NULL,
	[Country] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[BeachResort] [bit] NOT NULL,
	[PackageInclude] [bit] NOT NULL,
	[PackageId] [int] NULL,
	[Details] [nvarchar](max) NOT NULL,
	[HotelPhoto] [nvarchar](max) NOT NULL,
	[HotelSize] [int] NOT NULL,
	[Checkin] [datetime2](7) NULL,
	[Checkout] [datetime2](7) NULL,
	[Restriction] [bit] NOT NULL,
 CONSTRAINT [PK_hotels] PRIMARY KEY CLUSTERED 
(
	[HotelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[outputTrip]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[outputTrip](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[PackageName] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[HotelId] [int] NULL,
	[HotelName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[TicketName] [nvarchar](max) NOT NULL,
	[FlightNumber] [int] NOT NULL,
	[AirCraftName] [nvarchar](max) NOT NULL,
	[TailNumber] [int] NOT NULL,
	[CompanyName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_outputTrip] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PackagesDetails]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PackagesDetails](
	[PackageId] [nvarchar](450) NOT NULL,
	[PackageName] [nvarchar](max) NOT NULL,
	[HotelId] [int] NOT NULL,
	[PackagePrice] [decimal](18, 2) NOT NULL,
	[TripId] [int] NOT NULL,
	[Destination] [nvarchar](max) NOT NULL,
	[Details] [nvarchar](max) NOT NULL,
	[TicketId] [int] NOT NULL,
 CONSTRAINT [PK_PackagesDetails] PRIMARY KEY CLUSTERED 
(
	[PackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketsDetails]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketsDetails](
	[TicketId] [int] IDENTITY(1,1) NOT NULL,
	[TicketName] [nvarchar](max) NOT NULL,
	[UserId] [int] NOT NULL,
	[TicketNumber] [int] NOT NULL,
	[FlightNumber] [int] NOT NULL,
	[Arrival] [datetime2](7) NOT NULL,
	[Departure] [datetime2](7) NOT NULL,
	[PackageId] [int] NULL,
	[HotelId] [int] NULL,
	[DestinationId] [int] NOT NULL,
 CONSTRAINT [PK_TicketsDetails] PRIMARY KEY CLUSTERED 
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PackageId] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[voyagers]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[voyagers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Priority] [int] NOT NULL,
	[VoyagerType] [int] NOT NULL,
	[Created] [datetime2](7) NOT NULL,
	[Completed] [datetime2](7) NULL,
 CONSTRAINT [PK_voyagers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220516174422_InitialCreate', N'6.0.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220601210031_Package Table', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220601212230_Ticket and Flights Details', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220601213246_Ticket and Flights Details', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220606171943_ApplicationLogsData', N'6.0.5')
GO
SET IDENTITY_INSERT [dbo].[appLogs] ON 

INSERT [dbo].[appLogs] ([id], [LogsNumber], [UserId], [FormaId], [ModuliId], [InsertedDate]) VALUES (1, 10, 3, 3, 2, CAST(N'2022-06-06T10:42:26.0000000' AS DateTime2))
INSERT [dbo].[appLogs] ([id], [LogsNumber], [UserId], [FormaId], [ModuliId], [InsertedDate]) VALUES (2, 2001, 3, 2001, 2001, CAST(N'2022-06-06T10:43:18.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[appLogs] OFF
GO
SET IDENTITY_INSERT [dbo].[destination] ON 

INSERT [dbo].[destination] ([Id], [DestinationName], [State]) VALUES (1, N'Germany', N'Germnay')
SET IDENTITY_INSERT [dbo].[destination] OFF
GO
SET IDENTITY_INSERT [dbo].[FlightsDatas] ON 

INSERT [dbo].[FlightsDatas] ([FlightNumber], [FlightName], [FlightDate], [CompanyName], [AirCraftName], [TailNumber]) VALUES (1, N'Germany', CAST(N'2022-12-12T00:00:00.0000000' AS DateTime2), N'Turkish AirLines', N'Boeing 077', 12139412)
INSERT [dbo].[FlightsDatas] ([FlightNumber], [FlightName], [FlightDate], [CompanyName], [AirCraftName], [TailNumber]) VALUES (2, N'England', CAST(N'2021-12-02T00:00:00.0000000' AS DateTime2), N'Cana Det', N'Boeing 210', 23123121)
SET IDENTITY_INSERT [dbo].[FlightsDatas] OFF
GO
SET IDENTITY_INSERT [dbo].[hotels] ON 

INSERT [dbo].[hotels] ([HotelId], [HotelName], [HotelStatus], [Country], [City], [Address], [BeachResort], [PackageInclude], [PackageId], [Details], [HotelPhoto], [HotelSize], [Checkin], [Checkout], [Restriction]) VALUES (3, N'Det', 1, N'Germany', N'Germnay', N'germany', 1, 1, 1, N'etst', N'', 2, CAST(N'2021-12-12T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-12T00:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[hotels] OFF
GO
INSERT [dbo].[PackagesDetails] ([PackageId], [PackageName], [HotelId], [PackagePrice], [TripId], [Destination], [Details], [TicketId]) VALUES (N'1', N'Personale', 3, CAST(1210.00 AS Decimal(18, 2)), 1, N'germany', N'12', 1)
GO
SET IDENTITY_INSERT [dbo].[TicketsDetails] ON 

INSERT [dbo].[TicketsDetails] ([TicketId], [TicketName], [UserId], [TicketNumber], [FlightNumber], [Arrival], [Departure], [PackageId], [HotelId], [DestinationId]) VALUES (3, N'test', 2, 1, 1, CAST(N'2022-06-01T21:40:40.0750000' AS DateTime2), CAST(N'2022-06-01T21:40:40.0750000' AS DateTime2), 1, 1, 1)
INSERT [dbo].[TicketsDetails] ([TicketId], [TicketName], [UserId], [TicketNumber], [FlightNumber], [Arrival], [Departure], [PackageId], [HotelId], [DestinationId]) VALUES (4, N'test1', 2, 1, 1, CAST(N'2022-06-01T21:40:40.0750000' AS DateTime2), CAST(N'2022-06-01T21:40:40.0750000' AS DateTime2), 1, 3, 1)
SET IDENTITY_INSERT [dbo].[TicketsDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([UserId], [Name], [LastName], [UserName], [Email], [PackageId]) VALUES (1, N'Tina', N'Bytyqi', N'Tinax123', N'tina@gmail.com', 0)
INSERT [dbo].[users] ([UserId], [Name], [LastName], [UserName], [Email], [PackageId]) VALUES (2, N'Edisona', N'Rexha', N'edix123', N'edi@gmail.com', 0)
INSERT [dbo].[users] ([UserId], [Name], [LastName], [UserName], [Email], [PackageId]) VALUES (3, N'TIna', N'Bytyqi', N'teh@', N'tes@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
/****** Object:  StoredProcedure [dbo].[getTripDataForUser]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getTripDataForUser]
@userid as int,
@logsNumber as int,
@formaid as int,
@moduliid as int,
@InsertedDate as datetime

as
begin

  SELECT u.UserId,P.PackageName, u.Name,u.LastName,p.HotelId,h.HotelName,h.Address ,t.TicketName,f.FlightNumber,f.AirCraftName,f.TailNumber,f.CompanyName
  FROM PackagesDetails P INNER JOIN users u on P.PackageId=u.PackageId inner join hotels h on P.HotelId=h.HotelId
  inner join TicketsDetails t on h.HotelId=t.HotelId inner join FlightsDatas f on f.FlightNumber=t.FlightNumber 
  where u.UserId=@userid 

  insert into appLogs values(@logsNumber,@userid,@formaid,@moduliid,@InsertedDate)

  end
GO
/****** Object:  StoredProcedure [dbo].[getUsers]    Script Date: 6/6/2022 11:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getUsers]
@userid as int

as
begin

select UserId ,Name,LastName
from users 
where UserId=@userid

end
GO

USE [Photography]
GO
ALTER TABLE [dbo].[Picture] DROP CONSTRAINT [FK_Picture_Category]
GO
/****** Object:  Index [IX_CategoryId]    Script Date: 10/31/2013 7:51:42 PM ******/
DROP INDEX [IX_CategoryId] ON [dbo].[Picture]
GO
/****** Object:  Table [dbo].[Picture]    Script Date: 10/31/2013 7:51:42 PM ******/
DROP TABLE [dbo].[Picture]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 10/31/2013 7:51:42 PM ******/
DROP TABLE [dbo].[Category]
GO
USE [master]
GO
/****** Object:  Database [Photography]    Script Date: 10/31/2013 7:51:42 PM ******/
DROP DATABASE [Photography]
GO
/****** Object:  Database [Photography]    Script Date: 10/31/2013 7:51:42 PM ******/
CREATE DATABASE [Photography]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Photography', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Photography.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Photography_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Photography_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Photography] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Photography].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Photography] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Photography] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Photography] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Photography] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Photography] SET ARITHABORT OFF 
GO
ALTER DATABASE [Photography] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Photography] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Photography] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Photography] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Photography] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Photography] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Photography] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Photography] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Photography] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Photography] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Photography] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Photography] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Photography] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Photography] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Photography] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Photography] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Photography] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Photography] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Photography] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Photography] SET  MULTI_USER 
GO
ALTER DATABASE [Photography] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Photography] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Photography] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Photography] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Photography]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 10/31/2013 7:51:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[DisplayType] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Position] [int] NOT NULL,
	[Visible] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Picture]    Script Date: 10/31/2013 7:51:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Picture](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[FileName] [nvarchar](max) NOT NULL,
	[PictureType] [int] NOT NULL,
	[Position] [int] NOT NULL,
	[Width] [int] NOT NULL,
	[Height] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Picture] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Category] ON 

GO
INSERT [dbo].[Category] ([Id], [Name], [DisplayType], [Description], [Position], [Visible]) VALUES (1, N'Home', 1, NULL, 1, 1)
GO
INSERT [dbo].[Category] ([Id], [Name], [DisplayType], [Description], [Position], [Visible]) VALUES (2, N'About', 2, N'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', 2, 1)
GO
INSERT [dbo].[Category] ([Id], [Name], [DisplayType], [Description], [Position], [Visible]) VALUES (3, N'Landscape', 3, N'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 3, 1)
GO
INSERT [dbo].[Category] ([Id], [Name], [DisplayType], [Description], [Position], [Visible]) VALUES (4, N'Nature', 3, N'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 4, 1)
GO
INSERT [dbo].[Category] ([Id], [Name], [DisplayType], [Description], [Position], [Visible]) VALUES (5, N'Architecture', 3, N'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 5, 1)
GO
INSERT [dbo].[Category] ([Id], [Name], [DisplayType], [Description], [Position], [Visible]) VALUES (6, N'Portraits', 3, N'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.', 6, 1)
GO
INSERT [dbo].[Category] ([Id], [Name], [DisplayType], [Description], [Position], [Visible]) VALUES (7, N'Contact', 4, NULL, 7, 1)
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Picture] ON 

GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (1, 1, N'back-01.jpg', 1, 0, 1000, 560)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (2, 1, N'back-02.jpg', 1, 0, 1000, 560)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (3, 1, N'back-03.jpg', 1, 0, 1000, 560)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (4, 1, N'back-04.jpg', 1, 0, 1000, 560)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (5, 1, N'back-05.jpg', 1, 0, 1000, 560)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (6, 1, N'back-06.jpg', 1, 0, 1000, 560)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (7, 1, N'back-07.jpg', 1, 0, 1000, 560)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (8, 1, N'back-08.jpg', 1, 0, 1000, 560)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (9, 2, N'back-07.jpg', 1, 0, 1000, 560)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (10, 3, N'cover-01.jpg', 2, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (11, 3, N'thumb-01.jpg', 3, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (12, 3, N'thumb-01.jpg', 3, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (13, 3, N'thumb-01.jpg', 3, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (14, 3, N'thumb-01.jpg', 3, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (15, 3, N'thumb-01.jpg', 3, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (16, 3, N'thumb-01.jpg', 3, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (17, 4, N'cover-01.jpg', 2, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (18, 5, N'cover-01.jpg', 2, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (19, 6, N'cover-01.jpg', 2, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (20, 3, N'thumb-01.jpg', 3, 0, 383, 468)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (21, 3, N'thumb-01.jpg', 3, 0, 383, 468)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (22, 3, N'thumb-01.jpg', 3, 0, 383, 468)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (23, 3, N'thumb-01.jpg', 3, 0, 383, 468)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (24, 3, N'thumb-01.jpg', 3, 0, 383, 468)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (25, 3, N'thumb-01.jpg', 3, 0, 383, 468)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (26, 4, N'thumb-01.jpg', 3, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (27, 4, N'thumb-01.jpg', 3, 0, 383, 468)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (28, 5, N'thumb-01.jpg', 3, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (29, 5, N'thumb-01.jpg', 3, 0, 383, 468)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (30, 6, N'thumb-01.jpg', 3, 0, 383, 478)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (31, 6, N'thumb-01.jpg', 3, 0, 383, 468)
GO
INSERT [dbo].[Picture] ([Id], [CategoryId], [FileName], [PictureType], [Position], [Width], [Height]) VALUES (32, 7, N'contact.jpg', 2, 0, 374, 560)
GO
SET IDENTITY_INSERT [dbo].[Picture] OFF
GO
/****** Object:  Index [IX_CategoryId]    Script Date: 10/31/2013 7:51:42 PM ******/
CREATE NONCLUSTERED INDEX [IX_CategoryId] ON [dbo].[Picture]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Picture]  WITH CHECK ADD  CONSTRAINT [FK_Picture_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Picture] CHECK CONSTRAINT [FK_Picture_Category]
GO
USE [master]
GO
ALTER DATABASE [Photography] SET  READ_WRITE 
GO

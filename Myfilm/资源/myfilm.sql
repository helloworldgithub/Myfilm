USE [master]
GO
/****** Object:  Database [myFilm]    Script Date: 2015/7/19 21:26:36 ******/
CREATE DATABASE [myFilm]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'myFilm', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\myFilm.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'myFilm_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\myFilm_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [myFilm] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [myFilm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [myFilm] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [myFilm] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [myFilm] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [myFilm] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [myFilm] SET ARITHABORT OFF 
GO
ALTER DATABASE [myFilm] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [myFilm] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [myFilm] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [myFilm] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [myFilm] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [myFilm] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [myFilm] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [myFilm] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [myFilm] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [myFilm] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [myFilm] SET  DISABLE_BROKER 
GO
ALTER DATABASE [myFilm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [myFilm] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [myFilm] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [myFilm] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [myFilm] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [myFilm] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [myFilm] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [myFilm] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [myFilm] SET  MULTI_USER 
GO
ALTER DATABASE [myFilm] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [myFilm] SET DB_CHAINING OFF 
GO
ALTER DATABASE [myFilm] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [myFilm] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [myFilm]
GO
/****** Object:  Table [dbo].[comments]    Script Date: 2015/7/19 21:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[filmId] [int] NOT NULL,
	[comments] [text] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[films]    Script Date: 2015/7/19 21:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[films](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[filmName] [nvarchar](50) NOT NULL,
	[price] [float] NOT NULL,
	[length] [bigint] NOT NULL,
	[description] [text] NOT NULL,
	[director] [text] NOT NULL,
	[hall] [int] NOT NULL,
	[startTime] [datetime] NOT NULL,
	[logo] [nvarchar](50) NOT NULL,
	[amount] [int] NOT NULL,
	[score] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[scores]    Script Date: 2015/7/19 21:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[scores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[filmId] [int] NOT NULL,
	[score] [float] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[seat]    Script Date: 2015/7/19 21:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[seat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[row] [int] NOT NULL,
	[col] [int] NOT NULL,
	[hall] [int] NOT NULL,
	[start] [datetime] NOT NULL,
	[filmId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user]    Script Date: 2015/7/19 21:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[type] [int] NOT NULL
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [myFilm] SET  READ_WRITE 
GO

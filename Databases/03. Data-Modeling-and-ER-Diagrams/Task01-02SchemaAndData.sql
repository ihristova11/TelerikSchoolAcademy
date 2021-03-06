USE [master]
GO
/****** Object:  Database [01. ContinentWithCountries]    Script Date: 12-Jan-15 3:33:10 PM ******/
CREATE DATABASE [01. ContinentWithCountries]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'01. ContinentWithCountries', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\01. ContinentWithCountries.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'01. ContinentWithCountries_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\01. ContinentWithCountries_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [01. ContinentWithCountries] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [01. ContinentWithCountries].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [01. ContinentWithCountries] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET ARITHABORT OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [01. ContinentWithCountries] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [01. ContinentWithCountries] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET  DISABLE_BROKER 
GO
ALTER DATABASE [01. ContinentWithCountries] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [01. ContinentWithCountries] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [01. ContinentWithCountries] SET  MULTI_USER 
GO
ALTER DATABASE [01. ContinentWithCountries] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [01. ContinentWithCountries] SET DB_CHAINING OFF 
GO
ALTER DATABASE [01. ContinentWithCountries] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [01. ContinentWithCountries] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [01. ContinentWithCountries] SET DELAYED_DURABILITY = DISABLED 
GO
USE [01. ContinentWithCountries]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 12-Jan-15 3:33:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressID] [int] NOT NULL,
	[AddressText] [nvarchar](100) NOT NULL,
	[TownID] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 12-Jan-15 3:33:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[ContinentID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[ContinentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 12-Jan-15 3:33:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinentID] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[People]    Script Date: 12-Jan-15 3:33:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[PersonID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressID] [int] NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 12-Jan-15 3:33:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[TownID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[TownID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Addresses] ([AddressID], [AddressText], [TownID]) VALUES (1, N'Main Street 1', 2)
INSERT [dbo].[Addresses] ([AddressID], [AddressText], [TownID]) VALUES (2, N'Some Street 5', 1)
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (1, N'Europe')
INSERT [dbo].[Continents] ([ContinentID], [Name]) VALUES (2, N'Asia')
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (1, N'Bulgaria', 1)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinentID]) VALUES (2, N'China', 2)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (1, N'Pesho', N'Goshov', 2)
INSERT [dbo].[People] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (2, N'Penka', N'Stamatova', 1)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (1, N'Sofia', 1)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (2, N'Beijing', 2)
USE [master]
GO
ALTER DATABASE [01. ContinentWithCountries] SET  READ_WRITE 
GO

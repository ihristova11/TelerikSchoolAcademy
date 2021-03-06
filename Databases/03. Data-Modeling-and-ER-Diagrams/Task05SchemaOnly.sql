USE [master]
GO
/****** Object:  Database [05. Dictionary]    Script Date: 12-Jan-15 6:32:25 PM ******/
CREATE DATABASE [05. Dictionary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'05. Dictionary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\05. Dictionary.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'05. Dictionary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\05. Dictionary_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [05. Dictionary] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [05. Dictionary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [05. Dictionary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [05. Dictionary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [05. Dictionary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [05. Dictionary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [05. Dictionary] SET ARITHABORT OFF 
GO
ALTER DATABASE [05. Dictionary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [05. Dictionary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [05. Dictionary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [05. Dictionary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [05. Dictionary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [05. Dictionary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [05. Dictionary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [05. Dictionary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [05. Dictionary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [05. Dictionary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [05. Dictionary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [05. Dictionary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [05. Dictionary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [05. Dictionary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [05. Dictionary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [05. Dictionary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [05. Dictionary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [05. Dictionary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [05. Dictionary] SET  MULTI_USER 
GO
ALTER DATABASE [05. Dictionary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [05. Dictionary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [05. Dictionary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [05. Dictionary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [05. Dictionary] SET DELAYED_DURABILITY = DISABLED 
GO
USE [05. Dictionary]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 12-Jan-15 6:32:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[LanguageID] [int] IDENTITY(1,1) NOT NULL,
	[Language] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[LanguageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words]    Script Date: 12-Jan-15 6:32:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words](
	[WordID] [int] IDENTITY(1,1) NOT NULL,
	[Word] [nvarchar](50) NOT NULL,
	[LanguageID] [int] NOT NULL,
 CONSTRAINT [PK_Words] PRIMARY KEY CLUSTERED 
(
	[WordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words_Explanations]    Script Date: 12-Jan-15 6:32:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words_Explanations](
	[WordID] [int] NOT NULL,
	[ExplanationLanguageID] [int] NOT NULL,
	[Explanation] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words_Synonyms]    Script Date: 12-Jan-15 6:32:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words_Synonyms](
	[WordID] [int] NOT NULL,
	[SynonymWordID] [int] NOT NULL,
 CONSTRAINT [PK_Words_Synonyms] PRIMARY KEY CLUSTERED 
(
	[WordID] ASC,
	[SynonymWordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words_Translations]    Script Date: 12-Jan-15 6:32:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words_Translations](
	[WordID] [int] NOT NULL,
	[TranslationWordID] [int] NOT NULL,
 CONSTRAINT [PK_Words_Translations] PRIMARY KEY CLUSTERED 
(
	[WordID] ASC,
	[TranslationWordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([LanguageID])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Languages]
GO
ALTER TABLE [dbo].[Words_Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Explanations_Languages] FOREIGN KEY([ExplanationLanguageID])
REFERENCES [dbo].[Languages] ([LanguageID])
GO
ALTER TABLE [dbo].[Words_Explanations] CHECK CONSTRAINT [FK_Words_Explanations_Languages]
GO
ALTER TABLE [dbo].[Words_Explanations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Explanations_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Words_Explanations] CHECK CONSTRAINT [FK_Words_Explanations_Words]
GO
ALTER TABLE [dbo].[Words_Synonyms]  WITH CHECK ADD  CONSTRAINT [FK_Words_Synonyms_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Words_Synonyms] CHECK CONSTRAINT [FK_Words_Synonyms_Words]
GO
ALTER TABLE [dbo].[Words_Translations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Translations_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Words_Translations] CHECK CONSTRAINT [FK_Words_Translations_Words]
GO
ALTER TABLE [dbo].[Words_Translations]  WITH CHECK ADD  CONSTRAINT [FK_Words_Translations_Words1] FOREIGN KEY([TranslationWordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Words_Translations] CHECK CONSTRAINT [FK_Words_Translations_Words1]
GO
USE [master]
GO
ALTER DATABASE [05. Dictionary] SET  READ_WRITE 
GO

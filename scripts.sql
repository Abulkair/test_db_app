USE [master]
GO

/****** Object:  Database [test_db]    Script Date: Tue, 29.08.23 23:30:59 ******/
CREATE DATABASE [test_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'test_db', FILENAME = N'D:\test_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'test_db_log', FILENAME = N'D:\test_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

USE [test_db]
GO

/****** Object:  Table [dbo].[Companies]    Script Date: Tue, 29.08.23 23:31:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Companies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](500) NULL,
	[iin] [varchar](12) NULL,
	[address] [nvarchar](500) NULL,
	[description] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Employees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](50) NULL,
	[lastName] [varchar](50) NULL,
	[middleName] [varchar](50) NULL,
	[iin] [varchar](12) NULL,
	[companyId] [int] NULL
) ON [PRIMARY]
GO
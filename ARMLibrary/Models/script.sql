USE [master]
GO

/****** Object:  Database [Library]    Script Date: 21.03.2023 21:16:34 ******/
CREATE DATABASE [Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'D:\DataBaseMain\Date\Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'D:\DataBaseMain\Date\Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Library] SET ARITHABORT OFF 
GO

ALTER DATABASE [Library] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Library] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Library] SET RECOVERY FULL 
GO

ALTER DATABASE [Library] SET  MULTI_USER 
GO

ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Library] SET DELAYED_DURABILITY = DISABLED 
GO



ALTER DATABASE [Library] SET QUERY_STORE = ON
GO

ALTER DATABASE [Library] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200)
GO

ALTER DATABASE [Library] SET  READ_WRITE 
GO


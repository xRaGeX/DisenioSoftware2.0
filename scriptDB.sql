USE [master]
GO
/****** Object:  Database [Othello_DB]    Script Date: 22/04/2018 21:24:29 ******/
CREATE DATABASE [Othello_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Diseño de Software', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Diseño de Software.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Diseño de Software_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Diseño de Software_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Othello_DB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Othello_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Othello_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Othello_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Othello_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Othello_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Othello_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Othello_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Othello_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Othello_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Othello_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Othello_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Othello_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Othello_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Othello_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Othello_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Othello_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Othello_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Othello_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Othello_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Othello_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Othello_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Othello_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Othello_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Othello_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Othello_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Othello_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Othello_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Othello_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Othello_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Othello_DB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Othello_DB]
GO
/****** Object:  Table [dbo].[Estadisticas Persona]    Script Date: 22/04/2018 21:24:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estadisticas Persona](
	[ID_Facebook] [varchar](100) NOT NULL,
	[Partidas_Ganadas] [int] NOT NULL,
	[Partidas_Perdidas] [int] NOT NULL,
	[Partidas_Empatadas] [int] NOT NULL,
 CONSTRAINT [PK_Estadisticas Persona] PRIMARY KEY CLUSTERED 
(
	[ID_Facebook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 22/04/2018 21:24:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Jugadores](
	[ID_Facebook] [varchar](100) NOT NULL,
	[Nombre_Jugador] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Jugadores] PRIMARY KEY CLUSTERED 
(
	[ID_Facebook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sesiones]    Script Date: 22/04/2018 21:24:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sesiones](
	[ID_Sesion] [int] IDENTITY(1,1) NOT NULL,
	[ID_Jugador1] [varchar](100) NOT NULL,
	[ID_Jugador2] [varchar](100) NOT NULL,
	[tam_matriz] [int] NOT NULL,
	[pos_fichas_J1] [varchar](max) NOT NULL,
	[pos_fichas_J2] [varchar](max) NOT NULL,
	[Estado] [bit] NOT NULL,
	[ficha_J1] [varchar](50) NULL,
	[ficha_J2] [varchar](50) NULL,
	[Turno] [varchar](10) NULL,
	[Aceptada] [bit] NULL,
	[CantidadPartidas] [int] NULL,
 CONSTRAINT [PK_Sesiones] PRIMARY KEY CLUSTERED 
(
	[ID_Sesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Estadisticas Persona] ([ID_Facebook], [Partidas_Ganadas], [Partidas_Perdidas], [Partidas_Empatadas]) VALUES (N'10215300639739652', 7, 1, 0)
INSERT [dbo].[Jugadores] ([ID_Facebook], [Nombre_Jugador], [Activo]) VALUES (N'10155093047116193', N'Adrian Solis', 0)
INSERT [dbo].[Jugadores] ([ID_Facebook], [Nombre_Jugador], [Activo]) VALUES (N'10215300639739652', N'Josué Arce', 1)
SET IDENTITY_INSERT [dbo].[Sesiones] ON 

INSERT [dbo].[Sesiones] ([ID_Sesion], [ID_Jugador1], [ID_Jugador2], [tam_matriz], [pos_fichas_J1], [pos_fichas_J2], [Estado], [ficha_J1], [ficha_J2], [Turno], [Aceptada], [CantidadPartidas]) VALUES (24, N'10215300639739652', N'10215300639739652', 5, N'pJ1', N'pJ2', 1, N'f1.png', N'f10.png', N'1', 1, 1)
INSERT [dbo].[Sesiones] ([ID_Sesion], [ID_Jugador1], [ID_Jugador2], [tam_matriz], [pos_fichas_J1], [pos_fichas_J2], [Estado], [ficha_J1], [ficha_J2], [Turno], [Aceptada], [CantidadPartidas]) VALUES (25, N'10215300639739652', N'10155093047116193', 5, N'pJ1', N'pJ2', 1, N'f1.png', N'fJ2', N'1', 0, 1)
SET IDENTITY_INSERT [dbo].[Sesiones] OFF
USE [master]
GO
ALTER DATABASE [Othello_DB] SET  READ_WRITE 
GO

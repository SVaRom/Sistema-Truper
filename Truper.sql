USE [master]
GO
/****** Object:  Database [Truper]    Script Date: 04/12/2020 05:14:58 p. m. ******/
CREATE DATABASE [Truper]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Truper', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Truper.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Truper_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Truper_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Truper] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Truper].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Truper] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Truper] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Truper] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Truper] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Truper] SET ARITHABORT OFF 
GO
ALTER DATABASE [Truper] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Truper] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Truper] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Truper] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Truper] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Truper] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Truper] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Truper] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Truper] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Truper] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Truper] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Truper] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Truper] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Truper] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Truper] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Truper] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Truper] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Truper] SET RECOVERY FULL 
GO
ALTER DATABASE [Truper] SET  MULTI_USER 
GO
ALTER DATABASE [Truper] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Truper] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Truper] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Truper] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Truper] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Truper', N'ON'
GO
ALTER DATABASE [Truper] SET QUERY_STORE = OFF
GO
USE [Truper]
GO
/****** Object:  Table [dbo].[Catalogo]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalogo](
	[Fragmento] [varchar](2) NOT NULL,
	[Tabla] [varchar](50) NOT NULL,
	[Campo] [varchar](20) NOT NULL,
	[Valor] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[RFCC] [nvarchar](13) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Teléfono] [int] NULL,
	[Dirección] [nvarchar](30) NULL,
	[Email] [nvarchar](30) NULL,
	[TipoCliente] [nvarchar](10) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[RFCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[Folio] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Total] [money] NULL,
	[RFCC] [nvarchar](13) NULL,
	[RFCE] [nvarchar](13) NULL,
	[ID_Sucursal] [nvarchar](10) NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[Folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComProd]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComProd](
	[Folio] [int] NOT NULL,
	[ID_Producto] [nvarchar](10) NOT NULL,
	[Cantidad] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[RFCE] [nvarchar](13) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Dirección] [nvarchar](30) NULL,
	[Teléfono] [int] NULL,
	[Puesto] [nvarchar](15) NULL,
	[Sueldo] [money] NULL,
	[AñoNac] [int] NULL,
	[AñoEntrada] [int] NULL,
	[ID_Sucursal] [nvarchar](10) NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[RFCE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[F1]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F1](
	[RFCE] [nvarchar](13) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Dirección] [nvarchar](30) NULL,
	[Teléfono] [int] NULL,
	[Puesto] [nvarchar](15) NULL,
	[Sueldo] [money] NULL,
	[AñoNac] [int] NULL,
	[AñoEntrada] [int] NULL,
	[ID_Sucursal] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[F2]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F2](
	[RFCE] [nvarchar](13) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Dirección] [nvarchar](30) NULL,
	[Teléfono] [int] NULL,
	[Puesto] [nvarchar](15) NULL,
	[Sueldo] [money] NULL,
	[AñoNac] [int] NULL,
	[AñoEntrada] [int] NULL,
	[ID_Sucursal] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[F3]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F3](
	[RFCE] [nvarchar](13) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Dirección] [nvarchar](30) NULL,
	[Teléfono] [int] NULL,
	[Puesto] [nvarchar](15) NULL,
	[Sueldo] [money] NULL,
	[AñoNac] [int] NULL,
	[AñoEntrada] [int] NULL,
	[ID_Sucursal] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[F4]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F4](
	[RFCE] [nvarchar](13) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Dirección] [nvarchar](30) NULL,
	[Teléfono] [int] NULL,
	[Puesto] [nvarchar](15) NULL,
	[Sueldo] [money] NULL,
	[AñoNac] [int] NULL,
	[AñoEntrada] [int] NULL,
	[ID_Sucursal] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[F5]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F5](
	[RFCE] [nvarchar](13) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Dirección] [nvarchar](30) NULL,
	[Teléfono] [int] NULL,
	[Puesto] [nvarchar](15) NULL,
	[Sueldo] [money] NULL,
	[AñoNac] [int] NULL,
	[AñoEntrada] [int] NULL,
	[ID_Sucursal] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[F6]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F6](
	[RFCE] [nvarchar](13) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Dirección] [nvarchar](30) NULL,
	[Teléfono] [int] NULL,
	[Puesto] [nvarchar](15) NULL,
	[Sueldo] [money] NULL,
	[AñoNac] [int] NULL,
	[AñoEntrada] [int] NULL,
	[ID_Sucursal] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[F7]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F7](
	[RFCE] [nvarchar](13) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Dirección] [nvarchar](30) NULL,
	[Teléfono] [int] NULL,
	[Puesto] [nvarchar](15) NULL,
	[Sueldo] [money] NULL,
	[AñoNac] [int] NULL,
	[AñoEntrada] [int] NULL,
	[ID_Sucursal] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[F8]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F8](
	[RFCE] [nvarchar](13) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Dirección] [nvarchar](30) NULL,
	[Teléfono] [int] NULL,
	[Puesto] [nvarchar](15) NULL,
	[Sueldo] [money] NULL,
	[AñoNac] [int] NULL,
	[AñoEntrada] [int] NULL,
	[ID_Sucursal] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[F9]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[F9](
	[RFCE] [nvarchar](13) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Dirección] [nvarchar](30) NULL,
	[Teléfono] [int] NULL,
	[Puesto] [nvarchar](15) NULL,
	[Sueldo] [money] NULL,
	[AñoNac] [int] NULL,
	[AñoEntrada] [int] NULL,
	[ID_Sucursal] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ID_Producto] [nvarchar](10) NOT NULL,
	[Nombre] [nvarchar](30) NULL,
	[Precio] [money] NULL,
	[Categoría] [nvarchar](30) NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SucProd]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SucProd](
	[ID_Sucursal] [nvarchar](10) NOT NULL,
	[ID_Producto] [nvarchar](10) NOT NULL,
	[Existencia] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursales]    Script Date: 04/12/2020 05:14:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursales](
	[ID_Sucursal] [nvarchar](10) NOT NULL,
	[Nombre] [nvarchar](30) NULL,
	[Dirección] [nvarchar](30) NULL,
 CONSTRAINT [PK_Sucursales] PRIMARY KEY CLUSTERED 
(
	[ID_Sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Catalogo] ([Fragmento], [Tabla], [Campo], [Valor]) VALUES (N'F1', N'Empleados', N'ID_Sucursal', N'SUTR01')
INSERT [dbo].[Catalogo] ([Fragmento], [Tabla], [Campo], [Valor]) VALUES (N'F2', N'Empleados', N'ID_Sucursal', N'SUTR02')
INSERT [dbo].[Catalogo] ([Fragmento], [Tabla], [Campo], [Valor]) VALUES (N'F3', N'Empleados', N'ID_Sucursal', N'SUTR03')
INSERT [dbo].[Catalogo] ([Fragmento], [Tabla], [Campo], [Valor]) VALUES (N'F4', N'Empleados', N'ID_Sucursal', N'SUTR04')
INSERT [dbo].[Catalogo] ([Fragmento], [Tabla], [Campo], [Valor]) VALUES (N'F5', N'Empleados', N'ID_Sucursal', N'SUTR05')
INSERT [dbo].[Catalogo] ([Fragmento], [Tabla], [Campo], [Valor]) VALUES (N'F6', N'Empleados', N'ID_Sucursal', N'SUTR06')
INSERT [dbo].[Catalogo] ([Fragmento], [Tabla], [Campo], [Valor]) VALUES (N'F7', N'Empleados', N'ID_Sucursal', N'SUTR07')
INSERT [dbo].[Catalogo] ([Fragmento], [Tabla], [Campo], [Valor]) VALUES (N'F8', N'Empleados', N'ID_Sucursal', N'SUTR08')
INSERT [dbo].[Catalogo] ([Fragmento], [Tabla], [Campo], [Valor]) VALUES (N'F9', N'Empleados', N'ID_Sucursal', N'SUTR09')
GO
INSERT [dbo].[Clientes] ([RFCC], [Nombres], [Apellidos], [Teléfono], [Dirección], [Email], [TipoCliente]) VALUES (N'JARR45239540', N'José Antonio ', N'Ramírez Ramos', 495662878, N'Luz 540', N'jarr@gmail.com', N'Menudista')
INSERT [dbo].[Clientes] ([RFCC], [Nombres], [Apellidos], [Teléfono], [Dirección], [Email], [TipoCliente]) VALUES (N'MGRR80326331', N'María Guadalupe', N'Ramos Reyes', 492352313, N'Luna 331', N'mgrr@gmail.com', N'Mayorista ')
INSERT [dbo].[Clientes] ([RFCC], [Nombres], [Apellidos], [Teléfono], [Dirección], [Email], [TipoCliente]) VALUES (N'MJAD12620725', N'Mario de Jesús ', N'Álvarez Dávila', 492641731, N'Marte 725', N'mjad@gmail.com', N'Menudista')
INSERT [dbo].[Clientes] ([RFCC], [Nombres], [Apellidos], [Teléfono], [Dirección], [Email], [TipoCliente]) VALUES (N'NAPM54234612', N'Nancy Alejandra', N'Pérez Mora', 496754127, N'Caudillos 612', N'napm@gmail.com', N'Mayorista ')
GO
INSERT [dbo].[Empleados] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTCJ327591', N'Laura Michelle', N'Hernández Pérez', N'Prof 242', 492675120, N'Supervisora', 242523.0000, 1956, 1980, N'SUTR03')
INSERT [dbo].[Empleados] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTCJ34533485', N'Ana Sofía', N'González Ríos', N'Velaria 642', 492347178, N'Supervisora', 5000.0000, 1965, 1983, N'SUTR05')
INSERT [dbo].[Empleados] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTCJ880326 ', N'Pedro Martin', N'Medrano Juárez', N'Artillero 682', 491375122, N'Empleado', 3000.0000, 2000, 2019, N'SUTR01')
INSERT [dbo].[Empleados] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTEA78352', N'Miguel Ángel', N'Flores García', N'Corregidora 576', 493561465, N'Empleado', 3000.0000, 2000, 2018, N'SUTR07')
INSERT [dbo].[Empleados] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTFR020817', N'Gloria Guadalupe', N'Álferez Méndez', N'Insurgentes 133', 492364810, N'Empleada', 4000.0000, 1960, 1982, N'SUTR04')
INSERT [dbo].[Empleados] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTFR030188', N'Juan Francisco ', N'Díaz López', N'Atardecer 509', 497628923, N'Gerente', 6000.0000, 1955, 2000, N'SUTR02')
INSERT [dbo].[Empleados] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTFR093296', N'María Elena', N'Gómez Cruz', N'Soledad 321', 492532821, N'Gerente', 4000.0000, 1986, 2000, N'SUTR06')
INSERT [dbo].[Empleados] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTIH275189', N'Pedro Manuel', N'Martínez Hernández', N'Bravo 234', 495879432, N'Gerente', 3500.0000, 1999, 2004, N'SUTR08')
INSERT [dbo].[Empleados] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTSL2361715', N'Verónica Monserrat', N'Sánchez Romo', N'Hermano 275', 496676881, N'Supervisora', 35000.0000, 1943, 1995, N'SUTR09')
GO
INSERT [dbo].[F1] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTCJ880326 ', N'Pedro Martin', N'Medrano Juárez', N'Artillero 685', 491375122, N'Empleado', 3000.0000, 2000, 2019, N'SUTR01')
GO
INSERT [dbo].[F2] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTFR030188', N'Juan Francisco ', N'Díaz López', N'Atardecer 509', 497628923, N'Gerente', 6000.0000, 1955, 2000, N'SUTR02')
GO
INSERT [dbo].[F3] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTCJ327591', N'Laura Michelle', N'Hernández Pérez', N'Prof 242', 492675120, N'Supervisora', 242523.0000, 1956, 1980, N'SUTR03')
GO
INSERT [dbo].[F4] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTFR020817', N'Gloria Guadalupe', N'Álferez Méndez', N'Insurgentes 133', 492364810, N'Empleada', 4000.0000, 1960, 1982, N'SUTR04')
GO
INSERT [dbo].[F5] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTCJ34533485', N'Ana Sofía', N'González Ríos', N'Velaria 642', 492347178, N'Supervisora', 5000.0000, 1965, 1983, N'SUTR05')
GO
INSERT [dbo].[F6] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTFR093296', N'María Elena', N'Gómez Cruz', N'Soledad 321', 492532821, N'Gerente', 4000.0000, 1986, 2000, N'SUTR06')
GO
INSERT [dbo].[F7] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTEA78352', N'Miguel Ángel', N'Flores García', N'Corregidora 576', 493561465, N'Empleado', 3000.0000, 2000, 2018, N'SUTR07')
GO
INSERT [dbo].[F8] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTIH275189', N'Pedro Manuel', N'Martínez Hernández', N'Bravo 234', 495879432, N'Gerente', 3500.0000, 1999, 2004, N'SUTR08')
GO
INSERT [dbo].[F9] ([RFCE], [Nombres], [Apellidos], [Dirección], [Teléfono], [Puesto], [Sueldo], [AñoNac], [AñoEntrada], [ID_Sucursal]) VALUES (N'FTSL2361715', N'Verónica Monserrat', N'Sánchez Romo', N'Hermano 275', 496676881, N'Supervisora', 35000.0000, 1943, 1995, N'SUTR09')
GO
INSERT [dbo].[Productos] ([ID_Producto], [Nombre], [Precio], [Categoría]) VALUES (N'ATC13256', N'Clavos', 50.0000, N'Acero')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre], [Precio], [Categoría]) VALUES (N'ATM6523', N'Tela Mosquitera', 65.0000, N'Acero')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre], [Precio], [Categoría]) VALUES (N'EATWD43', N'Alambre TWD', 1800.0000, N'Eléctrico')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre], [Precio], [Categoría]) VALUES (N'ECTHW63', N'Cable THW', 2465.0000, N'Eléctrico')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre], [Precio], [Categoría]) VALUES (N'HLI7642', N'Llave Inglesa', 350.0000, N'Herramienta')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre], [Precio], [Categoría]) VALUES (N'HM1328', N'Martillo', 400.0000, N'Herramienta')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre], [Precio], [Categoría]) VALUES (N'LAR3252', N'Aceite Rojo', 80.0000, N'Limpieza')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre], [Precio], [Categoría]) VALUES (N'LDA8648', N'Franela', 30.0000, N'Limpieza')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre], [Precio], [Categoría]) VALUES (N'TCC7832', N'Cuerda Corrida', 40.0000, N'Tubería')
INSERT [dbo].[Productos] ([ID_Producto], [Nombre], [Precio], [Categoría]) VALUES (N'TPVC234', N'PVC', 785.0000, N'Tubería')
GO
INSERT [dbo].[Sucursales] ([ID_Sucursal], [Nombre], [Dirección]) VALUES (N'SUTR01', N'Aguascalientes', N'Av. Héroe Inmortal #401')
INSERT [dbo].[Sucursales] ([ID_Sucursal], [Nombre], [Dirección]) VALUES (N'SUTR02', N'CDMX', N'Av. Revolucionarios #123')
INSERT [dbo].[Sucursales] ([ID_Sucursal], [Nombre], [Dirección]) VALUES (N'SUTR03', N'Guadalajara', N'Av. Tapatio #124')
INSERT [dbo].[Sucursales] ([ID_Sucursal], [Nombre], [Dirección]) VALUES (N'SUTR04', N'Monterrey', N'Av. Tigres #432')
INSERT [dbo].[Sucursales] ([ID_Sucursal], [Nombre], [Dirección]) VALUES (N'SUTR05', N'Morelia', N'Calle Carnes #32')
INSERT [dbo].[Sucursales] ([ID_Sucursal], [Nombre], [Dirección]) VALUES (N'SUTR06', N'Oaxaca', N'Calle Miguel #54')
INSERT [dbo].[Sucursales] ([ID_Sucursal], [Nombre], [Dirección]) VALUES (N'SUTR07', N'Tabasco', N'Oxigeno #43')
INSERT [dbo].[Sucursales] ([ID_Sucursal], [Nombre], [Dirección]) VALUES (N'SUTR08', N'Mazatlán', N'Marlin #789')
INSERT [dbo].[Sucursales] ([ID_Sucursal], [Nombre], [Dirección]) VALUES (N'SUTR09', N'Cancún', N'Rana #654')
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Clientes] FOREIGN KEY([RFCC])
REFERENCES [dbo].[Clientes] ([RFCC])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Clientes]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Empleados] FOREIGN KEY([RFCE])
REFERENCES [dbo].[Empleados] ([RFCE])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Empleados]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Sucursales] FOREIGN KEY([ID_Sucursal])
REFERENCES [dbo].[Sucursales] ([ID_Sucursal])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Sucursales]
GO
ALTER TABLE [dbo].[ComProd]  WITH CHECK ADD  CONSTRAINT [FK_ComProd_Compras] FOREIGN KEY([Folio])
REFERENCES [dbo].[Compras] ([Folio])
GO
ALTER TABLE [dbo].[ComProd] CHECK CONSTRAINT [FK_ComProd_Compras]
GO
ALTER TABLE [dbo].[ComProd]  WITH CHECK ADD  CONSTRAINT [FK_ComProd_Productos] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Productos] ([ID_Producto])
GO
ALTER TABLE [dbo].[ComProd] CHECK CONSTRAINT [FK_ComProd_Productos]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Sucursales] FOREIGN KEY([ID_Sucursal])
REFERENCES [dbo].[Sucursales] ([ID_Sucursal])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Sucursales]
GO
ALTER TABLE [dbo].[SucProd]  WITH CHECK ADD  CONSTRAINT [FK_SucProd_Productos] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Productos] ([ID_Producto])
GO
ALTER TABLE [dbo].[SucProd] CHECK CONSTRAINT [FK_SucProd_Productos]
GO
ALTER TABLE [dbo].[SucProd]  WITH CHECK ADD  CONSTRAINT [FK_SucProd_Sucursales] FOREIGN KEY([ID_Sucursal])
REFERENCES [dbo].[Sucursales] ([ID_Sucursal])
GO
ALTER TABLE [dbo].[SucProd] CHECK CONSTRAINT [FK_SucProd_Sucursales]
GO
USE [master]
GO
ALTER DATABASE [Truper] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [AtlantidaDev]    Script Date: 23/11/2016 20:18:48 ******/
CREATE DATABASE [AtlantidaDev]
ALTER DATABASE [AtlantidaDev] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AtlantidaDev].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AtlantidaDev] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AtlantidaDev] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AtlantidaDev] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AtlantidaDev] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AtlantidaDev] SET ARITHABORT OFF 
GO
ALTER DATABASE [AtlantidaDev] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [AtlantidaDev] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AtlantidaDev] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AtlantidaDev] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AtlantidaDev] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AtlantidaDev] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AtlantidaDev] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AtlantidaDev] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AtlantidaDev] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AtlantidaDev] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AtlantidaDev] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AtlantidaDev] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AtlantidaDev] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AtlantidaDev] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AtlantidaDev] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AtlantidaDev] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AtlantidaDev] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AtlantidaDev] SET RECOVERY FULL 
GO
ALTER DATABASE [AtlantidaDev] SET  MULTI_USER 
GO
ALTER DATABASE [AtlantidaDev] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AtlantidaDev] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AtlantidaDev] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AtlantidaDev] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [AtlantidaDev] SET DELAYED_DURABILITY = DISABLED 
GO
USE [AtlantidaDev]
GO
/****** Object:  Table [dbo].[Auditoria]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Auditoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[campo] [varchar](50) NULL,
	[usuario] [varchar](50) NULL,
	[entidad] [varchar](50) NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [PK_Auditoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Caja]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caja](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numeroCuenta] [int] NULL,
	[descripcion] [nvarchar](50) NULL,
	[monto] [float] NULL,
 CONSTRAINT [PK_Caja] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[codigoCliente] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](10) NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](20) NULL,
	[email] [varchar](50) NULL,
	[telefono] [varchar](20) NULL,
	[fechaNac] [date] NULL,
	[medioContacto] [bit] NULL,
	[inhibicion] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[codigoCliente] ASC,
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ClientePresupuesto]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientePresupuesto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigoCliente] [int] NOT NULL,
	[idPresupuesto] [int] NOT NULL,
 CONSTRAINT [PK_ClientePresupuesto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cobro]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cobro](
	[idCobro] [int] IDENTITY(1,1) NOT NULL,
	[idPresupuesto] [int] NOT NULL,
	[nroFactura] [int] NOT NULL,
	[monto] [float] NOT NULL,
	[ventaCancelada] [int] NULL,
	[nro_tarjeta] [nvarchar](50) NULL,
	[nro_cuenta] [nvarchar](50) NULL,
	[cuotas] [nvarchar](10) NULL,
	[interes] [int] NULL,
	[fechaCobro] [datetime] NOT NULL,
 CONSTRAINT [PK_Cobro] PRIMARY KEY CLUSTERED 
(
	[idCobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Disponibles]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disponibles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[destino] [nvarchar](15) NULL,
 CONSTRAINT [PK_Disponibles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hospedaje]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hospedaje](
	[idProvHos] [int] NOT NULL,
	[idCuentaCorriente] [int] NULL,
	[poseeCuentaCorriente] [bit] NOT NULL CONSTRAINT [DF__Hospedaje__posee__56E8E7AB]  DEFAULT ((0)),
	[razonSocial] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](100) NULL,
	[mail] [nvarchar](50) NULL,
	[reservaPendiente] [bit] NOT NULL CONSTRAINT [DF__Hospedaje__reser__57DD0BE4]  DEFAULT ((1)),
	[montoAPagar] [float] NOT NULL,
	[categoria] [int] NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Hospedaje] PRIMARY KEY CLUSTERED 
(
	[idProvHos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Operaciones]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operaciones](
	[idOp] [int] IDENTITY(1,1) NOT NULL,
	[idTransporte] [int] NOT NULL,
	[origen] [nvarchar](50) NULL,
	[destino] [nvarchar](50) NULL,
	[fechaIda] [date] NULL,
	[fechaVuelta] [date] NULL,
	[capacidad] [int] NOT NULL,
 CONSTRAINT [PK_Operaciones] PRIMARY KEY CLUSTERED 
(
	[idOp] ASC,
	[idTransporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pago]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago](
	[idPago] [int] IDENTITY(1,1) NOT NULL,
	[idPresupuesto] [int] NOT NULL,
	[montoTransporte] [int] NULL,
	[montoHospedaje] [int] NULL,
	[confirmacionPagoRealizado] [int] NOT NULL CONSTRAINT [DF__Pago__confirmaci__16CE6296]  DEFAULT ((0)),
	[fechaPago] [datetime] NULL,
 CONSTRAINT [PK_Pago] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PaquetesPromocionable]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PaquetesPromocionable](
	[idPaquetePromocionable] [int] IDENTITY(1,1) NOT NULL,
	[idProveedor] [int] NOT NULL,
	[origen] [varchar](50) NULL,
	[destino] [varchar](50) NULL,
	[fechaPartida] [date] NULL,
	[fechaRegreso] [date] NULL,
	[cantidadPasajero] [int] NULL,
	[monto] [float] NULL,
	[fechaCreacionPaquete] [date] NULL,
	[paqueteActivo] [int] NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_PaquetesPromocionable] PRIMARY KEY CLUSTERED 
(
	[idPaquetePromocionable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Presupuesto]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presupuesto](
	[idPresupuesto] [int] IDENTITY(1,1) NOT NULL,
	[codigoCliente] [nvarchar](50) NOT NULL,
	[legajo] [int] NOT NULL,
	[destino] [nvarchar](50) NOT NULL,
	[fechaPartida] [datetime] NULL,
	[fechaRegreso] [datetime] NULL,
	[pasajeros] [nvarchar](250) NULL,
	[idPaquetePromocionable] [int] NULL,
	[fechaCreacion] [datetime] NOT NULL,
	[estado] [nvarchar](20) NULL,
	[idPresupuestoTransporte] [int] NULL,
	[idPresupuestoHotel] [int] NULL,
 CONSTRAINT [PK_presupuesto] PRIMARY KEY CLUSTERED 
(
	[idPresupuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PresupuestoCobros]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PresupuestoCobros](
	[idCobros] [int] IDENTITY(1,1) NOT NULL,
	[idPresupuesto] [int] NOT NULL,
 CONSTRAINT [PK_PresupuestoCobros] PRIMARY KEY CLUSTERED 
(
	[idCobros] ASC,
	[idPresupuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PresupuestoHospedaje]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PresupuestoHospedaje](
	[idPresupuesto] [int] NOT NULL,
	[idProvHos] [int] NOT NULL,
 CONSTRAINT [PK_PresupuestoHospedaje] PRIMARY KEY CLUSTERED 
(
	[idPresupuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PresupuestoPago]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PresupuestoPago](
	[idPago] [int] IDENTITY(1,1) NOT NULL,
	[idPresupuesto] [int] NOT NULL,
 CONSTRAINT [PK_PresupuestoPago] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC,
	[idPresupuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PresupuestoPaquetePromocionable]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PresupuestoPaquetePromocionable](
	[idPresupuesto] [int] NOT NULL,
	[idPaquetePromocionable] [int] NOT NULL,
 CONSTRAINT [PK_PresupuestoPaquetePromocionable] PRIMARY KEY CLUSTERED 
(
	[idPresupuesto] ASC,
	[idPaquetePromocionable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PresupuestoTransporte]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PresupuestoTransporte](
	[idPresupuesto] [int] NOT NULL,
	[idProvTrans] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Bitacora]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Bitacora](
	[idEvento] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_tbl_Bitacora] PRIMARY KEY CLUSTERED 
(
	[idEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Grupo]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Grupo](
	[idGrupo] [int] NOT NULL,
	[grupo] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Grupo] PRIMARY KEY CLUSTERED 
(
	[idGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_GrupoPermisos]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_GrupoPermisos](
	[idGrupo] [int] NOT NULL,
	[idPermisos] [int] NOT NULL,
 CONSTRAINT [PK_tbl_GrupoPermisos] PRIMARY KEY CLUSTERED 
(
	[idGrupo] ASC,
	[idPermisos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_idioma]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_idioma](
	[ikey] [varchar](50) NOT NULL,
	[nombre] [nchar](10) NULL,
 CONSTRAINT [PK_tbl_idioma] PRIMARY KEY CLUSTERED 
(
	[ikey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_MultiIdioma]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_MultiIdioma](
	[componente] [varchar](25) NOT NULL,
	[ikey] [varchar](50) NOT NULL,
	[value] [varchar](60) NOT NULL,
 CONSTRAINT [PK_tbl_MultiIdioma] PRIMARY KEY CLUSTERED 
(
	[componente] ASC,
	[ikey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Permisos]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Permisos](
	[idPermiso] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Permisos] PRIMARY KEY CLUSTERED 
(
	[idPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Usuario]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Usuario](
	[idUsuario] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[legajo] [varchar](50) NOT NULL,
	[idioma] [varchar](50) NOT NULL,
	[digitoVerificador] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_UsuarioGrupo]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_UsuarioGrupo](
	[idUsuario] [int] NOT NULL,
	[idGrupo] [int] NOT NULL,
 CONSTRAINT [PK_tbl_UsuarioGrupo] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC,
	[idGrupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Vendedor]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Vendedor](
	[legajo] [int] NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[domicilio] [varchar](20) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_Vendedor] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Transferencias]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transferencias](
	[idTransferencia] [int] IDENTITY(1,1) NOT NULL,
	[idPresupuesto] [int] NULL,
	[idCuentaCorriente] [int] NULL,
	[monto] [int] NULL,
 CONSTRAINT [PK_Transferencias] PRIMARY KEY CLUSTERED 
(
	[idTransferencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transporte]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transporte](
	[idProvTrans] [int] NOT NULL,
	[idCuentaCorriente] [int] NOT NULL,
	[poseeCuentaCorriente] [bit] NOT NULL,
	[razonSocial] [nvarchar](30) NOT NULL,
	[direccion] [nvarchar](30) NULL,
	[poseeReservaPorMail] [bit] NOT NULL CONSTRAINT [DF__Transport__posee__634EBE90]  DEFAULT ((0)),
	[mail] [nvarchar](30) NULL,
	[montoAPagar] [float] NULL,
	[TipoTransporte] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Transporte] PRIMARY KEY CLUSTERED 
(
	[idProvTrans] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vendedorPresupuesto]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendedorPresupuesto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[legajo] [int] NOT NULL,
	[idPresupuesto] [int] NOT NULL,
 CONSTRAINT [PK_vendedorPresupuesto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 23/11/2016 20:18:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[idVentas] [int] IDENTITY(1,1) NOT NULL,
	[idPresupuesto] [int] NOT NULL,
	[fechaVenta] [date] NULL,
 CONSTRAINT [PK_Ventas_1] PRIMARY KEY CLUSTERED 
(
	[idVentas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Auditoria] ON 

INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (1, N'1', N'1', N'VENTAS', CAST(N'2016-08-30 00:13:48.693' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (2, N'1', N'1', N'VENTAS', CAST(N'2016-08-30 00:21:25.250' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (3, N'1', N'1', N'VENTAS', CAST(N'2016-08-30 00:21:48.637' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (4, NULL, N'1', N'VENTAS', CAST(N'2016-08-30 00:21:51.530' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (5, N'1', N'1', N'PRESUPUESTO', CAST(N'2016-09-06 23:27:28.457' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (6, N'1', N'1', N'PRESUPUESTO', CAST(N'2016-09-06 23:27:31.360' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (7, N'1', N'1', N'PRESUPUESTO', CAST(N'2016-09-06 23:28:13.710' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (8, N'1', N'1', N'PRESUPUESTO', CAST(N'2016-09-06 23:29:49.070' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (9, N'1', N'1', N'PRESUPUESTO', CAST(N'2016-09-06 23:29:50.850' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (10, N'1', N'1', N'PRESUPUESTO', CAST(N'2016-09-06 23:30:20.250' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (11, N'1', N'1', N'PRESUPUESTO', CAST(N'2016-09-06 23:31:58.530' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (12, N'0', N'1', N'PRESUPUESTO', CAST(N'2016-09-06 23:35:58.747' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (13, N'1', N'1', N'PRESUPUESTO', CAST(N'2016-09-08 20:52:32.007' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (14, N'1', N'1', N'PRESUPUESTO', CAST(N'2016-09-08 20:52:35.477' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (15, N'1', N'1', N'PRESUPUESTO', CAST(N'2016-09-08 20:53:45.253' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (16, N'21', N'1', N'PRESUPUESTO', CAST(N'2016-09-18 20:41:02.393' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (17, N'21', N'1', N'PRESUPUESTO', CAST(N'2016-09-18 20:41:45.433' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (18, N'21', N'1', N'PRESUPUESTO', CAST(N'2016-09-18 20:42:34.180' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (19, N'0', N'1', N'PAGO', CAST(N'2016-09-20 22:52:57.003' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (20, N'0', N'1', N'PAGO', CAST(N'2016-09-21 13:14:45.660' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (21, N'0', N'1', N'PAGO', CAST(N'2016-09-21 13:43:07.630' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (22, N'0', N'1', N'COBRO', CAST(N'2016-09-21 13:54:38.377' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (23, N'0', N'1', N'COBRO', CAST(N'2016-09-21 13:54:50.673' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (24, N'0', N'1', N'COBRO', CAST(N'2016-09-21 14:02:05.133' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (25, N'0', N'1', N'COBRO', CAST(N'2016-09-21 14:02:11.543' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (26, N'0', N'1', N'COBRO', CAST(N'2016-09-21 14:02:19.377' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (27, N'0', N'1', N'COBRO', CAST(N'2016-09-21 14:02:33.370' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (28, N'0', N'1', N'COBRO', CAST(N'2016-09-21 14:02:56.143' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (29, N'0', N'1', N'COBRO', CAST(N'2016-09-21 14:02:59.630' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (30, N'0', N'1', N'COBRO', CAST(N'2016-09-21 14:03:02.487' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (31, N'0', N'1', N'COBRO', CAST(N'2016-09-21 14:03:22.973' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (32, N'0', N'1', N'COBRO', CAST(N'2016-09-21 14:04:16.653' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (33, N'0', N'1', N'PAGO', CAST(N'2016-09-21 14:08:37.323' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (34, N'0', N'1', N'PAGO', CAST(N'2016-09-21 14:09:25.037' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (35, N'3', N'1', N'COBRO', CAST(N'2016-09-21 14:27:20.803' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (36, N'3', N'1', N'COBRO', CAST(N'2016-09-21 14:27:23.833' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (37, N'3', N'1', N'COBRO', CAST(N'2016-09-21 14:27:35.927' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (38, N'3', N'1', N'COBRO', CAST(N'2016-09-21 14:27:42.427' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (39, N'3', N'1', N'COBRO', CAST(N'2016-09-21 14:27:45.370' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (40, N'2', N'1', N'COBRO', CAST(N'2016-09-21 14:39:37.983' AS DateTime))
INSERT [dbo].[Auditoria] ([id], [campo], [usuario], [entidad], [fecha]) VALUES (41, N'0', N'0', N'IS_CONFIG', CAST(N'2017-01-01 00:00:01.983' AS DateTime))
SET IDENTITY_INSERT [dbo].[Auditoria] OFF
SET IDENTITY_INSERT [dbo].[Caja] ON 

INSERT [dbo].[Caja] ([id], [numeroCuenta], [descripcion], [monto]) VALUES (1, 123999, N'Caja Ahorro Atlantida', 10035439)
INSERT [dbo].[Caja] ([id], [numeroCuenta], [descripcion], [monto]) VALUES (2, 123888, N'Cuenta Corriente Atlantida', 200000.36)
SET IDENTITY_INSERT [dbo].[Caja] OFF
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([codigoCliente], [dni], [nombre], [apellido], [email], [telefono], [fechaNac], [medioContacto], [inhibicion]) VALUES (1, N'33199809', N'Angel', N'Prado', N'angelbrunn@gmail.com', N'116823374', CAST(N'1987-07-13' AS Date), NULL, 1)
INSERT [dbo].[Cliente] ([codigoCliente], [dni], [nombre], [apellido], [email], [telefono], [fechaNac], [medioContacto], [inhibicion]) VALUES (3, N'33123123', N'Mario', N'Lopez', N'mariilopez@gmail.com', N'45459876', CAST(N'1985-01-01' AS Date), NULL, 1)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[ClientePresupuesto] ON 

INSERT [dbo].[ClientePresupuesto] ([id], [codigoCliente], [idPresupuesto]) VALUES (1, 1, 1)
INSERT [dbo].[ClientePresupuesto] ([id], [codigoCliente], [idPresupuesto]) VALUES (2, 0, 55)
INSERT [dbo].[ClientePresupuesto] ([id], [codigoCliente], [idPresupuesto]) VALUES (3, 0, 56)
SET IDENTITY_INSERT [dbo].[ClientePresupuesto] OFF
SET IDENTITY_INSERT [dbo].[Cobro] ON 

INSERT [dbo].[Cobro] ([idCobro], [idPresupuesto], [nroFactura], [monto], [ventaCancelada], [nro_tarjeta], [nro_cuenta], [cuotas], [interes], [fechaCobro]) VALUES (1, 1, 1, 1, 1, NULL, NULL, NULL, NULL, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Cobro] ([idCobro], [idPresupuesto], [nroFactura], [monto], [ventaCancelada], [nro_tarjeta], [nro_cuenta], [cuotas], [interes], [fechaCobro]) VALUES (2, 46, 2, 11131, 2, N'123456', N'789987', N'3', 1431, CAST(N'2016-10-15 13:23:43.747' AS DateTime))
INSERT [dbo].[Cobro] ([idCobro], [idPresupuesto], [nroFactura], [monto], [ventaCancelada], [nro_tarjeta], [nro_cuenta], [cuotas], [interes], [fechaCobro]) VALUES (3, 47, 3, 15901, 1, NULL, NULL, NULL, NULL, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Cobro] ([idCobro], [idPresupuesto], [nroFactura], [monto], [ventaCancelada], [nro_tarjeta], [nro_cuenta], [cuotas], [interes], [fechaCobro]) VALUES (4, 50, 4, 15901, 1, NULL, NULL, NULL, NULL, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Cobro] ([idCobro], [idPresupuesto], [nroFactura], [monto], [ventaCancelada], [nro_tarjeta], [nro_cuenta], [cuotas], [interes], [fechaCobro]) VALUES (5, 51, 5, 13357, 2, N'888999870', N'344335555', N'3', 4007, CAST(N'2016-10-15 14:19:01.047' AS DateTime))
INSERT [dbo].[Cobro] ([idCobro], [idPresupuesto], [nroFactura], [monto], [ventaCancelada], [nro_tarjeta], [nro_cuenta], [cuotas], [interes], [fechaCobro]) VALUES (6, 52, 6, 13357, 1, N'123', N'456', N'6', 1717, CAST(N'2016-10-15 16:51:00.540' AS DateTime))
INSERT [dbo].[Cobro] ([idCobro], [idPresupuesto], [nroFactura], [monto], [ventaCancelada], [nro_tarjeta], [nro_cuenta], [cuotas], [interes], [fechaCobro]) VALUES (7, 53, 7, 13356, 3, N'8989898', N'123123', N'6', 4007, CAST(N'2016-10-24 22:05:45.523' AS DateTime))
INSERT [dbo].[Cobro] ([idCobro], [idPresupuesto], [nroFactura], [monto], [ventaCancelada], [nro_tarjeta], [nro_cuenta], [cuotas], [interes], [fechaCobro]) VALUES (8, 54, 8, 19080, 3, NULL, NULL, NULL, NULL, CAST(N'2016-10-24 22:12:09.193' AS DateTime))
INSERT [dbo].[Cobro] ([idCobro], [idPresupuesto], [nroFactura], [monto], [ventaCancelada], [nro_tarjeta], [nro_cuenta], [cuotas], [interes], [fechaCobro]) VALUES (9, 55, 9, 19080, 3, NULL, NULL, NULL, NULL, CAST(N'2016-10-28 22:08:43.617' AS DateTime))
INSERT [dbo].[Cobro] ([idCobro], [idPresupuesto], [nroFactura], [monto], [ventaCancelada], [nro_tarjeta], [nro_cuenta], [cuotas], [interes], [fechaCobro]) VALUES (10, 56, 10, 19080, 0, NULL, NULL, NULL, NULL, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Cobro] OFF
SET IDENTITY_INSERT [dbo].[Disponibles] ON 

INSERT [dbo].[Disponibles] ([id], [destino]) VALUES (1, N'(MIA)-Miami')
INSERT [dbo].[Disponibles] ([id], [destino]) VALUES (2, N'(BUE)-Bs As')
INSERT [dbo].[Disponibles] ([id], [destino]) VALUES (3, N'(BRC)-Barcelona')
INSERT [dbo].[Disponibles] ([id], [destino]) VALUES (4, N'(LIM)-Lima')
SET IDENTITY_INSERT [dbo].[Disponibles] OFF
INSERT [dbo].[Hospedaje] ([idProvHos], [idCuentaCorriente], [poseeCuentaCorriente], [razonSocial], [direccion], [mail], [reservaPendiente], [montoAPagar], [categoria], [descripcion]) VALUES (1, 123777, 1, N'THE CASABLANCA ON THE OCEAN HOTEL', N' 6345 Collins Ave, Miami Beach, FL 33141, United States', N'casablanca@gmail.com', 1, 5000, 5, N'Hote 5 Estrellas Miami Beach')
SET IDENTITY_INSERT [dbo].[Operaciones] ON 

INSERT [dbo].[Operaciones] ([idOp], [idTransporte], [origen], [destino], [fechaIda], [fechaVuelta], [capacidad]) VALUES (1, 1, N'(BUE)-Bs As', N'(MIA)-Miami', CAST(N'2017-01-01' AS Date), CAST(N'2017-01-15' AS Date), 36)
INSERT [dbo].[Operaciones] ([idOp], [idTransporte], [origen], [destino], [fechaIda], [fechaVuelta], [capacidad]) VALUES (3, 1, N'(BUE)-Bs As', N'(BRC)-Barcelona', CAST(N'2017-01-01' AS Date), CAST(N'2017-01-28' AS Date), 25)
INSERT [dbo].[Operaciones] ([idOp], [idTransporte], [origen], [destino], [fechaIda], [fechaVuelta], [capacidad]) VALUES (5, 2, N'(BUE)-Bs As', N'(MIA)-Miami', CAST(N'2017-01-05' AS Date), CAST(N'2017-01-15' AS Date), 20)
INSERT [dbo].[Operaciones] ([idOp], [idTransporte], [origen], [destino], [fechaIda], [fechaVuelta], [capacidad]) VALUES (7, 2, N'(LIM)-Lima', N'(BUE)-Bs As', CAST(N'2017-01-15' AS Date), CAST(N'2017-01-20' AS Date), 60)
SET IDENTITY_INSERT [dbo].[Operaciones] OFF
SET IDENTITY_INSERT [dbo].[Pago] ON 

INSERT [dbo].[Pago] ([idPago], [idPresupuesto], [montoTransporte], [montoHospedaje], [confirmacionPagoRealizado], [fechaPago]) VALUES (1, 1, 0, 0, 0, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Pago] ([idPago], [idPresupuesto], [montoTransporte], [montoHospedaje], [confirmacionPagoRealizado], [fechaPago]) VALUES (2, 46, 10900, 5000, 0, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Pago] ([idPago], [idPresupuesto], [montoTransporte], [montoHospedaje], [confirmacionPagoRealizado], [fechaPago]) VALUES (3, 47, 10900, 5000, 0, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Pago] ([idPago], [idPresupuesto], [montoTransporte], [montoHospedaje], [confirmacionPagoRealizado], [fechaPago]) VALUES (4, 50, 10900, 5000, 0, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Pago] ([idPago], [idPresupuesto], [montoTransporte], [montoHospedaje], [confirmacionPagoRealizado], [fechaPago]) VALUES (5, 51, 10900, 5000, 1, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Pago] ([idPago], [idPresupuesto], [montoTransporte], [montoHospedaje], [confirmacionPagoRealizado], [fechaPago]) VALUES (6, 52, 10900, 5000, 3, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Pago] ([idPago], [idPresupuesto], [montoTransporte], [montoHospedaje], [confirmacionPagoRealizado], [fechaPago]) VALUES (7, 53, 10900, 5000, 2, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Pago] ([idPago], [idPresupuesto], [montoTransporte], [montoHospedaje], [confirmacionPagoRealizado], [fechaPago]) VALUES (8, 54, 10900, 5000, 2, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Pago] ([idPago], [idPresupuesto], [montoTransporte], [montoHospedaje], [confirmacionPagoRealizado], [fechaPago]) VALUES (9, 55, 0, 0, 5, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Pago] ([idPago], [idPresupuesto], [montoTransporte], [montoHospedaje], [confirmacionPagoRealizado], [fechaPago]) VALUES (10, 56, 10900, 5000, 0, CAST(N'2016-01-01 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Pago] OFF
SET IDENTITY_INSERT [dbo].[PaquetesPromocionable] ON 

INSERT [dbo].[PaquetesPromocionable] ([idPaquetePromocionable], [idProveedor], [origen], [destino], [fechaPartida], [fechaRegreso], [cantidadPasajero], [monto], [fechaCreacionPaquete], [paqueteActivo], [descripcion]) VALUES (1, 1, N'(BUE)-Bs As', N'(MIA)-Miami', CAST(N'2017-01-01' AS Date), CAST(N'2017-01-10' AS Date), 14, 15900.99, CAST(N'2016-08-24' AS Date), 1, N'10 dias en Miami.')
SET IDENTITY_INSERT [dbo].[PaquetesPromocionable] OFF
SET IDENTITY_INSERT [dbo].[Presupuesto] ON 

INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (1, N'1', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-10 00:00:00.000' AS DateTime), NULL, 1, CAST(N'2016-08-24 00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (2, N'0', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-10 00:00:00.000' AS DateTime), NULL, 1, CAST(N'2016-09-06 23:36:44.510' AS DateTime), N'SRES', NULL, NULL)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (3, N'3', 1, N'(BUE)-Bs As', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-10 00:00:00.000' AS DateTime), NULL, 1, CAST(N'2016-09-08 13:53:58.960' AS DateTime), N'SRES', NULL, NULL)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (4, N'1', 1, N'(BUE)-Bs As', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-10 00:00:00.000' AS DateTime), NULL, 1, CAST(N'2016-09-08 13:55:52.907' AS DateTime), N'SRES', NULL, NULL)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (5, N'1', 1, N'(BUE)-Bs As', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-10 00:00:00.000' AS DateTime), NULL, 1, CAST(N'2016-09-08 13:58:57.253' AS DateTime), N'SRES', NULL, NULL)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (6, N'1', 1, N'(BUE)-Bs As', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-10 00:00:00.000' AS DateTime), NULL, 1, CAST(N'2016-09-08 14:00:56.793' AS DateTime), N'SRES', NULL, NULL)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (7, N'1', 1, N'(BUE)-Bs As', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-10 00:00:00.000' AS DateTime), NULL, 1, CAST(N'2016-09-09 21:56:49.350' AS DateTime), N'SRES', NULL, NULL)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (8, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-10 00:00:00.000' AS DateTime), N'Mario Lopez', 1, CAST(N'2016-09-10 22:48:22.463' AS DateTime), N'SRES', NULL, NULL)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (9, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-12 23:04:11.030' AS DateTime), N'SRES', NULL, NULL)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (10, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-12 23:06:31.550' AS DateTime), N'SRES', NULL, NULL)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (18, N'1', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Angel Prado', 0, CAST(N'2016-09-13 23:09:06.173' AS DateTime), N'SRES', 0, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (19, N'1', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Angel Prado', 0, CAST(N'2016-09-13 23:56:54.187' AS DateTime), N'SRES', 0, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (20, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-18 20:23:22.613' AS DateTime), N'SRES', 0, 0)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (21, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-18 20:35:38.837' AS DateTime), N'CAN', 1, 0)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (22, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-18 22:11:17.627' AS DateTime), N'SRES-INT', 1, 0)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (23, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-18 22:16:09.177' AS DateTime), N'SRES-INT', 1, 0)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (24, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-18 22:32:26.123' AS DateTime), N'SRES-INT', 1, 0)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (25, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-20 21:44:21.557' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (26, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-20 22:04:31.900' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (27, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-20 22:12:39.207' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (28, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-20 22:14:11.363' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (29, N'1', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Angel Prado', 0, CAST(N'2016-09-20 22:26:34.973' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (30, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-20 22:32:34.970' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (31, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-20 22:35:33.027' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (32, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-20 22:51:00.043' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (33, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 13:03:52.770' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (34, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 13:08:08.800' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (35, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 13:11:32.817' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (36, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 13:14:01.503' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (37, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 13:39:20.187' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (38, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 13:42:24.587' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (39, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 13:49:06.857' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (40, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 13:56:57.100' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (41, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 13:59:14.957' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (42, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 14:00:40.130' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (43, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 14:07:56.897' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (44, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 14:17:34.863' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (45, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 14:21:11.213' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (46, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-09-21 14:30:37.810' AS DateTime), N'CAN', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (47, N'1', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Angel Prado', 0, CAST(N'2016-10-12 23:25:13.103' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (48, N'1', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Angel Prado', 0, CAST(N'2016-10-12 23:50:01.210' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (49, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-10-13 00:03:13.527' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (50, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez', 0, CAST(N'2016-10-13 00:11:22.653' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (51, N'1', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Angel Prado', 0, CAST(N'2016-10-15 13:47:08.263' AS DateTime), N'SRES-INT-INH', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (52, N'1', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Angel Prado', 0, CAST(N'2016-10-15 15:10:47.880' AS DateTime), N'CAN', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (53, N'1', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Angel Prado', 0, CAST(N'2016-10-15 16:03:22.713' AS DateTime), N'PAGO', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (54, N'1', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Angel Prado 33199809 | Mario Lopez 33123123', 0, CAST(N'2016-10-24 20:57:45.730' AS DateTime), N'PAGO', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (55, N'3', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Mario Lopez 33123123', 0, CAST(N'2016-10-28 22:07:10.353' AS DateTime), N'PAGO', 1, 1)
INSERT [dbo].[Presupuesto] ([idPresupuesto], [codigoCliente], [legajo], [destino], [fechaPartida], [fechaRegreso], [pasajeros], [idPaquetePromocionable], [fechaCreacion], [estado], [idPresupuestoTransporte], [idPresupuestoHotel]) VALUES (56, N'1', 1, N'(MIA)-Miami', CAST(N'2017-01-01 00:00:00.000' AS DateTime), CAST(N'2017-01-15 00:00:00.000' AS DateTime), N'Angel Prado 33199809', 0, CAST(N'2016-11-07 23:59:08.330' AS DateTime), N'SRES-INT-INH', 1, 1)
SET IDENTITY_INSERT [dbo].[Presupuesto] OFF
SET IDENTITY_INSERT [dbo].[PresupuestoCobros] ON 

INSERT [dbo].[PresupuestoCobros] ([idCobros], [idPresupuesto]) VALUES (1, 1)
INSERT [dbo].[PresupuestoCobros] ([idCobros], [idPresupuesto]) VALUES (2, 46)
INSERT [dbo].[PresupuestoCobros] ([idCobros], [idPresupuesto]) VALUES (3, 47)
INSERT [dbo].[PresupuestoCobros] ([idCobros], [idPresupuesto]) VALUES (4, 50)
INSERT [dbo].[PresupuestoCobros] ([idCobros], [idPresupuesto]) VALUES (5, 51)
INSERT [dbo].[PresupuestoCobros] ([idCobros], [idPresupuesto]) VALUES (6, 52)
INSERT [dbo].[PresupuestoCobros] ([idCobros], [idPresupuesto]) VALUES (7, 53)
INSERT [dbo].[PresupuestoCobros] ([idCobros], [idPresupuesto]) VALUES (8, 54)
INSERT [dbo].[PresupuestoCobros] ([idCobros], [idPresupuesto]) VALUES (9, 55)
INSERT [dbo].[PresupuestoCobros] ([idCobros], [idPresupuesto]) VALUES (10, 56)
SET IDENTITY_INSERT [dbo].[PresupuestoCobros] OFF
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (1, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (2, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (3, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (4, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (5, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (6, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (7, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (8, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (9, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (10, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (11, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (12, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (13, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (14, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (15, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (16, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (17, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (18, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (19, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (20, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (21, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (22, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (23, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (24, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (25, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (26, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (27, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (28, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (29, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (30, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (31, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (50, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (51, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (52, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (53, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (54, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (55, 1)
INSERT [dbo].[PresupuestoHospedaje] ([idPresupuesto], [idProvHos]) VALUES (56, 1)
SET IDENTITY_INSERT [dbo].[PresupuestoPago] ON 

INSERT [dbo].[PresupuestoPago] ([idPago], [idPresupuesto]) VALUES (1, 1)
INSERT [dbo].[PresupuestoPago] ([idPago], [idPresupuesto]) VALUES (2, 46)
INSERT [dbo].[PresupuestoPago] ([idPago], [idPresupuesto]) VALUES (3, 47)
INSERT [dbo].[PresupuestoPago] ([idPago], [idPresupuesto]) VALUES (4, 50)
INSERT [dbo].[PresupuestoPago] ([idPago], [idPresupuesto]) VALUES (5, 51)
INSERT [dbo].[PresupuestoPago] ([idPago], [idPresupuesto]) VALUES (6, 52)
INSERT [dbo].[PresupuestoPago] ([idPago], [idPresupuesto]) VALUES (7, 53)
INSERT [dbo].[PresupuestoPago] ([idPago], [idPresupuesto]) VALUES (8, 54)
INSERT [dbo].[PresupuestoPago] ([idPago], [idPresupuesto]) VALUES (9, 55)
INSERT [dbo].[PresupuestoPago] ([idPago], [idPresupuesto]) VALUES (10, 56)
SET IDENTITY_INSERT [dbo].[PresupuestoPago] OFF
INSERT [dbo].[PresupuestoPaquetePromocionable] ([idPresupuesto], [idPaquetePromocionable]) VALUES (1, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (1, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (4, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (5, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (6, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (10, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (11, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (12, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (13, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (14, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (16, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (17, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (18, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (19, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (20, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (21, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (22, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (23, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (24, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (25, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (26, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (27, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (28, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (29, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (30, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (31, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (32, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (33, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (34, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (35, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (36, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (37, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (38, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (39, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (40, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (41, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (42, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (43, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (44, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (7, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (8, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (9, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (15, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (50, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (51, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (52, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (53, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (55, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (56, 1)
INSERT [dbo].[PresupuestoTransporte] ([idPresupuesto], [idProvTrans]) VALUES (54, 1)
INSERT [dbo].[tbl_Bitacora] ([idEvento], [idUsuario], [descripcion], [fecha]) VALUES (1, 2, N'BKPException:Probando desde depuracion,insercion de Trazas.', CAST(N'2016-07-21 23:42:35.693' AS DateTime))
INSERT [dbo].[tbl_Bitacora] ([idEvento], [idUsuario], [descripcion], [fecha]) VALUES (2, 2, N'BLLExcepcion:Probando desde depuracion,insercion de Trazas.', CAST(N'2016-07-21 23:42:35.950' AS DateTime))
INSERT [dbo].[tbl_Bitacora] ([idEvento], [idUsuario], [descripcion], [fecha]) VALUES (3, 2, N'DALExcepcion:Probando desde depuracion,insercion de Trazas.', CAST(N'2016-07-21 23:42:36.070' AS DateTime))
INSERT [dbo].[tbl_Bitacora] ([idEvento], [idUsuario], [descripcion], [fecha]) VALUES (4, 2, N'IOException:Probando desde depuracion,insercion de Trazas.', CAST(N'2016-07-21 23:42:36.177' AS DateTime))
INSERT [dbo].[tbl_Bitacora] ([idEvento], [idUsuario], [descripcion], [fecha]) VALUES (5, 2, N'SEGExcepcion:Probando desde depuracion,insercion de Trazas.', CAST(N'2016-07-21 23:42:36.297' AS DateTime))
INSERT [dbo].[tbl_Grupo] ([idGrupo], [grupo], [descripcion]) VALUES (1, N'Admin', N'Administrador del Sistema')
INSERT [dbo].[tbl_Grupo] ([idGrupo], [grupo], [descripcion]) VALUES (2, N'Vendedor', N'Perfil Vendedor')
INSERT [dbo].[tbl_Grupo] ([idGrupo], [grupo], [descripcion]) VALUES (3, N'Jerarquico', N'Perfil Vendedor Jerarquico')
INSERT [dbo].[tbl_GrupoPermisos] ([idGrupo], [idPermisos]) VALUES (1, 1)
INSERT [dbo].[tbl_GrupoPermisos] ([idGrupo], [idPermisos]) VALUES (1, 2)
INSERT [dbo].[tbl_GrupoPermisos] ([idGrupo], [idPermisos]) VALUES (1, 3)
INSERT [dbo].[tbl_GrupoPermisos] ([idGrupo], [idPermisos]) VALUES (2, 2)
INSERT [dbo].[tbl_GrupoPermisos] ([idGrupo], [idPermisos]) VALUES (3, 2)
INSERT [dbo].[tbl_GrupoPermisos] ([idGrupo], [idPermisos]) VALUES (3, 3)
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_acciones', N'es', N'Acciones')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_cliente', N'en', N'Passenger Data')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_cliente', N'es', N'Datos del Pasajero')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_cliente_deuda', N'en', N'Validate customer debt')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_cliente_deuda', N'es', N'Validar deuda cliente')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_consultas', N'en', N'Quets')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_consultas', N'es', N'Consultas')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_disponibilidad', N'en', N'Availability')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_disponibilidad', N'es', N'Disponibilidad')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_encuesta', N'en', N'Survey passages')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_encuesta', N'es', N'Encuesta pasajes')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_estadoOP', N'en', N'List_estateOP')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_estadoOP', N'es', N'List_estadoOP')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_formulario_pago', N'en', N'Payment Form')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_formulario_pago', N'es', N'Formulario de pago')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_guardar_enc', N'en', N'Save Survey')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_guardar_enc', N'es', N'Guardar Encuesta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_hospedaje', N'en', N'Available hosting')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_hospedaje', N'es', N'Hospedaje disponible')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_metrica', N'en', N'Metrics')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_metrica', N'es', N'Metricas')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pagos_pend', N'en', N'Pending payments')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pagos_pend', N'es', N'Pagos Pendientes')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_1', N'en', N'I got availability you wanted?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_1', N'es', N'Obtuvo  la disponibilidad que deseaba?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_2', N'en', N'How many purchases made with us?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_2', N'es', N'Cuantas compras hizo con nosotros?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_3', N'en', N'What is your degree of satisfaction with the services?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_3', N'es', N'Cual es su grado de satisfaccion con el servicios?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_4', N'en', N'Would buy passenger service?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_4', N'es', N'Volveria a comprar el servicio de pasaje?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_5', N'en', N'Which is their degree of satisfaction with the seller?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_5', N'es', N'Cual es su grado de satisfaccion con el vendedor?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_6', N'en', N'I had problems when the accreditation?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_pregunta_6', N'es', N'Tuvo inconvenientes a la hora de la acreditacion?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_presupuesto', N'en', N'Not package promotion')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_presupuesto', N'es', N'Paquete No promocionable')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_result', N'en', N'Budget')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_result', N'es', N'Presupuesto')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_resultado_deuda', N'en', N'Result Debt')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_resultado_deuda', N'es', N'Resultado Deuda')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_resultadodisp', N'en', N'Visualizer Package')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'box_resultadodisp', N'es', N'Visualizar Paquete')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_alta', N'en', N'Hight')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_alta', N'es', N'Alta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_asignar', N'en', N'To assign')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_asignar', N'es', N'Asignar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_baja', N'en', N'Down')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_baja', N'es', N'Baja')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_bitacoraCSV', N'en', N'Try Bitacora CSV')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_bitacoraCSV', N'es', N'Probar Bitacora CSV')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_BorrarVendedor', N'en', N'Delete Seller')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_BorrarVendedor', N'es', N'Borrar Vendedor')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Buscar', N'en', N'Search')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Buscar', N'es', N'Busar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_cancelar', N'en', N'Cancel')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_cancelar', N'es', N'Cancelar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_carga', N'en', N'Load')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_carga', N'es', N'Cargar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_cargar', N'en', N'Load')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_cargar', N'es', N'Cargar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_clientes_frec', N'en', N'Frequent customers')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_clientes_frec', N'es', N'Clientes Frecuentes')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_consistenciaBD', N'en', N'Consistency Test BD')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_consistenciaBD', N'es', N'Probar Consistencia BD')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_cotizar', N'en', N'Quote')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_cotizar', N'es', N'Cotizar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_DesSeleccionarTodo', N'en', N'Deselected All')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_DesSeleccionarTodo', N'es', N'Des-Seleccionar Todo')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_digitoVerificador', N'en', N'Check Digit Test')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_digitoVerificador', N'es', N'Probar Digito Verificador')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_disponibilidad', N'en', N'Availability')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_disponibilidad', N'es', N'Disponibilidad')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Espanol', N'en', N'Spanish')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Espanol', N'es', N'EspaÃ±ol')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Exportar', N'en', N'Export')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Exportar', N'es', N'Exportar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_generapresu', N'en', N'BUDGET generate.')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_generapresu', N'es', N'Generar Presup.')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_GenerarUsuario', N'en', N'Generate User')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_GenerarUsuario', N'es', N'Generar Usuario')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_guardar', N'en', N'Save')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_guardar', N'es', N'Guardar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_HabilitarBusqueda', N'en', N'Enable Search')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_HabilitarBusqueda', N'es', N'Habilitar Busqueda')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_hospedaje', N'en', N'Get Hosting')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_hospedaje', N'es', N'Obtener Hospedaje')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Importar', N'en', N'Import')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Importar', N'es', N'Importar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_imprimir_voucher', N'en', N'Print Voucher')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_imprimir_voucher', N'es', N'Imprimir Voucher')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Ingles', N'en', N'English')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Ingles', N'es', N'Ingles')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_ini', N'en', N'Start')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_ini', N'es', N'Iniciar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_InsertarBitacora', N'en', N'Insert to Log')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_InsertarBitacora', N'es', N'Insertar en Bitacora')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_InsertarUsuario', N'en', N'Insert User')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_InsertarUsuario', N'es', N'Insertar Usuario')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_mas_vendidos', N'en', N'Destinations Bestsellers')
GO
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_mas_vendidos', N'es', N'Destinos Mas Vendidos')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_menos_vendidos', N'en', N'Less destinations Sold')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_menos_vendidos', N'es', N'Destinos Menos Vendidos')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_modificacion', N'en', N'Modification')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_modificacion', N'es', N'Modificacion')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Modificar', N'en', N'Save Changes')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Modificar', N'es', N'Guardar Cambios')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Nuevo', N'en', N'New')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_Nuevo', N'es', N'Nuevo')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_obtPaqNoProm', N'en', N'Get Package NoProm.')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_obtPaqNoProm', N'es', N'Obtener Paquetes No Prom.')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_obtPaqProm', N'en', N'Get Prom Packages.')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_obtPaqProm', N'es', N'Obtener Paquetes Prom.')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_ok', N'en', N'Okay')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_ok', N'es', N'Ok')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_pagar', N'en', N'Pay')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_pagar', N'es', N'Pagar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_refrescar', N'en', N'Refresh')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_refrescar', N'es', N'Refrescar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_reserva', N'en', N'Reserve')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_reserva', N'es', N'Reservar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_salir', N'en', N'Exit')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_salir', N'es', N'Salir')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_seleccionar', N'en', N'Select')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_seleccionar', N'es ', N'Seleccionar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_SeleccionarTodo', N'en', N'Select All')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_SeleccionarTodo', N'es', N'Seleccionar Todo')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_solicitarPax', N'en', N'Request Conf.payment')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_solicitarPax', N'es', N'Solicitar Conf.Pago')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_terminaop', N'en', N'finish OP')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_terminaop', N'es', N'Terminar OP')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_terminar_op', N'en', N'Finish Operacion')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_terminar_op', N'es', N'Terminar Operacion')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_transferencia', N'en', N'Transfer')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_transferencia', N'es', N'Transferencia')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_validar', N'en', N'Validate')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_validar', N'es', N'Validar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_validar_voucher', N'en', N'Validate Voucher')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'btn_validar_voucher', N'es', N'Validar Voucher')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_Activo', N'en', N'Active')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_Activo', N'es', N'Activo')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_avion', N'en', N'Airplane')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_avion', N'es', N'Avion')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_bus', N'en', N'Bus')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_bus', N'es', N'Bus')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_crucero', N'en', N'Cruise')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_crucero', N'es', N'Crucero')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_Inactivo', N'en', N'Inactive')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_Inactivo', N'es', N'Inactivo')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_tren', N'en', N'Train')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chk_tren', N'es', N'Tren')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxBitacora', N'en', N'TB_Bitacora')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxBitacora', N'es', N'TB_Bitacora')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxCobro', N'es', N'TB_Cobro')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxGrupo', N'en', N'TB_Grupo')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxGrupo', N'es', N'TB_Grupo')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxGrupoPermiso', N'en', N'TB_GrupoPermiso')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxGrupoPermiso', N'es', N'TB_GrupoPermiso')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxMultiIdioma', N'en', N'TB_MultiIdioma')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxMultiIdioma', N'es', N'TB_MultiIdioma')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxPago', N'en', N'TB_Pago')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxPago', N'es', N'TB_Pago')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxPermiso', N'en', N'TB_Permiso')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxPermiso', N'es', N'TB_Permiso')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxPresupuesto', N'en', N'TB_Presupuesto')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxPresupuesto', N'es', N'TB_Presupuesto')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxUsuario', N'en', N'TB_Usuario')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxUsuario', N'es', N'TB_Usuario')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxUsuarioGrupo', N'en', N'TB_UsuarioGrupo')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxUsuarioGrupo', N'es', N'TB_UsuarioGrupo')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxVendedor', N'en', N'TB_Vendedor')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'chkbxVendedor', N'es', N'TB_Vendedor')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ChkPagoToT', N'en', N'Total')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ChkPagoToT', N'es', N'Total')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ChkReserva', N'en', N'Reserve')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ChkReserva', N'es', N'Reserva')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box1', N'en', N'Yes')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box1', N'es', N'Si')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box2', N'en', N'Only one')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box2', N'es', N'Solo una')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box3', N'en', N'Excelent')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box3', N'es', N'Excelente')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box4', N'en', N'Yes,sure!')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box4', N'es', N'Si,seguro!')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box5', N'en', N'Excelent')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box5', N'es', N'Excelente')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box6', N'en', N'Not problem!')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck1_box6', N'es', N'No hubo problema!')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box1', N'en', N'I had to move date or time')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box1', N'es', N'Tuve que mover fecha u horario')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box2', N'en', N'less than 5')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box2', N'es', N'Menos de 5')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box3', N'en', N'Good')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box3', N'es', N'Buena')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box4', N'en', N'I do not know')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box4', N'es', N'No lo se')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box5', N'en', N'Good')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box5', N'es', N'Buena')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box6', N'en', N'It took, but everything went well')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck2_box6', N'es', N'Tardaron, pero todo salio bien')
GO
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box1', N'en', N'Not')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box1', N'es', N'No')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box2', N'en', N'More than 5')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box2', N'es', N'Mas de 5')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box3', N'en', N'Little satisfactory')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box3', N'es', N'Poca satisfactoria')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box4', N'en', N'Not')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box4', N'es', N'No')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box5', N'en', N'Little satisfactory')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box5', N'es', N'Poca satisfactoria')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box6', N'en', N'I could not obtain accreditation')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ck3_box6', N'es', N'No pude acreditarme')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_ayuda', N'en', N'Help')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_ayuda', N'es', N'Ayuda')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_backup', N'en', N'Backup')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_backup', N'es', N'Resguardo')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_cliente', N'en', N'Set Client')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_cliente', N'es', N'Ingresar cliente')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_cobro', N'en', N'collection')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_cobro', N'es', N'Cobro')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_cuenta', N'en', N'Enter the account details')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_cuenta', N'es', N'Ingrese datos de la cuenta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_debug', N'en', N'Debug')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_debug', N'es', N'Depuracion')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_encuesta', N'en', N'Survey')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_encuesta', N'es', N'Encuesta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_hospedaje', N'en', N'Hotel')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_hospedaje', N'es', N'Hospedaje')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_idioma', N'en', N'Lenguage')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_idioma', N'es', N'Idioma')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_metrica', N'en', N'Metrics')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_metrica', N'es', N'Metricas')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_pago', N'en', N'Payment')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_pago', N'es', N'Pago')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_PaqNoProm', N'en', N'Package Not Promotable')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_PaqNoProm', N'es', N'Paquete No Promocionable')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_presupuesto', N'en', N'Budget')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_presupuesto', N'es', N'Presupuesto')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_tarjeta', N'en', N'Enter card details')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_tarjeta', N'es', N'Ingresar datos de la tarjeta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_usuario', N'en', N'User')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'frm_usuario', N'es', N'Usuario')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'gpx_buscarUs', N'en', N'Search User')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'gpx_buscarUs', N'es', N'Buscar Usuario')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'gpx_Idioma', N'en', N'Lenguaje')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'gpx_Idioma', N'es', N'Idioma')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'gpx_nuevoUs', N'en', N'New User')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'gpx_nuevoUs', N'es', N'Nuevo Usuario')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'grp_Estado', N'en', N'Status')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'grp_Estado', N'es', N'Estado')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ini', N'en', N'ini')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'ini', N'es', N'ini')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_apellido', N'en', N'Last Name')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_apellido', N'es', N'Apellido')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_apellidoUs', N'en', N'Last Name:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_apellidoUs', N'es', N'Apellido:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_asiento', N'en', N'Seat')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_asiento', N'es', N'Asiento')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_banco', N'en', N'Bank')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_banco', N'es', N'Banco')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_banco_b', N'en', N'Bank')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_banco_b', N'es', N'Banco')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cantidad', N'en', N'Quantity')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cantidad', N'es', N'Cantidad')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_chIdioma', N'en', N'Select Lenguage')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_chIdioma', N'es', N'Elegir Idioma')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cliente1', N'en', N'Customer Number 1')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cliente1', N'es', N'Cliente Numero 1')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cliente2', N'en', N'Custumer Number 2')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cliente2', N'es', N'Cliente Numero 2')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cliente3', N'en', N'Customer Number 3')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cliente3', N'es', N'Cliente Numero 3')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cliente4', N'en', N'Customer Number 4')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cliente4', N'es', N'Cliente Numero 4')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cliente5', N'en', N'Customer Number 5')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_cliente5', N'es', N'Cliente Numero 5')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_codseguridad', N'en', N'Security Code')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_codseguridad', N'es', N'Cod.Seguridad')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_contraseÃ±a', N'en', N'Password')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_contraseÃ±a', N'es', N'ContraseÃ±a')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_contrasena', N'en', N'Password:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_contrasena', N'es', N'ContraseÃ±a: ')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_dato_cuenta', N'en', N'Account data')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_dato_cuenta', N'es', N'Datos de la cuenta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_datos_tarjeta', N'en', N'Card data')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_datos_tarjeta', N'es', N'Datos de la tarjeta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_del', N'en', N'Delimiter:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_del', N'es', N'Delimitador:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_descGrupo', N'en', N'Description Group:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_descGrupo', N'es', N'Descripcion Grupo:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_destino', N'en', N'Destination')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_destino', N'es', N'Destino')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_dni', N'en', N'Segurity Number')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_dni', N'es', N'Nro dni ')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_domicilio', N'en', N'Address:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_domicilio', N'es', N'Domicilio:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_email', N'en', N'Email')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_email', N'es', N'Mail')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_fechIda', N'en', N'Go Date ')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_fechIda', N'es', N'Fecha Ida')
GO
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_fechvenc', N'en', N'Date Exp.')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_fechvenc', N'es', N'Fecha Venc.')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_fechVue', N'en', N'Return Date')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_fechVue', N'es', N'Fecha Vuelta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_fecNac', N'en', N'Date of birth:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_fecNac', N'es', N'Fecha de Nac:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_fecNat', N'en', N'Birthday')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_fecNat', N'es', N'Fech.Nac.')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_forma_pago', N'en', N'Way to pay')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_forma_pago', N'es', N'Forma de pago')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_grupoDispo', N'en', N'Available groups:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_grupoDispo', N'es', N'Grupos Disponibles:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_idPres', N'en', N'Id.Budget')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_idPres', N'es', N'Id.Presupuesto')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_idUsuario', N'en', N'User id')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_idUsuario', N'es', N'idUsuario')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_importe', N'en', N'Amount')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_importe', N'es', N'Importe')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_legajo', N'en', N'File:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_legajo', N'es', N'Legajo:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_mail', N'en', N'Email')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_mail', N'es', N'Email')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_nombre', N'en', N'Name')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_nombre', N'es', N'Nombre')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_nombreUs', N'en', N'Name:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_nombreUs', N'es', N'Nombre:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_nrodni', N'en', N'Segurity  Number')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_nrodni', N'es', N'Nro dni')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_nrotarjeta', N'en', N'Card Number')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_nrotarjeta', N'es', N'Nro de la tarjeta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_num_cuenta', N'en', N'Account Number')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_num_cuenta', N'es', N'Numero cuenta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_num_cuenta_b', N'en', N'Account Number')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_num_cuenta_b', N'es', N'Numero cuenta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_origen', N'en', N'Origin')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_origen', N'es', N'Origen')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_ruta', N'en', N'Path:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_ruta', N'es', N'Ruta:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_telefono', N'en', N'Phone:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_telefono', N'es', N'Telefono:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_tipo', N'en', N'Type')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_tipo', N'es', N'Tipo')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_tipo_cuenta', N'en', N'Account Type')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_tipo_cuenta', N'es', N'Tipo cuenta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_tipo_cuenta_b', N'en', N'Account Type')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_tipo_cuenta_b', N'es', N'Tipo cuenta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_titulo', N'en', N'System Information')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_titulo', N'es', N'Informacion Sistema')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_usuario', N'en', N'User')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_usuario', N'es', N'Usuario')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_usuarioUs', N'en', N'User:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'lbl_usuarioUs', N'es', N'Usuario:')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Administracion', N'en', N'Administration')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Administracion', N'es', N'Administracion')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Ayuda', N'en', N'Help')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Ayuda', N'es', N'Ayuda')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_CyP', N'en', N'Collections / Payments')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_CyP', N'es', N'Cobros/Pagos')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Generar', N'en', N'Generate')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Generar', N'es', N'Generar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Idioma', N'en', N'Lenguage')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Idioma', N'es', N'Idioma')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Leer', N'en', N'Read')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Leer', N'es', N'Leer')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Negocio', N'en', N'Bussines')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Negocio', N'es', N'Negocio')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_PstVenta', N'en', N'Post Sale')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_PstVenta', N'es', N'Post-Venta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Terminar', N'en', N'Terminate')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Menu_Terminar', N'es', N'Terminar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node0', N'en', N'Home')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node0', N'es', N'Principal')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node1', N'en', N'Aministration')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node1', N'es', N'Administracion')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node2', N'en', N'Generate')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node2', N'es', N'Generar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node3', N'en', N'Collection/Payment')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node3', N'es', N'Cobro/Pago')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node4', N'en', N'Lenguaje')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node4', N'es', N'Idioma')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node5', N'en', N'Finish')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'Node5', N'es', N'Terminar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'rdio_cuota', N'en', N'Installments?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'rdio_cuota', N'es', N'Coutas?')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Cambiar', N'en', N'Change')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Cambiar', N'es', N'Cambiar')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Cobro', N'en', N'Collection')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Cobro', N'es', N'Cobro')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Depuracion', N'en', N'Debug')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Depuracion', N'es', N'Depuracion')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Encuesta', N'en', N'Poll')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Encuesta', N'es', N'Encuesta')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Metricas', N'en', N'Metrics')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Metricas', N'es', N'Metricas')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Pago', N'en', N'Payout')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Pago', N'es', N'Pago')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Presupuesto', N'en', N'Budget')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Presupuesto', N'es', N'Presupuesto')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Resguardo', N'en', N'Backup')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Resguardo', N'es', N'Resguardo')
GO
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Salir', N'en', N'Exit')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Salir', N'es', N'Salir')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Usuario', N'en', N'User')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'SubMenu_Usuario', N'es', N'Usuario')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'tab_00', N'en', N'Index')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'tab_00', N'es', N'Indice')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'tab_01', N'en', N'Help')
INSERT [dbo].[tbl_MultiIdioma] ([componente], [ikey], [value]) VALUES (N'tab_01', N'es', N'Ayuda')
INSERT [dbo].[tbl_Permisos] ([idPermiso], [descripcion]) VALUES (1, N'Full Access')
INSERT [dbo].[tbl_Permisos] ([idPermiso], [descripcion]) VALUES (2, N'Modulo Presupuesto')
INSERT [dbo].[tbl_Permisos] ([idPermiso], [descripcion]) VALUES (3, N'Modulo Tablero de Control')
INSERT [dbo].[tbl_Usuario] ([idUsuario], [usuario], [password], [legajo], [idioma], [digitoVerificador]) VALUES (1, N'JyDBNzc6gE5fPBZdkqWCs/RbtcB9TwI/RktoYDQkHmU=', N'rjl7a+wlWfAg8uV9HiYogB1HlCw/FMSxnFnpnamqXrQ=', N'XiSmwn6eMrLBmqWle4U97lLUoOdDI/Ng3Z95R1TUlFg=', N'T2XhhHaD5t/hUY1hZr3ChBZBmLTmZsFD6ARDaD3ldsU=', N'W7PAcT+onvw2u6KbJSNk2Ck/pQ+rhxqVPbZGhftpjNI=')
INSERT [dbo].[tbl_Usuario] ([idUsuario], [usuario], [password], [legajo], [idioma], [digitoVerificador]) VALUES (2, N'TestAdmin', N'JtaorZfHX/xUj2hz5ek85HVHnj4aEJc4HlQiH7U+wdI=', N'1', N'es', N'JMEeRWQMSzaAHLKIED8hM082H+++abElWqiOx8hG3Xc=')
INSERT [dbo].[tbl_Usuario] ([idUsuario], [usuario], [password], [legajo], [idioma], [digitoVerificador]) VALUES (3, N'TestVen', N'JtaorZfHX/xUj2hz5ek85HVHnj4aEJc4HlQiH7U+wdI=', N'2', N'es', N'2I440S6N0b6gkeadUskiEZugR6NnSbmuRP0XZRG0zK8=')
INSERT [dbo].[tbl_Usuario] ([idUsuario], [usuario], [password], [legajo], [idioma], [digitoVerificador]) VALUES (4, N'TestJer', N'JtaorZfHX/xUj2hz5ek85HVHnj4aEJc4HlQiH7U+wdI=', N'3', N'es', N'FD9eV7jv50PshxWMDt6iGQqiixFDGIOqfnkrlh2SAfg=')
INSERT [dbo].[tbl_Usuario] ([idUsuario], [usuario], [password], [legajo], [idioma], [digitoVerificador]) VALUES (5, N'TestIngles', N'JtaorZfHX/xUj2hz5ek85HVHnj4aEJc4HlQiH7U+wdI=', N'5', N'en', N'rLKFyWfuEK2qa5US/IWwjG8rN10mquiOg368tFsRP+U=')
INSERT [dbo].[tbl_UsuarioGrupo] ([idUsuario], [idGrupo]) VALUES (2, 1)
INSERT [dbo].[tbl_UsuarioGrupo] ([idUsuario], [idGrupo]) VALUES (3, 2)
INSERT [dbo].[tbl_UsuarioGrupo] ([idUsuario], [idGrupo]) VALUES (4, 3)
INSERT [dbo].[tbl_UsuarioGrupo] ([idUsuario], [idGrupo]) VALUES (5, 1)
INSERT [dbo].[tbl_UsuarioGrupo] ([idUsuario], [idGrupo]) VALUES (7, 1)
INSERT [dbo].[tbl_Vendedor] ([legajo], [apellido], [nombre], [telefono], [domicilio], [fechaNacimiento], [activo]) VALUES (1, N'Administrado', N'Angel', N'1122334546', N'Entre Rios', CAST(N'1987-07-13' AS Date), 1)
INSERT [dbo].[tbl_Vendedor] ([legajo], [apellido], [nombre], [telefono], [domicilio], [fechaNacimiento], [activo]) VALUES (2, N'Vendedor', N'Miguel', N'1231231212', N'Malaver', CAST(N'1980-12-13' AS Date), 1)
INSERT [dbo].[tbl_Vendedor] ([legajo], [apellido], [nombre], [telefono], [domicilio], [fechaNacimiento], [activo]) VALUES (3, N'Jerarquico', N'Roberto', N'1233211415', N'Belzu', CAST(N'1989-01-01' AS Date), 1)
INSERT [dbo].[tbl_Vendedor] ([legajo], [apellido], [nombre], [telefono], [domicilio], [fechaNacimiento], [activo]) VALUES (4, N'Admin', N'Brian', N'123567890', N'Lincon', CAST(N'1985-02-01' AS Date), 1)
INSERT [dbo].[tbl_Vendedor] ([legajo], [apellido], [nombre], [telefono], [domicilio], [fechaNacimiento], [activo]) VALUES (5, N'Admin', N'Brian', N'546789123', N'Lincon Av', CAST(N'1975-01-01' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Transferencias] ON 

INSERT [dbo].[Transferencias] ([idTransferencia], [idPresupuesto], [idCuentaCorriente], [monto]) VALUES (1, 53, 300700, 10900)
INSERT [dbo].[Transferencias] ([idTransferencia], [idPresupuesto], [idCuentaCorriente], [monto]) VALUES (2, 53, 300700, 5000)
INSERT [dbo].[Transferencias] ([idTransferencia], [idPresupuesto], [idCuentaCorriente], [monto]) VALUES (3, 55, 300700, 10900)
INSERT [dbo].[Transferencias] ([idTransferencia], [idPresupuesto], [idCuentaCorriente], [monto]) VALUES (4, 55, 300700, 5000)
SET IDENTITY_INSERT [dbo].[Transferencias] OFF
INSERT [dbo].[Transporte] ([idProvTrans], [idCuentaCorriente], [poseeCuentaCorriente], [razonSocial], [direccion], [poseeReservaPorMail], [mail], [montoAPagar], [TipoTransporte]) VALUES (1, 300700, 1, N'Aerolineas Argentina', N'Perú 2, C1067AAB CABA', 0, N'aerolineasarg@gmail.com', 10900, N'Avion')
INSERT [dbo].[Transporte] ([idProvTrans], [idCuentaCorriente], [poseeCuentaCorriente], [razonSocial], [direccion], [poseeReservaPorMail], [mail], [montoAPagar], [TipoTransporte]) VALUES (2, 255789, 1, N'TAM', N'Lima 65', 0, N'tam@tam.com', 14200, N'Avion')
SET IDENTITY_INSERT [dbo].[vendedorPresupuesto] ON 

INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (1, 1, 1)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (2, 1, 2)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (4, 1, 3)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (5, 1, 4)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (6, 1, 5)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (7, 1, 6)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (8, 1, 7)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (9, 1, 8)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (10, 1, 9)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (11, 1, 10)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (12, 1, 18)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (13, 1, 19)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (16, 1, 20)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (17, 1, 21)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (18, 1, 22)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (19, 1, 23)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (20, 1, 24)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (21, 1, 25)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (22, 1, 26)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (23, 1, 27)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (24, 1, 28)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (25, 1, 29)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (26, 1, 30)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (27, 1, 31)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (28, 1, 32)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (29, 1, 33)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (30, 1, 34)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (31, 1, 35)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (32, 1, 36)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (33, 1, 37)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (34, 1, 38)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (35, 1, 39)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (36, 1, 40)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (37, 1, 41)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (38, 1, 42)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (39, 1, 43)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (40, 1, 44)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (41, 1, 45)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (42, 1, 46)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (43, 1, 47)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (44, 1, 48)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (45, 1, 49)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (46, 1, 50)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (47, 1, 51)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (48, 1, 52)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (49, 1, 53)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (50, 1, 54)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (51, 1, 55)
INSERT [dbo].[vendedorPresupuesto] ([id], [legajo], [idPresupuesto]) VALUES (52, 1, 56)
SET IDENTITY_INSERT [dbo].[vendedorPresupuesto] OFF
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([idVentas], [idPresupuesto], [fechaVenta]) VALUES (1, 53, CAST(N'2016-10-15' AS Date))
INSERT [dbo].[Ventas] ([idVentas], [idPresupuesto], [fechaVenta]) VALUES (2, 55, CAST(N'2016-10-28' AS Date))
SET IDENTITY_INSERT [dbo].[Ventas] OFF
/****** Object:  Index [UQ_Cliente_codigoCliente]    Script Date: 23/11/2016 20:18:49 ******/
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [UQ_Cliente_codigoCliente] UNIQUE NONCLUSTERED 
(
	[codigoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Cobro_idCobro]    Script Date: 23/11/2016 20:18:49 ******/
ALTER TABLE [dbo].[Cobro] ADD  CONSTRAINT [UQ_Cobro_idCobro] UNIQUE NONCLUSTERED 
(
	[idCobro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Hospedaje_idProveedor]    Script Date: 23/11/2016 20:18:49 ******/
ALTER TABLE [dbo].[Hospedaje] ADD  CONSTRAINT [UQ_Hospedaje_idProveedor] UNIQUE NONCLUSTERED 
(
	[idProvHos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_PaquetesPromocionable_idPaquetePromocionable]    Script Date: 23/11/2016 20:18:49 ******/
ALTER TABLE [dbo].[PaquetesPromocionable] ADD  CONSTRAINT [UQ_PaquetesPromocionable_idPaquetePromocionable] UNIQUE NONCLUSTERED 
(
	[idPaquetePromocionable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_PaquetesPromocionable_idProveedor]    Script Date: 23/11/2016 20:18:49 ******/
ALTER TABLE [dbo].[PaquetesPromocionable] ADD  CONSTRAINT [UQ_PaquetesPromocionable_idProveedor] UNIQUE NONCLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_presupuesto_idPresupuesto]    Script Date: 23/11/2016 20:18:49 ******/
ALTER TABLE [dbo].[Presupuesto] ADD  CONSTRAINT [UQ_presupuesto_idPresupuesto] UNIQUE NONCLUSTERED 
(
	[idPresupuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_PresupuestoCobros_idCobros]    Script Date: 23/11/2016 20:18:49 ******/
ALTER TABLE [dbo].[PresupuestoCobros] ADD  CONSTRAINT [UQ_PresupuestoCobros_idCobros] UNIQUE NONCLUSTERED 
(
	[idCobros] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_PresupuestoCobros_idPresupuesto]    Script Date: 23/11/2016 20:18:49 ******/
ALTER TABLE [dbo].[PresupuestoCobros] ADD  CONSTRAINT [UQ_PresupuestoCobros_idPresupuesto] UNIQUE NONCLUSTERED 
(
	[idPresupuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_PresupuestoPaquetePromocionable_idPaquetePromocionable]    Script Date: 23/11/2016 20:18:49 ******/
ALTER TABLE [dbo].[PresupuestoPaquetePromocionable] ADD  CONSTRAINT [UQ_PresupuestoPaquetePromocionable_idPaquetePromocionable] UNIQUE NONCLUSTERED 
(
	[idPaquetePromocionable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_PresupuestoPaquetePromocionable_idPresupuesto]    Script Date: 23/11/2016 20:18:49 ******/
ALTER TABLE [dbo].[PresupuestoPaquetePromocionable] ADD  CONSTRAINT [UQ_PresupuestoPaquetePromocionable_idPresupuesto] UNIQUE NONCLUSTERED 
(
	[idPresupuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Transporte_idProveedor]    Script Date: 23/11/2016 20:18:49 ******/
ALTER TABLE [dbo].[Transporte] ADD  CONSTRAINT [UQ_Transporte_idProveedor] UNIQUE NONCLUSTERED 
(
	[idProvTrans] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_idioma]  WITH CHECK ADD  CONSTRAINT [FK_tbl_idioma_tbl_idioma] FOREIGN KEY([ikey])
REFERENCES [dbo].[tbl_idioma] ([ikey])
GO
ALTER TABLE [dbo].[tbl_idioma] CHECK CONSTRAINT [FK_tbl_idioma_tbl_idioma]
GO
/****** Object:  StoredProcedure [dbo].[sp_deuda_cliente]    Script Date: 23/11/2016 20:18:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_deuda_cliente]
	@pdni INT 
AS
BEGIN
SELECT CO.idPresupuesto AS 'PRE',CO.nroFactura AS 'FAC',CL.dni AS 'DNI',CL.nombre+' '+CL.apellido AS 'NOM' ,CO.monto AS 'MON' FROM [AtlantidaDev].[dbo].[Cobro] CO INNER JOIN [AtlantidaDev].[dbo].[Presupuesto] PR ON CO.idPresupuesto=PR.idPresupuesto
INNER JOIN [AtlantidaDev].[dbo].[Cliente] CL ON PR.codigoCliente=CL.codigoCliente WHERE CO.ventaCancelada=0 OR CO.ventaCancelada=2 AND CL.dni=@pdni;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_get_pagosActivos]    Script Date: 23/11/2016 20:18:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_get_pagosActivos] 

AS
BEGIN
--'0:Pago iniciado y Activo - no hay actividad |1:Pago por reserva |2:Pago por totalidad|3:cancelado|4:seña Paga|5:tot Paga'0:Pago iniciado y Activo - no hay actividad |1:Pago por reserva |2:Pago por totalidad|3:cancelado|4:seña Paga|5:tot Paga
  SELECT TR.idProvTrans AS 'IDPROV-TRANS',HO.idProvHos AS 'IDPROV-HOSP',PT.idPresupuesto AS 'IDPRESU',TR.idCuentaCorriente AS 'CCORR',PA.[confirmacionPagoRealizado] AS 'ESTADO',PA.montoTransporte AS 'MAP-TRANSP',TR.razonSocial AS 'RAZON SOCIAL TRANSP',PA.montoHospedaje AS 'MAP-HOSP',HO.razonSocial AS 'RAZON SOCIAL-HOSP'
  FROM [AtlantidaDev].[dbo].[Pago] PA 
  INNER JOIN [AtlantidaDev].[dbo].[PresupuestoTransporte] PT ON PA.idPresupuesto=PT.idPresupuesto
  INNER JOIN [AtlantidaDev].[dbo].[PresupuestoHospedaje] PH ON PA.idPresupuesto=PH.idPresupuesto
  INNER JOIN [AtlantidaDev].[dbo].[Transporte] TR ON PT.idProvTrans=TR.idProvTrans
  INNER JOIN [AtlantidaDev].[dbo].[Hospedaje] HO ON PH.idProvHos=HO.idProvHos
  WHERE [confirmacionPagoRealizado]=1 OR [confirmacionPagoRealizado]=2

END

GO
/****** Object:  StoredProcedure [dbo].[sp_get_presupuesto]    Script Date: 23/11/2016 20:18:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_get_presupuesto]
AS
BEGIN

SELECT TOP 1 [idPresupuesto] AS 'IDP'
      ,[codigoCliente] AS 'CCLI'
      ,[destino] AS 'CCD'
      ,[fechaPartida] AS 'FP'
      ,[fechaRegreso] AS 'FR'
      ,[pasajeros] AS 'PAS'
      ,[estado] AS 'ESTADO'
  FROM [AtlantidaDev].[dbo].[Presupuesto]
  ORDER BY idPresupuesto DESC;

END

GO
/****** Object:  StoredProcedure [dbo].[sp_get_presupuestoById]    Script Date: 23/11/2016 20:18:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_get_presupuestoById]
       @idPresupuesto int
AS
BEGIN
SELECT TOP 1 [idPresupuesto] AS 'IDP'
      ,[codigoCliente] AS 'CCLI'
      ,[destino] AS 'CCD'
      ,[fechaPartida] AS 'FP'
      ,[fechaRegreso] AS 'FR'
      ,[pasajeros] AS 'PAS'
      ,[estado] AS 'ESTADO'
  FROM [AtlantidaDev].[dbo].[Presupuesto]
  where [idPresupuesto]=@idPresupuesto
  ORDER BY idPresupuesto DESC;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_hospedajes_disponibles]    Script Date: 23/11/2016 20:18:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_hospedajes_disponibles] 
AS
BEGIN
SELECT idProvHos As 'IDH',razonSocial AS 'NOMBRE' , montoAPagar AS 'PRECIO', categoria AS 'ESTRELLAS', descripcion AS 'DESCRIPCION' FROM [AtlantidaDev].[dbo].[Hospedaje];
END

GO
/****** Object:  StoredProcedure [dbo].[sp_paquetes_no_promocionables]    Script Date: 23/11/2016 20:18:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_paquetes_no_promocionables] 
	-- Add the parameters for the stored procedure here
	@pOrigen VARCHAR(50), 
	@pDestino VARCHAR(50),
	@pFIda DATE,
	@pFVta DATE,
	@pMedioTransp VARCHAR(30)
AS
BEGIN
SELECT idOp AS 'IDPAX',origen AS 'CCO',destino AS 'CCD',fechaIda AS 'FP',fechaVuelta AS 'FR',idTransporte as 'IDT', razonSocial AS 'EMP',capacidad AS 'DIS', montoAPagar AS 'MT','NO PROMO' as TPA
FROM [AtlantidaDev].[dbo].[Operaciones] INNER JOIN [AtlantidaDev].[dbo].[Transporte]  ON idTransporte = idProvTrans
WHERE Origen=@pOrigen AND destino=@pDestino AND fechaIda BETWEEN  @pFIda AND DATEADD(DAY,5,@pFIda) AND TipoTransporte = @pMedioTransp
END

GO
/****** Object:  StoredProcedure [dbo].[sp_paquetes_promocionables]    Script Date: 23/11/2016 20:18:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_paquetes_promocionables] 
AS
BEGIN
SELECT idPaquetePromocionable AS 'IDPAX',origen AS 'CCO',destino AS 'CCD',fechaPartida AS 'FP',fechaRegreso AS 'FR',
(SELECT d.razonSocial +' | '+d.TipoTransporte FROM [AtlantidaDev].[dbo].[PresupuestoTransporte] C INNER JOIN [AtlantidaDev].[dbo].[Transporte] D ON C.idProvTrans =D.idProvTrans
WHERE c.idPresupuesto = A.idPaquetePromocionable) AS 'EMP',
cantidadPasajero AS 'DIS',
(SELECT d.razonSocial FROM [AtlantidaDev].[dbo].[PresupuestoHospedaje] C INNER JOIN [AtlantidaDev].[dbo].[Hospedaje] D ON C.idProvHos=D.idProvHos
WHERE c.idPresupuesto = A.idPaquetePromocionable) AS 'HO',
monto AS 'COT', 'PROMO' as TPA
FROM [AtlantidaDev].[dbo].[PaquetesPromocionable] A where paqueteActivo = 1;

END

GO
/****** Object:  StoredProcedure [dbo].[sp_set_estadoPresupuesto]    Script Date: 23/11/2016 20:18:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_set_estadoPresupuesto]
 @idPresupuesto int,
 @estado nvarchar(10)
AS
BEGIN
UPDATE [AtlantidaDev].[dbo].[Presupuesto] SET [estado]=@estado WHERE idPresupuesto=@idPresupuesto
END

GO
/****** Object:  StoredProcedure [dbo].[sp_voucher_cliente]    Script Date: 23/11/2016 20:18:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_voucher_cliente]
@pdni INT
AS
BEGIN
SELECT PR.idPresupuesto AS 'PRE',CO.nroFactura AS 'FACTURA',CL.dni AS 'DNI',PR.pasajeros AS 'PASAJEROS',CO.monto AS 'MON',PR.destino AS 'DESTINO',PR.fechaPartida AS 'FECHA.PARTIDA',PR.fechaRegreso AS 'FECHA.REGRESO',
TR.razonSocial AS 'TRANSPORTE',HO.razonSocial AS 'HOSPEDAJE'
FROM [AtlantidaDev].[dbo].[Cobro] CO 
INNER JOIN [AtlantidaDev].[dbo].[Presupuesto] PR ON CO.idPresupuesto=PR.idPresupuesto
INNER JOIN [AtlantidaDev].[dbo].[PresupuestoTransporte] PT ON PR.idPresupuesto=PT.idPresupuesto
INNER JOIN [AtlantidaDev].[dbo].[PresupuestoHospedaje] PH ON PR.idPresupuesto=PH.idPresupuesto
INNER JOIN [AtlantidaDev].[dbo].[Transporte] TR ON TR.idProvTrans = PT.idProvTrans
INNER JOIN [AtlantidaDev].[dbo].[Hospedaje] HO ON HO.idProvHos=PH.idProvHos
INNER JOIN [AtlantidaDev].[dbo].[Cliente] CL ON PR.codigoCliente=CL.codigoCliente 
WHERE CO.ventaCancelada=3 AND CL.dni=@pdni;
END

GO
USE [master]
GO
ALTER DATABASE [AtlantidaDev] SET  READ_WRITE 
GO

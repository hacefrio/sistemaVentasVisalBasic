USE [SistemaVentas]
GO
/****** Object:  User [root]    Script Date: 05-12-2019 23:59:51 ******/
CREATE USER [root] FOR LOGIN [root] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [root]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [root]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [root]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [root]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [root]
GO
ALTER ROLE [db_datareader] ADD MEMBER [root]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [root]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [root]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [root]
GO
/****** Object:  Table [dbo].[detalleVenta]    Script Date: 05-12-2019 23:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalleVenta](
	[ID_producto] [int] NULL,
	[cantidad] [int] NULL,
	[total] [float] NULL,
	[N_venta] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inventario]    Script Date: 05-12-2019 23:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventario](
	[ID_producto] [int] NOT NULL,
	[cantidad] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 05-12-2019 23:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[ID_producto] [int] NOT NULL,
	[Nombre_producto] [nchar](100) NOT NULL,
	[precio] [int] NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[ID_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 05-12-2019 23:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[N_venta] [int] NULL,
	[Total] [int] NULL,
	[IVA] [float] NULL,
	[Total_final] [float] NULL,
	[fecha] [nchar](10) NULL
) ON [PRIMARY]
GO

USE [master]
GO
/****** Object:  Database [Computer_Shop]    Script Date: 28/12/2016 6:12:10 CH ******/
CREATE DATABASE [Computer_Shop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Computer_Shop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Computer_Shop.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Computer_Shop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Computer_Shop_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Computer_Shop] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Computer_Shop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Computer_Shop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Computer_Shop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Computer_Shop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Computer_Shop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Computer_Shop] SET ARITHABORT OFF 
GO
ALTER DATABASE [Computer_Shop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Computer_Shop] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Computer_Shop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Computer_Shop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Computer_Shop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Computer_Shop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Computer_Shop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Computer_Shop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Computer_Shop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Computer_Shop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Computer_Shop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Computer_Shop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Computer_Shop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Computer_Shop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Computer_Shop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Computer_Shop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Computer_Shop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Computer_Shop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Computer_Shop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Computer_Shop] SET  MULTI_USER 
GO
ALTER DATABASE [Computer_Shop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Computer_Shop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Computer_Shop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Computer_Shop] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Computer_Shop]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[TenKH] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[CMND] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DT] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[LoaiKH] [bit] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MyOrders]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MyOrders](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[OrderID] [int] NOT NULL,
 CONSTRAINT [PK_MyOrders] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[TrangThai] [bit] NULL,
	[NgayTao] [datetime] NULL,
	[NgayGiao] [datetime] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrdersDetail]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersDetail](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [int] NOT NULL,
 CONSTRAINT [PK_OrdersDetail] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[Image] [nvarchar](50) NULL,
	[Price] [int] NULL,
	[Descriptions] [nvarchar](max) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Recommendation]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recommendation](
	[ReProductID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
 CONSTRAINT [PK_Recommendation] PRIMARY KEY CLUSTERED 
(
	[ReProductID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SubCategory]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategory](
	[SubCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[SubCategoryName] [nvarchar](50) NULL,
	[CategoryID] [int] NULL,
 CONSTRAINT [PK_SubCategory] PRIMARY KEY CLUSTERED 
(
	[SubCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SubCategoryMenu]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategoryMenu](
	[SubCategoryID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
 CONSTRAINT [PK_SubCategoryMenu] PRIMARY KEY CLUSTERED 
(
	[SubCategoryID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TimeBaseDisplay]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeBaseDisplay](
	[TimeID] [int] IDENTITY(1,1) NOT NULL,
	[FromTime] [datetime] NULL,
	[ToTime] [datetime] NULL,
	[FromHour] [time](4) NULL,
	[ToHour] [time](4) NULL,
	[DayOfWeek] [int] NULL,
 CONSTRAINT [PK_TimeBaseDisplay] PRIMARY KEY CLUSTERED 
(
	[TimeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TimeRule]    Script Date: 28/12/2016 6:12:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeRule](
	[TimeID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
 CONSTRAINT [PK_TimeRule] PRIMARY KEY CLUSTERED 
(
	[TimeID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Admin] ([TaiKhoan], [MatKhau]) VALUES (N'admin', N'123')
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1011, N'Laptop')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1016, N'Linh Kiện')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1017, N'Test')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1018, N'Test2')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1019, N'Test3')
SET IDENTITY_INSERT [dbo].[Category] OFF
INSERT [dbo].[Customer] ([TaiKhoan], [MatKhau], [TenKH], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DT], [Email], [LoaiKH]) VALUES (N'dieuthuyen', N'123456', N'Điêu Thuyền', CAST(0x0000836C00000000 AS DateTime), 0, N'025213458', N'Tp.HCM', N'0916549823', N'dieuthuyen@gmail.com', 1)
INSERT [dbo].[Customer] ([TaiKhoan], [MatKhau], [TenKH], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DT], [Email], [LoaiKH]) VALUES (N'dongtrac', N'dongtrac', N'Đỗng Trác', CAST(0x00004D2E00000000 AS DateTime), 1, N'025636548', N'Đã Nẵng', N'0921135456', N'dongtrac@gmail.com', 1)
INSERT [dbo].[Customer] ([TaiKhoan], [MatKhau], [TenKH], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DT], [Email], [LoaiKH]) VALUES (N'lam', N'123', N'Nguyễn Nghĩa Lâm', CAST(0x0000870000000000 AS DateTime), 1, N'0123456789', N'TP HCM', N'0123456789', N'nnlam94@gmail.com', 1)
INSERT [dbo].[Customer] ([TaiKhoan], [MatKhau], [TenKH], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DT], [Email], [LoaiKH]) VALUES (N'lam123', N'123', N'Lâm', CAST(0x0000A6DA00000000 AS DateTime), 1, N'0123123123', N'0123123123', N'123123123', N'23@gmail.com', 0)
INSERT [dbo].[Customer] ([TaiKhoan], [MatKhau], [TenKH], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DT], [Email], [LoaiKH]) VALUES (N'lamaa', N'123', N'Lâm', CAST(0x0000A6DA00000000 AS DateTime), 1, N'0123123', N'123', N'123', N'123', 0)
INSERT [dbo].[Customer] ([TaiKhoan], [MatKhau], [TenKH], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DT], [Email], [LoaiKH]) VALUES (N'lamjok', N'123qwe', N'Nguyễn Nghĩa Lâm', CAST(0x0000A6DA00000000 AS DateTime), 1, N'0123456789', N'12/9 hcm', N'01283224124', N'nnlm@gmail.com', 0)
INSERT [dbo].[Customer] ([TaiKhoan], [MatKhau], [TenKH], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DT], [Email], [LoaiKH]) VALUES (N'lubo', N'lubolaanh', N'Lữ Bố', CAST(0x00006F8300000000 AS DateTime), 1, N'026498526', N'Huế', N'0854151459', N'lubodeptrai@gmail.com', 1)
INSERT [dbo].[Customer] ([TaiKhoan], [MatKhau], [TenKH], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DT], [Email], [LoaiKH]) VALUES (N'luubi', N'qweasd', N'Lưu Bị', CAST(0x0000A6DA00000000 AS DateTime), 1, N'1212312312', N'1231231', N'0123123123', N'22@gmail.co', 0)
INSERT [dbo].[Customer] ([TaiKhoan], [MatKhau], [TenKH], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DT], [Email], [LoaiKH]) VALUES (N'taothao', N'anhtao', N'Tào Tháo', CAST(0x000030A200000000 AS DateTime), 1, N'025689845', N'Ha Nội', N'0121324545', N'taothao@gmail.com', 0)
INSERT [dbo].[Customer] ([TaiKhoan], [MatKhau], [TenKH], [NgaySinh], [GioiTinh], [CMND], [DiaChi], [DT], [Email], [LoaiKH]) VALUES (N'taythi', N'taythilachi', N'Tây Thi', CAST(0x00006DFC00000000 AS DateTime), 0, N'023658786', N'Tp.HCM', N'0945875458', N'taythimynhan@gmail.com', 0)
INSERT [dbo].[MyOrders] ([TaiKhoan], [OrderID]) VALUES (N'lam', 9)
INSERT [dbo].[MyOrders] ([TaiKhoan], [OrderID]) VALUES (N'lam', 11)
INSERT [dbo].[MyOrders] ([TaiKhoan], [OrderID]) VALUES (N'lam', 12)
INSERT [dbo].[MyOrders] ([TaiKhoan], [OrderID]) VALUES (N'lam', 18)
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [TenKH], [DiaChi], [GhiChu], [DienThoai], [TrangThai], [NgayTao], [NgayGiao]) VALUES (9, N'Tào Tháo', N'abc', N'', N'0162659125', 1, CAST(0x0000A6D400000000 AS DateTime), CAST(0x0000A6DC00000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [TenKH], [DiaChi], [GhiChu], [DienThoai], [TrangThai], [NgayTao], [NgayGiao]) VALUES (11, N'Nguyễn Nghĩa Lâm', N'123123123', N'123123', N'0123456789', 0, CAST(0x0000A6DF00000000 AS DateTime), CAST(0x0000A6EE00000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [TenKH], [DiaChi], [GhiChu], [DienThoai], [TrangThai], [NgayTao], [NgayGiao]) VALUES (12, N'Nguyễn Nghĩa Lâm', N'123123', N'123', N'0123456789', 0, CAST(0x0000A6DF00000000 AS DateTime), CAST(0x0000A6E700000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [TenKH], [DiaChi], [GhiChu], [DienThoai], [TrangThai], [NgayTao], [NgayGiao]) VALUES (13, N'Nguyễn Nghĩa Lâm', N'12/2', N'414124', N'01283224124', 0, CAST(0x0000A6E000000000 AS DateTime), CAST(0x0000A6E100000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [TenKH], [DiaChi], [GhiChu], [DienThoai], [TrangThai], [NgayTao], [NgayGiao]) VALUES (14, N'Lâm', N'123123', N'444', N'444444', 1, CAST(0x0000A6E300000000 AS DateTime), CAST(0x0000A6E500000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [TenKH], [DiaChi], [GhiChu], [DienThoai], [TrangThai], [NgayTao], [NgayGiao]) VALUES (16, N'Nguyễn Nghĩa Lâm', N'Q7', N'chuyển phát nhanh', N'0123456789', 0, CAST(0x0000A6E200000000 AS DateTime), CAST(0x0000A6E400000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [TenKH], [DiaChi], [GhiChu], [DienThoai], [TrangThai], [NgayTao], [NgayGiao]) VALUES (17, N'Nguyễn Nghĩa Lâm', N'2414124', N'123123', N'0123456789', 0, CAST(0x0000A6E300000000 AS DateTime), CAST(0x0000A6E400000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [TenKH], [DiaChi], [GhiChu], [DienThoai], [TrangThai], [NgayTao], [NgayGiao]) VALUES (18, N'Nguyễn Nghĩa Lâm', N'TP HCM', N'AAAA', N'0123456789', 0, CAST(0x0000A6E300000000 AS DateTime), CAST(0x0000A6E500000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [TenKH], [DiaChi], [GhiChu], [DienThoai], [TrangThai], [NgayTao], [NgayGiao]) VALUES (19, N'Joudas', N'Joo', N'Haah', N'0123123123', 0, CAST(0x0000A6E300000000 AS DateTime), CAST(0x0000A6E700000000 AS DateTime))
INSERT [dbo].[Orders] ([OrderID], [TenKH], [DiaChi], [GhiChu], [DienThoai], [TrangThai], [NgayTao], [NgayGiao]) VALUES (20, N'Nguyễn Nghĩa Lâm', N'123123123', N'3333333', N'91231231', 1, CAST(0x0000A6E400000000 AS DateTime), CAST(0x0000A6E600000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Orders] OFF
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (9, 1, 4, 60000000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (11, 1, 3, 45000000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (11, 6, 4, 1480000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (12, 1, 3, 45000000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (12, 2, 5, 63750000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (13, 1, 1, 15000000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (13, 2, 1, 12500000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (14, 1, 3, 45000000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (14, 2, 5, 62500000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (14, 6, 4, 1480000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (14, 7, 2, 760000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (16, 1, 1, 15000000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (17, 1, 3, 45000000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (18, 1, 3, 45000000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (18, 6, 2, 740000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (18, 13, 4, 4800000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (19, 1, 1, 15000000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (19, 14, 1, 12000000)
INSERT [dbo].[OrdersDetail] ([OrderID], [ProductID], [SoLuong], [Gia]) VALUES (20, 8, 1, 120000)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (1, N'Dell 6015', N'Image/skin_9.jpg', 15000000, N'Speed through tasks and stay connected with the Dell Inspiron 620 desktop. Stylish and slim, this PC features 2nd Generation Intel® Core™ processors for multi-tasking and the power to run a variety of useful functions. The Inspiron 620 desktop gives you speedy access to things that matter. Whatever projects or fun application you’re ready to start running, you can enjoy a pristine, smooth experience. In addition, media connectivity let’s you entertain friends and organize photos plus much, much more. With Microsoft Office Starter 2010 plus a games access package also included, this Dell home computer is expertly crafted for both work and play.')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (2, N'Dell 6022', N'Image/skin_10.jpg', 12500000, NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (3, N'Dell 6023', N'Image/skin_11.jpg', 13700000, NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (4, N'Dell 1023', N'Image/skin_1.jpg', 14500000, NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (5, N'Ram DDR2', N'Image/ram1.jpg', 400000, NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (6, N'Ram DDR3', N'Image/ram2.jpg', 370000, NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (7, N'Ram DDR3 Bus 1k7', N'Image/ram3.jpg', 380000, N'')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (8, N'Chuột Genius', N'Image/chuot1.jpg', 120000, N'')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (9, N'Chuột Dell 1200', N'Image/chuot2.jpg', 125000, N'')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (10, N'Bàn Phím Bosston', N'Image/bp1.jpg', 320000, N'')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (11, N'Bàn Phím Dell', N'Image/bp2.jpg', 350000, N'')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (12, N'Bàn Phím N32SP', N'Image/bp3.jpg', 370000, N'')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (13, N'HDD KingSton 500Gb', N'Image/o1.jpg', 1200000, N'')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (14, N'SSD KingSton 1Tb', N'Image/o2.jpg', 12000000, N'')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Image], [Price], [Descriptions]) VALUES (15, N'DellTest', N'Image/skin_8.jpg', 111, N'123123')
INSERT [dbo].[Recommendation] ([ReProductID], [ProductID]) VALUES (1, 4)
INSERT [dbo].[Recommendation] ([ReProductID], [ProductID]) VALUES (2, 1)
INSERT [dbo].[Recommendation] ([ReProductID], [ProductID]) VALUES (2, 3)
INSERT [dbo].[Recommendation] ([ReProductID], [ProductID]) VALUES (2, 4)
INSERT [dbo].[Recommendation] ([ReProductID], [ProductID]) VALUES (3, 1)
INSERT [dbo].[Recommendation] ([ReProductID], [ProductID]) VALUES (3, 2)
INSERT [dbo].[Recommendation] ([ReProductID], [ProductID]) VALUES (4, 1)
INSERT [dbo].[Recommendation] ([ReProductID], [ProductID]) VALUES (4, 3)
INSERT [dbo].[Recommendation] ([ReProductID], [ProductID]) VALUES (7, 5)
INSERT [dbo].[Recommendation] ([ReProductID], [ProductID]) VALUES (7, 6)
INSERT [dbo].[Recommendation] ([ReProductID], [ProductID]) VALUES (15, 5)
SET IDENTITY_INSERT [dbo].[SubCategory] ON 

INSERT [dbo].[SubCategory] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (1015, N'Dell', 1011)
INSERT [dbo].[SubCategory] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (1016, N'Asus', 1011)
INSERT [dbo].[SubCategory] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (1017, N'RAM', 1016)
INSERT [dbo].[SubCategory] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (1018, N'Chuột', 1016)
INSERT [dbo].[SubCategory] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (1019, N'Bàn Phím', 1016)
INSERT [dbo].[SubCategory] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (1020, N'Ổ Cứng', 1016)
INSERT [dbo].[SubCategory] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (1021, N'TestSub', 1017)
INSERT [dbo].[SubCategory] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (1022, N'TestSub2', 1018)
INSERT [dbo].[SubCategory] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (1023, N'TestSub3', 1019)
SET IDENTITY_INSERT [dbo].[SubCategory] OFF
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1015, 1)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1015, 2)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1015, 3)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1015, 4)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1016, 4)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1017, 5)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1017, 6)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1017, 7)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1018, 8)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1018, 9)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1019, 10)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1019, 11)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1019, 12)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1020, 13)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1020, 14)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1021, 5)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1021, 6)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1022, 10)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1022, 11)
INSERT [dbo].[SubCategoryMenu] ([SubCategoryID], [ProductID]) VALUES (1023, 15)
SET IDENTITY_INSERT [dbo].[TimeBaseDisplay] ON 

INSERT [dbo].[TimeBaseDisplay] ([TimeID], [FromTime], [ToTime], [FromHour], [ToHour], [DayOfWeek]) VALUES (3, CAST(0x0000A6D400000000 AS DateTime), CAST(0x0000A6D400000000 AS DateTime), CAST(0x04002A7515000000 AS Time), CAST(0x0400105522000000 AS Time), 3)
INSERT [dbo].[TimeBaseDisplay] ([TimeID], [FromTime], [ToTime], [FromHour], [ToHour], [DayOfWeek]) VALUES (4, CAST(0x0000A6E300000000 AS DateTime), CAST(0x0000A6E400000000 AS DateTime), CAST(0x04002A7515000000 AS Time), CAST(0x04006E0A1E000000 AS Time), 4)
INSERT [dbo].[TimeBaseDisplay] ([TimeID], [FromTime], [ToTime], [FromHour], [ToHour], [DayOfWeek]) VALUES (5, CAST(0x0000A6E300000000 AS DateTime), CAST(0x0000A6E500000000 AS DateTime), CAST(0x0400000000000000 AS Time), CAST(0x0400475A31000000 AS Time), 5)
SET IDENTITY_INSERT [dbo].[TimeBaseDisplay] OFF
INSERT [dbo].[TimeRule] ([TimeID], [ProductID]) VALUES (3, 1)
INSERT [dbo].[TimeRule] ([TimeID], [ProductID]) VALUES (3, 2)
INSERT [dbo].[TimeRule] ([TimeID], [ProductID]) VALUES (4, 5)
INSERT [dbo].[TimeRule] ([TimeID], [ProductID]) VALUES (4, 6)
INSERT [dbo].[TimeRule] ([TimeID], [ProductID]) VALUES (4, 10)
ALTER TABLE [dbo].[MyOrders]  WITH CHECK ADD  CONSTRAINT [FK_MyOrders_Customer] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[Customer] ([TaiKhoan])
GO
ALTER TABLE [dbo].[MyOrders] CHECK CONSTRAINT [FK_MyOrders_Customer]
GO
ALTER TABLE [dbo].[MyOrders]  WITH CHECK ADD  CONSTRAINT [FK_MyOrders_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[MyOrders] CHECK CONSTRAINT [FK_MyOrders_Orders]
GO
ALTER TABLE [dbo].[OrdersDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrdersDetail_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrdersDetail] CHECK CONSTRAINT [FK_OrdersDetail_Orders]
GO
ALTER TABLE [dbo].[OrdersDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrdersDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrdersDetail] CHECK CONSTRAINT [FK_OrdersDetail_Product]
GO
ALTER TABLE [dbo].[Recommendation]  WITH CHECK ADD  CONSTRAINT [FK_Recommendation_Product] FOREIGN KEY([ReProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Recommendation] CHECK CONSTRAINT [FK_Recommendation_Product]
GO
ALTER TABLE [dbo].[Recommendation]  WITH CHECK ADD  CONSTRAINT [FK_Recommendation_Product1] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Recommendation] CHECK CONSTRAINT [FK_Recommendation_Product1]
GO
ALTER TABLE [dbo].[SubCategory]  WITH CHECK ADD  CONSTRAINT [FK_SubCategory_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[SubCategory] CHECK CONSTRAINT [FK_SubCategory_Category]
GO
ALTER TABLE [dbo].[SubCategoryMenu]  WITH CHECK ADD  CONSTRAINT [FK_SubCategoryMenu_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[SubCategoryMenu] CHECK CONSTRAINT [FK_SubCategoryMenu_Product]
GO
ALTER TABLE [dbo].[SubCategoryMenu]  WITH CHECK ADD  CONSTRAINT [FK_SubCategoryMenu_SubCategory] FOREIGN KEY([SubCategoryID])
REFERENCES [dbo].[SubCategory] ([SubCategoryID])
GO
ALTER TABLE [dbo].[SubCategoryMenu] CHECK CONSTRAINT [FK_SubCategoryMenu_SubCategory]
GO
ALTER TABLE [dbo].[TimeRule]  WITH CHECK ADD  CONSTRAINT [FK_TimeRule_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[TimeRule] CHECK CONSTRAINT [FK_TimeRule_Product]
GO
ALTER TABLE [dbo].[TimeRule]  WITH CHECK ADD  CONSTRAINT [FK_TimeRule_TimeBaseDisplay] FOREIGN KEY([TimeID])
REFERENCES [dbo].[TimeBaseDisplay] ([TimeID])
GO
ALTER TABLE [dbo].[TimeRule] CHECK CONSTRAINT [FK_TimeRule_TimeBaseDisplay]
GO
USE [master]
GO
ALTER DATABASE [Computer_Shop] SET  READ_WRITE 
GO

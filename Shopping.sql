USE [master]
GO
/****** Object:  Database [Shopping]    Script Date: 7/5/2023 1:04:30 PM ******/
CREATE DATABASE [Shopping]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shopping', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Shopping.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Shopping_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Shopping_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Shopping] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shopping].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Shopping] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Shopping] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Shopping] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Shopping] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Shopping] SET ARITHABORT OFF 
GO
ALTER DATABASE [Shopping] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Shopping] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Shopping] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Shopping] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Shopping] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Shopping] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Shopping] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Shopping] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Shopping] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Shopping] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Shopping] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Shopping] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Shopping] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Shopping] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Shopping] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Shopping] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Shopping] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Shopping] SET RECOVERY FULL 
GO
ALTER DATABASE [Shopping] SET  MULTI_USER 
GO
ALTER DATABASE [Shopping] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Shopping] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Shopping] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Shopping] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Shopping] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Shopping] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Shopping', N'ON'
GO
ALTER DATABASE [Shopping] SET QUERY_STORE = ON
GO
ALTER DATABASE [Shopping] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Shopping]
GO
/****** Object:  Table [dbo].[tblCategories]    Script Date: 7/5/2023 1:04:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategories](
	[categoryID] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblCategories] PRIMARY KEY CLUSTERED 
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 7/5/2023 1:04:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduct](
	[productID] [nvarchar](30) NOT NULL,
	[name] [nvarchar](200) NULL,
	[price] [money] NULL,
	[quantity] [int] NULL,
	[categoryID] [int] NOT NULL,
 CONSTRAINT [PK_tblProduct] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 7/5/2023 1:04:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[userID] [nvarchar](30) NOT NULL,
	[name] [nvarchar](50) NULL,
	[phone] [nvarchar](20) NULL,
	[address] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[password] [nvarchar](10) NULL,
 CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblCategories] ([categoryID], [name]) VALUES (1, N'Active')
INSERT [dbo].[tblCategories] ([categoryID], [name]) VALUES (2, N'Sports')
INSERT [dbo].[tblCategories] ([categoryID], [name]) VALUES (3, N'Deligate')
GO
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW001', N'Samsung Galaxy Watch5', 6490.0000, 21, 3)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW002', N'Xiaomi Watch S1 Active', 2990.0000, 20, 2)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW003', N'Xiaomi Redmi band 2', 790.0000, 20, 1)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW004', N'Huawei Band 7', 949.0000, 20, 3)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW005', N'Huawei Watch GT3', 5490.0000, 20, 3)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW006', N'Apple Watch Series 7 41mm (GPS)', 8290.0000, 20, 1)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW007', N'Apple Watch SE 2022', 6990.0000, 20, 2)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW008', N'Xiaomi Redmi Watch 2 Lite', 990.0000, 20, 3)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW009', N'Xiaomi Mi Band 7', 890.0000, 20, 3)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW010', N'Apple Watch Series 6', 5000.0000, 20, 1)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW011', N'Garmin Forerunner 745', 6990.0000, 20, 2)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW012', N'Apple Watch SE 44mm (GPS)', 6290.0000, 20, 3)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW013', N'Huawei Watch GT Runner', 3390.0000, 20, 2)
INSERT [dbo].[tblProduct] ([productID], [name], [price], [quantity], [categoryID]) VALUES (N'SW016', N'Xiao watch', 2800.0000, 29, 3)
GO
INSERT [dbo].[tblUser] ([userID], [name], [phone], [address], [email], [password]) VALUES (N'admin', N'Phạm Quang Vinh', N'0942705605', N'HCM', N'thedh@admin.vn', N'1')
INSERT [dbo].[tblUser] ([userID], [name], [phone], [address], [email], [password]) VALUES (N'anime', N'Nguyễn Văn Cao Kỳ', N'0942705605', N'dak lak', N'9277.dev@gmail.com', N'1')
INSERT [dbo].[tblUser] ([userID], [name], [phone], [address], [email], [password]) VALUES (N'SE130363', N'Ngo Trinh Gia Bao', N'0124827864', N'HN', N'baoht@gmail.com', N'1')
INSERT [dbo].[tblUser] ([userID], [name], [phone], [address], [email], [password]) VALUES (N'SE140103', N'Phuoc Long', N'0467237645', N'HN', N'long@fu.edu.vn', N'1')
GO
ALTER TABLE [dbo].[tblProduct]  WITH CHECK ADD  CONSTRAINT [FK_tblProduct_tblCategories] FOREIGN KEY([categoryID])
REFERENCES [dbo].[tblCategories] ([categoryID])
GO
ALTER TABLE [dbo].[tblProduct] CHECK CONSTRAINT [FK_tblProduct_tblCategories]
GO
USE [master]
GO
ALTER DATABASE [Shopping] SET  READ_WRITE 
GO

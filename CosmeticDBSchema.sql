USE [master]
GO
/****** Object:  Database [CosmaticShopDb]    Script Date: 01/09/2023 12:28:15 am ******/
CREATE DATABASE [CosmaticShopDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CosmaticShopDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CosmaticShopDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CosmaticShopDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\CosmaticShopDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CosmaticShopDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CosmaticShopDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CosmaticShopDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CosmaticShopDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CosmaticShopDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CosmaticShopDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CosmaticShopDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CosmaticShopDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CosmaticShopDb] SET  MULTI_USER 
GO
ALTER DATABASE [CosmaticShopDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CosmaticShopDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CosmaticShopDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CosmaticShopDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CosmaticShopDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CosmaticShopDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CosmaticShopDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [CosmaticShopDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CosmaticShopDb]
GO
/****** Object:  Table [dbo].[tblCategory]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategory](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[Name] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[Name] [nvarchar](200) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[Description] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomerPayment]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomerPayment](
	[CustomerPaymentID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[SaleID] [int] NULL,
	[PaidDate] [date] NULL,
	[TotalAmount] [float] NULL,
	[PaidAmount] [float] NULL,
	[BalanceAmount] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerPaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](200) NULL,
	[UserTypeID] [int] NULL,
	[ContactNo] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[CNIC] [nvarchar](100) NULL,
	[Photo] [nvarchar](max) NULL,
	[Address] [nvarchar](200) NULL,
	[Description] [nvarchar](200) NULL,
	[UserName] [nvarchar](200) NULL,
	[Password] [nvarchar](200) NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblExpensesCategory]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblExpensesCategory](
	[ExpCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[EmployeeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblExpeses]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblExpeses](
	[ExpenseID] [int] IDENTITY(1,1) NOT NULL,
	[ExpCategoryID] [int] NULL,
	[Title] [nvarchar](200) NULL,
	[Comments] [nvarchar](300) NULL,
	[Reason] [nvarchar](200) NOT NULL,
	[Cost] [float] NULL,
	[EmployeeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduct](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NULL,
	[EmployeeID] [int] NULL,
	[ExPDate] [date] NULL,
	[ManufactureDate] [date] NULL,
	[CurrentPurchaseUnitPrice] [float] NULL,
	[Qty] [int] NULL,
	[SaleUnitPrice] [float] NULL,
	[IsActive] [bit] NULL,
	[ProductName] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProductUnit]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProductUnit](
	[UnitID] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProductUnitManage]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProductUnitManage](
	[ManageID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[SaleUnit] [int] NULL,
	[PurchaseUnit] [int] NULL,
	[QtyInPurchaseUnit] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ManageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPurchase]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPurchase](
	[purchaseID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[SupplierID] [int] NULL,
	[PurchaseDate] [date] NULL,
	[TotalAmount] [float] NULL,
	[Comments] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[purchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPurchaseDetail]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPurchaseDetail](
	[PurchaseDetailID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [int] NULL,
	[ItemID] [int] NULL,
	[Qty] [int] NULL,
	[UnitPrice] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PurchaseDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSale]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSale](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[EmployeeID] [int] NULL,
	[SaleDate] [datetime] NULL,
	[TotalAmount] [float] NULL,
	[Comments] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSaleDetail]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSaleDetail](
	[SaleDetailID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NULL,
	[Qty] [int] NULL,
	[UnitPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSupplier]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSupplier](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[Name] [nvarchar](200) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[Description] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSupplierPayment]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSupplierPayment](
	[SupplierPaymentID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [int] NULL,
	[EmployeeID] [int] NULL,
	[PaymentDate] [datetime] NULL,
	[TotalAmount] [int] NULL,
	[PaidAmount] [int] NULL,
	[BalanceAmount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierPaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUserType]    Script Date: 01/09/2023 12:28:16 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserType](
	[UserTypeID] [int] IDENTITY(1,1) NOT NULL,
	[UserType] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblEmployee] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[tblProduct] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[tblCategory]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblCustomer]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblCustomerPayment]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblCustomerPayment]  WITH CHECK ADD FOREIGN KEY([SaleID])
REFERENCES [dbo].[tblSale] ([SaleID])
GO
ALTER TABLE [dbo].[tblEmployee]  WITH CHECK ADD FOREIGN KEY([UserTypeID])
REFERENCES [dbo].[tblUserType] ([UserTypeID])
GO
ALTER TABLE [dbo].[tblExpensesCategory]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblExpeses]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblExpeses]  WITH CHECK ADD FOREIGN KEY([ExpCategoryID])
REFERENCES [dbo].[tblExpensesCategory] ([ExpCategoryID])
GO
ALTER TABLE [dbo].[tblProduct]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[tblCategory] ([CategoryID])
GO
ALTER TABLE [dbo].[tblProduct]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblProductUnitManage]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[tblProductUnit] ([UnitID])
GO
ALTER TABLE [dbo].[tblProductUnitManage]  WITH CHECK ADD FOREIGN KEY([PurchaseUnit])
REFERENCES [dbo].[tblProductUnit] ([UnitID])
GO
ALTER TABLE [dbo].[tblProductUnitManage]  WITH CHECK ADD FOREIGN KEY([SaleUnit])
REFERENCES [dbo].[tblProductUnit] ([UnitID])
GO
ALTER TABLE [dbo].[tblPurchase]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblPurchase]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[tblSupplier] ([SupplierID])
GO
ALTER TABLE [dbo].[tblPurchaseDetail]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[tblProduct] ([ItemID])
GO
ALTER TABLE [dbo].[tblPurchaseDetail]  WITH CHECK ADD FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[tblPurchase] ([purchaseID])
GO
ALTER TABLE [dbo].[tblSale]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[tblCustomer] ([CustomerID])
GO
ALTER TABLE [dbo].[tblSale]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblSaleDetail]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[tblProduct] ([ItemID])
GO
ALTER TABLE [dbo].[tblSupplier]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblSupplierPayment]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmpID])
GO
ALTER TABLE [dbo].[tblSupplierPayment]  WITH CHECK ADD FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[tblPurchase] ([purchaseID])
GO
USE [master]
GO
ALTER DATABASE [CosmaticShopDb] SET  READ_WRITE 
GO

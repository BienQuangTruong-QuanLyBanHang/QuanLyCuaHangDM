USE [master]
GO
/****** Object:  Database [QuanLySanPham]    Script Date: 7/21/2020 3:14:29 PM ******/
CREATE DATABASE [QuanLySanPham]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLySanPham', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLySanPham.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLySanPham_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLySanPham_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLySanPham] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLySanPham].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLySanPham] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLySanPham] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLySanPham] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLySanPham] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLySanPham] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLySanPham] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLySanPham] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLySanPham] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySanPham] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLySanPham] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLySanPham] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLySanPham] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLySanPham] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLySanPham] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLySanPham] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLySanPham] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLySanPham] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLySanPham] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLySanPham] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLySanPham] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLySanPham] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLySanPham] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLySanPham] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLySanPham] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLySanPham] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLySanPham] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLySanPham] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLySanPham] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLySanPham] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLySanPham] SET QUERY_STORE = OFF
GO
USE [QuanLySanPham]
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDCTHD]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--cthd--
CREATE FUNCTION [dbo].[AUTO_IDCTHD]()
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @ID VARCHAR(7)
	IF (SELECT COUNT(MaCTHD) FROM ChiTietHoaDon) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCTHD, 3)) FROM ChiTietHoaDon
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'CTHD00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'CTHD0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDCTPN]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--ctpn--
CREATE FUNCTION [dbo].[AUTO_IDCTPN]()
RETURNS VARCHAR(7)
AS
BEGIN
	DECLARE @ID VARCHAR(7)
	IF (SELECT COUNT(MaCTPN) FROM ChiTietPhieuNhap) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCTPN, 3)) FROM ChiTietPhieuNhap
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'CTPN00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'CTPN0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDCV]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--cv--
CREATE FUNCTION [dbo].[AUTO_IDCV]()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaChucVu) FROM ChucVu) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaChucVu, 3)) FROM ChucVu
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'CV00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'CV0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDHD]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--hd--
CREATE FUNCTION [dbo].[AUTO_IDHD]()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaHoaDon) FROM HoaDon) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaHoaDon, 3)) FROM HoaDon
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'HD00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'HD0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDHSX]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--hsx--
CREATE FUNCTION [dbo].[AUTO_IDHSX]()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaHangSanXuat) FROM HangSanXuat) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaHangSanXuat, 3)) FROM HangSanXuat
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'HSX00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'HSX0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDKH]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IDKH]()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaKhachHang) FROM KHACHHANG) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaKhachHang, 3)) FROM KHACHHANG
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'KH00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'KH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDLKH]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--lkh--
CREATE FUNCTION [dbo].[AUTO_IDLKH]()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaLoaiKhachHang) FROM LoaiKhachHang) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaLoaiKhachHang, 3)) FROM LoaiKhachHang
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'LKH00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'LKH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDLSP]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--lsp--
CREATE FUNCTION [dbo].[AUTO_IDLSP]()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaLoaiSanPham) FROM LoaiSanPham) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaLoaiSanPham, 3)) FROM LoaiSanPham
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'LSP00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'LSP0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDNPP]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--npp--
CREATE FUNCTION [dbo].[AUTO_IDNPP]()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaNhaPhanPhoi) FROM NhaPhanPhoi) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaNhaPhanPhoi, 3)) FROM NhaPhanPhoi
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'NPP00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'NPP0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDNV]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--manv--
CREATE FUNCTION [dbo].[AUTO_IDNV]()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaNhanVien) FROM NhanVien) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaNhanVien, 3)) FROM NhanVien
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'NV00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'NV0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDPN]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--pn--
CREATE FUNCTION [dbo].[AUTO_IDPN]()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaPhieuNhap) FROM PhieuNhap) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaPhieuNhap, 3)) FROM PhieuNhap
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'PN00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'PN0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDQ]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--quyen--
CREATE FUNCTION [dbo].[AUTO_IDQ]()
RETURNS VARCHAR(4)
AS
BEGIN
	DECLARE @ID VARCHAR(4)
	IF (SELECT COUNT(MaQuyen) FROM Quyen) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaQuyen, 3)) FROM Quyen
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'Q00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'Q0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDSP]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--sp--
CREATE FUNCTION [dbo].[AUTO_IDSP]()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaSanPham) FROM SanPham) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaSanPham, 3)) FROM SanPham
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'SP00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'SP0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDU]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--user--
CREATE FUNCTION [dbo].[AUTO_IDU]()
RETURNS VARCHAR(4)
AS
BEGIN
	DECLARE @ID VARCHAR(4)
	IF (SELECT COUNT(ID) FROM Users) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(ID, 3)) FROM Users
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'U00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'U0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [varchar](5) NOT NULL,
	[TenSanPham] [nvarchar](50) NOT NULL,
	[LoaiSanPham] [varchar](6) NOT NULL,
	[HangSanXuat] [varchar](6) NOT NULL,
	[GiaNhap] [bigint] NOT NULL,
	[GiaBan] [bigint] NOT NULL,
	[TonKho] [int] NOT NULL,
	[MaMau] [nchar](10) NOT NULL,
	[Image] [varchar](150) NULL,
	[ChuThich] [nvarchar](255) NULL,
 CONSTRAINT [PK__SanPham__FAC7442DCC4F3133] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC,
	[MaMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangSanXuat]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangSanXuat](
	[MaHangSanXuat] [varchar](6) NOT NULL,
	[TenHangSanXuat] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHangSanXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [varchar](6) NOT NULL,
	[TenLoaiSanPham] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ChiTiet_SanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ChiTiet_SanPham] as
select s.MaSanPham, s.TenSanPham, l.TenLoaiSanPham, h.TenHangSanXuat, s.GiaNhap, s.GiaBan, s.TonKho, s.TrangThai
from SanPham s, LoaiSanPham l, HangSanXuat h
where s.LoaiSanPham = l.MaLoaiSanPham and s.HangSanXuat = h.MaHangSanXuat
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [varchar](5) NOT NULL,
	[MaSanPham] [varchar](5) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TongTien] [bigint] NOT NULL,
	[GhiChu] [nvarchar](255) NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [varchar](5) NOT NULL,
	[MaKhachHang] [varchar](5) NOT NULL,
	[MaNhanVien] [varchar](5) NOT NULL,
	[NgayLapHoaDon] [date] NOT NULL,
	[TongTien] [bigint] NOT NULL,
	[TinhTrang] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [varchar](5) NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[LoaiKhachHang] [varchar](6) NOT NULL,
	[GhiChu] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](5) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[NgayVaoLam] [date] NULL,
	[ChucVu] [varchar](5) NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SoDT] [varchar](11) NOT NULL,
	[GhiChu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ChiTiet_HoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

		create view [dbo].[ChiTiet_HoaDon] as
		select c.MaHoaDon, s.TenSanPham, s.GiaBan, c.SoLuong, c.TongTien, h.NgayLapHoaDon, v.TenNhanVien, k.TenKhachHang, h.TongTien as N'Total'
		from ChiTietHoaDon c, SanPham s, HoaDon h, KhachHang k, NhanVien v
		where c.MaSanPham = s.MaSanPham and h.MaHoaDon = c.MaHoaDon and h.MaKhachHang = k.MaKhachHang and h.MaNhanVien = v.MaNhanVien and h.TinhTrang = N'Đã thanh toán'
		
GO
/****** Object:  Table [dbo].[NhaPhanPhoi]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaPhanPhoi](
	[MaNhaPhanPhoi] [varchar](6) NOT NULL,
	[TenNhaPhanPhoi] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[ChuThich] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaPhanPhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [varchar](5) NOT NULL,
	[MaNhanVien] [varchar](5) NOT NULL,
	[MaNhaPhanPhoi] [varchar](6) NOT NULL,
	[TongTien] [bigint] NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[TinhTrang] [nchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [varchar](5) NOT NULL,
	[MaSanPham] [varchar](5) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TongTien] [bigint] NOT NULL,
	[ChuThich] [nvarchar](255) NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ChiTiet_PhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ChiTiet_PhieuNhap] as
select ct.MaPhieuNhap, s.TenSanPham, s.GiaNhap, ct.SoLuong, ct.TongTien, pn.NgayNhap, nv.TenNhanVien, npp.TenNhaPhanPhoi, pn.TongTien as 'Total'
from ChiTietPhieuNhap ct, SanPham s, PhieuNhap pn, NhaPhanPhoi npp, NhanVien nv
where ct.MaSanPham = s.MaSanPham and pn.MaPhieuNhap = ct.MaPhieuNhap and npp.MaNhaPhanPhoi = pn.MaNhaPhanPhoi and pn.MaNhanVien = nv.MaNhanVien and pn.TinhTrang = N'Đã thanh toán'
GO
/****** Object:  Table [dbo].[LoaiKhachHang]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKhachHang](
	[MaLoaiKhachHang] [varchar](6) NOT NULL,
	[TenLoaiKhachHang] [nvarchar](50) NOT NULL,
	[GhiChu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ChiTiet_KhachHang]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ChiTiet_KhachHang] as
select kh.MaKhachHang, kh.TenKhachHang, kh.SDT, kh.NgaySinh, kh.GioiTinh, kh.DiaChi, l.TenLoaiKhachHang
from KhachHang kh, LoaiKhachHang l
where kh.LoaiKhachHang = l.MaLoaiKhachHang
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [varchar](5) NOT NULL,
	[TenChucVu] [nvarchar](50) NOT NULL,
	[GhiChu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ChiTiet_NhanVien]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ChiTiet_NhanVien] as
select nv.MaNhanVien, nv.TenNhanVien, nv.NgaySinh, nv.GioiTinh, nv.SoDT, vc.TenChucVu, nv.DiaChi
from NhanVien nv, ChucVu vc
where nv.ChucVu = vc.MaChucVu
GO
/****** Object:  Table [dbo].[BangMau]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangMau](
	[MaMau] [nchar](10) NOT NULL,
	[TenMau] [nvarchar](50) NULL,
 CONSTRAINT [PK_BangMau] PRIMARY KEY CLUSTERED 
(
	[MaMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManHinh]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManHinh](
	[MaMH] [nvarchar](50) NOT NULL,
	[TenMH] [nvarchar](100) NULL,
 CONSTRAINT [PK_ManHinh] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyenManHinh]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyenManHinh](
	[MaChucVu] [varchar](5) NOT NULL,
	[MaMH] [nvarchar](50) NOT NULL,
	[CoQuyen] [bit] NULL,
 CONSTRAINT [PK_PhanQuyenManHinh] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [varchar](4) NOT NULL,
	[MaNhanVien] [varchar](5) NOT NULL,
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](1000) NOT NULL,
	[ChuThich] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'C001      ', N'Trắng')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD001', N'SP001', 5, 21000000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD001', N'SP002', 3, 1890000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD002', N'SP003', 4, 1300000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD002', N'SP004', 30, 1100000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD002', N'SP005', 6, 7490000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD003', N'SP006', 9, 16200000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD003', N'SP007', 2, 34000000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD004', N'SP008', 9, 1200000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD004', N'SP009', 28, 14000000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD005', N'SP010', 49, 400000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD006', N'SP011', 49, 400000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD006', N'SP012', 45, 1960000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD006', N'SP013', 7, 1800000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD006', N'SP014', 1, 7890000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD007', N'SP015', 1, 7890000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD008', N'SP016', 1, 7890000, NULL)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD008', N'SP017', 3, 1890000, NULL)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD008', N'SP018', 26, 21000000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD009', N'SP001', 2, 0, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD009', N'SP010', 2, 0, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD010', N'SP001', 2, 15780000, N'')
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien], [GhiChu]) VALUES (N'HD011', N'SP001', 58, 457620000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN001', N'SP001', 100, 1000000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN001', N'SP002', 100, 180000000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN002', N'SP003', 100, 130000000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN002', N'SP004', 12, 240000000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN003', N'SP005', 100, 7890000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN003', N'SP006', 100, 7490000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN004', N'SP002', 1, 1800000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN004', N'SP006', 1, 1500000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN004', N'SP007', 300, 3000000, N'demo')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN004', N'SP008', 100, 70000000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN005', N'SP009', 100, 70000000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN005', N'SP010', 200, 3600000, N'demo')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN006', N'SP011', 200, 14780000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN006', N'SP012', 200, 14780000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN007', N'SP013', 300, 22170000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN007', N'SP014', 500, 9000000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN009', N'SP006', 2, 3000000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN009', N'SP010', 1, 12000000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN010', N'SP004', 2, 40000000, N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [TongTien], [ChuThich]) VALUES (N'PN012', N'SP001', 10, 73900000, N'')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (N'CV001', N'Giám Đốc', N'')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (N'CV002', N'Thu Ngân', N'')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (N'CV003', N'Kế Toán', N'')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (N'CV004', N'Bảo Vệ', N'')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (N'CV005', N'Lễ Tân', N'')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (N'CV006', N'Tư vấn khách hàng', N'')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (N'CV007', N'Quản Lý ', N'')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (N'CV008', N'Lao Công', N'')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (N'CV009', N'Kiểm Soát Viên', N'')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (N'CV010', N'chưa có', N'')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [GhiChu]) VALUES (N'CV011', N'giu xe', N'')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX001', N'SamSung')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX002', N'LG')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX003', N'Acer')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX004', N'Sony')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX005', N'Senko')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX006', N'Xiaomi')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX007', N'Asia')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX008', N'Panasonic')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX009', N'Toshiba')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX010', N'Sharp')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX011', N'Beko')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX012', N'TCL')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX013', N'Apple')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX014', N'Aqua')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX015', N'Daikin')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX016', N'Midea')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX017', N'Electrolux')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX018', N'Asanzo')
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat]) VALUES (N'HSX019', N'Dalton')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [TinhTrang]) VALUES (N'HD001', N'KH001', N'NV002', CAST(N'2018-07-03' AS Date), 30790000, N'Đã thanh toán       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [TinhTrang]) VALUES (N'HD002', N'KH002', N'NV002', CAST(N'2018-07-03' AS Date), 4790000, N'Chưa thanh toán     ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [TinhTrang]) VALUES (N'HD003', N'KH003', N'NV002', CAST(N'2018-07-03' AS Date), 172970000, N'Chưa thanh toán     ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [TinhTrang]) VALUES (N'HD004', N'KH004', N'NV002', CAST(N'2018-07-03' AS Date), 15200000, N'Chưa thanh toán     ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [TinhTrang]) VALUES (N'HD005', N'KH005', N'NV002', CAST(N'2018-07-04' AS Date), 2760000, N'Chưa thanh toán     ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [TinhTrang]) VALUES (N'HD006', N'KH006', N'NV002', CAST(N'2018-07-05' AS Date), 7890000, N'Chưa thanh toán     ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [TinhTrang]) VALUES (N'HD007', N'KH007', N'NV002', CAST(N'2018-07-05' AS Date), 7890000, N'Chưa thanh toán     ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [TinhTrang]) VALUES (N'HD008', N'KH008', N'NV002', CAST(N'2019-11-04' AS Date), 157580000, N'Đã thanh toán       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [TinhTrang]) VALUES (N'HD009', N'KH001', N'NV001', CAST(N'2019-11-13' AS Date), 0, N'Đã thanh toán       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [TinhTrang]) VALUES (N'HD010', N'KH001', N'NV001', CAST(N'2019-11-13' AS Date), 125070000, N'Đã thanh toán       ')
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [TinhTrang]) VALUES (N'HD011', N'KH008', N'NV001', CAST(N'2019-11-21' AS Date), 630590000, N'Đã thanh toán       ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES (N'KH001', N'Nguyễn Thanh Tùng', CAST(N'1996-03-02' AS Date), N'Nam', N'Thái Bình', N'0909898964', N'LKH001', N'          ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES (N'KH002', N'Hong Huong', CAST(N'1986-09-02' AS Date), N'Nữ', N'Chua biet', N'0745322222', N'LKH003', N'          ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES (N'KH003', N'đức cường', CAST(N'1980-04-10' AS Date), N'Nam', N'Hà Nội', N'0914232372', N'LKH003', N'mới thêm  ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES (N'KH004', N'Phạm Hồng Hà', CAST(N'1992-06-09' AS Date), N'Nữ', N'102 nguyễn tất thành', N'0166542753', N'LKH001', N'          ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES (N'KH005', N'Hoàng Raper', CAST(N'2000-06-09' AS Date), N'Nam', N' Hải Phòng', N'0166554322', N'LKH002', N'          ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES (N'KH006', N'Phạm Hồng Hà', CAST(N'1992-06-09' AS Date), N'Nam', N'102 nguyễn tất thành', N'0166542753', N'LKH002', N'          ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES (N'KH007', N'phạm hoàng huy', CAST(N'2000-05-03' AS Date), N'Nam', N'hcm', N'0126445654', N'LKH003', N'          ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [LoaiKhachHang], [GhiChu]) VALUES (N'KH008', N'phạm hoàng huy', CAST(N'2000-05-03' AS Date), N'Nam', N'hcm', N'0126445654', N'LKH002', N'          ')
INSERT [dbo].[LoaiKhachHang] ([MaLoaiKhachHang], [TenLoaiKhachHang], [GhiChu]) VALUES (N'LKH001', N'vip', N'')
INSERT [dbo].[LoaiKhachHang] ([MaLoaiKhachHang], [TenLoaiKhachHang], [GhiChu]) VALUES (N'LKH002', N'thường', N'')
INSERT [dbo].[LoaiKhachHang] ([MaLoaiKhachHang], [TenLoaiKhachHang], [GhiChu]) VALUES (N'LKH003', N'sinh viên', N'')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP001', N'Điện lạnh')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP002', N'Điện tử')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP003', N'Điện gia dụng')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP004', N'Smartphone')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP005', N'Phụ Kiện')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP006', N'linh Kiện')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF001', N'Bán hàng')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF002', N'Nhập hàng')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF003', N'Quản lý nhân sự')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF004', N'Quản lý hàng hóa')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV001', N'Phạm Hoàng Huy', CAST(N'1996-12-25' AS Date), N'Nam', CAST(N'2016-01-01' AS Date), N'CV001', N'51- 102 Nguyễn Tất Thành', N'01293223225', N'chức cao nhất có thể')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV002', N'Phạm Văn Toàn', CAST(N'1997-01-02' AS Date), N'Nam', CAST(N'2011-03-05' AS Date), N'CV002', N'Đà Lạt', N'01293223225', N'')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV003', N'Nguyễn Trúc Nhân', CAST(N'1990-06-10' AS Date), N'Nam', CAST(N'2014-12-03' AS Date), N'CV006', N'Hà Nội ', N'091425635', N'')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV004', N'Phạm Băng Băng', CAST(N'1896-03-02' AS Date), N'Nữ', CAST(N'2015-05-04' AS Date), N'CV002', N'việt nam', N'01652343643', N'')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV005', N'Nguyễn Thanh Tùng', CAST(N'1994-07-05' AS Date), N'Nam', CAST(N'2015-09-07' AS Date), N'CV003', N'Thái Bình', N'09090909090', N'')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV006', N'Lương Bích Hữu', CAST(N'1988-06-23' AS Date), N'Nam', CAST(N'2015-06-04' AS Date), N'CV003', N'TP.HCM', N'46789976654', N'')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV007', N'Khởi My', CAST(N'1984-06-03' AS Date), N'Nữ', CAST(N'2015-06-03' AS Date), N'CV004', N'Cần Thơ', N'', N'')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV008', N'Nguyễn thị Hồng', CAST(N'1997-08-07' AS Date), N'Nữ', CAST(N'2011-03-05' AS Date), N'CV004', N'Hà Nội', N'01293223225', N'
')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV009', N'nguyễn Văn Hùng', CAST(N'1994-03-02' AS Date), N'Nam', CAST(N'2011-03-05' AS Date), N'CV005', N'Cầu Giấy', N'01653454267', N'')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV010', N'Phạm Văn Nguyên', CAST(N'1997-01-02' AS Date), N'Nam', CAST(N'2014-03-05' AS Date), N'CV006', N'hà nội', N'0921457432', N'')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV011', N'Lý Bích Thùy', CAST(N'1984-06-03' AS Date), N'Nữ', CAST(N'2015-06-03' AS Date), N'CV006', N'Thái Nguyên', N'01293223225', N'')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV012', N'nguyễn Văn Sang', CAST(N'1994-03-02' AS Date), N'Nam', CAST(N'2011-03-05' AS Date), N'CV006', N'Bình Dương', N'01653454267', N'')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SoDT], [GhiChu]) VALUES (N'NV013', N'Lê Hồng Mai', CAST(N'1984-06-03' AS Date), N'Nữ', CAST(N'2015-06-03' AS Date), N'CV006', N'Q2', N'01293223225', N'')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email], [ChuThich]) VALUES (N'NPP001', N'Cty Nhật Cường', N'Hồ Chí Minh', N'098674322', N'nhatcuong@gmail.com', N'')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email], [ChuThich]) VALUES (N'NPP002', N'Cty Tiến Nhật', N'Trung Quốc ', N'34657865434', N'tienhat@gmail.com', N'')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email], [ChuThich]) VALUES (N'NPP003', N'Cty Phú Lợi', N'Việt Nam', N'34657865434', N'phuloi@gmail.com', N'')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email], [ChuThich]) VALUES (N'NPP004', N'Cty Quang Dương', N'Quảng đông Trung quốc', N'01293223225', N'wanzang@gmail.com', N'')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email], [ChuThich]) VALUES (N'NPP005', N'Cty Hồng Hải', N'Việt Nam', N'34657865434', N'hongghai@gmail.com', N'          ')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email], [ChuThich]) VALUES (N'NPP006', N'Cty ADO', N'Việt Nam', N'34657865434', N'ado23@gmail.com', N'')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN001', N'NV002', N'NPP001', 181000000, CAST(N'2018-04-03' AS Date), N'Đã thanh toán       ')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN002', N'NV003', N'NPP002', 370000000, CAST(N'2019-01-01' AS Date), N'Đã thanh toán       ')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN003', N'NV004', N'NPP003', 100000, CAST(N'2018-07-01' AS Date), N'Chưa thanh toán     ')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN004', N'NV005', N'NPP004', 76300000, CAST(N'2019-04-03' AS Date), N'Chưa thanh toán     ')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN005', N'NV006', N'NPP005', 31170000, CAST(N'2019-11-03' AS Date), N'Đã thanh toán       ')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN006', N'NV007', N'NPP006', 14780000, CAST(N'2019-11-04' AS Date), N'Đã thanh toán       ')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN007', N'NV008', N'NPP006', 14780000, CAST(N'2019-11-07' AS Date), N'Đã thanh toán       ')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN008', N'NV001', N'NPP005', 0, CAST(N'2019-11-13' AS Date), N'Chưa thanh toán     ')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN009', N'NV001', N'NPP001', 15000000, CAST(N'2019-11-20' AS Date), N'Đã thanh toán       ')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN010', N'NV001', N'NPP004', 40000000, CAST(N'2019-11-20' AS Date), N'Đã thanh toán       ')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN011', N'NV001', N'NPP005', 4500000, CAST(N'2019-11-20' AS Date), N'Chưa thanh toán     ')
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap], [TinhTrang]) VALUES (N'PN012', N'NV001', N'NPP001', 73900000, CAST(N'2019-11-21' AS Date), N'Chưa thanh toán     ')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP001', N'Loa công nghệ 7.0', N'LSP002', N'HSX001', 7390000, 7890000, 100, N'C001      ', N'D:\Winform\QuanLyCuaHangDM\Images\lg-ol55d-4.jpg', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP002', N'Máy lạnh', N'LSP001', N'HSX001', 1800000, 1890000, 108, N'C001      ', N'D:\Winform\QuanLyCuaHangDM\Images\vi-vn-beko-rsvc12vs-1.jpg', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP003', N'TV 100in', N'LSP002', N'HSX001', 1300000, 1300000, 10, N'C001      ', N'D:\Winform\QuanLyCuaHangDM\Images\vi-vn-smart-tivi-samsung-32-inch-ua32n4300-(2).jpg', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP004', N'Máy lọc nước', N'LSP003', N'HSX002', 20000000, 21000000, 102, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP005', N'Loa âm thanh vòm', N'LSP002', N'HSX001', 700000, 7490000, 3000, N'C001      ', N'', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP006', N'TV 5k', N'LSP002', N'HSX001', 1500000, 1800000, 106, N'C001      ', N'D:\Winform\QuanLyCuaHangDM\Images\vi-vn-smart-tivi-samsung-32-inch-ua32n4300-(2).jpg', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP007', N'TV 50in', N'LSP002', N'HSX002', 15000000, 17000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP008', N'Máy lạnh', N'LSP001', N'HSX002', 1000000, 1200000, 100, N'C001      ', N'', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP009', N'Máy nước nóng', N'LSP003', N'HSX002', 8490000, 9000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP010', N'Máy giặt', N'LSP003', N'HSX002', 12000000, 12600000, 101, N'C001      ', N'', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP011', N'Máy giặt', N'LSP003', N'HSX002', 10000000, 11000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP012', N'Máy điều họa', N'LSP001', N'HSX008', 20000000, 21000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP013', N'Máy giặt 9kg', N'LSP003', N'HSX008', 1000000, 1200000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP014', N'Máy lạnh', N'LSP001', N'HSX009', 20000000, 21000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP015', N'Tai nghe TrueWireless', N'LSP002', N'HSX009', 20000000, 21000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP016', N'Tai nghe sport', N'LSP002', N'HSX009', 20000000, 21000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP017', N'Máy lạnh', N'LSP001', N'HSX005', 20000000, 21000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP018', N'Máy lạnh', N'LSP001', N'HSX005', 20000000, 21000000, 65, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP019', N'Nồi cơm điện', N'LSP003', N'HSX005', 20000000, 21000000, 102, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP020', N'loa rela bueltooth', N'LSP002', N'HSX005', 10000000, 14000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP021', N'loa rock bueltooth', N'LSP002', N'HSX004', 10000000, 14000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP022', N'loa beataudio bueltooth', N'LSP002', N'HSX004', 10000000, 14000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP023', N'Máy giặt 8kg', N'LSP003', N'HSX004', 900000, 1100000, 17, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP024', N'ipad pro 12.9inch', N'LSP002', N'HSX013', 1800000, 1960000, 89, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP025', N'apple watch', N'LSP002', N'HSX013', 100000000, 144900000, 13, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP026', N'Máy lạnh 2n', N'LSP001', N'HSX006', 140000000, 160000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP027', N'Máy nước nóng', N'LSP003', N'HSX006', 10000000, 12000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP028', N'Máy in HP', N'LSP002', N'HSX006', 11000000, 119900000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP029', N'Máy giặt 10kg', N'LSP003', N'HSX006', 8500000, 8900000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP030', N'Màn hình 50in', N'LSP002', N'HSX010', 100000000, 160000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP031', N'Máy sấy', N'LSP003', N'HSX010', 8000000, 8500000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP032', N'TV 50in', N'LSP002', N'HSX010', 3490000, 3990000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP033', N'TV 50in', N'LSP002', N'HSX011', 7000000, 8000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP034', N'Máy lạnh 1', N'LSP001', N'HSX011', 130000000, 160000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP035', N'TV 50in', N'LSP002', N'HSX011', 299000, 400000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP036', N'TV 50in', N'LSP002', N'HSX012', 3000, 5000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP037', N'ổ cứng samsung ssd 128gb', N'LSP005', N'HSX014', 8000000, 9600000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP038', N'Chuột máy tính', N'LSP005', N'HSX014', 1800000, 1960000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP039', N'Máy lạnh', N'LSP001', N'HSX014', 10000000, 11000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP040', N'samsung s10+', N'LSP002', N'HSX001', 10000000, 11000000, 100, N'C001      ', NULL, N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP041', N'samsung galaxy s10', N'LSP004', N'HSX001', 10000000, 11000000, 100, N'C001      ', N'', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP042', N'Máy lạnh', N'LSP001', N'HSX015', 299000, 400000, 100, N'C001      ', N'', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP043', N'ip 11 pro max', N'LSP004', N'HSX013', 38000000, 40000000, 0, N'C001      ', N'D:\Winform\QuanLyCuaHangDM\Images\image-not-found.jpg', N'hàng mới về')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP044', N'ip 11', N'LSP004', N'HSX013', 20000000, 22000000, 100, N'C001      ', N'D:\Winform\QuanLyCuaHangDM\Images\image-not-found.jpg', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP045', N'macbook 15in', N'LSP002', N'HSX013', 30000000, 35000000, 10, N'C001      ', N'D:\Winform\QuanLyCuaHangDM\Images\lg-ol55d-4.jpg', N'')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [TonKho], [MaMau], [Image], [ChuThich]) VALUES (N'SP046', N'demo', N'LSP001', N'HSX001', 1, 1, 1, N'C001      ', N'', N'')
INSERT [dbo].[Users] ([ID], [MaNhanVien], [TenDangNhap], [MatKhau], [ChuThich]) VALUES (N'U001', N'NV001', N'admin', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', N'người có thẩm quyền cao nhất')
INSERT [dbo].[Users] ([ID], [MaNhanVien], [TenDangNhap], [MatKhau], [ChuThich]) VALUES (N'U002', N'NV002', N'sa', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', NULL)
INSERT [dbo].[Users] ([ID], [MaNhanVien], [TenDangNhap], [MatKhau], [ChuThich]) VALUES (N'U003', N'NV003', N'pop', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', NULL)
INSERT [dbo].[Users] ([ID], [MaNhanVien], [TenDangNhap], [MatKhau], [ChuThich]) VALUES (N'U004', N'NV004', N'kol', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', NULL)
INSERT [dbo].[Users] ([ID], [MaNhanVien], [TenDangNhap], [MatKhau], [ChuThich]) VALUES (N'U005', N'nv008', N'om', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', NULL)
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  CONSTRAINT [DF_ChiTietPhieuNhap_ChuThich]  DEFAULT ('') FOR [ChuThich]
GO
ALTER TABLE [dbo].[ChucVu] ADD  CONSTRAINT [PK_ChucVu]  DEFAULT ([DBO].[AUTO_IDCV]()) FOR [MaChucVu]
GO
ALTER TABLE [dbo].[ChucVu] ADD  CONSTRAINT [DF_ChucVu_GhiChu]  DEFAULT ('') FOR [GhiChu]
GO
ALTER TABLE [dbo].[HangSanXuat] ADD  CONSTRAINT [PK_HangSanXUat]  DEFAULT ([DBO].[AUTO_IDHSX]()) FOR [MaHangSanXuat]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [PK_HoaDon]  DEFAULT ([DBO].[AUTO_IDHD]()) FOR [MaHoaDon]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_NgayLapHoaDon]  DEFAULT (getdate()) FOR [NgayLapHoaDon]
GO
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [PK_KhachHang]  DEFAULT ([DBO].[AUTO_IDKH]()) FOR [MaKhachHang]
GO
ALTER TABLE [dbo].[LoaiKhachHang] ADD  CONSTRAINT [PK_LoaiKhachHang]  DEFAULT ([DBO].[AUTO_IDLKH]()) FOR [MaLoaiKhachHang]
GO
ALTER TABLE [dbo].[LoaiSanPham] ADD  CONSTRAINT [PK_LoaiSanPham]  DEFAULT ([DBO].[AUTO_IDLSP]()) FOR [MaLoaiSanPham]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [PK_NhanVien]  DEFAULT ([DBO].[AUTO_IDNV]()) FOR [MaNhanVien]
GO
ALTER TABLE [dbo].[NhaPhanPhoi] ADD  CONSTRAINT [PK_NhaPhanPhoi]  DEFAULT ([DBO].[AUTO_IDNPP]()) FOR [MaNhaPhanPhoi]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  CONSTRAINT [PK_PhieuNhap]  DEFAULT ([DBO].[AUTO_IDPN]()) FOR [MaPhieuNhap]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [PK_SanPham]  DEFAULT ([DBO].[AUTO_IDSP]()) FOR [MaSanPham]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF_SanPham_image]  DEFAULT ('') FOR [Image]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF_SanPham_ChuThich]  DEFAULT ('') FOR [ChuThich]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [PK_TaiKhoan]  DEFAULT ([DBO].[AUTO_IDU]()) FOR [ID]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap1] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap1]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKhachHang] FOREIGN KEY([LoaiKhachHang])
REFERENCES [dbo].[LoaiKhachHang] ([MaLoaiKhachHang])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKhachHang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([ChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[PhanQuyenManHinh]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyenManHinh_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[PhanQuyenManHinh] CHECK CONSTRAINT [FK_PhanQuyenManHinh_ChucVu]
GO
ALTER TABLE [dbo].[PhanQuyenManHinh]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyenManHinh_ManHinh] FOREIGN KEY([MaMH])
REFERENCES [dbo].[ManHinh] ([MaMH])
GO
ALTER TABLE [dbo].[PhanQuyenManHinh] CHECK CONSTRAINT [FK_PhanQuyenManHinh_ManHinh]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaPhanPhoi] FOREIGN KEY([MaNhaPhanPhoi])
REFERENCES [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaPhanPhoi]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_BangMau] FOREIGN KEY([MaMau])
REFERENCES [dbo].[BangMau] ([MaMau])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_BangMau]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_HangSanXuat] FOREIGN KEY([HangSanXuat])
REFERENCES [dbo].[HangSanXuat] ([MaHangSanXuat])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_HangSanXuat]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([LoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[DBRestore]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[DBRestore]

@name VARCHAR(MAX) = 'QuanLySanPham' -- DB NAME TO Restore
AS
BEGIN

DECLARE @SQL VARCHAR(MAX)
DECLARE @NewDBName VARCHAR(MAX) -- NEW DB NAME TO RESTORE THE BACKED UP DB.
DECLARE @FileNameOrgBackup VARCHAR(MAX) -- Backup file name to restore
DECLARE @PathOrgignalBackup VARCHAR(MAX) -- Path of backup file to restore

SET @NewDBName = @name
SET @PathOrgignalBackup = 'D:\Winform\QuanLyCuaHangDM\Backup\'
SET @FileNameOrgBackup = @PathOrgignalBackup + @name + '.bak'
SET @SQL = ''

SET @SQL ='RESTORE DATABASE ' + @NewDBName
SET @SQL = @SQL + ' FROM DISK = ''' + @FileNameOrgBackup + ''''

select @SQL
--EXECUTE(@SQL)
END
GO
/****** Object:  StoredProcedure [dbo].[getChucVu]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getChucVu]
(
	@TenDangNhap varchar(50)
)
as
Begin
	select ChucVu from Users u, NhanVien n where TenDangNhap = @TenDangNhap and n.MaNhanVien = u.MaNhanVien
End
GO
/****** Object:  StoredProcedure [dbo].[spBackup]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spBackup]
(
			--@Name VARCHAR(MAX)
			@Path VARCHAR(MAX)
)
as
Begin
		DECLARE @Name VARCHAR(256)
		--DECLARE @path VARCHAR(256) -- path of backup files
		DECLARE @fileNameFull VARCHAR(256) -- filename for backup
		DECLARE @fileDate VARCHAR(20) -- used for file name
		DECLARE @fileNameDiff VARCHAR(256)
		DECLARE @fileNameLog VARCHAR(256)
		DECLARE @fileNameTail VARCHAR(256)

		--SET @path = 'D:\Winform\QuanLyCuaHangDM\Backup\'
		SET @Name = 'QuanLySanPham'
		-- specify filename format
		SELECT @fileDate = CONVERT(VARCHAR(20),GETDATE(),112)

		BEGIN
		SET @fileNameFull = @path + '\' + @name + @fileDate + '_'  + 'Full.BAK'
		SET @fileNameDiff = @path + '\' + @name + @fileDate + '_'  + 'Diff.BAK'
		SET @fileNameLog = @path + '\' + @name + @fileDate + '_'  + 'Log.TRN'
		SET @fileNameTail = @path + '\' + @name + @fileDate + '_'  + 'Tail.TRN'
		BACKUP DATABASE @name TO DISK = @fileNameFull with init
		BACKUP DATABASE @name TO DISK = @fileNameDiff WITH DIFFERENTIAL, init
		BACKUP LOG @name TO DISK = @fileNameLog with init
		BACKUP LOG @name TO DISK = @fileNameTail with no_truncate
		END
End
GO
/****** Object:  StoredProcedure [dbo].[spChangePass]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spChangePass]
(
	@TenDangNhap varchar(50),
	@MatKhau varchar(200)
)
as
Begin
	update Users set 
						MatKhau = @MatKhau									 
		where TenDangNhap =@TenDangNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spCheckDangNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spCheckDangNhap]
(
		@TenDangNhap		varchar(100),
		@MatKhau		nvarchar(200)
)
	as
	Begin
				select	* from Users dn
				where		dn.TenDangNhap= @TenDangNhap
				and			dn.MatKhau=@MatKhau				
	End
GO
/****** Object:  StoredProcedure [dbo].[spCheckTaiKhoan]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spCheckTaiKhoan]
(
	@TenDangNhap varchar(50),
	@MatKhau varchar(200)
)
as
Begin
	select count(*) from Users where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau
End
GO
/****** Object:  StoredProcedure [dbo].[spCheckTinhTrangHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spCheckTinhTrangHoaDon]
(
			@MaHoaDon			varchar(5)
)
as
Begin
	select count(*) from HoaDon where MaHoaDon = @MaHoaDon and TinhTrang = N'Đã thanh toán'
End
GO
/****** Object:  StoredProcedure [dbo].[spCheckTinhTrangPhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spCheckTinhTrangPhieuNhap]
(
			@MaPhieuNhap			varchar(5)
)
as
Begin
	select count(*) from PhieuNhap where MaPhieuNhap = @MaPhieuNhap and TinhTrang = N'Đã thanh toán'
End
GO
/****** Object:  StoredProcedure [dbo].[spCheckTonTai]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spCheckTonTai]
(
		@MaNhanVien		varchar(5),
		@TenDangNhap	nvarchar(50)
)
	as
	Begin
				select	count(*) from Users dn
				where		dn.TenDangNhap= @TenDangNhap
				or			dn.MaNhanVien=@MaNhanVien				
	End
GO
/****** Object:  StoredProcedure [dbo].[spCheckTonTaiMNV]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spCheckTonTaiMNV]
(
		@MaNhanVien				varchar(5)
)
	as
	Begin
				select	count(*) from NhanVien where MaNhanVien = @MaNhanVien				
	End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteChucVu]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------- spDeleteChucVu ---------------------*/
create procedure [dbo].[spDeleteChucVu]
(
	@MaChucVu varchar(5)
)
as
Begin
	delete from ChucVu where MaChucVu = @MaChucVu
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteCTHD]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------- Delete CTPN ---------------------*/
create procedure [dbo].[spDeleteCTHD]
(
	@MaCTHD varchar(7)
)
as
Begin	
	delete from ChiTietHoaDon where MaCTHD = @MaCTHD
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteCTPN]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteCTPN]
(
	@MaCTPN varchar(7)
)
as
Begin
	delete from ChiTietPhieuNhap where MaCTPN=@MaCTPN
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteHangSX]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------- Delete LoaiSanPham ---------------------*/
create procedure [dbo].[spDeleteHangSX]
(
	@MaHangSanXuat varchar(6)
)
as
Begin
	delete from HangSanXuat where MaHangSanXuat = @MaHangSanXuat
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteHoaDon]
(
	@MaHoaDon varchar(5)
)
as
Begin
	delete from HoaDon where MaHoaDon=@MaHoaDon
	delete from ChiTietHoaDon where MaHoaDon = @MaHoaDon
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteKhachHang]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteKhachHang]
(
	@MaKhachHang varchar(5)
)
as
Begin
	delete from KhachHang where MaKhachHang=@MaKhachHang
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteLoaiKhachHang]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteLoaiKhachHang]
(
	@MaLoaiKhachHang varchar(6)
)
as
Begin
	delete from LoaiKhachHang where MaLoaiKhachHang = @MaLoaiKhachHang
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteLoaiSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteLoaiSanPham]
(
	@MaLoaiSanPham varchar(6)
)
as
Begin
	delete from LoaiSanPham where MaLoaiSanPham = @MaLoaiSanPham
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteNhanVien]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteNhanVien]
(
	@MaNhanVien varchar(5)
)
as
Begin
	delete from NhanVien where MaNhanVien=@MaNhanVien
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteNhaPhanPhoi]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------- Delete NhaPhanPhoi ---------------------*/
create procedure [dbo].[spDeleteNhaPhanPhoi]
(
	@MaNhaPhanPhoi varchar(6)
)
as
Begin
	delete from NhaPhanPhoi where MaNhaPhanPhoi=@MaNhaPhanPhoi
End
GO
/****** Object:  StoredProcedure [dbo].[spDeletePhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------- Delete PhieuNhap ---------------------*/
create procedure [dbo].[spDeletePhieuNhap]
(
	@MaPhieuNhap varchar(5)
)
as
Begin
	delete from PhieuNhap where MaPhieuNhap=@MaPhieuNhap
	delete from ChiTietPhieuNhap where MaPhieuNhap = @MaPhieuNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteSanPham]
(
	@MaSanPham varchar(5)
)
as
Begin
	delete from SanPham where MaSanPham = @MaSanPham
End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteUser]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------- Delete users ---------------------*/
create procedure [dbo].[spDeleteUser]
(
	@ID						varchar(4)
)
as
Begin
	delete from Users where ID=@ID
End
GO
/****** Object:  StoredProcedure [dbo].[spgetChucVu]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetChucVu]
as
Begin
	select * from ChucVu
End
GO
/****** Object:  StoredProcedure [dbo].[spgetCTHD]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetCTHD]
as
Begin
	select *from ChiTietHoaDon
End
GO
/****** Object:  StoredProcedure [dbo].[spgetCTHDByMaHD]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetCTHDByMaHD]
(
	@MaHoaDon varchar(5)
)
as
Begin
	select *from ChiTietHoaDon where MaHoaDon = @MaHoaDon
End
GO
/****** Object:  StoredProcedure [dbo].[spgetCTPN]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetCTPN]
as
Begin
	select *from ChiTietPhieuNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spgetCTPNByMaPN]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetCTPNByMaPN]
(
	@MaPhieuNhap		varchar(5)
)
as
Begin
	select *from ChiTietPhieuNhap where MaPhieuNhap = @MaPhieuNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spGetGiaBanByMaSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetGiaBanByMaSanPham]
(
	@MaSanPham varchar(5)
)
as
Begin
	select GiaBan from SanPham where MaSanPham = @MaSanPham
End
GO
/****** Object:  StoredProcedure [dbo].[spGetGiaNhapByMaSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetGiaNhapByMaSanPham]
(
	@MaSanPham varchar(5)
)
as
Begin
	select GiaNhap from SanPham where MaSanPham = @MaSanPham
End
GO
/****** Object:  StoredProcedure [dbo].[spgetHangSX]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetHangSX]
as
Begin
	select * from HangSanXuat
End
GO
/****** Object:  StoredProcedure [dbo].[spgetHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetHoaDon]
as
Begin
	select *from HoaDon
End
GO
/****** Object:  StoredProcedure [dbo].[spGetIdUser]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetIdUser]
(
	@TenDangNhap varchar(50)
)
as
Begin
	select MaNhanVien from Users where TenDangNhap = @TenDangNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spgetKhachHang]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetKhachHang]
as
Begin
	select *from KhachHang
End
GO
/****** Object:  StoredProcedure [dbo].[spgetLoaiKhachHang]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetLoaiKhachHang]
as
Begin
	select * from LoaiKhachHang
End
GO
/****** Object:  StoredProcedure [dbo].[spgetLoaiSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetLoaiSanPham]
as
Begin
	select * from LoaiSanPham
End
GO
/****** Object:  StoredProcedure [dbo].[spGetMaKHByMaHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetMaKHByMaHoaDon]
(
	@MaHoaDon varchar(5)
)
as
Begin
	select MaKhachHang from HoaDon where MaHoaDon = @MaHoaDon
End
GO
/****** Object:  StoredProcedure [dbo].[spGetMaNPPByMaPhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetMaNPPByMaPhieuNhap]
(
	@MaPhieuNhap varchar(5)
)
as
Begin
	select TenNhaPhanPhoi from PhieuNhap p, NhaPhanPhoi n where MaPhieuNhap = @MaPhieuNhap and p.MaNhaPhanPhoi = n.MaNhaPhanPhoi
End
GO
/****** Object:  StoredProcedure [dbo].[spGetMaNVByMaHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetMaNVByMaHoaDon]
(
	@MaHoaDon varchar(5)
)
as
Begin
	select MaNhanVien from HoaDon where MaHoaDon = @MaHoaDon
End
GO
/****** Object:  StoredProcedure [dbo].[spGetMaNVByMaPhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGetMaNVByMaPhieuNhap]
(
	@MaPhieuNhap varchar(5)
)
as
Begin
	select MaNhanVien from PhieuNhap where MaPhieuNhap = @MaPhieuNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spGetNgayLapHoaDonByMaHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------------- spGetNgayNhapByMaHoaDon -------------------*/
create procedure [dbo].[spGetNgayLapHoaDonByMaHoaDon]
(
	@MaHoaDon varchar(5)
)
as
Begin
	select NgayLapHoaDon from HoaDon where MaHoaDon = @MaHoaDon
End
GO
/****** Object:  StoredProcedure [dbo].[spGetNgayNhapByMaPhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------------- spGetNgayNhapByMaPhieuNhap -------------------*/
create procedure [dbo].[spGetNgayNhapByMaPhieuNhap]
(
	@MaPhieuNhap varchar(5)
)
as
Begin
	select NgayNhap from PhieuNhap where MaPhieuNhap = @MaPhieuNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spgetNhanVien]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetNhanVien]
as
Begin
	select *from NhanVien
	--IdNhanVien as 'Id Nhân Viên ',HoLot + + Ten as ' Họ Tên ',Ngaysinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',DienThoai as 'Điện Thoại',Email,DiaChi as 'Địa chỉ' 
End
GO
/****** Object:  StoredProcedure [dbo].[spgetNhanVienByIdNhanVien]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetNhanVienByIdNhanVien]
(
	@MaNhanVien varchar(5)
)
as
Begin
	select * from NhanVien where MaNhanVien = @MaNhanVien
End

GO
/****** Object:  StoredProcedure [dbo].[spgetNhaPhanPhoi]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetNhaPhanPhoi]
as
Begin
	select *from NhaPhanPhoi
End
GO
/****** Object:  StoredProcedure [dbo].[spgetPhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetPhieuNhap]
as
Begin
	select *from PhieuNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spgetSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetSanPham]
as
Begin
	select * from SanPham
End
GO
/****** Object:  StoredProcedure [dbo].[spgetSanPhamByMaSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetSanPhamByMaSanPham]
(
	@MaSanPham varchar(5)
)
as
Begin
	select * from SanPham where MaSanPham = @MaSanPham
End
GO
/****** Object:  StoredProcedure [dbo].[spgetTenHangSanXuat]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetTenHangSanXuat]
as
Begin
	select TenHangSanXuat from HangSanXuat
End
GO
/****** Object:  StoredProcedure [dbo].[spGetTinhTrangByMaHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------------- spGetTinhTrangByMaHoaDon -------------------*/
create procedure [dbo].[spGetTinhTrangByMaHoaDon]
(
	@MaHoaDon varchar(5)
)
as
Begin
	select TinhTrang from HoaDon where MaHoaDon = @MaHoaDon
End
GO
/****** Object:  StoredProcedure [dbo].[spGetTinhTrangByMaPhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------------- spGetTinhTrangByMaPhieuNhap -------------------*/
create procedure [dbo].[spGetTinhTrangByMaPhieuNhap]
(
	@MaPhieuNhap varchar(5)
)
as
Begin
	select TinhTrang from PhieuNhap where MaPhieuNhap = @MaPhieuNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spGetTongTienByMaHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------------- spGetTongTienByMaHoaDon -------------------*/
create procedure [dbo].[spGetTongTienByMaHoaDon]
(
	@MaHoaDon varchar(5)
)
as
Begin
	select TongTien from HoaDon where MaHoaDon = @MaHoaDon
End
GO
/****** Object:  StoredProcedure [dbo].[spGetTongTienByMaPhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------------- spGetTongTienByMaPhieuNhap -------------------*/
create procedure [dbo].[spGetTongTienByMaPhieuNhap]
(
	@MaPhieuNhap varchar(5)
)
as
Begin
	select TongTien from PhieuNhap where MaPhieuNhap = @MaPhieuNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spgetTonKho]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetTonKho]
(
	@MaSanPham nchar(5)
)
as
Begin
	select TonKho from SanPham where MaSanPham = @MaSanPham
End
GO
/****** Object:  StoredProcedure [dbo].[spgetuser]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------------- Hien thi thong tin users -------------------*/
create procedure [dbo].[spgetuser]
as
Begin
	select * from Users
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertChucVu]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertChucVu]
(
			@TenChucVu			nvarchar(50),
			@GhiChu						nvarchar(50)
)
as
Begin
		insert into ChucVu(TenChucVu, GhiChu)
		values(@TenChucVu, @GhiChu)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertCTHD]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-------------- Insert CTHD -----------------------------*/
create procedure [dbo].[spInsertCTHD]
(
			@MaHoaDon				varchar(5),
			@MaSanPham				varchar(5),
			@SoLuong				int,
			@GhiChu					nvarchar(255)
)
as
Begin
		insert into ChiTietHoaDon( MaHoaDon, MaSanPham, SoLuong, TongTien, GhiChu)
		values(@MaHoaDon, @MaSanPham, @SoLuong, 0, @GhiChu)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertCTPN]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertCTPN]
(
			@MaPhieuNhap			varchar(5),
			@MaSanPham				varchar(5),
			@SoLuong				int,
			@ChuThich				nvarchar(255)
)
as
Begin
		insert into ChiTietPhieuNhap( MaPhieuNhap, MaSanPham, SoLuong, TongTien, ChuThich)
		values(@MaPhieuNhap, @MaSanPham, @SoLuong, 0, @ChuThich)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertDangNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertDangNhap]
(
		@MaNhanVien			varchar(5),
		@TenDangNhap		varchar(100),
		@MatKhau			nvarchar(200)
)
	as
	Begin
				insert into Users(MaNhanVien, TenDangNhap, MatKhau)
				values(@MaNhanVien, @TenDangNhap, @MatKhau)				
	End
GO
/****** Object:  StoredProcedure [dbo].[spInsertHangSX]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertHangSX]
(
			@TenHangSanXuat			nvarchar(50)
)
as
Begin
		insert into HangSanXuat(TenHangSanXuat)
		values(@TenHangSanXuat)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertHoaDon]
(
			@MaKhachHang			varchar(5),
			@MaNhanVien				varchar(5)
)
as
Begin
		insert into HoaDon(MaKhachHang, MaNhanVien, NgayLapHoaDon, TongTien, TinhTrang)
		values(@MaKhachHang, @MaNhanVien, GETDATE(), 0, N'Chưa thanh toán')
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertKhachHang]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertKhachHang]
(
			@TenKhachHang			nvarchar(50),
			@NgaySinh				date,
			@GioiTinh				nvarchar(10),
			@DiaChi					nvarchar(50),
			@SDT					varchar(11),
			@LoaiKhachHang			varchar(6),
			@GhiChu					nvarchar(255)
)
as
Begin
		insert into KhachHang(TenKhachHang, NgaySinh, GioiTinh, DiaChi, SDT, LoaiKhachHang, GhiChu)
		values(@TenKhachHang, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @LoaiKhachHang, @GhiChu)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertLoaiKhachHang]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertLoaiKhachHang]
(
			@TenLoaiKhachHang			nvarchar(50),
			@GhiChu						nvarchar(50)
)
as
Begin
		insert into LoaiKhachHang(TenLoaiKhachHang, GhiChu)
		values(@TenLoaiKhachHang, @GhiChu)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertLoaiSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertLoaiSanPham]
(
			@TenLoaiSanPham			nvarchar(50)
)
as
Begin
		insert into LoaiSanPham(TenLoaiSanPham)
		values(@TenLoaiSanPham)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertNhanVien]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertNhanVien]
(
			@TenNhanVien			nvarchar(50),
			@NgaySinh				date,
			@GioiTinh				nvarchar(10),
			@ChucVu					varchar(5),
			@DiaChi					nvarchar(50),
			@SoDT					varchar(11),
			@GhiChu					nvarchar(255)
)
as
Begin
		insert into NhanVien(TenNhanvien, NgaySinh, GioiTinh, ChucVu, DiaChi, SoDT, GhiChu)
		values(@TenNhanVien, @NgaySinh, @GioiTinh, @ChucVu, @DiaChi, @SoDT, @GhiChu)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertNhaPhanPhoi]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertNhaPhanPhoi]
(
			@TenNhaPhanPhoi			nvarchar(50),
			@DiaChi					nvarchar(50),
			@SDT					varchar(11),
			@Email					nvarchar(50),
			@ChuThich				nvarchar(255)
)
as
Begin
		insert into NhaPhanPhoi(TenNhaPhanPhoi, DiaChi, SDT, Email, ChuThich)
		values(@TenNhaPhanPhoi, @DiaChi, @SDT, @Email, @ChuThich)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertPhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertPhieuNhap]
(
			@MaNhanVien				varchar(5),
			@MaNhaPhanPhoi			varchar(6)
)
as
Begin
		insert into PhieuNhap(MaNhanVien, MaNhaPhanPhoi, TongTien, NgayNhap, TinhTrang)
		values(@MaNhanVien, @MaNhaPhanPhoi, 0, GETDATE(), N'Chưa thanh toán')
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertSanPham]
(
			@TenSanPham			nvarchar(50),
			@LoaiSanPham		varchar(6),
			@HangSanXuat		varchar(6),
			@GiaNhap			int,
			@GiaBan				int,
			@TonKho				int,
			@TrangThai			nchar(10),
			@Image				nvarchar(100),
			@ChuThich			nvarchar(50)
)
as
Begin
		insert into SanPham(TenSanPham, LoaiSanPham, HangSanXuat, GiaNhap, GiaBan, TonKho, TrangThai, Image, ChuThich)
		values(@TenSanPham, @LoaiSanPham, @HangSanXuat, @GiaNhap, @GiaBan, @TonKho, @TrangThai, @Image, @ChuThich)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertUser]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*-------------- Insert users -----------------------------*/
create procedure [dbo].[spInsertUser]
(
			@MaNhanVien				varchar(5),
			@TenDangNhap			varchar(50),
			@MatKhau				nvarchar(200),
			@ChuThich				nvarchar(255)
)
as
Begin
		insert into Users(MaNhanVien, TenDangNhap, MatKhau, ChuThich)
		values(@MaNhanVien, @TenDangNhap, @MatKhau, @ChuThich)
End
GO
/****** Object:  StoredProcedure [dbo].[spRestoreFullAndLog]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spRestoreFullAndLog]
(
		@fileName	VARCHAR(256) 
)
as
Begin
		RESTORE DATABASE QuanLySanPham FROM DISK = @fileName WITH NORECOVERY
End
GO
/****** Object:  StoredProcedure [dbo].[spRestoreTail]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spRestoreTail]
(
		@fileNameTail	VARCHAR(256)
)
as
Begin
		RESTORE DATABASE QuanLySanPham FROM DISK = @fileNameTail with RECOVERY
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateChucVu]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--drop proc spUpdateSanPham
/*------------------- spUpdateChucVu -----------------------*/
create procedure [dbo].[spUpdateChucVu]
(
			@MaChucVu			varchar(5),
			@TenChucVu			nvarchar(50),
			@GhiChu						nvarchar(50)
)
as
Begin
		update ChucVu set 
						TenChucVu =	@TenChucVu
						 
		where MaChucVu = @MaChucVu
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCTHD]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateCTHD]
(
			@MaCTHD					varchar(7),
			@MaHoaDon				varchar(5),
			@MaSanPham				varchar(5),
			@SoLuong				int,
			@GhiChu					nvarchar(255)
)
as
Begin
	update ChiTietHoaDon set 
						MaHoaDon		=	@MaHoaDon,
						MaSanPham		=	@MaSanPham,
						SoLuong			=	@SoLuong,
						GhiChu		=	@GhiChu								 
		where MaCTHD = @MaCTHD
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCTPN]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateCTPN]
(
			@MaCTPN					varchar(7),
			@MaPhieuNhap			varchar(5),
			@MaSanPham				varchar(5),
			@SoLuong				int,
			@ChuThich				nvarchar(255)
)
as
Begin
	update ChiTietPhieuNhap set 
						MaPhieuNhap		=	@MaPhieuNhap,
						MaSanPham		=	@MaSanPham,
						SoLuong			=	@SoLuong,
						ChuThich		=	@ChuThich								 
		where MaCTPN = @MaCTPN
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateHangSX]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--drop proc spUpdateSanPham
/*------------------- Update LoaiSanPham -----------------------*/
create procedure [dbo].[spUpdateHangSX]
(
			@MaHangSanXuat			varchar(6),
			@TenHangSanXuat			nvarchar(50)
)
as
Begin
		update HangSanXuat set 
						TenHangSanXuat =	@TenHangSanXuat
						 
		where MaHangSanXuat = @MaHangSanXuat
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateHoaDon]
(
			@MaHoaDon				varchar(5),
			@MaKhachHang			varchar(5)
)
as
Begin
	update HoaDon set 
						MaKhachHang		=	@MaKhachHang										 
		where MaHoaDon = @MaHoaDon
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateKhachHang]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateKhachHang]
(
			@MaKhachHang			varchar(5),
			@TenKhachHang			nvarchar(50),
			@NgaySinh				date,
			@GioiTinh				nvarchar(10),
			@DiaChi					nvarchar(50),
			@SDT					varchar(11),
			@LoaiKhachHang			varchar(6),
			@GhiChu					nvarchar(255) 	 
)
as
Begin
	update KhachHang set 
						TenKhachHang =	@TenKhachHang,
						NgaySinh	=	@NgaySinh,
						GioiTinh	=	@GioiTinh,
						DiaChi		=	@DiaChi,
						SDT			=	@SDT,
						LoaiKhachHang = @LoaiKhachHang,
						GhiChu		=	@GhiChu
											 
		where MaKhachHang = @MaKhachHang
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateLoaiKhachHang]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateLoaiKhachHang]
(
			@MaLoaiKhachHang			varchar(6),
			@TenLoaiKhachHang			nvarchar(50),
			@GhiChu						nvarchar(50)
)
as
Begin
		update LoaiKhachHang set 
						TenLoaiKhachHang =	@TenLoaiKhachHang
						 
		where MaLoaiKhachHang = @MaLoaiKhachHang
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateLoaiSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateLoaiSanPham]
(
			@MaLoaiSanPham			varchar(6),
			@TenLoaiSanPham			nvarchar(50)
)
as
Begin
		update LoaiSanPham set 
						TenLoaiSanPham =	@TenLoaiSanPham
						 
		where MaLoaiSanPham = @MaLoaiSanPham
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateNhanVien]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateNhanVien]
(
			@MaNhanVien				varchar(5),
			@TenNhanVien			nvarchar(50),
			@NgaySinh				date,
			@GioiTinh				nvarchar(10),
			@ChucVu					varchar(6),
			@DiaChi					nvarchar(50),
			@SoDT					varchar(11),
			@GhiChu					nvarchar(255)  	 
)
as
Begin
	update NhanVien set 
						TenNhanVien =	@TenNhanVien,
						NgaySinh	=	@NgaySinh,
						GioiTinh	=	@GioiTinh,
						ChucVu		=	@ChucVu,
						DiaChi		=	@DiaChi,
						SoDT		=	@SoDT,
						GhiChu		=	@GhiChu
											 
		where MaNhanVien =@MaNhanVien
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateNhaPhanPhoi]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateNhaPhanPhoi]
(
			@MaNhaPhanPhoi			varchar(6),
			@TenNhaPhanPhoi			nvarchar(50),
			@DiaChi					nvarchar(50),
			@SDT					varchar(11),
			@Email					nvarchar(50),
			@ChuThich				nvarchar(255)
)
as
Begin
	update NhaPhanPhoi set 
						TenNhaPhanPhoi	=	@TenNhaPhanPhoi,
						DiaChi			=	@DiaChi,
						SDT				=	@SDT,
						Email			=	@Email,
						ChuThich		=	@ChuThich
											 
		where MaNhaPhanPhoi = @MaNhaPhanPhoi
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdatePhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdatePhieuNhap]
(
			@MaPhieuNhap			varchar(5),
			@MaNhaPhanPhoi			varchar(6)
)
as
Begin
	update PhieuNhap set 
						MaNhaPhanPhoi	=	@MaNhaPhanPhoi										 
		where MaPhieuNhap = @MaPhieuNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateSanPham]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateSanPham]
(
			@MaSanPham			varchar(5),
			@TenSanPham			nvarchar(50),
			@LoaiSanPham		varchar(6),
			@HangSanXuat		varchar(6),
			@GiaNhap			int,
			@GiaBan				int,
			@TonKho				int,
			@TrangThai			nchar(10),
			@Image				nvarchar(100),
			@ChuThich			nvarchar(50)
)
as
Begin
		update SanPham set 
						TenSanPham =	@TenSanPham,
						LoaiSanPham	=	@LoaiSanPham,
						HangSanXuat	=	@HangSanXuat,
						GiaNhap		=	@GiaNhap,
						GiaBan		=	@GiaBan,
						TonKho		=	@TonKho,
						Image		=	@Image,
						TrangThai	=	@TrangThai,
						ChuThich	=	@ChuThich
						 
		where MaSanPham = @MaSanPham
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateTinhTrangHoaDon]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateTinhTrangHoaDon]
(
			@MaHoaDon			varchar(5)
)
as
Begin
	update HoaDon set 
						TinhTrang	=	N'Đã thanh toán'										 
		where MaHoaDon = @MaHoaDon
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateTinhTrangPhieuNhap]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateTinhTrangPhieuNhap]
(
			@MaPhieuNhap			varchar(5)
)
as
Begin
	update PhieuNhap set 
						TinhTrang	=	N'Đã thanh toán'										 
		where MaPhieuNhap = @MaPhieuNhap
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateUser]    Script Date: 7/21/2020 3:14:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------------------- Update users -----------------------*/
create procedure [dbo].[spUpdateUser]
(
			@ID						varchar(4),
			@MaNhanVien				varchar(5),
			@TenDangNhap			varchar(50),
			@MatKhau				nvarchar(200),
			@ChuThich				nvarchar(255)
)
as
Begin
	update Users set 
						MaNhanVien			=	@MaNhanVien,
						TenDangNhap			=	@TenDangNhap,
						MatKhau				=	@MatKhau,
						ChuThich			=	@ChuThich
											 
		where ID = @ID
End
GO
USE [master]
GO
ALTER DATABASE [QuanLySanPham] SET  READ_WRITE 
GO

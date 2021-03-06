USE [master]
GO
/****** Object:  Database [QuanLySanPham]    Script Date: 8/12/2020 1:12:13 AM ******/
CREATE DATABASE [QuanLySanPham]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLySanPham', FILENAME = N'D:\HK6\PTPM&UDTM\Data\QuanLySanPham.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLySanPham_log', FILENAME = N'D:\HK6\PTPM&UDTM\Data\QuanLySanPham_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
EXEC sys.sp_db_vardecimal_storage_format N'QuanLySanPham', N'ON'
GO
USE [QuanLySanPham]
GO
/****** Object:  Table [dbo].[BangMau]    Script Date: 8/12/2020 1:12:13 AM ******/
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
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 8/12/2020 1:12:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [varchar](5) NOT NULL,
	[MaSanPham] [varchar](5) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TongTien] [bigint] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 8/12/2020 1:12:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [varchar](5) NOT NULL,
	[MaSanPham] [varchar](5) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiaNhap] [bigint] NULL,
	[TongTien] [bigint] NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 8/12/2020 1:12:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [varchar](5) NOT NULL,
	[TenChucVu] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangSanXuat]    Script Date: 8/12/2020 1:12:13 AM ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 8/12/2020 1:12:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [varchar](5) NOT NULL,
	[MaKhachHang] [varchar](11) NOT NULL,
	[MaNhanVien] [varchar](5) NOT NULL,
	[NgayLapHoaDon] [date] NOT NULL,
	[TongTien] [bigint] NOT NULL,
 CONSTRAINT [PK__HoaDon__835ED13BEE3E6F91] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 8/12/2020 1:12:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [varchar](11) NOT NULL,
	[TenKhachHang] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[LoaiKhachHang] [varchar](6) NOT NULL,
 CONSTRAINT [PK__KhachHan__88D2F0E59DA5D874] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiKhachHang]    Script Date: 8/12/2020 1:12:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKhachHang](
	[MaLoaiKhachHang] [varchar](6) NOT NULL,
	[TenLoaiKhachHang] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 8/12/2020 1:12:13 AM ******/
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
/****** Object:  Table [dbo].[ManHinh]    Script Date: 8/12/2020 1:12:13 AM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 8/12/2020 1:12:13 AM ******/
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
	[SDT] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaPhanPhoi]    Script Date: 8/12/2020 1:12:13 AM ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaNhaPhanPhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyenManHinh]    Script Date: 8/12/2020 1:12:13 AM ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 8/12/2020 1:12:13 AM ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 8/12/2020 1:12:13 AM ******/
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
	[DVT] [nvarchar](10) NULL,
	[TonKho] [int] NOT NULL,
	[MaMau] [nchar](10) NOT NULL,
	[Image] [varchar](150) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 8/12/2020 1:12:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [varchar](4) NOT NULL,
	[MaNhanVien] [varchar](5) NOT NULL,
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ChiTiet_KhachHang]    Script Date: 8/12/2020 1:12:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ChiTiet_KhachHang] as
select kh.MaKhachHang, kh.TenKhachHang, kh.SDT, kh.NgaySinh, kh.GioiTinh, kh.DiaChi, l.TenLoaiKhachHang
from KhachHang kh, LoaiKhachHang l
where kh.LoaiKhachHang = l.MaLoaiKhachHang
GO
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#000000   ', N'Đen')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#000080   ', N'Xanh nước biển')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#0000FF   ', N'Xanh dương')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#008000   ', N'Xanh lá')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#008080   ', N'Xanh mòng két')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#00FF00   ', N'Vàng chanh')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#00FFFF   ', N'Xanh lơ')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#800000   ', N'Màu hạt dẻ')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#800080   ', N'Tím')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#808000   ', N'Màu ô liu')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#808080   ', N'Xám')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#C0C0C0   ', N'Bạc')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#FF0000   ', N'Đỏ')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#FF00FF   ', N'Màu cánh sen')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#FFFF00   ', N'Vàng')
INSERT [dbo].[BangMau] ([MaMau], [TenMau]) VALUES (N'#FFFFFF   ', N'Trắng')
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD001', N'SP001', 5, 21000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD001', N'SP002', 3, 1890000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD002', N'SP003', 4, 1300000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD002', N'SP004', 30, 1100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD002', N'SP005', 6, 7490000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD003', N'SP006', 9, 16200000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD003', N'SP007', 2, 34000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD004', N'SP008', 9, 1200000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD004', N'SP009', 28, 14000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD005', N'SP010', 49, 400000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD006', N'SP011', 49, 400000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD006', N'SP012', 45, 1960000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD006', N'SP013', 7, 1800000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD006', N'SP014', 1, 7890000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD007', N'SP015', 1, 7890000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD008', N'SP016', 1, 7890000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD008', N'SP017', 3, 1890000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD008', N'SP018', 26, 21000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD010', N'SP001', 2, 15780000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD011', N'SP001', 58, 457620000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD012', N'SP004', 2, 7890000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD013', N'SP002', 1, 1890000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD013', N'SP025', 1, 144900000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD014', N'SP007', 1, 17000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD014', N'SP023', 1, 1100000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD015', N'SP013', 3, 3600000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD015', N'SP016', 3, 63000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD016', N'SP015', 2, 42000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD016', N'SP019', 1, 21000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD017', N'SP001', 1, 7890000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD017', N'SP037', 2, 19200000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD018', N'SP001', 2, 15780000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD018', N'SP003', 1, 1300000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD019', N'SP024', 1, 1960000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD019', N'SP025', 3, 434700000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD020', N'SP001', 1, 7890000)
INSERT [dbo].[ChiTietHoaDon] ([MaHoaDon], [MaSanPham], [SoLuong], [TongTien]) VALUES (N'HD020', N'SP038', 2, 3920000)
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN001', N'SP001', 100, 7390000, 1000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN001', N'SP002', 100, 7390000, 180000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN002', N'SP003', 100, 1800000, 130000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN002', N'SP004', 12, 1800000, 240000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN003', N'SP005', 100, 1300000, 7890000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN003', N'SP006', 100, 1300000, 7490000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN004', N'SP002', 1, 20000000, 1800000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN004', N'SP006', 1, 20000000, 1500000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN004', N'SP007', 300, 20000000, 3000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN004', N'SP008', 100, 20000000, 70000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN005', N'SP009', 100, 700000, 70000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN005', N'SP010', 200, 700000, 3600000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN006', N'SP011', 200, 1500000, 14780000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN006', N'SP012', 200, 1500000, 14780000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN007', N'SP013', 300, 15000000, 22170000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN007', N'SP014', 500, 15000000, 9000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN009', N'SP006', 2, 8490000, 3000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN009', N'SP010', 1, 8490000, 12000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN010', N'SP004', 2, 12000000, 40000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [GiaNhap], [TongTien]) VALUES (N'PN012', N'SP001', 10, 20000000, 73900000)
GO
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV001', N'Giám Đốc')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV002', N'Thu Ngân')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV003', N'Kế Toán')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV004', N'Bảo Vệ')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV005', N'Lễ Tân')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV006', N'Tư vấn khách hàng')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV007', N'Quản Lý ')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV008', N'Lao Công')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV009', N'Kiểm Soát Viên')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV011', N'giu xe')
GO
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
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD001', N'0973278844', N'NV002', CAST(N'2018-07-03' AS Date), 30790000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD002', N'0976323244', N'NV002', CAST(N'2018-07-03' AS Date), 4790000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD003', N'0895894789', N'NV002', CAST(N'2018-07-03' AS Date), 172970000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD004', N'0628864882', N'NV002', CAST(N'2018-07-03' AS Date), 15200000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD005', N'0832323444', N'NV002', CAST(N'2018-07-04' AS Date), 2760000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD006', N'0974532322', N'NV002', CAST(N'2018-07-05' AS Date), 7890000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD007', N'0163234544', N'NV002', CAST(N'2018-07-05' AS Date), 7890000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD008', N'0976323244', N'NV002', CAST(N'2019-11-04' AS Date), 157580000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD010', N'0976323244', N'NV001', CAST(N'2019-11-13' AS Date), 125070000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD011', N'0628864882', N'NV001', CAST(N'2019-11-21' AS Date), 630590000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD012', N'0163234544', N'NV001', CAST(N'2020-07-26' AS Date), 54879000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD013', N'0163234544', N'NV001', CAST(N'2020-07-26' AS Date), 161469000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD014', N'0163234544', N'NV001', CAST(N'2020-07-27' AS Date), 19910000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD015', N'00000000', N'NV002', CAST(N'2020-08-03' AS Date), 101310000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD016', N'00000000', N'NV002', CAST(N'2020-08-03' AS Date), 118800000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD017', N'00000000', N'NV002', CAST(N'2020-08-03' AS Date), 23771000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD018', N'00000000', N'NV002', CAST(N'2020-08-03' AS Date), 24838000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD019', N'00000000', N'NV002', CAST(N'2020-08-03' AS Date), 533126000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien]) VALUES (N'HD020', N'0163234544', N'NV002', CAST(N'2020-08-03' AS Date), 11810000)
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [LoaiKhachHang]) VALUES (N'00000000', N'a', CAST(N'2020-07-15' AS Date), N'Nam', N'â', N'LKH002')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [LoaiKhachHang]) VALUES (N'0163234544', N'Phạm Hoàng Huy', CAST(N'2000-05-03' AS Date), N'Nam', N'233/21 Quang Trung, Phường 15, Q. Gò Vấp', N'LKH003')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [LoaiKhachHang]) VALUES (N'0327871233', N'nguyen the lu', CAST(N'2000-05-03' AS Date), N'Nam', N'hcm', N'LKH002')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [LoaiKhachHang]) VALUES (N'0328826113', N'as', CAST(N'2010-02-09' AS Date), N'Nam', N'đâsdadadadadad', N'LKH001')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [LoaiKhachHang]) VALUES (N'0628864882', N'Phạm Hồng Hà', CAST(N'1992-06-09' AS Date), N'Nữ', N'102 nguyễn tất thành', N'LKH001')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [LoaiKhachHang]) VALUES (N'0832323444', N'Hoàng', CAST(N'2000-06-09' AS Date), N'Nam', N' Hải Phòng', N'LKH002')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [LoaiKhachHang]) VALUES (N'0895894789', N'đức cường', CAST(N'1980-04-10' AS Date), N'Nam', N'HN', N'LKH003')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [LoaiKhachHang]) VALUES (N'0973278844', N'Nguyễn Thanh Tùng', CAST(N'1996-03-02' AS Date), N'Nam', N'Thái Bình', N'LKH001')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [LoaiKhachHang]) VALUES (N'0974532322', N'Phạm Hồng Hà', CAST(N'1992-06-09' AS Date), N'Nam', N'102 nguyễn tất thành', N'LKH002')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [NgaySinh], [GioiTinh], [DiaChi], [LoaiKhachHang]) VALUES (N'0976323244', N'Hong Huong', CAST(N'1986-09-02' AS Date), N'Nữ', N'Chua biet', N'LKH003')
GO
INSERT [dbo].[LoaiKhachHang] ([MaLoaiKhachHang], [TenLoaiKhachHang]) VALUES (N'LKH001', N'vip')
INSERT [dbo].[LoaiKhachHang] ([MaLoaiKhachHang], [TenLoaiKhachHang]) VALUES (N'LKH002', N'thường')
INSERT [dbo].[LoaiKhachHang] ([MaLoaiKhachHang], [TenLoaiKhachHang]) VALUES (N'LKH003', N'sinh viên')
GO
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP001', N'Điện lạnh')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP002', N'Điện tử')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP003', N'Điện gia dụng')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP004', N'Smartphone')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP005', N'Phụ Kiện')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (N'LSP006', N'linh Kiện')
GO
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF001', N'Bán hàng')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF002', N'Nhập hàng')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF003', N'Quản lý nhân sự')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF004', N'Quản lý hàng hóa')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF005', N'Quản lý khách hàng')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF006', N'Quản lý tài khoản')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF007', N'Quản lý nhà cung cấp')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF008', N'Quản lý danh sách phiếu nhập')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF009', N'Quản lý danh sách hóa đơn')
INSERT [dbo].[ManHinh] ([MaMH], [TenMH]) VALUES (N'SF010', N'Phân quyền người dùng')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV001', N'Phạm Hoàng Huy', CAST(N'1996-12-25' AS Date), N'Nam', CAST(N'2016-01-01' AS Date), N'CV001', N'51- 102 Nguyễn Tất Thành', N'0328645287')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV002', N'Biện Quang Trường', CAST(N'1999-04-01' AS Date), N'Nam', CAST(N'2011-03-05' AS Date), N'CV002', N'Gò Vấp', N'0899032312')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV003', N'Nguyễn Trúc Nhân', CAST(N'1990-06-10' AS Date), N'Nam', CAST(N'2014-12-03' AS Date), N'CV006', N'Hà Nội ', N'0853674236')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV004', N'Phạm Băng Băng', CAST(N'1896-03-02' AS Date), N'Nữ', CAST(N'2015-05-04' AS Date), N'CV002', N'việt nam', N'0675634453')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV005', N'Nguyễn Thanh Tùng', CAST(N'1994-07-05' AS Date), N'Nam', CAST(N'2015-09-07' AS Date), N'CV003', N'Thái Bình', N'0656345244')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV006', N'Lương Bích Hữu', CAST(N'1988-06-23' AS Date), N'Nam', CAST(N'2015-06-04' AS Date), N'CV003', N'TP.HCM', N'0532413413')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV007', N'Khởi My', CAST(N'1984-06-03' AS Date), N'Nữ', CAST(N'2015-06-03' AS Date), N'CV004', N'Cần Thơ', N'0524314324')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV008', N'Nguyễn thị Hồng', CAST(N'1997-08-07' AS Date), N'Nữ', CAST(N'2011-03-05' AS Date), N'CV004', N'Hà Nội', N'0542513423')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV009', N'nguyễn Văn Hùng', CAST(N'1994-03-02' AS Date), N'Nam', CAST(N'2011-03-05' AS Date), N'CV005', N'Cầu Giấy', N'0934242433')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV010', N'Phạm Văn Nguyên', CAST(N'1997-01-02' AS Date), N'Nam', CAST(N'2014-03-05' AS Date), N'CV006', N'hà nội', N'0756245234')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV011', N'Lý Bích Thùy', CAST(N'1984-06-03' AS Date), N'Nữ', CAST(N'2015-06-03' AS Date), N'CV006', N'Thái Nguyên', N'0632432425')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV012', N'nguyễn Văn Sang', CAST(N'1994-03-02' AS Date), N'Nam', CAST(N'2011-03-05' AS Date), N'CV006', N'Bình Dương', N'0542512444')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [NgayVaoLam], [ChucVu], [DiaChi], [SDT]) VALUES (N'NV013', N'Lê Hồng Mai', CAST(N'1984-06-03' AS Date), N'Nữ', CAST(N'2015-06-03' AS Date), N'CV006', N'Q2', N'0234355556')
GO
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email]) VALUES (N'NPP001', N'Cty Nhật Cường', N'Hồ Chí Minh', N'098674322', N'nhatcuong@gmail.com')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email]) VALUES (N'NPP002', N'Cty Tiến Nhật', N'Trung Quốc ', N'34657865434', N'tienhat@gmail.com')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email]) VALUES (N'NPP003', N'Cty Phú Lợi', N'Việt Nam', N'34657865434', N'phuloi@gmail.com')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email]) VALUES (N'NPP004', N'Cty Quang Dương', N'Quảng đông Trung quốc', N'01293223225', N'wanzang@gmail.com')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email]) VALUES (N'NPP005', N'Cty Hồng Hải', N'Việt Nam', N'34657865434', N'hongghai@gmail.com')
INSERT [dbo].[NhaPhanPhoi] ([MaNhaPhanPhoi], [TenNhaPhanPhoi], [DiaChi], [SDT], [Email]) VALUES (N'NPP006', N'Cty ADO', N'Việt Nam', N'34657865434', N'ado23@gmail.com')
GO
INSERT [dbo].[PhanQuyenManHinh] ([MaChucVu], [MaMH], [CoQuyen]) VALUES (N'CV001', N'SF001', 1)
INSERT [dbo].[PhanQuyenManHinh] ([MaChucVu], [MaMH], [CoQuyen]) VALUES (N'CV001', N'SF002', 1)
INSERT [dbo].[PhanQuyenManHinh] ([MaChucVu], [MaMH], [CoQuyen]) VALUES (N'CV001', N'SF003', 1)
INSERT [dbo].[PhanQuyenManHinh] ([MaChucVu], [MaMH], [CoQuyen]) VALUES (N'CV001', N'SF004', 0)
INSERT [dbo].[PhanQuyenManHinh] ([MaChucVu], [MaMH], [CoQuyen]) VALUES (N'CV001', N'SF005', 1)
INSERT [dbo].[PhanQuyenManHinh] ([MaChucVu], [MaMH], [CoQuyen]) VALUES (N'CV001', N'SF006', 1)
INSERT [dbo].[PhanQuyenManHinh] ([MaChucVu], [MaMH], [CoQuyen]) VALUES (N'CV001', N'SF007', 1)
INSERT [dbo].[PhanQuyenManHinh] ([MaChucVu], [MaMH], [CoQuyen]) VALUES (N'CV001', N'SF008', 0)
INSERT [dbo].[PhanQuyenManHinh] ([MaChucVu], [MaMH], [CoQuyen]) VALUES (N'CV001', N'SF009', 0)
INSERT [dbo].[PhanQuyenManHinh] ([MaChucVu], [MaMH], [CoQuyen]) VALUES (N'CV001', N'SF010', 1)
INSERT [dbo].[PhanQuyenManHinh] ([MaChucVu], [MaMH], [CoQuyen]) VALUES (N'CV002', N'SF001', 1)
GO
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN001', N'NV002', N'NPP001', 181000000, CAST(N'2018-04-03' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN002', N'NV003', N'NPP002', 370000000, CAST(N'2019-01-01' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN003', N'NV004', N'NPP003', 100000, CAST(N'2018-07-01' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN004', N'NV005', N'NPP004', 76300000, CAST(N'2019-04-03' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN005', N'NV006', N'NPP005', 31170000, CAST(N'2019-11-03' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN006', N'NV007', N'NPP006', 14780000, CAST(N'2019-11-04' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN007', N'NV008', N'NPP006', 14780000, CAST(N'2019-11-07' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN008', N'NV001', N'NPP005', 0, CAST(N'2019-11-13' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN009', N'NV001', N'NPP001', 15000000, CAST(N'2019-11-20' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN010', N'NV001', N'NPP004', 40000000, CAST(N'2019-11-20' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN011', N'NV001', N'NPP005', 4500000, CAST(N'2019-11-20' AS Date))
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhanVien], [MaNhaPhanPhoi], [TongTien], [NgayNhap]) VALUES (N'PN012', N'NV001', N'NPP001', 73900000, CAST(N'2019-11-21' AS Date))
GO
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP001', N'Loa công nghệ 7.0', N'LSP002', N'HSX001', 0, 7890000, N'Cái', 100, N'#000000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP002', N'Máy lạnh', N'LSP001', N'HSX001', 1800000, 1890000, N'Cái', 108, N'#FFFFFF   ', N'D:\HK6\QuanLyCuaHangDM\Images\vi-vn-beko-rsvc12vs-1.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP003', N'TV 100in', N'LSP002', N'HSX001', 1300000, 1300000, N'Cái', 10, N'#000000   ', N'D:\HK6\QuanLyCuaHangDM\Images\vi-vn-smart-tivi-samsung-32-inch-ua32n4300-(2).jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP004', N'Máy lọc nước', N'LSP003', N'HSX002', 20000000, 21000000, N'Cái', 102, N'#FFFFFF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP005', N'Loa âm thanh vòm', N'LSP002', N'HSX001', 700000, 7490000, N'Cái', 3000, N'#000000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP006', N'TV 5k', N'LSP002', N'HSX001', 1500000, 1800000, N'Cái', 106, N'#FFFFFF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP007', N'TV 50in', N'LSP002', N'HSX002', 15000000, 17000000, N'Cái', 100, N'#000000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP008', N'Máy lạnh', N'LSP001', N'HSX002', 1000000, 1200000, N'Cái', 100, N'#FFFFFF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP009', N'Máy nước nóng', N'LSP003', N'HSX002', 8490000, 9000000, N'Cái', 100, N'#000000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP010', N'Máy giặt', N'LSP003', N'HSX002', 12000000, 12600000, N'Cái', 101, N'#FFFFFF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP011', N'Máy giặt', N'LSP003', N'HSX002', 10000000, 11000000, N'Cái', 100, N'#000000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP012', N'Máy điều họa', N'LSP001', N'HSX008', 20000000, 21000000, N'Cái', 100, N'#FFFFFF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP013', N'Máy giặt 9kg', N'LSP003', N'HSX008', 1000000, 1200000, N'Cái', 100, N'#000000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP014', N'Máy lạnh', N'LSP001', N'HSX009', 20000000, 21000000, N'Cái', 100, N'#FFFFFF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP015', N'Tai nghe TrueWireless', N'LSP002', N'HSX009', 20000000, 21000000, N'Cái', 100, N'#000000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP016', N'Tai nghe sport', N'LSP002', N'HSX009', 20000000, 21000000, N'Cái', 100, N'#FF0000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP017', N'Máy lạnh', N'LSP001', N'HSX005', 20000000, 21000000, N'Cái', 100, N'#FF0000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP018', N'Máy lạnh', N'LSP001', N'HSX005', 20000000, 21000000, N'Cái', 65, N'#000080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP019', N'Nồi cơm điện', N'LSP003', N'HSX005', 20000000, 21000000, N'Cái', 102, N'#FF0000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP020', N'loa rela bueltooth', N'LSP002', N'HSX005', 10000000, 14000000, N'Cái', 100, N'#800080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP021', N'loa rock bueltooth', N'LSP002', N'HSX004', 10000000, 14000000, N'Cái', 100, N'#FF0000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP022', N'loa beataudio bueltooth', N'LSP002', N'HSX004', 10000000, 14000000, N'Cái', 100, N'#800080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP023', N'Máy giặt 8kg', N'LSP003', N'HSX004', 900000, 1100000, N'Cái', 17, N'#FF0000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP024', N'ipad pro 12.9inch', N'LSP002', N'HSX013', 1800000, 1960000, N'Cái', 89, N'#800080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP025', N'apple watch', N'LSP002', N'HSX013', 100000000, 144900000, N'Cái', 13, N'#FF0000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP026', N'Máy lạnh 2n', N'LSP001', N'HSX006', 140000000, 160000000, N'Cái', 100, N'#800080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP027', N'Máy nước nóng', N'LSP003', N'HSX006', 10000000, 12000000, N'Cái', 100, N'#FF0000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP028', N'Máy in HP', N'LSP002', N'HSX006', 11000000, 119900000, N'Cái', 100, N'#FF0000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP029', N'Máy giặt 10kg', N'LSP003', N'HSX006', 8500000, 8900000, N'Cái', 100, N'#808080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP030', N'Màn hình 50in', N'LSP002', N'HSX010', 100000000, 160000000, N'Cái', 100, N'#FF0000   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP031', N'Máy sấy', N'LSP003', N'HSX010', 8000000, 8500000, N'Cái', 100, N'#808080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP032', N'TV 50in', N'LSP002', N'HSX010', 3490000, 3990000, N'Cái', 100, N'#808080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP033', N'TV 50in', N'LSP002', N'HSX011', 7000000, 8000000, N'Cái', 100, N'#808080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP034', N'Máy lạnh 1', N'LSP001', N'HSX011', 130000000, 160000000, N'Cái', 100, N'#FF00FF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP035', N'TV 50in', N'LSP002', N'HSX011', 299000, 400000, N'Cái', 100, N'#800080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP036', N'TV 50in', N'LSP002', N'HSX012', 3000, 5000, N'Cái', 100, N'#808080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP037', N'ổ cứng samsung ssd 128gb', N'LSP005', N'HSX014', 8000000, 9600000, N'Cái', 100, N'#FF00FF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP038', N'Chuột máy tính', N'LSP005', N'HSX014', 1800000, 1960000, N'Cái', 100, N'#000080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP039', N'Máy lạnh', N'LSP001', N'HSX014', 10000000, 11000000, N'Cái', 100, N'#FF00FF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP040', N'samsung s10+', N'LSP002', N'HSX001', 10000000, 11000000, N'Cái', 100, N'#FF00FF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP041', N'samsung galaxy s10', N'LSP004', N'HSX001', 10000000, 11000000, N'Cái', 100, N'#000080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP042', N'Máy lạnh', N'LSP001', N'HSX015', 299000, 400000, N'Cái', 100, N'#FF00FF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP043', N'ip 11 pro max', N'LSP004', N'HSX013', 38000000, 40000000, N'Cái', 0, N'#000080   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [LoaiSanPham], [HangSanXuat], [GiaNhap], [GiaBan], [DVT], [TonKho], [MaMau], [Image]) VALUES (N'SP045', N'macbook 15in', N'LSP002', N'HSX013', 30000000, 35000000, N'Cái', 10, N'#FF00FF   ', N'D:\HK6\QuanLyCuaHangDM\Images\image-not-found.jpg')
GO
INSERT [dbo].[Users] ([ID], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (N'U001', N'NV001', N'admin', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[Users] ([ID], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (N'U002', N'NV002', N'truong', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[Users] ([ID], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (N'U003', N'NV003', N'pop', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[Users] ([ID], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (N'U004', N'NV004', N'kol', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[Users] ([ID], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (N'U005', N'nv008', N'om', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3')
INSERT [dbo].[Users] ([ID], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (N'U006', N'NV010', N'Truong22', N'96cae35ce8a9b0244178bf28e4966c2ce1b8385723a96a6b838858cdd6ca0a1e')
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_NgayLapHoaDon]  DEFAULT (getdate()) FOR [NgayLapHoaDon]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [DF_SanPham_image]  DEFAULT ('') FOR [Image]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap1] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap1]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_SanPham]
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
USE [master]
GO
ALTER DATABASE [QuanLySanPham] SET  READ_WRITE 
GO
